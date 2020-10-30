<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmacen))
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.Busq_numdoc = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.dgvAlmacen = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbInactivo
        '
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInactivo.Location = New System.Drawing.Point(351, 72)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(71, 17)
        Me.rbInactivo.TabIndex = 101
        Me.rbInactivo.TabStop = True
        Me.rbInactivo.Text = "Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'rbActivo
        '
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Checked = True
        Me.rbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActivo.Location = New System.Drawing.Point(255, 72)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(61, 17)
        Me.rbActivo.TabIndex = 100
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'Busq_numdoc
        '
        Me.Busq_numdoc.BackgroundImage = CType(resources.GetObject("Busq_numdoc.BackgroundImage"), System.Drawing.Image)
        Me.Busq_numdoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Busq_numdoc.Location = New System.Drawing.Point(484, 41)
        Me.Busq_numdoc.Name = "Busq_numdoc"
        Me.Busq_numdoc.Size = New System.Drawing.Size(22, 21)
        Me.Busq_numdoc.TabIndex = 99
        Me.Busq_numdoc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Almacen"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Aceptar, Me.ToolStripSeparator1, Me.Btn_cancelar, Me.ToolStripSeparator2, Me.Btn_Imprimir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip1.TabIndex = 95
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Aceptar.Image = CType(resources.GetObject("Btn_Aceptar.Image"), System.Drawing.Image)
        Me.Btn_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(72, 22)
        Me.Btn_Aceptar.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancelar.Image = CType(resources.GetObject("Btn_cancelar.Image"), System.Drawing.Image)
        Me.Btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(77, 22)
        Me.Btn_cancelar.Text = "Cancelar"
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
        'txtAlmacen
        '
        Me.txtAlmacen.Location = New System.Drawing.Point(229, 40)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(249, 20)
        Me.txtAlmacen.TabIndex = 94
        '
        'dgvAlmacen
        '
        Me.dgvAlmacen.AllowUserToAddRows = False
        Me.dgvAlmacen.AllowUserToDeleteRows = False
        Me.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlmacen.Location = New System.Drawing.Point(12, 95)
        Me.dgvAlmacen.Name = "dgvAlmacen"
        Me.dgvAlmacen.ReadOnly = True
        Me.dgvAlmacen.Size = New System.Drawing.Size(668, 453)
        Me.dgvAlmacen.TabIndex = 93
        '
        'frmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.rbInactivo)
        Me.Controls.Add(Me.rbActivo)
        Me.Controls.Add(Me.Busq_numdoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.dgvAlmacen)
        Me.MaximizeBox = False
        Me.Name = "frmAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
    Friend WithEvents Busq_numdoc As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents dgvAlmacen As System.Windows.Forms.DataGridView
End Class
