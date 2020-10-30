Imports System.IO
Imports System.Drawing.Imaging


Public Class frmArticulos
    Dim objGlobales As New cGlobales
    Dim ObjDataSet As New DataSet
    Dim objdatos As New cDatos

    Dim correlativo As String
    Private Function CargarCboUnidades() As DataSet
        ObjDataSet = objdatos.GetUnidadesAllAct()

        Dim row As DataRow = ObjDataSet.Tables(0).NewRow()
        row("DescripcionUnidadMedida") = "<- selecciona uno->"
        ObjDataSet.Tables(0).Rows.InsertAt(row, 0)

        cboUnidad.DataSource = ObjDataSet.Tables(0)
        cboUnidad.DisplayMember = ObjDataSet.Tables(0).Columns(1).Caption
        cboUnidad.ValueMember = ObjDataSet.Tables(0).Columns(0).Caption

        Return ObjDataSet
    End Function
    Private Function CargarCboProveedor() As DataSet
        ObjDataSet = objdatos.GetProveedoresAllAct()

        Dim row As DataRow = ObjDataSet.Tables(0).NewRow()
        row("DesProveedor") = "<- selecciona uno->"
        ObjDataSet.Tables(0).Rows.InsertAt(row, 0)

        cboProveedor.DataSource = ObjDataSet.Tables(0)
        cboProveedor.DisplayMember = ObjDataSet.Tables(0).Columns(3).Caption
        cboProveedor.ValueMember = ObjDataSet.Tables(0).Columns(0).Caption

        Return ObjDataSet
    End Function
    Private Function CargarCboCategorias() As DataSet
        ObjDataSet = objdatos.GetCategoriasAllAct()

        Dim row As DataRow = ObjDataSet.Tables(0).NewRow()
        row("DesCategoria") = "<- selecciona uno->"
        ObjDataSet.Tables(0).Rows.InsertAt(row, 0)

        cboCategoria.DataSource = ObjDataSet.Tables(0)
        cboCategoria.DisplayMember = ObjDataSet.Tables(0).Columns(1).Caption
        cboCategoria.ValueMember = ObjDataSet.Tables(0).Columns(0).Caption

        Return ObjDataSet
    End Function
    Private Function CargarCboAlmacen() As DataSet
        ObjDataSet = objdatos.GetAlmacenAllAct()

        Dim row As DataRow = ObjDataSet.Tables(0).NewRow()
        row("DescripcionAlmacen") = "<- selecciona uno->"
        ObjDataSet.Tables(0).Rows.InsertAt(row, 0)

        cboAlmacen.DataSource = ObjDataSet.Tables(0)
        cboAlmacen.DisplayMember = ObjDataSet.Tables(0).Columns(1).Caption
        cboAlmacen.ValueMember = ObjDataSet.Tables(0).Columns(0).Caption

        Return ObjDataSet
    End Function
    Private Function CargarCboMarcas() As DataSet
        ObjDataSet = objdatos.GetMarcasAllAct()

        Dim row As DataRow = ObjDataSet.Tables(0).NewRow()
        row("DescripcionMarca") = "<- selecciona uno->"
        ObjDataSet.Tables(0).Rows.InsertAt(row, 0)

        cboMarca.DataSource = ObjDataSet.Tables(0)
        cboMarca.DisplayMember = ObjDataSet.Tables(0).Columns(1).Caption
        cboMarca.ValueMember = ObjDataSet.Tables(0).Columns(0).Caption

        Return ObjDataSet
    End Function
    Private Sub darformato()
        Try


            dgvArticulos.Columns(0).Visible = False
            dgvArticulos.Columns(7).Visible = False
            dgvArticulos.Columns(8).Visible = False
            dgvArticulos.Columns(9).Visible = False
            dgvArticulos.Columns(10).Visible = False
            dgvArticulos.Columns(12).Visible = False
        
            dgvArticulos.Columns(0).HeaderText = "Codigo articulo"
            dgvArticulos.Columns(1).HeaderText = "Código artículo"
            dgvArticulos.Columns(2).HeaderText = "Etiqueta de artículo"
            dgvArticulos.Columns(3).HeaderText = "Descripción de artículo"
            dgvArticulos.Columns(4).HeaderText = "Precio de compra"
            dgvArticulos.Columns(5).HeaderText = "Precio 1"
            dgvArticulos.Columns(6).HeaderText = "Precio 2"
            dgvArticulos.Columns(13).HeaderText = "Fecha"
            dgvArticulos.Columns(14).HeaderText = "Almacén"
            dgvArticulos.Columns(15).HeaderText = "Unidad"
            dgvArticulos.Columns(16).HeaderText = "Marca"
            dgvArticulos.Columns(17).HeaderText = "Categoria"
            dgvArticulos.Columns(18).HeaderText = "Proveedor"
            dgvArticulos.Columns(19).HeaderText = "Estatus"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"
            'dgvArticulos.Columns(2).HeaderText = "Descripción de artículo"

            dgvArticulos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(18).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvArticulos.Columns(19).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Private Sub Correlativos()
        correlativo = objdatos.GetNextArticulo
        txtCodigoArticulo.Text = correlativo

        Dim alto As Single = 10

        Dim bm As Bitmap = Nothing
        bm = Codigos.codigo128("A" & txtCodigoArticulo.Text & "B", True, alto)
        If Not IsNothing(bm) Then
            PictureBox1.Image = bm
        End If


    End Sub


    Private Sub frmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            CargarCboUnidades()
            CargarCboProveedor()
            CargarCboCategorias()
            CargarCboAlmacen()
            CargarCboMarcas()



            ObjDataSet = objdatos.GetArticulosAll()
            dgvArticulos.DataSource = ObjDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvArticulos)
            Correlativos()
            'Dim oInforme As New crArtiEtique
            'Dim oInforme As New rptOrders()
            'Dim oCampoInforme As TextObject
            'Dim oDatosInforme As SummaryInfo
            'Dim oDatosInforme As SummaryInfo
            '  oInforme.DataDefinition.FormulaFields(0).Text = "Textodsfsdfsdfsdfsdfsdfsdfdsfsdfsdfs"


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

    End Sub

    Private Sub txtCodigoArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoArticulo.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoArticulo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoArticulo.KeyUp

        Try
            Dim alto As Single = 10

            Dim bm As Bitmap = Nothing
            bm = Codigos.codigo128("A" & txtCodigoArticulo.Text & "B", True, alto)
            If Not IsNothing(bm) Then
                PictureBox1.Image = bm
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtCodigoArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo.TextChanged

    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Try

    
        If txtCodigoArticulo.TextLength = 0 Then
                MessageBox.Show("Debe ingresar codigo de Articulo")
            txtCodigoArticulo.Focus()
            Exit Sub
            End If

            If txtArticulo.TextLength = 0 Then
                MessageBox.Show("Debe ingresar Articulo")
                txtArticulo.Focus()
                Exit Sub
            End If

            If txtExistencia.TextLength = 0 Then
                MessageBox.Show("Debe ingresar existencia")
                txtExistencia.Focus()
                Exit Sub
            End If

            If txtPrecioCompra.TextLength = 0 Then
                MessageBox.Show("Debe ingresar precio de compra")
                txtPrecioCompra.Focus()
                Exit Sub
            End If
            If txtPrecio1.TextLength = 0 Then
                MessageBox.Show("Debe ingresar precio1")
                txtPrecio1.Focus()
                Exit Sub
            End If

            If txtPrecio2.TextLength = 0 Then
                MessageBox.Show("Debe ingresar precio2")
                txtPrecio2.Focus()
                Exit Sub
            End If
        '  If objDatos.GetBuscarMarcaSelect(Trim(txtMarcas.Text)) = False Then


        If Btn_Guardar.Text = "Guardar" Then


            If objdatos.GetBuscarArticuloSelect(Trim(txtCodigoArticulo.Text)) = False Then

                Dim blbEstatus As Boolean


                If rbActivo.Checked = True Then
                    blbEstatus = True
                Else
                    blbEstatus = False
                End If

                    objdatos.GetInsertArticuloRow(txtCodigoArticulo.Text, ImageToByteArray(PictureBox1.Image), txtArticulo.Text, txtPrecioCompra.Text, txtPrecio1.Text, txtPrecio2.Text, cboUnidad.SelectedValue, cboCategoria.SelectedValue, cboMarca.SelectedValue, cboProveedor.SelectedValue, txtExistencia.Text, cboAlmacen.SelectedValue, blbEstatus)
                    'objdatos.GetIn
                    txtCodigoArticulo.Text = ""
                    txtCodigoArticulo.Focus()
                    txtArticulo.Text = ""
                    txtPrecioCompra.Text = ""
                    txtPrecio1.Text = ""
                    txtPrecio2.Text = ""
                    CargarCboAlmacen()
                    CargarCboCategorias()
                    CargarCboMarcas()
                    CargarCboProveedor()
                    CargarCboUnidades()
                    txtExistencia.Text = ""
                    rbActivo.Checked = False
                    rbInactivo.Checked = False
                    Btn_Guardar.Text = "Guardar"
                    PictureBox1.Image = Nothing
                    ObjDataSet = objdatos.GetArticulosAll()
                    dgvArticulos.DataSource = ObjDataSet.Tables(0)
                    darformato()
                    objGlobales.FormatearGrid(dgvArticulos)
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

            objdatos.GetModificarArticuloRow(intIdArticulo, txtCodigoArticulo.Text, ImageToByteArray(PictureBox1.Image), txtArticulo.Text, txtPrecioCompra.Text, txtPrecio1.Text, txtPrecio2.Text, cboUnidad.SelectedValue, cboCategoria.SelectedValue, cboMarca.SelectedValue, cboProveedor.SelectedValue, txtExistencia.Text, cboAlmacen.SelectedValue, blbEstatus)
            txtCodigoArticulo.Text = ""
            txtCodigoArticulo.Focus()
            txtArticulo.Text = ""
            txtPrecioCompra.Text = ""
            txtPrecio1.Text = ""
            txtPrecio2.Text = ""
            CargarCboAlmacen()
            CargarCboCategorias()
            CargarCboMarcas()
            CargarCboProveedor()
            CargarCboUnidades()
            txtExistencia.Text = ""
            rbActivo.Checked = False
            rbInactivo.Checked = False
            Btn_Guardar.Text = "Guardar"
            PictureBox1.Image = Nothing
            ObjDataSet = objdatos.GetArticulosAll()
            dgvArticulos.DataSource = ObjDataSet.Tables(0)
            darformato()
            objGlobales.FormatearGrid(dgvArticulos)
            PictureBox1.Image = Nothing
                rbActivo.Checked = True
                rbInactivo.Checked = False
                Correlativos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Busq_numdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Busq_numdoc.Click
        Dim Buscador As New BusqGenerico
        Buscador.StartPosition = FormStartPosition.CenterScreen
        Buscador.Form = "ARTICULOS"
        Buscador.ToolStripLabel1.Text = "Articulos"
        Buscador.Show()
        Buscador.Txt_Filtro.Focus()
    End Sub

    Private Sub Btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Imprimir.Click
        Dim objDatatso As New cDatos
        Dim objcrInformes As New crArticulos
        objDatatso.GetArticulosAll()
        objcrInformes.SetDataSource(objDatatso.GetArticulosAll.Tables(0))
        crvArticulos.ReportSource = objcrInformes

        'objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Left = "9900"
        ' objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Width = "2000"
        ' objcrInformes.Section3.ReportObjects("CodigoEtiqueta1").Height = "1000"
        objcrInformes.Refresh()

        crvArticulos.Show()

        'Dim myDataReport As New Report1() ' --> Nombre del RPT

        '' This is to get the individual textobject
        'TryCast(myDataReport.Section2.ReportObjects("txtFromDate"), TextObject).Text = "02/01/17"
        'TryCast(myDataReport.Section2.ReportObjects("txtToDate"), TextObject).Text = "02/10/17"
        'TryCast(myDataReport.Section2.ReportObjects("txtStation"), TextObject).Text = "MyStation"

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        txtCodigoArticulo.Text = ""
        txtCodigoArticulo.Focus()
        txtArticulo.Text = ""
        txtPrecioCompra.Text = ""
        txtPrecio1.Text = ""
        txtPrecio2.Text = ""
        CargarCboAlmacen()
        CargarCboCategorias()
        CargarCboMarcas()
        CargarCboProveedor()
        CargarCboUnidades()
        txtExistencia.Text = ""
        rbActivo.Checked = True
        rbInactivo.Checked = False
        Btn_Guardar.Text = "Guardar"
        PictureBox1.Image = Nothing
        Correlativos()
    End Sub

    Private Sub dgvArticulos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticulos.CellContentClick

    End Sub

    Private Sub dgvArticulos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvArticulos.CellMouseDoubleClick
        Try

            'Dim data = TryCast(data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value, Byte())
            'Dim stream = New MemoryStream(data)
            'frmArticulos.PictureBox1.Image = Image.FromStream(stream)

            intIdArticulo = Me.dgvArticulos.Item(0, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            txtCodigoArticulo.Text = Me.dgvArticulos.Item(1, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            Dim data = TryCast(Me.dgvArticulos.Item(2, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value, Byte())
            Dim stream = New MemoryStream(data)
            PictureBox1.Image = Image.FromStream(stream)
            txtArticulo.Text = Me.dgvArticulos.Item(3, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            txtPrecioCompra.Text = Me.dgvArticulos.Item(4, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            txtPrecio1.Text = Me.dgvArticulos.Item(5, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            txtPrecio2.Text = Me.dgvArticulos.Item(6, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            txtExistencia.Text = Me.dgvArticulos.Item(11, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            cboAlmacen.Text = Me.dgvArticulos.Item(14, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            cboUnidad.Text = Me.dgvArticulos.Item(15, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            cboMarca.Text = Me.dgvArticulos.Item(16, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            cboCategoria.Text = Me.dgvArticulos.Item(17, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value
            cboProveedor.Text = Me.dgvArticulos.Item(18, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value

            Dim blnEstatus As Boolean = Me.dgvArticulos.Item(19, Me.dgvArticulos.SelectedCells.Item(0).RowIndex).Value

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

    Private Sub txtPrecioCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioCompra.TextChanged

    End Sub

    Private Sub txtPrecio1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio1.TextChanged

    End Sub

    Private Sub txtPrecio2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio2.TextChanged

    End Sub

    Private Sub txtExistencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExistencia.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtExistencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExistencia.TextChanged

    End Sub
End Class