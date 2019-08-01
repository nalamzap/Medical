Public Class MADO

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog With {
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        }
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog With {
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        }

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inventory.Show()
        Inventory.Dock = DockStyle.Right
        Customer.Show()
        Customer.Dock = DockStyle.Fill


    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click


    End Sub
End Class
