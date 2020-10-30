<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonAlmacen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonArticulos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCategorias = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUnidadesMedida = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonMarcas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonProveedores = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonConfigBarra = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuArchivo = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemArticulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemCategoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemUnidadesDeMedida = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemMarca = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemConfiguraciónDeEtiquetas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.mnuArchivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAlmacen, Me.ToolStripButtonArticulos, Me.ToolStripButtonCategorias, Me.ToolStripButtonUnidadesMedida, Me.ToolStripButtonMarcas, Me.ToolStripButtonProveedores, Me.ToolStripButtonConfigBarra})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1229, 39)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButtonAlmacen
        '
        Me.ToolStripButtonAlmacen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAlmacen.Image = CType(resources.GetObject("ToolStripButtonAlmacen.Image"), System.Drawing.Image)
        Me.ToolStripButtonAlmacen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAlmacen.Name = "ToolStripButtonAlmacen"
        Me.ToolStripButtonAlmacen.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonAlmacen.Text = "Almacen"
        Me.ToolStripButtonAlmacen.ToolTipText = "Almacen"
        '
        'ToolStripButtonArticulos
        '
        Me.ToolStripButtonArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonArticulos.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__1_
        Me.ToolStripButtonArticulos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonArticulos.Name = "ToolStripButtonArticulos"
        Me.ToolStripButtonArticulos.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonArticulos.Text = "Artículos"
        '
        'ToolStripButtonCategorias
        '
        Me.ToolStripButtonCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCategorias.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__2_
        Me.ToolStripButtonCategorias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCategorias.Name = "ToolStripButtonCategorias"
        Me.ToolStripButtonCategorias.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonCategorias.Text = "Categoría de artículos"
        '
        'ToolStripButtonUnidadesMedida
        '
        Me.ToolStripButtonUnidadesMedida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUnidadesMedida.Image = CType(resources.GetObject("ToolStripButtonUnidadesMedida.Image"), System.Drawing.Image)
        Me.ToolStripButtonUnidadesMedida.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUnidadesMedida.Name = "ToolStripButtonUnidadesMedida"
        Me.ToolStripButtonUnidadesMedida.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonUnidadesMedida.Text = "Unidades de medida"
        '
        'ToolStripButtonMarcas
        '
        Me.ToolStripButtonMarcas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonMarcas.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__6_
        Me.ToolStripButtonMarcas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMarcas.Name = "ToolStripButtonMarcas"
        Me.ToolStripButtonMarcas.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonMarcas.Text = "Marcas de los artículos"
        '
        'ToolStripButtonProveedores
        '
        Me.ToolStripButtonProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonProveedores.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__5_
        Me.ToolStripButtonProveedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonProveedores.Name = "ToolStripButtonProveedores"
        Me.ToolStripButtonProveedores.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonProveedores.Text = "Proveedores de los artículos"
        '
        'ToolStripButtonConfigBarra
        '
        Me.ToolStripButtonConfigBarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonConfigBarra.Image = CType(resources.GetObject("ToolStripButtonConfigBarra.Image"), System.Drawing.Image)
        Me.ToolStripButtonConfigBarra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonConfigBarra.Name = "ToolStripButtonConfigBarra"
        Me.ToolStripButtonConfigBarra.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonConfigBarra.Text = "Configuración de etiquetas"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 720)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1229, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ProcesosToolStripMenuItem})
        Me.mnuArchivo.Location = New System.Drawing.Point(0, 0)
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(1229, 24)
        Me.mnuArchivo.TabIndex = 9
        Me.mnuArchivo.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAlmacen, Me.MenuItemArticulo, Me.MenuItemCategoria, Me.MenuItemUnidadesDeMedida, Me.MenuItemMarca, Me.MenuItemProveedores})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MenuItemAlmacen
        '
        Me.MenuItemAlmacen.Image = Global.SISAdministrativoRD.My.Resources.Resources.fabrica_casa_con_inventario
        Me.MenuItemAlmacen.Name = "MenuItemAlmacen"
        Me.MenuItemAlmacen.Size = New System.Drawing.Size(182, 22)
        Me.MenuItemAlmacen.Text = "Almacén"
        '
        'MenuItemArticulo
        '
        Me.MenuItemArticulo.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__1_
        Me.MenuItemArticulo.Name = "MenuItemArticulo"
        Me.MenuItemArticulo.Size = New System.Drawing.Size(182, 22)
        Me.MenuItemArticulo.Text = "Articulo"
        '
        'MenuItemCategoria
        '
        Me.MenuItemCategoria.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__2_
        Me.MenuItemCategoria.Name = "MenuItemCategoria"
        Me.MenuItemCategoria.Size = New System.Drawing.Size(182, 22)
        Me.MenuItemCategoria.Text = "Categoria"
        '
        'MenuItemUnidadesDeMedida
        '
        Me.MenuItemUnidadesDeMedida.Name = "MenuItemUnidadesDeMedida"
        Me.MenuItemUnidadesDeMedida.Size = New System.Drawing.Size(182, 22)
        Me.MenuItemUnidadesDeMedida.Text = "Unidades de medida"
        '
        'MenuItemMarca
        '
        Me.MenuItemMarca.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__6_
        Me.MenuItemMarca.Name = "MenuItemMarca"
        Me.MenuItemMarca.Size = New System.Drawing.Size(182, 22)
        Me.MenuItemMarca.Text = "Marca"
        '
        'MenuItemProveedores
        '
        Me.MenuItemProveedores.Image = Global.SISAdministrativoRD.My.Resources.Resources.favicon__5_
        Me.MenuItemProveedores.Name = "MenuItemProveedores"
        Me.MenuItemProveedores.Size = New System.Drawing.Size(182, 22)
        Me.MenuItemProveedores.Text = "Proveedores"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemConfiguraciónDeEtiquetas})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'MenuItemConfiguraciónDeEtiquetas
        '
        Me.MenuItemConfiguraciónDeEtiquetas.Image = Global.SISAdministrativoRD.My.Resources.Resources.barras64
        Me.MenuItemConfiguraciónDeEtiquetas.Name = "MenuItemConfiguraciónDeEtiquetas"
        Me.MenuItemConfiguraciónDeEtiquetas.Size = New System.Drawing.Size(217, 22)
        Me.MenuItemConfiguraciónDeEtiquetas.Text = "Configuración de etiquetas"
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SISAdministrativoRD.My.Resources.Resources.sistema_admin
        Me.ClientSize = New System.Drawing.Size(1229, 742)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.mnuArchivo)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuArchivo
        Me.Name = "MDIPrincipal"
        Me.Text = "Sistema de Almacen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.mnuArchivo.ResumeLayout(False)
        Me.mnuArchivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonAlmacen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonArticulos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCategorias As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUnidadesMedida As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonMarcas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonProveedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonConfigBarra As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuArchivo As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemAlmacen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemArticulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemCategoria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemConfiguraciónDeEtiquetas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemUnidadesDeMedida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemMarca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemProveedores As System.Windows.Forms.ToolStripMenuItem

End Class
