<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarcas))
        Me.dgvMarcas = New System.Windows.Forms.DataGridView()
        Me.txtMarcas = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.Busq_numdoc = New System.Windows.Forms.Button()
        CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMarcas
        '
        Me.dgvMarcas.AllowUserToAddRows = False
        Me.dgvMarcas.AllowUserToDeleteRows = False
        Me.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarcas.Location = New System.Drawing.Point(2, 121)
        Me.dgvMarcas.Name = "dgvMarcas"
        Me.dgvMarcas.ReadOnly = True
        Me.dgvMarcas.Size = New System.Drawing.Size(635, 434)
        Me.dgvMarcas.TabIndex = 0
        '
        'txtMarcas
        '
        Me.txtMarcas.Location = New System.Drawing.Point(214, 66)
        Me.txtMarcas.Name = "txtMarcas"
        Me.txtMarcas.Size = New System.Drawing.Size(249, 20)
        Me.txtMarcas.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Guardar, Me.ToolStripSeparator1, Me.Btn_Salir, Me.ToolStripSeparator2, Me.Btn_Imprimir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(640, 25)
        Me.ToolStrip1.TabIndex = 86
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
        Me.Btn_Imprimir.Size = New System.Drawing.Size(70, 22)
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Marca"
        '
        'rbActivo
        '
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Checked = True
        Me.rbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActivo.Location = New System.Drawing.Point(240, 98)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(61, 17)
        Me.rbActivo.TabIndex = 91
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'rbInactivo
        '
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInactivo.Location = New System.Drawing.Point(336, 98)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(71, 17)
        Me.rbInactivo.TabIndex = 92
        Me.rbInactivo.TabStop = True
        Me.rbInactivo.Text = "Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'Busq_numdoc
        '
        Me.Busq_numdoc.BackgroundImage = CType(resources.GetObject("Busq_numdoc.BackgroundImage"), System.Drawing.Image)
        Me.Busq_numdoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Busq_numdoc.Location = New System.Drawing.Point(469, 65)
        Me.Busq_numdoc.Name = "Busq_numdoc"
        Me.Busq_numdoc.Size = New System.Drawing.Size(22, 21)
        Me.Busq_numdoc.TabIndex = 90
        Me.Busq_numdoc.UseVisualStyleBackColor = True
        '
        'FrmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(640, 567)
        Me.Controls.Add(Me.rbInactivo)
        Me.Controls.Add(Me.rbActivo)
        Me.Controls.Add(Me.Busq_numdoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtMarcas)
        Me.Controls.Add(Me.dgvMarcas)
        Me.MaximizeBox = False
        Me.Name = "FrmMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas"
        CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMarcas As System.Windows.Forms.DataGridView
    Friend WithEvents txtMarcas As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Btn_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Btn_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Busq_numdoc As System.Windows.Forms.Button
    Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
End Class
