Imports System.Text
Imports System.Windows

Public Class MainForm
    Private selectedFlavors As New List(Of String)
    Private flavorLimit As Integer = 3
    Private syrupBoxSize As Double = 34 ' 1L syrup box size in oz
    Private CO2BoxSize As Double = 170 ' 5L CO2 box size in oz
    Private lowSyrupThreshold As Double = 12 ' 0.3L syrup threshold in oz
    Private lowCO2Threshold As Double = 54 ' 1.5L CO2 threshold in oz
    Private syrupDispensed As New Dictionary(Of String, Double)
    Private CO2Dispensed As Double = 0

    Private Sub btnMixDisp_Click(sender As Object, e As EventArgs) Handles btnMixDisp.Click
        If Not (rad8oz.Checked Or rad16oz.Checked Or rad24oz.Checked Or rad32oz.Checked) Then
            ' No radio button is selected
            MessageBox.Show("Please select a size before dispensing.")
        ElseIf selectedFlavors.Count < 1 Then
            ' No flavor is selected
            MessageBox.Show("Please select at least one flavor before dispensing.")
        ElseIf selectedFlavors.Count > flavorLimit Then
            ' More than three flavors selected
            MessageBox.Show("You can only mix up to three flavors. Please select " & flavorLimit & " or fewer flavors.")
        Else
            Dim oz As Integer
            oz = If(rad8oz.Checked, 8, If(rad16oz.Checked, 16, If(rad24oz.Checked, 24, 32)))
            Dim flavors As String = String.Join(", ", selectedFlavors)
            Dim result As DialogResult = MessageBox.Show("Now dispensing " & oz & " oz of " & flavors & "." & vbCrLf & "Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                ' okay button was clicked
                Dim syrupPerFlavor As Double = oz / (selectedFlavors.Count * 2)
                Dim CO2PerFlavor As Double = oz / (selectedFlavors.Count * 2)
                Dim totalSyrupDispensed As Double = 0
                For Each flavor In selectedFlavors
                    syrupDispensed.TryGetValue(flavor, totalSyrupDispensed)
                    totalSyrupDispensed += syrupPerFlavor
                    syrupDispensed(flavor) = totalSyrupDispensed
                Next
                CO2Dispensed += CO2PerFlavor
                MessageBox.Show("Dispensed " & syrupPerFlavor & " oz of syrup and " & CO2PerFlavor & " oz of CO2 for each flavor.")
                ' Check low thresholds
                If CO2Dispensed < lowCO2Threshold Then
                    MessageBox.Show("CO2 fluid level is low.")
                End If
                For Each flavor In selectedFlavors
                    If syrupDispensed(flavor) < lowSyrupThreshold Then
                        MessageBox.Show(flavor & " syrup level is low.")
                    End If
                Next
            Else
                ' No button was clicked
            End If
        End If
    End Sub
    Private Sub picCola_Click(sender As Object, e As EventArgs) Handles picCola.Click
        Me.Hide() ' Hide the current form
        ColaSelections.ShowDialog() ' Show the new form as modal

        If selectedFlavors.Contains(ColaSelections.flavor) Then
            selectedFlavors.Remove(ColaSelections.flavor)
            picCola.BackColor = Color.White
        Else
            selectedFlavors.Add(ColaSelections.flavor)
            picCola.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            Return
        End If

    End Sub

    Private Sub picPibb_Click(sender As Object, e As EventArgs) Handles picPibb.Click


        If selectedFlavors.Contains("Pibb Extra") Then
            selectedFlavors.Remove("Pibb Extra")
            picPibb.BackColor = Color.White
        Else
            selectedFlavors.Add("Pibb Extra")
            picPibb.BackColor = Color.LimeGreen
        End If
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
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
        If selectedFlavors.Count >= flavorLimit Then
            MessageBox.Show("You have reached the maximum number of flavors.")
            Return
        End If
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnSyrupLvl_Click(sender As Object, e As EventArgs) Handles btnSyrupLvl.Click
        Dim syrupLevels As New StringBuilder()
        For Each flavor In syrupDispensed.Keys
            Dim ozDispensed As Double = syrupDispensed(flavor)
            Dim boxesDispensed As Integer = Math.Floor(ozDispensed / syrupBoxSize)
            Dim ozRemaining As Double = ozDispensed Mod syrupBoxSize
            syrupLevels.AppendLine(flavor & ": " & boxesDispensed & " boxes, " & ozRemaining & " oz remaining")
        Next
        MessageBox.Show(syrupLevels.ToString())
    End Sub

    Private Sub btnOrderSyrup_Click(sender As Object, e As EventArgs) Handles btnOrderSyrup.Click
        Dim orderForm As New OrderSyrup()
        orderForm.ShowDialog()

        If orderForm.DialogResult = DialogResult.OK Then
            ' Update the syrup levels
            For Each flavor In orderForm.OrderedSyrups.Keys
                Dim numBoxes As Integer = orderForm.OrderedSyrups(flavor)
                If syrupDispensed.ContainsKey(flavor) Then
                    syrupDispensed(flavor) += numBoxes * syrupBoxSize
                Else
                    syrupDispensed.Add(flavor, numBoxes * syrupBoxSize)
                End If
            Next

            ' Check the CO2 and syrup levels and display a message box
            Dim lowLevels As New StringBuilder()
            Dim co2Remaining As Double = CO2Dispensed - CO2BoxSize / 2 * syrupDispensed.Count
            If co2Remaining < lowCO2Threshold Then
                lowLevels.AppendLine("CO2 is running low.")
            End If
            For Each flavor In syrupDispensed.Keys
                Dim ozDispensed As Double = syrupDispensed(flavor)
                Dim ozRemaining As Double = ozDispensed Mod syrupBoxSize
                If ozRemaining < lowSyrupThreshold Then
                    lowLevels.AppendLine(flavor & " is running low.")
                End If
            Next
            If lowLevels.Length > 0 Then
                MessageBox.Show("Syrup and CO2 levels are low." & vbCrLf & lowLevels.ToString())
            Else
                MessageBox.Show("Syrup and CO2 levels are normal.")
            End If
        End If
    End Sub
End Class