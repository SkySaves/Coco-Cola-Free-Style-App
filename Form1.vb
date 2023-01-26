Imports System.Windows

Public Class Form1
    Dim selectedFlavor As String = Form2.flavor
    Private Sub btnMixDisp_Click(sender As Object, e As EventArgs) Handles btnMixDisp.Click

        If rad8oz.Checked = False And rad10oz.Checked = False And rad12oz.Checked = False Then
            ' No radio button is selected
            MsgBox("Please select a size before dispensing.")
        Else
            Dim oz As Integer
            If rad8oz.Checked = True Then
                oz = 8
            ElseIf rad10oz.Checked = True Then
                oz = 10
            ElseIf rad12oz.Checked = True Then
                oz = 12
            End If
            Dim result As Integer = MsgBox("Now dispensing " & oz & " oz of " & selectedFlavor & "." & vbCrLf & "Do you want to proceed?", vbYesNo + vbInformation, "Confirmation")
            If result = vbYes Then
                ' okay button was clicked

            Else
                ' No button was clicked
            End If
        End If
    End Sub

    Private Sub picCola_Click(sender As Object, e As EventArgs) Handles picCola.Click
        Dim frm As New Form2 ' Create an instance of the new form
        Me.Hide() ' Hide the current form
        frm.Show() ' Show the new form
        selectedFlavor = "Coca Cola"
    End Sub

    Private Sub picDietCola_Click(sender As Object, e As EventArgs) Handles picDietCola.Click
        selectedFlavor = "Diet Coke"
    End Sub

    Private Sub picColaZero_Click(sender As Object, e As EventArgs) Handles picColaZero.Click
        selectedFlavor = "Coca Cola Zero"
    End Sub

    Private Sub picSprite_Click(sender As Object, e As EventArgs) Handles picSprite.Click
        selectedFlavor = "Sprite"
    End Sub

    Private Sub picSpriteZero_Click(sender As Object, e As EventArgs) Handles picSpriteZero.Click
        selectedFlavor = "Sprite Zero"
    End Sub

    Private Sub picPibb_Click(sender As Object, e As EventArgs) Handles picPibb.Click
        selectedFlavor = "Pibb Xtra"
    End Sub

    Private Sub picPowerade_Click(sender As Object, e As EventArgs) Handles picPowerade.Click
        selectedFlavor = "Powerade"
    End Sub

    Private Sub picRoot_Click(sender As Object, e As EventArgs) Handles picRoot.Click
        selectedFlavor = "Barq's Root Beer"
    End Sub

    Private Sub PicFanta_Click(sender As Object, e As EventArgs) Handles PicFanta.Click
        selectedFlavor = "Fanta"
    End Sub

    Private Sub picPepper_Click(sender As Object, e As EventArgs) Handles picPepper.Click
        selectedFlavor = "Dr. Pepper"
    End Sub

    Private Sub picMello_Click(sender As Object, e As EventArgs) Handles picMello.Click
        selectedFlavor = "Mello Yello"
    End Sub

    Private Sub picMinute_Click(sender As Object, e As EventArgs) Handles picMinute.Click
        selectedFlavor = "Minute Maid"
    End Sub
End Class
