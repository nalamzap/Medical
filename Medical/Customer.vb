Imports System.Drawing.Printing
Public Class Customer
    Dim mPrintBitMap As Bitmap
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        MdiParent = MADO
    End Sub
    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Draw the image centered.
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) \ 2
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitMap, lWidth, lHeight)

        e.HasMorePages = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mPrintBitMap = New Bitmap(Me.Width, Me.Width)
        Dim lRect As Rectangle
        lRect.Width = Me.Width - 5
        lRect.Height = Me.Height
        PrintPreviewControl1.Visible = False
        Refresh()
        Me.DrawToBitmap(mPrintBitMap, lRect)


        ' Make a PrintDocument and print.
        PrintDocument1 = New PrintDocument
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.PrinterSettings.PrintToFile = True
        PrintDocument1.PrinterSettings.PrintFileName = "me.jpg"
        PrintPreviewControl1.Visible = True
        PrintPreviewControl1.Document = PrintDocument1

    End Sub
End Class