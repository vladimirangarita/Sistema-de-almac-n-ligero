Public Class frmCategorias
    Dim objDatos As New cDatos
    Dim objDataSet As New DataSet
    Dim objGlobales As New cGlobales
    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Dim Buscador As New BusqGenerico
        Buscador.StartPosition = FormStartPosition.CenterScreen
        Buscador.Form = "CATEGORIAS"
        Buscador.ToolStripLabel1.Text = "Categorias"
        Buscador.Show()
        Buscador.Txt_Filtro.Focus()
    End Sub
    Private Sub darformato()
        Try


            dgvCategorias.Columns(0).Visible = False
            dgvCategorias.Columns(1).Visible = True
            dgvCategorias.Columns(2).Visible = True
            dgvCategorias.Columns(0).HeaderText = "Codigo"
            dgvCategorias.Columns(1).HeaderText = "Descripción"
            dgvCategorias.Columns(2).HeaderText = "Estatus"
            dgvCategorias.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvCategorias.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvCategorias.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            objDataSet = objDatos.GetCategoriasAll()
            dgvCategorias.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvCategorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        If txtCategorias.TextLength = 0 Then
            MessageBox.Show("Debe ingresar categoria")
            txtCategorias.Focus()
            Exit Sub
        End If

        '  If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then


        If Btn_Aceptar.Text = "Guardar" Then


            If objDatos.GetBuscarMarcaSelect(Trim(txtCategorias.Text)) = False Then

                Dim blbEstatus As Boolean


                If rbActivo.Checked = True Then
                    blbEstatus = True
                Else
                    blbEstatus = False
                End If


                objDatos.GetInsertCategoriaRow(txtCategorias.Text, blbEstatus)
                txtCategorias.Text = ""
                txtCategorias.Focus()
                objDataSet = objDatos.GetCategoriasAll()
                dgvCategorias.DataSource = objDataSet.Tables(0)
                darformato()
                objGlobales.FormatearGrid(dgvCategorias)
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

            objDatos.GetModificarCategoriaRow(intIdCategoria, txtCategorias.Text, blbEstatus)
            txtCategorias.Text = ""
            txtCategorias.Focus()
            objDataSet = objDatos.GetCategoriasAll()
            dgvCategorias.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvCategorias)
            Btn_Aceptar.Text = "Guardar"
            rbActivo.Checked = False
            rbInactivo.Checked = False
        End If

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Try

      
        Btn_Aceptar.Text = "Guardar"
        txtCategorias.Text = ""
        txtCategorias.Focus()
        objDataSet = objDatos.GetCategoriasAll()
        dgvCategorias.DataSource = objDataSet.Tables(0)
        darformato()
        objGlobales.FormatearGrid(dgvCategorias)
        rbActivo.Checked = True
            rbInactivo.Checked = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvCategorias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategorias.CellContentClick

    End Sub

    Private Sub dgvCategorias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategorias.CellDoubleClick
        Try

            intIdCategoria = Me.dgvCategorias.Item(0, Me.dgvCategorias.SelectedCells.Item(0).RowIndex).Value
            txtCategorias.Text = Me.dgvCategorias.Item(1, Me.dgvCategorias.SelectedCells.Item(0).RowIndex).Value

            Dim blnEstatus As Boolean = Me.dgvCategorias.Item(2, Me.dgvCategorias.SelectedCells.Item(0).RowIndex).Value

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