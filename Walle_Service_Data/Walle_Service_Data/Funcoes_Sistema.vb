Imports System.Net
Imports System.IO

Public Class Funcoes_Sistema

    Dim WithEvents WClient As New System.Net.WebClient
    Dim Ftpkey As New WebClient

    Public Sub ProcurarArquivos(ByVal arquivoFTP As String, ByVal usuario As String, ByVal senha As String, ByVal Cod As String)

        'Dim sArquivos As ArrayList = New ArrayList
        'Dim iContador As Integer
        'Dim fwr As FtpWebRequest = FtpWebRequest.Create("ftp://ftp.fourkey.com.br/Walle/Client/" & Cod & "/Licenca/Ativas")
        'fwr.Credentials = New NetworkCredential(usuario, senha)
        'fwr.Method = WebRequestMethods.Ftp.ListDirectory
        'Dim sr As New StreamReader(fwr.GetResponse().GetResponseStream())
        'Dim str As String = sr.ReadLine()
        'Dim CaminhoCop As String = System.Reflection.Assembly.GetExecutingAssembly().Location

        'iContador = 0
        'While Not str Is Nothing

        '    fwr = WebRequest.Create(arquivoFTP & "/Walle/Client/" & Cod & "/Licenca/" & linhaTexto)
        '    fwr.Credentials = New NetworkCredential(usuario, senha)
        '    fwr.Method = WebRequestMethods.Ftp.DeleteFile
        '    Dim ftpResp As FtpWebResponse = fwr.GetResponse

        '    sr.

        '    linhaTexto = str
        '    str = sr.ReadLine()
        '    linhaTexto = linhaTexto.Replace(".txt", "")

        '    If linhaTexto = ComputerName Then

        '        Return True

        '    End If

        'End While

    End Sub

    Private Sub CriarPasta()

        Directory.CreateDirectory("C:\Fourkey\Admin\1002\")


    End Sub

    Public Sub DownloadFile(ByVal Cod As Integer, ByVal usuarioftp As String, ByVal senhaftp As String)

        Frm_Inicio.Lb_Conexao.Text = "Configurando Conexão"
        Frm_Inicio.Progress_Inicio.Value = 1
        Application.DoEvents()

        Dim Cont As Integer = 1
        Dim fwr As FtpWebRequest = FtpWebRequest.Create("ftp://ftp.fourkey.com.br/Walle/Client/" & Cod & "/File")
        fwr.Credentials = New NetworkCredential(usuarioftp, senhaftp)
        fwr.Method = WebRequestMethods.Ftp.ListDirectory
        fwr.UsePassive = False

        Frm_Inicio.Lb_Conexao.Text = "Estabelecendo Conexão"
        Frm_Inicio.Progress_Inicio.Value = 5
        Application.DoEvents()

        Frm_Inicio.Coment = "Conectando"
        Dim sr As New StreamReader(fwr.GetResponse().GetResponseStream())

        Frm_Inicio.Lb_Conexao.Text = "Recebendo Lista"
        Frm_Inicio.Progress_Inicio.Value = 7
        Application.DoEvents()

        Frm_Inicio.Coment = "Listando"
        Dim str As String = sr.ReadLine()

        Dim ArrayDeArquivo As New ArrayList
        Dim linhatexto As String
        Dim Valor As Double
        Dim Conteudo As Double

        Frm_Inicio.Lb_Conexao.Text = "Listando Arquivos"
        Frm_Inicio.Progress_Inicio.Value = 8
        Application.DoEvents()

        Try

            While Not str Is Nothing

                ArrayDeArquivo.Add(str)

                str = sr.ReadLine()

            End While

        Catch ex As Exception

            '

        End Try

        sr.Dispose()
        sr.Close()

        Frm_Inicio.Lb_Conexao.Text = "Conexão Finalizada"
        Frm_Inicio.Progress_Inicio.Value = 10
        Application.DoEvents()

        Valor = 100 / ArrayDeArquivo.Count
        Conteudo = Valor

        'MsgBox(ArrayDeArquivo.Count)

        For i As Integer = 0 To ArrayDeArquivo.Count - 1

            Try

                linhatexto = ArrayDeArquivo.Item(i).ToString
                Dim FtpClient As FtpWebRequest = FtpWebRequest.Create("ftp://ftp.fourkey.com.br/Walle/Client/" & Cod & "/File/" & linhatexto)
                FtpClient.Credentials = New NetworkCredential(usuarioftp, senhaftp)
                FtpClient.Method = WebRequestMethods.Ftp.DownloadFile
                FtpClient.UsePassive = False
                'Get the response to the Ftp request and the associated stream
                Using response As System.Net.FtpWebResponse = CType(FtpClient.GetResponse, System.Net.FtpWebResponse)
                    Using responseStream As IO.Stream = response.GetResponseStream
                        'loop to read & write to file
                        Using fs As New IO.FileStream("C:\Fourkey\Admin\Files\" & Cod & "\" & linhatexto, IO.FileMode.Create)
                            Dim buffer(2047) As Byte
                            Dim read As Integer = 0
                            Do
                                read = responseStream.Read(buffer, 0, buffer.Length)
                                fs.Write(buffer, 0, read)
                            Loop Until read = 0 'see Note(1)
                            responseStream.Close()
                            fs.Flush()
                            fs.Close()
                        End Using
                        responseStream.Close()
                    End Using
                    response.Close()
                End Using

                Frm_Inicio.Lb_Arquivos.Text = "Copiando arquivo " & Cont & "/" & ArrayDeArquivo.Count & "-" & linhatexto
                Frm_Inicio.Progress_Arq.Value = Conteudo
                Application.DoEvents()

                Cont = Cont + 1
                Conteudo = Conteudo + Valor

            Catch ex As Exception

                '

            End Try

        Next

        Conteudo = 0

        For i As Integer = 0 To ArrayDeArquivo.Count - 1

            linhatexto = ArrayDeArquivo.Item(i).ToString

            Try

                Dim filename As String = ArrayDeArquivo.Item(i)
                Dim ftpReq As FtpWebRequest = WebRequest.Create("ftp://ftp.fourkey.com.br/Walle/Client/" & Cod & "/File/" & linhatexto)

                ftpReq.Method = WebRequestMethods.Ftp.DeleteFile
                ftpReq.Credentials = New NetworkCredential(usuarioftp, senhaftp)

                Dim ftpResp As FtpWebResponse = ftpReq.GetResponse

                Frm_Inicio.Lb_Arquivos.Text = "Deletando arquivo " & Cont & "/" & ArrayDeArquivo.Count & "-" & linhatexto
                Frm_Inicio.Progress_Arq.Value = Conteudo
                Application.DoEvents()

            Catch ex As Exception

                'Nada a fazer

            End Try

        Next

    End Sub 'FAZ DOWNLOAD DO ARQUIVO REMOTO

End Class
