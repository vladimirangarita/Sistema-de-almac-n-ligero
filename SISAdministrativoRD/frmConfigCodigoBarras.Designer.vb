<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigCodigoBarras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigCodigoBarras))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtAnchura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Busq_numdoc = New System.Windows.Forms.Button()
        Me.txtNEtiquetas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.crvArticulos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtDerechaIzquierda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArribaAbajo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDerechaIzquierda01 = New System.Windows.Forms.TextBox()
        Me.txtDerechaIzquierda02 = New System.Windows.Forms.TextBox()
        Me.txtDerechaIzquierda03 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(90, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 24)
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Código"
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(90, 26)
        Me.txtCodigoArticulo.MaxLength = 8
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.ReadOnly = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(212, 20)
        Me.txtCodigoArticulo.TabIndex = 148
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Altura"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(469, 24)
        Me.txtAltura.MaxLength = 8
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(212, 20)
        Me.txtAltura.TabIndex = 152
        '
        'txtAnchura
        '
        Me.txtAnchura.Location = New System.Drawing.Point(469, 46)
        Me.txtAnchura.MaxLength = 8
        Me.txtAnchura.Name = "txtAnchura"
        Me.txtAnchura.Size = New System.Drawing.Size(212, 20)
        Me.txtAnchura.TabIndex = 154
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Anchura"
        '
        'Busq_numdoc
        '
        Me.Busq_numdoc.BackgroundImage = CType(resources.GetObject("Busq_numdoc.BackgroundImage"), System.Drawing.Image)
        Me.Busq_numdoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Busq_numdoc.Location = New System.Drawing.Point(308, 24)
        Me.Busq_numdoc.Name = "Busq_numdoc"
        Me.Busq_numdoc.Size = New System.Drawing.Size(22, 21)
        Me.Busq_numdoc.TabIndex = 155
        Me.Busq_numdoc.UseVisualStyleBackColor = True
        '
        'txtNEtiquetas
        '
        Me.txtNEtiquetas.Location = New System.Drawing.Point(469, 108)
        Me.txtNEtiquetas.MaxLength = 8
        Me.txtNEtiquetas.Name = "txtNEtiquetas"
        Me.txtNEtiquetas.Size = New System.Drawing.Size(33, 20)
        Me.txtNEtiquetas.TabIndex = 158
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(357, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "N° etiquetas"
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(90, 72)
        Me.txtArticulo.MaxLength = 8
        Me.txtArticulo.Multiline = True
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.ReadOnly = True
        Me.txtArticulo.Size = New System.Drawing.Size(212, 35)
        Me.txtArticulo.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Articulo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Guardar, Me.ToolStripSeparator1, Me.Btn_Salir, Me.ToolStripSeparator2, Me.Btn_Imprimir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(918, 25)
        Me.ToolStrip1.TabIndex = 161
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(72, 22)
        Me.Btn_Guardar.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = CType(resources.GetObject("Btn_Salir.Image"), System.Drawing.Image)
        Me.Btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(77, 22)
        Me.Btn_Salir.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Image = CType(resources.GetObject("Btn_Imprimir.Image"), System.Drawing.Image)
        Me.Btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(69, 22)
        Me.Btn_Imprimir.Text = "Mostrar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'crvArticulos
        '
        Me.crvArticulos.ActiveViewIndex = -1
        Me.crvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvArticulos.CachedPageNumberPerDoc = 10
        Me.crvArticulos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvArticulos.Location = New System.Drawing.Point(7, 141)
        Me.crvArticulos.Name = "crvArticulos"
        Me.crvArticulos.Size = New System.Drawing.Size(911, 409)
        Me.crvArticulos.TabIndex = 162
        Me.crvArticulos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'txtDerechaIzquierda
        '
        Me.txtDerechaIzquierda.Location = New System.Drawing.Point(489, 87)
        Me.txtDerechaIzquierda.MaxLength = 8
        Me.txtDerechaIzquierda.Name = "txtDerechaIzquierda"
        Me.txtDerechaIzquierda.Size = New System.Drawing.Size(43, 20)
        Me.txtDerechaIzquierda.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(357, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Derecha, izquierda"
        '
        'txtArribaAbajo
        '
        Me.txtArribaAbajo.Location = New System.Drawing.Point(469, 65)
        Me.txtArribaAbajo.MaxLength = 8
        Me.txtArribaAbajo.Name = "txtArribaAbajo"
        Me.txtArribaAbajo.Size = New System.Drawing.Size(212, 20)
        Me.txtArribaAbajo.TabIndex = 164
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(357, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Arriba, abajo"
        '
        'txtDerechaIzquierda01
        '
        Me.txtDerechaIzquierda01.Location = New System.Drawing.Point(534, 87)
        Me.txtDerechaIzquierda01.MaxLength = 8
        Me.txtDerechaIzquierda01.Name = "txtDerechaIzquierda01"
        Me.txtDerechaIzquierda01.Size = New System.Drawing.Size(43, 20)
        Me.txtDerechaIzquierda01.TabIndex = 167
        '
        'txtDerechaIzquierda02
        '
        Me.txtDerechaIzquierda02.Location = New System.Drawing.Point(579, 87)
        Me.txtDerechaIzquierda02.MaxLength = 8
        Me.txtDerechaIzquierda02.Name = "txtDerechaIzquierda02"
        Me.txtDerechaIzquierda02.Size = New System.Drawing.Size(43, 20)
        Me.txtDerechaIzquierda02.TabIndex = 168
        '
        'txtDerechaIzquierda03
        '
        Me.txtDerechaIzquierda03.Location = New System.Drawing.Point(624, 87)
        Me.txtDerechaIzquierda03.MaxLength = 8
        Me.txtDerechaIzquierda03.Name = "txtDerechaIzquierda03"
        Me.txtDerechaIzquierda03.Size = New System.Drawing.Size(43, 20)
        Me.txtDerechaIzquierda03.TabIndex = 169
        '
        'frmConfigCodigoBarras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(918, 562)
        Me.Controls.Add(Me.txtDerechaIzquierda03)
        Me.Controls.Add(Me.txtDerechaIzquierda02)
        Me.Controls.Add(Me.txtDerechaIzquierda01)
        Me.Controls.Add(Me.txtDerechaIzquierda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtArribaAbajo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.crvArticulos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNEtiquetas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Busq_numdoc)
        Me.Controls.Add(Me.txtAnchura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigoArticulo)
        Me.MaximizeBox = False
        Me.Name = "frmConfigCodigoBarras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de etiquetas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtAnchura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Busq_numdoc As System.Windows.Forms.Button
    Friend WithEvents txtNEtiquetas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Btn_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Btn_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents crvArticulos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtDerechaIzquierda As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtArribaAbajo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDerechaIzquierda01 As System.Windows.Forms.TextBox
    Friend WithEvents txtDerechaIzquierda02 As System.Windows.Forms.TextBox
    Friend WithEvents txtDerechaIzquierda03 As System.Windows.Forms.TextBox
End Class
