Imports System.IO

Public Class Frm_Inicio

    Public Shared UserCript As String = My.Settings.CriptUser
    Public Shared PassCript As String = My.Settings.CriptPass
    Dim Funcao As New Funcoes_Sistema
    Public Coment As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DownloadArquivos()

    End Sub

    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DownloadArquivos()

        Timer_Loop.Enabled = False
        Application.DoEvents()

        For i As Integer = 1000 To 1010

            Try

                If Directory.Exists("C:\Fourkey\Admin\Files\" & i) = False Then

                    Directory.CreateDirectory("C:\Fourkey\Admin\Files\" & i)

                End If

                Funcao.DownloadFile(i, UserCript, PassCript)

            Catch ex As Exception

                '

            End Try

            Lb_Arquivos.Text = ""
            Lb_Conexao.Text = ""
            Progress_Arq.Value = 0
            Progress_Inicio.Value = 0

        Next

        Timer_Loop.Enabled = True

    End Sub

    Private Sub Timer_Loop_Tick(sender As Object, e As EventArgs) Handles Timer_Loop.Tick

        DownloadArquivos()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer_Loop.Enabled = False

    End Sub

End Class
