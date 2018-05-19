Public Class frmDetected

    Private Sub frmDetected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmVerify.WindowState = FormWindowState.Normal Then
            frmVerify.Hide()
        Else

        End If
        LoadingTime.Start()
    End Sub

    Private Sub LoadingTime_Tick(sender As Object, e As EventArgs) Handles LoadingTime.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName("notepad")

            For Each x As Process In Processos
                x.Kill()
            Next
            frmVerify.Close()
        Else

        End If
    End Sub

    Private Sub VerifyOnline_Tick(sender As Object, e As EventArgs) Handles VerifyOnline.Tick
        Dim myprocesses As Process()
        myprocesses = Process.GetProcessesByName("notepad") 'obter processos com o nome X
        If myprocesses.Length > 0 = True Then 'se for maior que 0 então existem processos com o nome X

        Else
            Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName("notepad")

            For Each x As Process In Processos
                x.Kill()
            Next
            frmVerify.Close()
        End If
    End Sub
End Class