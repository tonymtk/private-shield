Imports System.IO
Imports System.Threading
Public Class frmVerify

    Dim lista_PeT As New ListBox
    Dim i As Integer = -1
    Dim TH1 As Thread
    Private Sub ListarDados()

        Dim pList() As System.Diagnostics.Process =
    System.Diagnostics.Process.GetProcesses
        For Each proc As System.Diagnostics.Process In pList
            If proc.MainWindowTitle <> Nothing Then
                If Me.InvokeRequired Then
                    Dim args() As String = {proc.MainWindowTitle.ToUpper}
                    Me.Invoke(New Action(Of String)(AddressOf ListarDados), args)
                    Return
                End If
                lista_PeT.Items.Add(proc.MainWindowTitle.ToUpper)
            Else
                If Me.InvokeRequired Then
                    Dim args() As String = {proc.ProcessName.ToUpper}
                    Me.Invoke(New Action(Of String)(AddressOf ListarDados), args)
                    Return
                End If
                lista_PeT.Items.Add(proc.ProcessName.ToUpper)
            End If
        Next
        Do
            Try
                i = i + 1
                lista_PeT.SelectedIndex = i
                Dim pesquisar As String
                For Each item As String In elemento_chave
                    pesquisar = InStr(lista_PeT.SelectedItem, item)
                    If pesquisar > 0 Then
                        frmDetected.Label2.Text = lista_PeT.SelectedItem
                        frmDetected.ShowDialog()
                    End If
                Next
            Catch
                i = -1
                lista_PeT.Items.Clear()
                Exit Do
            End Try
        Loop
        TH1 = New Thread(AddressOf ListarDados)
        TH1.IsBackground = True
        TH1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName(ProcessBox.Text)

        For Each x As Process In Processos
            x.Kill()
        Next
        Me.Close()
    End Sub

    Private Sub VerifyOnline_Tick(sender As Object, e As EventArgs) Handles VerifyOnline.Tick
        Dim myprocesses As Process()
        myprocesses = Process.GetProcessesByName(ProcessBox.Text) 'obter processos com o nome X(ProcessBox)
        If myprocesses.Length > 0 = True Then 'se for maior que 0 então existem processos com o nome X(ProcessBox)

        Else
            Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName(ProcessBox.Text)

            For Each x As Process In Processos
                x.Kill()
            Next
            Me.Close()
        End If
    End Sub

    Private Sub SafeButton_Click(sender As Object, e As EventArgs) Handles SafeButton.Click
        Me.Hide()
        VerifyOnline.Start()
        TH1 = New Thread(AddressOf ListarDados)
        TH1.IsBackground = True
        TH1.Start()
    End Sub

    Private Sub frmVerify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Este software possui alto uso de processamento!", MsgBoxStyle.Exclamation, "Atenção")
        MsgBox("Versão 2.0.0.0 DIDÁTICO" & vbNewLine & "Compartilhado por KingCoder(RpDev Team Leader)", MsgBoxStyle.Information, "Informação")
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub SiteButton_Click(sender As Object, e As EventArgs) Handles SiteButton.Click
        frmNavigator.ShowDialog()
    End Sub
End Class
