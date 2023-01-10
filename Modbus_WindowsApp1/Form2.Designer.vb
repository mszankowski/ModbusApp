<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.txtResults = New System.Windows.Forms.RichTextBox()
        Me.txtScript = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(472, 346)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(490, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = " Wyswietl plik txt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.BackColor = System.Drawing.Color.Transparent
        Me.btnExecute.Location = New System.Drawing.Point(694, 97)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(143, 41)
        Me.btnExecute.TabIndex = 103
        Me.btnExecute.TabStop = False
        Me.btnExecute.Text = "btnExecute" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wyslij komende"
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(605, 163)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(326, 182)
        Me.txtResults.TabIndex = 102
        Me.txtResults.Text = "https://www.emoreau.com/Entries/Articles/2018/06/Running-a-PowerShell-script-from" &
    "-a-Net-application.aspx"
        '
        'txtScript
        '
        Me.txtScript.Location = New System.Drawing.Point(605, 40)
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(297, 51)
        Me.txtScript.TabIndex = 101
        Me.txtScript.Text = "ping 192.168.1.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(602, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = " Komenda do wysłania w CMD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(602, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = " Okno wyniku "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 375)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExecute As Button
    Friend WithEvents txtResults As RichTextBox
    Friend WithEvents txtScript As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
