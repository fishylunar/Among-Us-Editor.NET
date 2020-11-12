<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.hatBox = New System.Windows.Forms.TextBox()
        Me.skinBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cN = New System.Windows.Forms.NumericUpDown()
        Me.rawDataBox = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.versionTxt = New System.Windows.Forms.Label()
        CType(Me.cN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(152, 75)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 23)
        Me.nameBox.TabIndex = 0
        '
        'hatBox
        '
        Me.hatBox.Location = New System.Drawing.Point(152, 133)
        Me.hatBox.Name = "hatBox"
        Me.hatBox.Size = New System.Drawing.Size(100, 23)
        Me.hatBox.TabIndex = 4
        '
        'skinBox
        '
        Me.skinBox.Location = New System.Drawing.Point(152, 162)
        Me.skinBox.Name = "skinBox"
        Me.skinBox.Size = New System.Drawing.Size(100, 23)
        Me.skinBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Skin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 79)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 79)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Save Graphical"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(17, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Among Us Editor .NET"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"None", "Brainslug 1", "Mini Crewmate 1", "Hamster 1", "Stickmin 1", "Hamster  2", "Mini Crewmate 2", "Brainslug 2", "Stickmin 2", "Bedcrab 1", "Bedcrab 2"})
        Me.ComboBox1.Location = New System.Drawing.Point(151, 191)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 17
        '
        'cN
        '
        Me.cN.Location = New System.Drawing.Point(152, 102)
        Me.cN.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.cN.Name = "cN"
        Me.cN.Size = New System.Drawing.Size(120, 23)
        Me.cN.TabIndex = 18
        '
        'rawDataBox
        '
        Me.rawDataBox.Location = New System.Drawing.Point(293, 75)
        Me.rawDataBox.Name = "rawDataBox"
        Me.rawDataBox.Size = New System.Drawing.Size(243, 303)
        Me.rawDataBox.TabIndex = 19
        Me.rawDataBox.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(293, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Raw Editor"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.statusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 470)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(545, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = "Status :"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(52, 17)
        Me.statusLabel.Text = "Running"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Graphical Editor"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 79)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Save Raw"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(293, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 79)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "GUI <= Raw"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(345, 382)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 79)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "GUI => Raw"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 220)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 155)
        Me.RichTextBox1.TabIndex = 27
        Me.RichTextBox1.Text = "Among Us Editor.NET" & Global.Microsoft.VisualBasic.ChrW(10) & "Created by f1sk // Jayy" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "V 0.2.2" & Global.Microsoft.VisualBasic.ChrW(10) & "+ Github Release with src" & Global.Microsoft.VisualBasic.ChrW(10) & "V " &
    "0.2.1" & Global.Microsoft.VisualBasic.ChrW(10) & "+ Status Indicator" & Global.Microsoft.VisualBasic.ChrW(10) & "V 0.2" & Global.Microsoft.VisualBasic.ChrW(10) & "+ RAW Editor" & Global.Microsoft.VisualBasic.ChrW(10) & "+ Graphical Color" & Global.Microsoft.VisualBasic.ChrW(10) & "+ Named Pets" & Global.Microsoft.VisualBasic.ChrW(10) & "V 0.1" &
    "" & Global.Microsoft.VisualBasic.ChrW(10) & "Initial Build"
        '
        'versionTxt
        '
        Me.versionTxt.AutoSize = True
        Me.versionTxt.Location = New System.Drawing.Point(248, 30)
        Me.versionTxt.Name = "versionTxt"
        Me.versionTxt.Size = New System.Drawing.Size(45, 15)
        Me.versionTxt.TabIndex = 28
        Me.versionTxt.Text = "version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 492)
        Me.Controls.Add(Me.versionTxt)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rawDataBox)
        Me.Controls.Add(Me.cN)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.skinBox)
        Me.Controls.Add(Me.hatBox)
        Me.Controls.Add(Me.nameBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Among Us Editor .NET"
        CType(Me.cN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameBox As TextBox
    Friend WithEvents hatBox As TextBox
    Friend WithEvents skinBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cN As NumericUpDown
    Friend WithEvents rawDataBox As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents versionTxt As Label
End Class
