<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgendarNuevaCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarOEliminarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendarNuevaCitaToolStripMenuItem, Me.ConsultarOEliminarCitaToolStripMenuItem, Me.ModificarCitaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgendarNuevaCitaToolStripMenuItem
        '
        Me.AgendarNuevaCitaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgendarNuevaCitaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AgendarNuevaCitaToolStripMenuItem.Image = CType(resources.GetObject("AgendarNuevaCitaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgendarNuevaCitaToolStripMenuItem.Name = "AgendarNuevaCitaToolStripMenuItem"
        Me.AgendarNuevaCitaToolStripMenuItem.Size = New System.Drawing.Size(151, 21)
        Me.AgendarNuevaCitaToolStripMenuItem.Text = "Agregar Nueva Cita"
        '
        'ConsultarOEliminarCitaToolStripMenuItem
        '
        Me.ConsultarOEliminarCitaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ConsultarOEliminarCitaToolStripMenuItem.Image = CType(resources.GetObject("ConsultarOEliminarCitaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarOEliminarCitaToolStripMenuItem.Name = "ConsultarOEliminarCitaToolStripMenuItem"
        Me.ConsultarOEliminarCitaToolStripMenuItem.Size = New System.Drawing.Size(179, 21)
        Me.ConsultarOEliminarCitaToolStripMenuItem.Text = "Consultar o Eliminar Cita"
        '
        'ModificarCitaToolStripMenuItem
        '
        Me.ModificarCitaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ModificarCitaToolStripMenuItem.Image = CType(resources.GetObject("ModificarCitaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarCitaToolStripMenuItem.Name = "ModificarCitaToolStripMenuItem"
        Me.ModificarCitaToolStripMenuItem.Size = New System.Drawing.Size(118, 21)
        Me.ModificarCitaToolStripMenuItem.Text = "Modificar Cita"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AyudaToolStripMenuItem.Image = CType(resources.GetObject("AyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(765, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "               "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel1.Text = "Bienvenido :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel2.Text = "Usuario"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(765, 420)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents AgendarNuevaCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarOEliminarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
