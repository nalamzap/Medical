<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlusItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchText = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlusItem, Me.AddNewItem, Me.RemoveItem, Me.SearchText, Me.SearchInventory})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(442, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlusItem
        '
        Me.PlusItem.Name = "PlusItem"
        Me.PlusItem.Padding = New System.Windows.Forms.Padding(0)
        Me.PlusItem.Size = New System.Drawing.Size(44, 26)
        Me.PlusItem.Text = "+Item"
        '
        'AddNewItem
        '
        Me.AddNewItem.Name = "AddNewItem"
        Me.AddNewItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AddNewItem.Size = New System.Drawing.Size(86, 26)
        Me.AddNewItem.Text = "Add new Item"
        '
        'RemoveItem
        '
        Me.RemoveItem.Name = "RemoveItem"
        Me.RemoveItem.Padding = New System.Windows.Forms.Padding(0)
        Me.RemoveItem.Size = New System.Drawing.Size(82, 26)
        Me.RemoveItem.Text = "Remove Item"
        '
        'SearchText
        '
        Me.SearchText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(190, 26)
        '
        'SearchInventory
        '
        Me.SearchInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchInventory.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInventory.ForeColor = System.Drawing.Color.MidnightBlue
        Me.SearchInventory.Margin = New System.Windows.Forms.Padding(0, -2, 0, 0)
        Me.SearchInventory.Name = "SearchInventory"
        Me.SearchInventory.Padding = New System.Windows.Forms.Padding(0)
        Me.SearchInventory.Size = New System.Drawing.Size(28, 28)
        Me.SearchInventory.Text = "ϙ"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inventory
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inventory"
        Me.ShowInTaskbar = False
        Me.Text = "Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PlusItem As ToolStripMenuItem
    Friend WithEvents AddNewItem As ToolStripMenuItem
    Friend WithEvents RemoveItem As ToolStripMenuItem
    Friend WithEvents SearchText As ToolStripTextBox
    Friend WithEvents SearchInventory As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
