Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGoToErr.Click

        Dim isNumber As String
        isNumber = txtnumber.Text

        On Error GoTo ErrorEventHandler

        Dim numbericValue As Double
        numbericValue = CDbl(isNumber)

        MsgBox("You entered a valid number: " & numbericValue)
        Exit Sub

ErrorEventHandler:
        MsgBox("Error: " & isNumber & " is not a number")


    End Sub
End Class
