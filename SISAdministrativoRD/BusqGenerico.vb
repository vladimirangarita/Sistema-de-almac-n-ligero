Imports System.IO

Public Class BusqGenerico
    Public Form As String = ""
    Dim datos As New DataSet
    Dim objGlobales As New cGlobales
    Dim objDatos As New cDatos


    Private Sub pasar()
        Try

            If data_busqueda.RowCount = 0 Then
                Exit Sub
            End If
            Dim Fila_Seleccionada As Integer = data_busqueda.CurrentCell.RowIndex
            Select Case Form
                Case "MARCAS"
                    ' MsgBox(Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value.ToString))
                    Dim strMarca As String = Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value.ToString)
                    intIdMarca = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    FrmMarcas.txtMarcas.Text = (Trim(strMarca))
                    FrmMarcas.Btn_Guardar.Text = "Modificar"
                    blnEstatusMarca = data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value
                    If blnEstatusMarca = True Then
                        FrmMarcas.rbActivo.Checked = True
                    Else
                        FrmMarcas.rbInactivo.Checked = True
                    End If
                    ' Frm_Auditoria.Txt_usuario.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value))
                Case "CATEGORIAS"
                    intIdCategoria = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    frmCategorias.txtCategorias.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value))
                    frmCategorias.Btn_Aceptar.Text = "Modificar"
                    blnEstatusCategoria = data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value
                    If blnEstatusCategoria = True Then
                        frmCategorias.rbActivo.Checked = True
                    Else
                        frmCategorias.rbInactivo.Checked = True
                    End If

                Case "UNIDADES"
                    intIdUnidad = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    frmUnidades.txtUnidadesMedida.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value))
                    frmUnidades.Btn_Aceptar.Text = "Modificar"
                    blnEstatusUnidad = data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value
                    If blnEstatusUnidad = True Then
                        frmUnidades.rbActivo.Checked = True
                    Else
                        frmCategorias.rbInactivo.Checked = True
                    End If
                Case "ALMACEN"
                    intIdAlmacen = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    frmAlmacen.txtAlmacen.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value))
                    frmAlmacen.Btn_Aceptar.Text = "Modificar"
                    blnEstatusAlmacen = data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value
                    If blnEstatusAlmacen = True Then
                        frmAlmacen.rbActivo.Checked = True
                    Else
                        frmAlmacen.rbInactivo.Checked = True
                    End If



                Case "PROVEEDORES"

                    intIdProveedor = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    frmProveedores.txtCodigo.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value))
                    frmProveedores.txtRCN.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value))
                    frmProveedores.txtDescripcionProveedor.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(3).Value))
                    frmProveedores.txtContacto.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(4).Value))
                    frmProveedores.txtDireccion.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(5).Value))
                    frmProveedores.txtTelefono.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(6).Value))
                    frmProveedores.txtTelefonomovil.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(7).Value))
                    frmProveedores.txtEmail.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(8).Value))
                    frmProveedores.txtBalance.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(9).Value))
                    'frmProveedores.txtBalance.Text = (Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(9).Value))

                    frmProveedores.Btn_Guardar.Text = "Modificar"
                    blnEstatusProveedor = data_busqueda.Rows(Fila_Seleccionada).Cells(11).Value
                    If blnEstatusProveedor = True Then
                        frmProveedores.rbActivo.Checked = True
                    Else
                        frmProveedores.rbInactivo.Checked = True
                    End If

                Case "ARTICULOS"
                    intIdArticulo = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    frmArticulos.txtCodigoArticulo.Text = data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value
                    Dim data = TryCast(data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value, Byte())
                    Dim stream = New MemoryStream(data)
                    frmArticulos.PictureBox1.Image = Image.FromStream(stream)
                    frmArticulos.txtArticulo.Text = data_busqueda.Rows(Fila_Seleccionada).Cells(3).Value
                    frmArticulos.txtPrecioCompra.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(4).Value)
                    frmArticulos.txtPrecio1.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(5).Value)
                    frmArticulos.txtPrecio2.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(6).Value)
                    frmArticulos.cboUnidad.SelectedValue = data_busqueda.Rows(Fila_Seleccionada).Cells(7).Value
                    frmArticulos.cboCategoria.SelectedValue = data_busqueda.Rows(Fila_Seleccionada).Cells(8).Value
                    frmArticulos.cboMarca.SelectedValue = data_busqueda.Rows(Fila_Seleccionada).Cells(9).Value
                    frmArticulos.cboProveedor.SelectedValue = data_busqueda.Rows(Fila_Seleccionada).Cells(10).Value
                    frmArticulos.txtExistencia.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(11).Value)
                    frmArticulos.cboAlmacen.SelectedValue = data_busqueda.Rows(Fila_Seleccionada).Cells(12).Value

                    blnEstatusArticulo = data_busqueda.Rows(Fila_Seleccionada).Cells(19).Value
                    If blnEstatusArticulo = True Then
                        frmArticulos.rbActivo.Checked = True
                    Else
                        frmArticulos.rbInactivo.Checked = True
                    End If
                    frmArticulos.Btn_Guardar.Text = "Modificar"
                Case "CONFIGURACION_ETIQUETA"
                    intIdArticuloEtiqueta = CInt(data_busqueda.Rows(Fila_Seleccionada).Cells(0).Value)
                    frmConfigCodigoBarras.txtCodigoArticulo.Text = data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value
                    frmConfigCodigoBarras.txtArticulo.Text = data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value
                    Dim data = TryCast(data_busqueda.Rows(Fila_Seleccionada).Cells(3).Value, Byte())
                    Dim stream = New MemoryStream(data)
                    frmConfigCodigoBarras.PictureBox1.Image = Image.FromStream(stream)
                    frmConfigCodigoBarras.txtAltura.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(4).Value)
                    frmConfigCodigoBarras.txtAnchura.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(5).Value)
                    frmConfigCodigoBarras.txtNEtiquetas.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(6).Value)
                    frmConfigCodigoBarras.txtArribaAbajo.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(7).Value)
                    frmConfigCodigoBarras.txtDerechaIzquierda.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(8).Value)
                    frmConfigCodigoBarras.txtDerechaIzquierda01.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(9).Value)
                    frmConfigCodigoBarras.txtDerechaIzquierda02.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(10).Value)
                    frmConfigCodigoBarras.txtDerechaIzquierda03.Text = CDec(data_busqueda.Rows(Fila_Seleccionada).Cells(11).Value)

                    frmConfigCodigoBarras.Btn_Guardar.Text = "Modificar"

            End Select
            Form = ""
            Me.Close()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub buscar()
        Try
            Dim vista As New DataView
            Dim str As String = String.Empty
            vista.Table = datos.Tables(0)
            Select Case Form
                Case "MARCAS"
                    str = "DescripcionMarca LIKE '" & Txt_Filtro.Text & "%'"
                Case "CATEGORIAS"
                    str = "DesCategoria LIKE '" & Txt_Filtro.Text & "%'"
                Case "UNIDADES"
                    str = "DescripcionUnidadMedida LIKE '" & Txt_Filtro.Text & "%'"
                Case "ALMACEN"
                    str = "DescripcionAlmacen LIKE '" & Txt_Filtro.Text & "%'"
                Case "PROVEEDORES"
                    str = "DesProveedor LIKE '" & Txt_Filtro.Text & "%'"
                Case "ARTICULOS"
                    str = "DescripcionArt LIKE '" & Txt_Filtro.Text & "%'"
                Case "CONFIGURACION_ETIQUETA"
                    str = "DescripcionArt LIKE '" & Txt_Filtro.Text & "%'"
                 
                  

            
            End Select
            vista.RowFilter = str
            data_busqueda.DataSource = vista
            data_busqueda.Update()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BusqGenerico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objGlobales.FormatearGrid(data_busqueda)
        Select Case Form
            Case "MARCAS"
                datos = objDatos.GetMarcasAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).HeaderText = "Id."
                data_busqueda.Columns(1).HeaderText = "Nombre"
                data_busqueda.Columns(0).Visible = False
                data_busqueda.Columns(2).Visible = True
                'data_busqueda.Columns(4).Visible = False
                'data_busqueda.Columns(5).Visible = False
                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Case "CATEGORIAS"
                datos = objDatos.GetCategoriasAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).Visible = False
                data_busqueda.Columns(2).Visible = True
                data_busqueda.Columns(0).HeaderText = "Id."
                data_busqueda.Columns(1).HeaderText = "Descripción"
                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Case "UNIDADES"
                datos = objDatos.GetUnidadesAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).Visible = False
                data_busqueda.Columns(0).HeaderText = "Id."
                data_busqueda.Columns(1).HeaderText = "Descripción"
                data_busqueda.Columns(2).HeaderText = "Estatus"
                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Case "ALMACEN"
                datos = objDatos.GetAlmacenAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).Visible = False
                data_busqueda.Columns(0).HeaderText = "Id."
                data_busqueda.Columns(1).HeaderText = "Descripción"
                data_busqueda.Columns(2).HeaderText = "Estatus"
                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Case "PROVEEDORES"
                datos = objDatos.GetProveedoresAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).HeaderText = "Codigo"
                data_busqueda.Columns(1).HeaderText = "Descripción"
                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Case "ARTICULOS"
                datos = objDatos.GetArticulosAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).Visible = False
                data_busqueda.Columns(1).HeaderText = "Codigo"
                data_busqueda.Columns(2).HeaderText = "Etiqueta"
                data_busqueda.Columns(3).HeaderText = "Articulo"
                data_busqueda.Columns(4).Visible = False
                data_busqueda.Columns(5).Visible = False
                data_busqueda.Columns(6).Visible = False
                data_busqueda.Columns(7).Visible = False
                data_busqueda.Columns(8).Visible = False
                data_busqueda.Columns(9).Visible = False
                data_busqueda.Columns(10).Visible = False
                data_busqueda.Columns(11).Visible = False
                data_busqueda.Columns(12).Visible = False
                data_busqueda.Columns(13).Visible = False
                data_busqueda.Columns(14).Visible = False
                data_busqueda.Columns(15).Visible = False
                data_busqueda.Columns(16).Visible = False
                data_busqueda.Columns(17).Visible = False
                data_busqueda.Columns(18).Visible = False

                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Case "CONFIGURACION_ETIQUETA"
                datos = objDatos.GetEtiquetasConfigAll
                data_busqueda.DataSource = datos.Tables(0)
                data_busqueda.Columns(0).Visible = False
                data_busqueda.Columns(1).HeaderText = "Codigo"
                data_busqueda.Columns(2).HeaderText = "Articulo"
                data_busqueda.Columns(3).HeaderText = "Etiqueta"
                data_busqueda.Columns(4).HeaderText = "Alto"
                data_busqueda.Columns(5).HeaderText = "Ancho"
                data_busqueda.Columns(7).HeaderText = "Arriva,Abajo"
                data_busqueda.Columns(8).HeaderText = "Drecha,izquierda"
     
                data_busqueda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                data_busqueda.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
         

        End Select
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Txt_Filtro.Text = ""
        Txt_Filtro.Focus()
    End Sub

    Private Sub Txt_Filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Filtro.Click

    End Sub

    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        pasar()
    End Sub

    Private Sub Txt_Filtro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Filtro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            pasar()
        End If
    End Sub

    Private Sub Txt_Filtro_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Filtro.KeyUp
        buscar()
    End Sub

    Private Sub data_busqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_busqueda.CellContentClick

    End Sub

    Private Sub data_busqueda_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_busqueda.CellDoubleClick
        pasar()
    End Sub
End Class