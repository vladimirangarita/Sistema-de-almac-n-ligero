Imports System.Windows.Forms

Public Class MDIPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs)
        '   tslMensaje.Text = "Formulario abierto"
    End Sub
  
    Private form As frmAlmacen = Nothing
    Private form1 As frmArticulos = Nothing
    Private form2 As frmCategorias = Nothing
    Private form3 As frmUnidades = Nothing
    Private form4 As FrmMarcas = Nothing
    'Private form5 As frmAlmacen = Nothing
    'Private form6 As frmAlmacen = Nothing
    'Private form7 As frmAlmacen = Nothing

    Private Sub form_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        '  tslMensaje.Text = "Se ha cerrado el Formulario"
    End Sub
    Private Sub form_FormClosed1(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        '  tslMensaje.Text = "Se ha cerrado el Formulario"
    End Sub
    Private Sub form_FormClosed2(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        '  tslMensaje.Text = "Se ha cerrado el Formulario"
    End Sub
    Private Sub form_FormClosed3(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        '  tslMensaje.Text = "Se ha cerrado el Formulario"
    End Sub
    Private Sub form_FormClosed4(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        '  tslMensaje.Text = "Se ha cerrado el Formulario"
    End Sub

    Private Sub form_Disposed(ByVal sender As Object, ByVal e As EventArgs)
        form = Nothing
    End Sub
    Private Sub form_Disposed1(ByVal sender As Object, ByVal e As EventArgs)
        form1 = Nothing
    End Sub
    Private Sub form_Disposed2(ByVal sender As Object, ByVal e As EventArgs)
        form2 = Nothing
    End Sub
    Private Sub form_Disposed3(ByVal sender As Object, ByVal e As EventArgs)
        form3 = Nothing
    End Sub
    Private Sub form_Disposed4(ByVal sender As Object, ByVal e As EventArgs)
        form4 = Nothing
    End Sub
    Private ReadOnly Property FormInstance() As frmAlmacen
        Get
            If Form Is Nothing Then
                Form = New frmAlmacen()
                Form.MdiParent = Me

                AddHandler Form.Disposed, New EventHandler(AddressOf form_Disposed)
                AddHandler Form.FormClosed, New FormClosedEventHandler(AddressOf form_FormClosed)

                AddHandler Form.Load, New EventHandler(AddressOf form_Load)
            End If

            Return Form
        End Get
    End Property
    Private ReadOnly Property FormInstance1() As frmArticulos
        Get
            If form1 Is Nothing Then
                form1 = New frmArticulos()
                form1.MdiParent = Me

                AddHandler form1.Disposed, New EventHandler(AddressOf form_Disposed1)
                AddHandler form1.FormClosed, New FormClosedEventHandler(AddressOf form_FormClosed1)

                AddHandler form1.Load, New EventHandler(AddressOf form_Load)
            End If

            Return form1
        End Get
    End Property

    Private ReadOnly Property FormInstance2() As frmCategorias
        Get
            If form2 Is Nothing Then
                form2 = New frmCategorias()
                form2.MdiParent = Me

                AddHandler form2.Disposed, New EventHandler(AddressOf form_Disposed2)
                AddHandler form2.FormClosed, New FormClosedEventHandler(AddressOf form_FormClosed2)

                AddHandler form2.Load, New EventHandler(AddressOf form_Load)
            End If

            Return form2
        End Get
    End Property
    Private ReadOnly Property FormInstance3() As frmUnidades
        Get
            If form3 Is Nothing Then
                form3 = New frmUnidades()
                form3.MdiParent = Me

                AddHandler form3.Disposed, New EventHandler(AddressOf form_Disposed3)
                AddHandler form3.FormClosed, New FormClosedEventHandler(AddressOf form_FormClosed3)

                AddHandler form3.Load, New EventHandler(AddressOf form_Load)
            End If

            Return form3
        End Get
    End Property
    Private ReadOnly Property FormInstance4() As FrmMarcas
        Get
            If form4 Is Nothing Then
                form4 = New FrmMarcas()
                form4.MdiParent = Me

                AddHandler form4.Disposed, New EventHandler(AddressOf form_Disposed4)
                AddHandler form4.FormClosed, New FormClosedEventHandler(AddressOf form_FormClosed4)

                AddHandler form4.Load, New EventHandler(AddressOf form_Load)
            End If

            Return form4
        End Get
    End Property
    Private Sub ToolStripButtonAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAlmacen.Click

        Try

       
            If frmAlmacen.Created = False Then
                frmAlmacen.StartPosition = FormStartPosition.CenterScreen
                frmAlmacen.Show()
            Else
                frmAlmacen.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonArticulos.Click
        Try


            If frmArticulos.Created = False Then
                frmArticulos.StartPosition = FormStartPosition.CenterScreen
                frmArticulos.Show()
            Else
                frmArticulos.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCategorias.Click
        Try


            If frmCategorias.Created = False Then
                frmCategorias.StartPosition = FormStartPosition.CenterScreen
                frmCategorias.Show()
            Else
                frmCategorias.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonUnidadesMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonUnidadesMedida.Click
        Try


            If frmUnidades.Created = False Then
                frmUnidades.StartPosition = FormStartPosition.CenterScreen
                frmUnidades.Show()
            Else
                frmUnidades.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonMarcas.Click
        Try


            If FrmMarcas.Created = False Then
                FrmMarcas.StartPosition = FormStartPosition.CenterScreen
                FrmMarcas.Show()
            Else
                FrmMarcas.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonProveedores.Click
        Try


            If frmProveedores.Created = False Then
                frmProveedores.StartPosition = FormStartPosition.CenterScreen
                frmProveedores.Show()
            Else
                frmProveedores.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonConfigBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonConfigBarra.Click
        Try


            If frmConfigCodigoBarras.Created = False Then
                frmConfigCodigoBarras.StartPosition = FormStartPosition.CenterScreen
                frmConfigCodigoBarras.Show()
            Else
                frmConfigCodigoBarras.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MDIPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim dtm_fecha_act As Date = Now.Date
        'Dim dtm_fecha_fin As Date = "02/06/2017"

        'If dtm_fecha_act > dtm_fecha_fin Then
        '    MsgBox("Bloqueado")
        '    End
        'End If
    End Sub

    Private Sub MenuItemAlmacen_Click(sender As Object, e As EventArgs) Handles MenuItemAlmacen.Click
        Try


            If frmAlmacen.Created = False Then
                frmAlmacen.StartPosition = FormStartPosition.CenterScreen
                frmAlmacen.Show()
            Else
                frmAlmacen.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItemArticulo_Click(sender As Object, e As EventArgs) Handles MenuItemArticulo.Click
        Try


            If frmArticulos.Created = False Then
                frmArticulos.StartPosition = FormStartPosition.CenterScreen
                frmArticulos.Show()
            Else
                frmArticulos.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItemCategoria_Click(sender As Object, e As EventArgs) Handles MenuItemCategoria.Click
        Try


            If frmCategorias.Created = False Then
                frmCategorias.StartPosition = FormStartPosition.CenterScreen
                frmCategorias.Show()
            Else
                frmCategorias.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItemUnidadesDeMedida_Click(sender As Object, e As EventArgs) Handles MenuItemUnidadesDeMedida.Click
        Try


            If frmUnidades.Created = False Then
                frmUnidades.StartPosition = FormStartPosition.CenterScreen
                frmUnidades.Show()
            Else
                frmUnidades.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItemProveedores_Click(sender As Object, e As EventArgs) Handles MenuItemProveedores.Click
        Try


            If frmProveedores.Created = False Then
                frmProveedores.StartPosition = FormStartPosition.CenterScreen
                frmProveedores.Show()
            Else
                frmProveedores.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItemMarca_Click(sender As Object, e As EventArgs) Handles MenuItemMarca.Click
        Try


            If FrmMarcas.Created = False Then
                FrmMarcas.StartPosition = FormStartPosition.CenterScreen
                FrmMarcas.Show()
            Else
                FrmMarcas.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItemConfiguraciónDeEtiquetas_Click(sender As Object, e As EventArgs) Handles MenuItemConfiguraciónDeEtiquetas.Click
        Try


            If frmConfigCodigoBarras.Created = False Then
                frmConfigCodigoBarras.StartPosition = FormStartPosition.CenterScreen
                frmConfigCodigoBarras.Show()
            Else
                frmConfigCodigoBarras.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
