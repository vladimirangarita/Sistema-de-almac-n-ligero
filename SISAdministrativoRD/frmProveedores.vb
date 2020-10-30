Public Class frmProveedores
    Dim objDatos As New cDatos
    Dim objDataSet As New DataSet
    Dim objGlobales As New cGlobales
    Dim correlativo As String

    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Try

            Dim Buscador As New BusqGenerico
            Buscador.StartPosition = FormStartPosition.CenterScreen
            Buscador.Form = "PROVEEDORES"
            Buscador.ToolStripLabel1.Text = "Proveedores"
            Buscador.Show()
            Buscador.Txt_Filtro.Focus()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub darformato()
        Try


            dgvProveedores.Columns(0).Visible = False
            dgvProveedores.Columns(1).Visible = True
            dgvProveedores.Columns(2).Visible = True
            dgvProveedores.Columns(0).HeaderText = "Codigo"
            dgvProveedores.Columns(1).HeaderText = "Codigo"
            dgvProveedores.Columns(2).HeaderText = "RNC"
            dgvProveedores.Columns(3).HeaderText = "Proveedor"
            dgvProveedores.Columns(4).HeaderText = "Contacto"
            dgvProveedores.Columns(5).HeaderText = "Dirección"
            dgvProveedores.Columns(6).HeaderText = "Teléfono"
            dgvProveedores.Columns(7).HeaderText = "Teléfono móvil"
            dgvProveedores.Columns(8).HeaderText = "Email"
            dgvProveedores.Columns(9).HeaderText = "Balance"
            dgvProveedores.Columns(10).HeaderText = "Fecha ingreso"
            dgvProveedores.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProveedores.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            'dgvProveedores.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Correlativos()
        correlativo = objDatos.GetNextProveedor
        txtCodigo.Text = correlativo

    

    End Sub
    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            objDataSet = objDatos.GetProveedoresAll()
            dgvProveedores.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvProveedores)
            Correlativos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Try


            If txtCodigo.TextLength = 0 Then
                MessageBox.Show("Debe ingresar codigo")
                txtCodigo.Focus()
                Exit Sub
            End If


            If txtRCN.TextLength = 0 Then
                MessageBox.Show("Debe ingresar RCN")
                txtRCN.Focus()
                Exit Sub
            End If


            If txtDescripcionProveedor.TextLength = 0 Then
                MessageBox.Show("Debe ingresar proveedor")
                txtDescripcionProveedor.Focus()
                Exit Sub
            End If


            If txtContacto.TextLength = 0 Then
                MessageBox.Show("Debe ingresar contacto")
                txtContacto.Focus()
                Exit Sub
            End If


            If txtTelefono.TextLength = 0 Then
                MessageBox.Show("Debe ingresar telefono")
                txtTelefono.Focus()
                Exit Sub
            End If



            If txtBalance.TextLength = 0 Then
                MessageBox.Show("Debe ingresar balance")
                txtBalance.Focus()
                Exit Sub
            End If


            If txtCodigo.TextLength = 0 Then
                MessageBox.Show("Debe ingresar codigo")
                txtCodigo.Focus()
                Exit Sub
            End If


            If txtEmail.TextLength = 0 Then
                MessageBox.Show("Debe ingresar codigo")
                txtEmail.Focus()
                Exit Sub
            End If


            If txtDireccion.TextLength = 0 Then
                MessageBox.Show("Debe ingresar direccion")
                txtDireccion.Focus()
                Exit Sub
            End If



            '  If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then


            If Btn_Guardar.Text = "Guardar" Then


                If objDatos.GetBuscarProveedorSelect(Trim(txtRCN.Text)) = False Then

                    Dim blbEstatus As Boolean


                    If rbActivo.Checked = True Then
                        blbEstatus = True
                    Else
                        blbEstatus = False
                    End If


                    objDatos.GetInsertProveedorRow(txtCodigo.Text, txtRCN.Text, txtDescripcionProveedor.Text, txtContacto.Text, txtDireccion.Text, txtTelefono.Text, txtTelefonomovil.Text, txtEmail.Text, txtBalance.Text, Now.Date, blbEstatus)
                    txtCodigo.Text = ""
                    txtRCN.Text = ""
                    txtDescripcionProveedor.Text = ""
                    txtContacto.Text = ""
                    txtDireccion.Text = ""
                    txtTelefono.Text = ""
                    txtTelefonomovil.Text = ""
                    txtEmail.Text = ""
                    txtBalance.Text = ""
                    txtCodigo.Focus()
                    objDataSet = objDatos.GetProveedoresAll()
                    dgvProveedores.DataSource = objDataSet.Tables(0)
                    darformato()
                    objGlobales.FormatearGrid(dgvProveedores)
                    rbActivo.Checked = False
                    rbInactivo.Checked = False
                    Btn_Guardar.Text = "Guardar"
                    Correlativos()

                Else
                    MsgBox("Existe")
                End If
            End If

            If Btn_Guardar.Text = "Modificar" Then
                Dim blbEstatus As Boolean


                If rbActivo.Checked = True Then
                    blbEstatus = True
                Else
                    blbEstatus = False
                End If

                objDatos.GetModificarProveedorRow(intIdProveedor, txtCodigo.Text, txtRCN.Text, txtDescripcionProveedor.Text, txtContacto.Text, txtDireccion.Text, txtTelefono.Text, txtTelefonomovil.Text, txtEmail.Text, txtBalance.Text, Now.Date, blbEstatus)
                txtCodigo.Text = ""
                txtRCN.Text = ""
                txtDescripcionProveedor.Text = ""
                txtContacto.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtTelefonomovil.Text = ""
                txtEmail.Text = ""
                txtBalance.Text = ""
                txtCodigo.Focus()
                objDataSet = objDatos.GetProveedoresAll()
                dgvProveedores.DataSource = objDataSet.Tables(0)
                darformato()
                objGlobales.FormatearGrid(dgvProveedores)
                rbActivo.Checked = False
                rbInactivo.Checked = False
                Btn_Guardar.Text = "Guardar"
                Correlativos()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Try
            txtCodigo.Text = ""
            txtRCN.Text = ""
            txtDescripcionProveedor.Text = ""
            txtContacto.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            txtTelefonomovil.Text = ""
            txtEmail.Text = ""
            txtBalance.Text = ""
            txtCodigo.Focus()
            objDataSet = objDatos.GetProveedoresAll()
            dgvProveedores.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvProveedores)
            rbActivo.Checked = True
            rbInactivo.Checked = False
            Btn_Guardar.Text = "Guardar"
            Correlativos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick

    End Sub

    Private Sub dgvProveedores_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
        Try

            intIdProveedor = Me.dgvProveedores.Item(0, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtCodigo.Text = Me.dgvProveedores.Item(1, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtRCN.Text = Me.dgvProveedores.Item(2, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtDescripcionProveedor.Text = Me.dgvProveedores.Item(3, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtContacto.Text = Me.dgvProveedores.Item(4, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtDireccion.Text = Me.dgvProveedores.Item(5, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtTelefono.Text = Me.dgvProveedores.Item(6, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtTelefonomovil.Text = Me.dgvProveedores.Item(7, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtEmail.Text = Me.dgvProveedores.Item(8, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value
            txtBalance.Text = Me.dgvProveedores.Item(9, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value

            Dim blnEstatus As Boolean = Me.dgvProveedores.Item(11, Me.dgvProveedores.SelectedCells.Item(0).RowIndex).Value

            If blnEstatus = True Then
                rbActivo.Checked = True
            End If
            If blnEstatus = False Then
                rbInactivo.Checked = True
            End If

            Btn_Guardar.Text = "Modificar"

        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtRCN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRCN.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRCN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRCN.TextChanged

    End Sub

    Private Sub txtBalance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalance.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBalance.TextChanged

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefonomovil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonomovil.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefonomovil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefonomovil.TextChanged

    End Sub
End Class