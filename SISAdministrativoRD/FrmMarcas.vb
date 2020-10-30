Public Class FrmMarcas
    Dim objDatos As New cDatos
    Dim objDataSet As New DataSet
    Dim objGlobales As New cGlobales
    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Dim Buscador As New BusqGenerico
        Buscador.StartPosition = FormStartPosition.CenterScreen
        Buscador.Form = "MARCAS"
        Buscador.ToolStripLabel1.Text = "Factura/Cliente"
        Buscador.Show()
        Buscador.Txt_Filtro.Focus()
    End Sub
    Private Sub darformato()
        Try

      
        dgvMarcas.Columns(0).Visible = False
        dgvMarcas.Columns(1).Visible = True
        dgvMarcas.Columns(2).Visible = True
        dgvMarcas.Columns(0).HeaderText = "Codigo"
        dgvMarcas.Columns(1).HeaderText = "Descripción"
        dgvMarcas.Columns(2).HeaderText = "Estatus"
        dgvMarcas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvMarcas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvMarcas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            objDataSet = objDatos.GetMarcasAll()
            dgvMarcas.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvMarcas)
            'Vladimir prueba
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click

        If txtMarcas.TextLength = 0 Then
            MessageBox.Show("Debe ingresar marca")
            txtMarcas.Focus()
            Exit Sub
        End If

        '  If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then


        If Btn_Guardar.Text = "Guardar" Then


            If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then

                Dim blbEstatus As Boolean


                If rbActivo.Checked = True Then
                    blbEstatus = True
                Else
                    blbEstatus = False
                End If


                objDatos.GetInsertMarcaRow(txtMarcas.Text, blbEstatus)
                txtMarcas.Text = ""
                txtMarcas.Focus()
                objDataSet = objDatos.GetMarcasAll()
                dgvMarcas.DataSource = objDataSet.Tables(0)
                darformato()
                objGlobales.FormatearGrid(dgvMarcas)
                rbActivo.Checked = False
                rbInactivo.Checked = False
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

            objDatos.GetModificarMarcaRow(intIdMarca, txtMarcas.Text, blbEstatus)
            txtMarcas.Text = ""
            txtMarcas.Focus()
            objDataSet = objDatos.GetMarcasAll()
            dgvMarcas.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvMarcas)
            Btn_Guardar.Text = "Guardar"
            rbActivo.Checked = False
            rbInactivo.Checked = False
        End If



        ' End If
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Try

                Btn_Guardar.Text = "Guardar"
        txtMarcas.Text = ""
        txtMarcas.Focus()
        objDataSet = objDatos.GetMarcasAll()
        dgvMarcas.DataSource = objDataSet.Tables(0)
        darformato()
        objGlobales.FormatearGrid(dgvMarcas)
        rbActivo.Checked = True
        rbInactivo.Checked = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub dgvMarcas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMarcas.CellContentClick

    End Sub

    Private Sub dgvMarcas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMarcas.CellDoubleClick
        Try

            intIdMarca = Me.dgvMarcas.Item(0, Me.dgvMarcas.SelectedCells.Item(0).RowIndex).Value
            txtMarcas.Text = Me.dgvMarcas.Item(1, Me.dgvMarcas.SelectedCells.Item(0).RowIndex).Value

            Dim blnEstatus As Boolean = Me.dgvMarcas.Item(2, Me.dgvMarcas.SelectedCells.Item(0).RowIndex).Value

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
End Class