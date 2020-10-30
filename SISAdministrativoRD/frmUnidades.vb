Public Class frmUnidades
    Dim objDatos As New cDatos
    Dim objDataSet As New DataSet
    Dim objGlobales As New cGlobales
    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Try

            Dim Buscador As New BusqGenerico
            Buscador.StartPosition = FormStartPosition.CenterScreen
            Buscador.Form = "UNIDADES"
            Buscador.ToolStripLabel1.Text = "Unidades de medida"
            Buscador.Show()
            Buscador.Txt_Filtro.Focus()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub darformato()
        Try


            dgvUnidadesMedida.Columns(0).Visible = False
            dgvUnidadesMedida.Columns(1).Visible = True
            dgvUnidadesMedida.Columns(2).Visible = True
            dgvUnidadesMedida.Columns(0).HeaderText = "Codigo"
            dgvUnidadesMedida.Columns(1).HeaderText = "Descripción"
            dgvUnidadesMedida.Columns(2).HeaderText = "Estatus"
            dgvUnidadesMedida.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvUnidadesMedida.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvUnidadesMedida.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            objDataSet = objDatos.GetUnidadesAll
            dgvUnidadesMedida.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvUnidadesMedida)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click

        Try

        

        If txtUnidadesMedida.TextLength = 0 Then
            MessageBox.Show("Debe ingresar unidad")
            txtUnidadesMedida.Focus()
            Exit Sub
        End If

        '  If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then


        If Btn_Aceptar.Text = "Guardar" Then


            If objDatos.GetBuscarUnidadSelect(Trim(txtUnidadesMedida.Text)) = False Then

                Dim blbEstatus As Boolean


                If rbActivo.Checked = True Then
                    blbEstatus = True
                Else
                    blbEstatus = False
                End If


                objDatos.GetInsertUnidadRow(txtUnidadesMedida.Text, blbEstatus)
                txtUnidadesMedida.Text = ""
                txtUnidadesMedida.Focus()
                objDataSet = objDatos.GetUnidadesAll()
                dgvUnidadesMedida.DataSource = objDataSet.Tables(0)
                darformato()
                objGlobales.FormatearGrid(dgvUnidadesMedida)
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

            objDatos.GetModificarUnidadRow(intIdUnidad, txtUnidadesMedida.Text, blbEstatus)
            txtUnidadesMedida.Text = ""
            txtUnidadesMedida.Focus()
            objDataSet = objDatos.GetUnidadesAll()
            dgvUnidadesMedida.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvUnidadesMedida)
            Btn_Aceptar.Text = "Guardar"
            rbActivo.Checked = False
            rbInactivo.Checked = False
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Try

     
            Btn_Aceptar.Text = "Guardar"
            txtUnidadesMedida.Text = ""
            txtUnidadesMedida.Focus()
            objDataSet = objDatos.GetUnidadesAll()
            dgvUnidadesMedida.DataSource = objDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvUnidadesMedida)
            rbActivo.Checked = True
            rbInactivo.Checked = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvUnidadesMedida_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUnidadesMedida.CellContentClick

    End Sub

    Private Sub dgvUnidadesMedida_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUnidadesMedida.CellDoubleClick
        Try

            intIdUnidad = Me.dgvUnidadesMedida.Item(0, Me.dgvUnidadesMedida.SelectedCells.Item(0).RowIndex).Value
            txtUnidadesMedida.Text = Me.dgvUnidadesMedida.Item(1, Me.dgvUnidadesMedida.SelectedCells.Item(0).RowIndex).Value

            Dim blnEstatus As Boolean = Me.dgvUnidadesMedida.Item(2, Me.dgvUnidadesMedida.SelectedCells.Item(0).RowIndex).Value

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