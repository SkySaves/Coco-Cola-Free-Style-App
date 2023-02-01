Imports System.Windows

Public Class MainForm
    Private selectedFlavor As String

    Private Sub btnMixDisp_Click(sender As Object, e As EventArgs) Handles btnMixDisp.Click
        If Not (rad16oz.Checked Or rad16oz.Checked Or rad24oz.Checked Or rad32oz.Checked) Then
            ' No radio button is selected
            MessageBox.Show("Please select a size before dispensing.")
        Else
            Dim oz As Integer
            oz = If(rad16oz.Checked, 8, If(rad16oz.Checked, 16, If(rad24oz.Checked, 24, 32)))
            Dim result As DialogResult = MessageBox.Show("Now dispensing " & oz & " oz of " & selectedFlavor & "." & vbCrLf & "Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                ' okay button was clicked
            Else
                ' No button was clicked
            End If
        End If
    End Sub


    Private Sub picCola_Click(sender As Object, e As EventArgs) Handles picCola.Click
        Me.Hide() ' Hide the current form
        ColaSelections.ShowDialog() ' Show the new form as modal
        selectedFlavor = ColaSelections.flavor
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