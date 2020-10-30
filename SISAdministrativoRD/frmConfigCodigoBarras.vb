Imports System.IO
Imports System.Drawing.Imaging

Public Class frmConfigCodigoBarras
    Dim objGlobales As New cGlobales
    Dim ObjDataSet As New DataSet
    Dim objdatos As New cDatos
    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Try

      
            Dim Buscador As New BusqGenerico
            Buscador.StartPosition = FormStartPosition.CenterScreen
            Buscador.Form = "CONFIGURACION_ETIQUETA"
            Buscador.ToolStripLabel1.Text = "Articulos"
            Buscador.Show()
            Buscador.Txt_Filtro.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Try

  
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
            Return ms.ToArray()
        Catch ex As Exception

        End Try
    End Function

    Private Sub Btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Imprimir.Click
        Try

      
        Dim objcrInformes As New crEtiquetas
        Dim i As Integer
        '  DataTable dt2 = new DataTable();
        Dim dt2 As New DataTable
        Dim dr As DataRow

            dt2 = objdatos.GetEtiquetasConfigSelect(txtCodigoArticulo.Text).Tables(0)

            If CInt(txtNEtiquetas.Text) > 1 Then
                For i = 0 To CInt(txtNEtiquetas.Text) - 1
                    If i > 0 Then
                        dr = dt2.NewRow()
                        dr("IdConfiEtiqueta") = intIdArticuloEtiqueta
                        dr("Codigo") = txtCodigoArticulo.Text
                        dr("DescripcionArt") = txtArticulo.Text
                        dr("CodigoEtiqueta") = ImageToByteArray(PictureBox1.Image)
                        dr("Altura") = txtAltura.Text
                        dr("Anchura") = txtAnchura.Text
                        dr("NEtiquetas") = txtNEtiquetas.Text
                        dt2.Rows.Add(dr)
                    End If
                Next



            End If

        objcrInformes.SetDataSource(dt2)
        crvArticulos.ReportSource = objcrInformes
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Width = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Height = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta2").Width = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta2").Height = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta3").Width = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta3").Height = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta4").Width = txtAltura.Text
        objcrInformes.Section3.ReportObjects("CodigoEtiqueta4").Height = txtAltura.Text


            objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Top = txtArribaAbajo.Text
            objcrInformes.Section3.ReportObjects("CodigoEtiqueta2").Top = txtArribaAbajo.Text
            objcrInformes.Section3.ReportObjects("CodigoEtiqueta3").Top = txtArribaAbajo.Text
            objcrInformes.Section3.ReportObjects("CodigoEtiqueta4").Top = txtArribaAbajo.Text


            objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Left = txtDerechaIzquierda.Text
            objcrInformes.Section3.ReportObjects("CodigoEtiqueta2").Left = txtDerechaIzquierda01.Text
            objcrInformes.Section3.ReportObjects("CodigoEtiqueta3").Left = txtDerechaIzquierda02.Text
            objcrInformes.Section3.ReportObjects("CodigoEtiqueta4").Left = txtDerechaIzquierda03.Text




        '  objcrInformes.Refresh()

        crvArticulos.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        If Btn_Guardar.Text = "Modificar" Then
            Dim blbEstatus As Boolean


            'If rbActivo.Checked = True Then
            '    blbEstatus = True
            'Else
            '    blbEstatus = False
            'End If

            objdatos.GetModificarConfigEtiquetaRow(intIdArticuloEtiqueta, txtAltura.Text, txtAnchura.Text, txtNEtiquetas.Text, txtArribaAbajo.Text, txtDerechaIzquierda.Text, txtDerechaIzquierda01.Text, txtDerechaIzquierda02.Text, txtDerechaIzquierda03.Text)
            txtCodigoArticulo.Text = ""
            PictureBox1.Image = Nothing
            txtAltura.Text = ""
            txtAltura.Focus()
            txtAnchura.Text = ""
            txtNEtiquetas.Text = ""
            txtArticulo.Text = ""
            txtArribaAbajo.Text = ""
            txtDerechaIzquierda.Text = ""
            txtDerechaIzquierda01.Text = ""
            txtDerechaIzquierda02.Text = ""
            txtDerechaIzquierda03.Text = ""
            Btn_Guardar.Text = "Guardar"

            'ObjDataSet = objdatos.GetAlmacenAll()
            'dgvAlmacen.DataSource = ObjDataSet.Tables(0)
            'darformato()
            'objGlobales.FormatearGrid(dgvAlmacen)
            'Btn_Aceptar.Text = "Guardar"
            'rbActivo.Checked = False
            'rbInactivo.Checked = False
        End If
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Try

            txtCodigoArticulo.Text = ""
            PictureBox1.Image = Nothing
            txtAltura.Text = ""
            txtAltura.Focus()
            txtAnchura.Text = ""
            txtNEtiquetas.Text = ""
            txtArticulo.Text = ""
            txtArribaAbajo.Text = ""
            txtDerechaIzquierda.Text = ""
            txtDerechaIzquierda01.Text = ""
            txtDerechaIzquierda02.Text = ""
            txtDerechaIzquierda03.Text = ""
            Btn_Guardar.Text = "Guardar"
            Dim dt2 As New DataTable
            dt2 = objdatos.GetEtiquetasConfigSelect("").Tables(0)
            Dim objcrInformes As New crEtiquetas
            objcrInformes.SetDataSource(dt2)
            crvArticulos.ReportSource = objcrInformes

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmConfigCodigoBarras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class