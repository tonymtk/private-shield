Public Class frmNavigator

    Private Sub frmNavigator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.Clear()
        Clipboard.SetText(LinkBox.Text)
    End Sub

    Private Sub CopyButton2_Click(sender As Object, e As EventArgs) Handles CopyButton2.Click
        Clipboard.Clear()
        Clipboard.SetText(LinkBox2.Text)
    End Sub

    Private Sub CopyButton3_Click(sender As Object, e As EventArgs) Handles CopyButton3.Click
        Clipboard.Clear()
        Clipboard.SetText(LinkBox3.Text)
    End Sub

    Private Sub CopyButton4_Click(sender As Object, e As EventArgs) Handles CopyButton4.Click
        Clipboard.Clear()
        Clipboard.SetText(LinkBox4.Text)
    End Sub

    Private Sub OpenLinkButton_Click(sender As Object, e As EventArgs) Handles OpenLinkButton.Click
        Process.Start(LinkBox.Text)
    End Sub

    Private Sub OpenLinkButton2_Click(sender As Object, e As EventArgs) Handles OpenLinkButton2.Click
        Process.Start(LinkBox2.Text)
    End Sub

    Private Sub OpenLinkButton3_Click(sender As Object, e As EventArgs) Handles OpenLinkButton3.Click
        Process.Start(LinkBox3.Text)
    End Sub

    Private Sub OpenLinkButton4_Click(sender As Object, e As EventArgs) Handles OpenLinkButton4.Click
        Process.Start(LinkBox4.Text)
    End Sub
End Class