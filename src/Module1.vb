Imports System.Windows.Forms
Module Module1

    Sub Main()
        Dim user As String = InputBox("input username", "login", "ppetech")
        Dim passWord As String = InputBox("input passWord", "login", "ppetech")
        MessageBox.Show("are you sure to login", "Login confirmation", MessageBoxButtons.OKCancel)
        If (passWord = "ppetech") Then user = "success"
        Console.WriteLine("ans: " + user)
        Console.ReadLine()



    End Sub

End Module
