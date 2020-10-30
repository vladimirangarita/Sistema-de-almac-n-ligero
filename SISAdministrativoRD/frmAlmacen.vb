Public Class frmAlmacen
    Dim objDatos As New cDatos
    Dim objDataSet As New DataSet
    Dim objGlobales As New cGlobales
    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Dim Buscador As New BusqGenerico
        Buscador.StartPosition = FormStartPosition.CenterScreen
        Buscador.Form = "ALMACEN"
        Buscador.ToolStripLabel1.Text = "Almacen"
        Buscador.Show()
        Buscador.Txt_Filtro.Focus()
    End Sub
    Private Sub darformato()
        Try


            dgvAlmacen.Columns(0).Visible = False
            dgvAlmacen.Columns(1).Visible = True
            dgvAlmacen.Columns(2).Visible = True
            dgvAlmacen.Columns(0).HeaderText = "Codigo"
            dgvAlmacen.Columns(1).HeaderText = "Descripción"
            dgvAlmacen.Columns(2).HeaderText = "Estatus"
            dgvAlmacen.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvAlmacen.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvAlmacen.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            objDataSet = objDatos.GetAlmacenAll()
            dgvAlmacen.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvAlmacen)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        If txtAlmacen.TextLength = 0 Then
            MessageBox.Show("Debe ingresar Almacen")
            txtAlmacen.Focus()
            Exit Sub
        End If

        '  If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then


        If Btn_Aceptar.Text = "Guardar" Then


            If objDatos.GetBuscarAlmacenSelect(Trim(txtAlmacen.Text)) = False Then

                Dim blbEstatus As Boolean


                If rbActivo.Checked = True Then
                    blbEstatus = True
                Else
                    blbEstatus = False
                End If


                objDatos.GetInsertAlmacenRow(txtAlmacen.Text, blbEstatus)
                txtAlmacen.Text = ""
                txtAlmacen.Focus()
                objDataSet = objDatos.GetCategoriasAll()
                dgvAlmacen.DataSource = objDataSet.Tables(0)
                darformato()
                objGlobales.FormatearGrid(dgvAlmacen)
                rbActivo.Checked = False
                rbInactivo.Checked = False
            Else
                MsgBox("Existe")
            End If
        End If

        If Btn_Aceptar.Text = "Modificar" Then
            Dim blbEstatus As Boolean


            If rbActivo.Checked = True Then
                blbEstatus = True
            Else
                blbEstatus = False
            End If

            objDatos.GetModificarAlmacenRow(intIdAlmacen, txtAlmacen.Text, blbEstatus)
            txtAlmacen.Text = ""
            txtAlmacen.Focus()
            objDataSet = objDatos.GetAlmacenAll()
            dgvAlmacen.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvAlmacen)
            Btn_Aceptar.Text = "Guardar"
            rbActivo.Checked = False
            rbInactivo.Checked = False
        End If
    End Sub

    Private Sub Btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelar.Click
        txtAlmacen.Text = ""
        txtAlmacen.Focus()
        objDataSet = objDatos.GetAlmacenAll()
        dgvAlmacen.DataSource = objDataSet.Tables(0)
        darformato()
        objGlobales.FormatearGrid(dgvAlmacen)
        Btn_Aceptar.Text = "Guardar"
        rbActivo.Checked = True
        rbInactivo.Checked = False
    End Sub

    Private Sub dgvAlmacen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlmacen.CellContentClick

    End Sub

    Private Sub dgvAlmacen_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvAlmacen.CellMouseDoubleClick
        Try

            intIdAlmacen = Me.dgvAlmacen.Item(0, Me.dgvAlmacen.SelectedCells.Item(0).RowIndex).Value
            txtAlmacen.Text = Me.dgvAlmacen.Item(1, Me.dgvAlmacen.SelectedCells.Item(0).RowIndex).Value

            Dim blnEstatus As Boolean = Me.dgvAlmacen.Item(2, Me.dgvAlmacen.SelectedCells.Item(0).RowIndex).Value

            If blnEstatus = True Then
                rbActivo.Checked = True
            End If
            If blnEstatus = False Then
                rbInactivo.Checked = True
            End If

            Btn_Aceptar.Text = "Modificar"

        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class