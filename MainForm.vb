Imports System.Security.Policy
Imports System.Text
Imports System.Windows
Public Class MainForm
    Private syrupLevels As New Dictionary(Of String, Double) From {
    {"Coca Cola", 1.0},
    {"Diet Cola", 1.0},
    {"Cola Zero", 1.0},
    {"Pibb Xtra", 1.0},
    {"Mello Yello", 1.0},
    {"Minute Maid", 1.0},
    {"Powerade", 1.0},
    {"Sprite", 1.0},
    {"Sprite Zero", 1.0},
    {"Fanta", 1.0},
    {"Dr. Pepper", 1.0},
    {"Barq's", 1.0}
}
    Dim co2Level As Double = 5.0
    Dim cboSize As ComboBox = Me.Controls("cboSize")
    Dim cboFlavor1 As ComboBox = Me.Controls("cboFlavor1")
    Dim cboFlavor2 As ComboBox = Me.Controls("cboFlavor2")
    Dim cboFlavor3 As ComboBox = Me.Controls("cboFlavor3")
    Dim totalSyrupConsumed As Double = 0.0
    Dim syrupConsumed As Double = 0.0
    Dim c02Consumed As Double = 0.0
    Dim lowCo2 As Boolean = False
    Dim selectedFlavors As List(Of String) = New List(Of String)
    Dim selectedSize As String = ""
    Dim selectedFlavor1 As String = "None"
    Dim selectedFlavor2 As String = "None"
    Dim selectedFlavor3 As String = "None"
    Dim flavorLimit As Integer = 3

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSize = New ComboBox
        cboSize.Items.Add("Small")
        cboSize.Items.Add("Medium")
        cboSize.Items.Add("Large")
        cboSize.SelectedIndex = 0

        If cboSize IsNot Nothing Then
            cboSize.SelectedIndex = 0
        End If
        If cboFlavor1 IsNot Nothing Then
            cboFlavor1.SelectedIndex = 0
        End If
        If cboFlavor2 IsNot Nothing Then
            cboFlavor2.SelectedIndex = 0
        End If
        If cboFlavor3 IsNot Nothing Then
            cboFlavor3.SelectedIndex = 0
        End If

        For Each key As String In syrupLevels.Keys
            If syrupLevels(key) <= 0.3 Then
                Dim result As DialogResult = MessageBox.Show("The syrup level for " & key & " is low. Please order more syrup.", "Low Syrup Level", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Return
                End If
            End If
        Next

        If co2Level <= 1.5 Then
            MessageBox.Show("The CO2 level is low. Please order more CO2.")
            lowCo2 = True
        End If
    End Sub

    Private Sub btnMixDisp_Click(sender As Object, e As EventArgs) Handles btnMixDisp.Click
        If selectedFlavors.Count = 0 Then
            MessageBox.Show("Please select at least one flavor.")
            Return
        End If

        For Each flavor As String In selectedFlavors
            If syrupLevels.ContainsKey(flavor) Then
                If syrupLevels(flavor) < 0.1 Then
                    MessageBox.Show("The flavor '" & flavor & "' is too low to dispense.")
                    Return
                ElseIf syrupLevels(flavor) <= 0.3 Then
                    MessageBox.Show("The syrup level for '" & flavor & "' is low. Please order more syrup.")
                End If
            Else
                MessageBox.Show("The flavor " & flavor & " is not in the syrup levels dictionary. Please correct this.", "Invalid Flavor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next



        Dim selectedSize As String = ""
        If rad8oz.Checked Then
            selectedSize = "8oz"
        ElseIf rad16oz.Checked Then
            selectedSize = "16oz"
        ElseIf rad24oz.Checked Then
            selectedSize = "24oz"
        ElseIf rad32oz.Checked Then
            selectedSize = "32oz"
        End If

        If selectedSize = "" Then
            MessageBox.Show("Please select a size.")
            Return
        End If

        Dim totalSyrupConsumed As Double = 0
        Dim c02Consumed As Double = 0

        Select Case selectedSize
            Case "8oz"
                totalSyrupConsumed = 0.1
                c02Consumed = 0.1 / 2
            Case "16oz"
                totalSyrupConsumed = 0.2
                c02Consumed = 0.2 / 2
            Case "24oz"
                totalSyrupConsumed = 0.3
                c02Consumed = 0.3 / 2
            Case "32oz"
                totalSyrupConsumed = 0.4
                c02Consumed = 0.4 / 2
            Case Else
                ' Handle the case where an invalid size is selected
        End Select

        For Each flavor As String In selectedFlavors
            If syrupLevels.ContainsKey(flavor) Then
                If syrupLevels(flavor) < 0.1 Then
                    MessageBox.Show("The flavor '" & flavor & "' is too low to dispense.")
                    Return
                Else
                    Dim syrupConsumed As Double = totalSyrupConsumed / selectedFlavors.Count
                    syrupLevels(flavor) -= syrupConsumed

                End If
            Else
                MessageBox.Show("The flavor " & flavor & " is not in the syrup levels dictionary. Please correct this.", "Invalid Flavor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        Dim result As DialogResult = MessageBox.Show("Dispense " & selectedSize.ToString & " of " & String.Join(", ", selectedFlavors) & "?", "Confirm Dispense", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Dispensing " & selectedSize.ToString & " of " & String.Join(", ", selectedFlavors) & ".")
            co2Level -= c02Consumed
            If co2Level < 0.1 Then
                MessageBox.Show("CO2 is running low. Please refill the CO2 tank.", "Low CO2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub


    Private Sub picCola_Click(sender As Object, e As EventArgs) Handles picCola.Click
        'Me.Hide() ' Hide the current form
        'ColaSelections.ShowDialog() ' Show the new form as modal

        If selectedFlavors.Contains(ColaSelections.flavor) Then
            selectedFlavors.Remove(ColaSelections.flavor)
            picCola.BackColor = Color.White
        Else
            'selectedFlavors.Add(ColaSelections.flavor)
            selectedFlavors.Add("Coca Cola")

            picCola.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove(ColaSelections.flavor)
            picCola.BackColor = Color.White
            Return
        End If
    End Sub


    Private Sub picDietCola_Click(sender As Object, e As EventArgs) Handles picDietCola.Click


        If selectedFlavors.Contains("Diet Cola") Then
            selectedFlavors.Remove("Diet Cola")
            picDietCola.BackColor = Color.White
        Else
            selectedFlavors.Add("Diet Cola")
            picDietCola.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Diet Cola")
            picDietCola.BackColor = Color.White

            Return
        End If

    End Sub
    Private Sub picColaZero_Click(sender As Object, e As EventArgs) Handles picColaZero.Click

        If selectedFlavors.Contains("Cola Zero") Then
            selectedFlavors.Remove("Cola Zero")
            picColaZero.BackColor = Color.White
        Else
            selectedFlavors.Add("Cola Zero")
            picColaZero.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Cola Zero")
            picColaZero.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub PicFanta_Click(sender As Object, e As EventArgs) Handles PicFanta.Click

        If selectedFlavors.Contains("Fanta") Then
            selectedFlavors.Remove("Fanta")
            PicFanta.BackColor = Color.White
        Else
            selectedFlavors.Add("Fanta")
            PicFanta.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Fanta")
            PicFanta.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picSprite_Click(sender As Object, e As EventArgs) Handles picSprite.Click


        If selectedFlavors.Contains("Sprite") Then
            selectedFlavors.Remove("Sprite")
            picSprite.BackColor = Color.White
        Else
            selectedFlavors.Add("Sprite")
            picSprite.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Sprite")
            picSprite.BackColor = Color.White

            Return
        End If

    End Sub

    Private Sub picSpriteZero_Click(sender As Object, e As EventArgs) Handles picSpriteZero.Click


        If selectedFlavors.Contains("Sprite Zero") Then
            selectedFlavors.Remove("Sprite Zero")
            picSpriteZero.BackColor = Color.White
        Else
            selectedFlavors.Add("Sprite Zero")
            picSpriteZero.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Sprite Zero")
            picSpriteZero.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picPibb_Click(sender As Object, e As EventArgs) Handles picPibb.Click


        If selectedFlavors.Contains("Pibb Xtra") Then
            selectedFlavors.Remove("Pibb Xtra")
            picPibb.BackColor = Color.White
        Else
            selectedFlavors.Add("Pibb Xtra")
            picPibb.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Pibb Xtra")
            picPibb.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picPowerade_Click(sender As Object, e As EventArgs) Handles picPowerade.Click

        If selectedFlavors.Contains("Powerade") Then
            selectedFlavors.Remove("Powerade")
            picPowerade.BackColor = Color.White
        Else
            selectedFlavors.Add("Powerade")
            picPowerade.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Powerade")
            picPowerade.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picRoot_Click(sender As Object, e As EventArgs) Handles picRoot.Click


        If selectedFlavors.Contains("Barq's") Then
                selectedFlavors.Remove("Barq's")
            picRoot.BackColor = Color.White
        Else
            selectedFlavors.Add("Barq's")
            picRoot.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Barq's")
            picRoot.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picPepper_Click(sender As Object, e As EventArgs) Handles picPepper.Click


        If selectedFlavors.Contains("Dr. Pepper") Then
            selectedFlavors.Remove("Dr. Pepper")
            picPepper.BackColor = Color.White
        Else
            selectedFlavors.Add("Dr. Pepper")
            picPepper.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Dr. Pepper")
            picPepper.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picMello_Click(sender As Object, e As EventArgs) Handles picMello.Click

        If selectedFlavors.Contains("Mello Yello") Then
            selectedFlavors.Remove("Mello Yello")
            picMello.BackColor = Color.White
        Else
            selectedFlavors.Add("Mello Yello")
            picMello.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Mello Yello")
            picMello.BackColor = Color.White
            Return
        End If

    End Sub

    Private Sub picMinute_Click(sender As Object, e As EventArgs) Handles picMinute.Click

        If selectedFlavors.Contains("Minute Maid") Then
            selectedFlavors.Remove("Minute Maid")
            picMinute.BackColor = Color.White
        Else
            selectedFlavors.Add("Minute Maid")
            picMinute.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count > flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            selectedFlavors.Remove("Minute Maid")
            picMinute.BackColor = Color.White
            Return
        End If
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnOrderSyrup_Click(sender As Object, e As EventArgs) Handles btnOrderSyrup.Click
        Dim lowSyrups As New List(Of String)
        Dim message As String = ""

        For Each key As String In syrupLevels.Keys
            If syrupLevels(key) <= 0.3 Then
                lowSyrups.Add(key)
                syrupLevels(key) = 10.0
            End If
        Next

        If lowSyrups.Count > 0 Then
            message = "The following syrups have been replenished: " & String.Join(", ", lowSyrups) & vbNewLine
        End If

        If co2Level <= 1.5 Then
            co2Level = 5.0
            message &= "Co2 has been replenished."
        End If

        If message <> "" Then
            MessageBox.Show(message, "Order Syrups")
        End If
    End Sub

    Private Sub btnSyrupLvl_Click(sender As Object, e As EventArgs) Handles btnSyrupLvl.Click
        Dim message As String = "Current syrup levels:" & vbNewLine
        For Each key As String In syrupLevels.Keys
            message &= key & ": " & syrupLevels(key).ToString("0.0") & " liters" & vbNewLine
        Next
        message &= "Co2: " & co2Level.ToString("0.0") & " liters"
        MessageBox.Show(message, "Syrup and Co2 Levels")
    End Sub
End Class