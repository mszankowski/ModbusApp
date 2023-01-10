Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fileReader As String
            RichTextBox1.Text = CurDir()
            Dim lokalizacja As String
            lokalizacja = CurDir() + "\INFO.txt"
            fileReader = My.Computer.FileSystem.ReadAllText(lokalizacja)
            RichTextBox1.Text = fileReader
        Catch ex As Exception
            MsgBox("błąd!!")

        End Try

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText("D:\test.txt")
        'RichTextBox1.Text = fileReader
        'RichTextBox1.Text = CurDir()



    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        txtResults.Clear()

        Dim script As String = txtScript.Text

        Dim objProcess As New System.Diagnostics.Process()

        objProcess.StartInfo.FileName = "powershell.exe"
        objProcess.StartInfo.Arguments = script
        objProcess.StartInfo.RedirectStandardOutput = True
        objProcess.StartInfo.RedirectStandardError = True
        objProcess.StartInfo.UseShellExecute = False
        objProcess.StartInfo.CreateNoWindow = True
        objProcess.Start()

        Dim output As String = objProcess.StandardOutput.ReadToEnd()
        Dim errors As String = objProcess.StandardError.ReadToEnd()

        txtResults.Text += "Output:" + Environment.NewLine
        txtResults.Text += "-------" + Environment.NewLine
        txtResults.Text += output + Environment.NewLine
        txtResults.Text += Environment.NewLine
        txtResults.Text += "Errors:" + Environment.NewLine
        txtResults.Text += "-------" + Environment.NewLine
        txtResults.Text += errors + Environment.NewLine
    End Sub
End Class