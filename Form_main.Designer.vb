<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.texte_CB = New System.Windows.Forms.TextBox()
        Me.save_IMG = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.convert_CB = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Chose_Font = New System.Windows.Forms.GroupBox()
        Me.Liste_Fonts = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Chose_Font.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.texte_CB)
        Me.GroupBox1.Location = New System.Drawing.Point(391, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Texte"
        '
        'texte_CB
        '
        Me.texte_CB.Location = New System.Drawing.Point(6, 20)
        Me.texte_CB.Name = "texte_CB"
        Me.texte_CB.Size = New System.Drawing.Size(368, 20)
        Me.texte_CB.TabIndex = 0
        '
        'save_IMG
        '
        Me.save_IMG.Location = New System.Drawing.Point(6, 120)
        Me.save_IMG.Name = "save_IMG"
        Me.save_IMG.Size = New System.Drawing.Size(753, 26)
        Me.save_IMG.TabIndex = 1
        Me.save_IMG.Text = "Save picture (.jpg)"
        Me.save_IMG.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.convert_CB)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox2.MaximumSize = New System.Drawing.Size(765, 100)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(765, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(765, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Code barre ( texte )"
        '
        'convert_CB
        '
        Me.convert_CB.AutoSize = True
        Me.convert_CB.BackColor = System.Drawing.Color.White
        Me.convert_CB.Location = New System.Drawing.Point(5, 19)
        Me.convert_CB.MaximumSize = New System.Drawing.Size(754, 90)
        Me.convert_CB.MinimumSize = New System.Drawing.Size(754, 90)
        Me.convert_CB.Name = "convert_CB"
        Me.convert_CB.Size = New System.Drawing.Size(754, 90)
        Me.convert_CB.TabIndex = 0
        Me.convert_CB.Text = resources.GetString("convert_CB.Text")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.save_IMG)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 187)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(765, 157)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Code barre ( image )"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(754, 95)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(754, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(754, 95)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 358)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(780, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(126, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Chose_Font
        '
        Me.Chose_Font.Controls.Add(Me.Liste_Fonts)
        Me.Chose_Font.Location = New System.Drawing.Point(6, 5)
        Me.Chose_Font.Name = "Chose_Font"
        Me.Chose_Font.Size = New System.Drawing.Size(384, 50)
        Me.Chose_Font.TabIndex = 6
        Me.Chose_Font.TabStop = False
        Me.Chose_Font.Text = "Font"
        '
        'Liste_Fonts
        '
        Me.Liste_Fonts.FormattingEnabled = True
        Me.Liste_Fonts.Location = New System.Drawing.Point(7, 18)
        Me.Liste_Fonts.Name = "Liste_Fonts"
        Me.Liste_Fonts.Size = New System.Drawing.Size(363, 21)
        Me.Liste_Fonts.TabIndex = 0
        '
        'Form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.Chose_Font)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Barcode"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Chose_Font.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents texte_CB As System.Windows.Forms.TextBox
    Friend WithEvents save_IMG As System.Windows.Forms.Button
    Friend WithEvents convert_CB As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Chose_Font As System.Windows.Forms.GroupBox
    Friend WithEvents Liste_Fonts As System.Windows.Forms.ComboBox
End Class
