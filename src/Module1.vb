Imports System.Windows.Forms
Module Module1

    Sub Main()
        Dim user As String = InputBox("input username", "login", "ppetech")
        Dim passWord As String = InputBox("input passWord", "login", "ppetech")
        Dim textDisplay As String
        MessageBox.Show("are you sure to login", "Login confirmation", MessageBoxButtons.OKCancel)
        If (passWord = "ppetech") Then
            textDisplay = "loin as: " + user
        Else
            textDisplay = "incorrect password"
        End If
        Console.WriteLine(textDisplay)
        Console.ReadLine()



    End Sub

End Module
