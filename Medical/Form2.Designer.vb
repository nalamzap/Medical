<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 500)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(475, 474)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.TextBox1.Location = New System.Drawing.Point(161, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Phone No :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.TextBox2.Location = New System.Drawing.Point(161, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.TextBox3.Location = New System.Drawing.Point(161, 90)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(271, 87)
        Me.TextBox3.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(483, 500)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
