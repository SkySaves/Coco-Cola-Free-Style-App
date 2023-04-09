Imports System.Security.Policy
Imports System.Text
Imports System.Windows
Imports System.Data.SQLite
Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports Microsoft.Data.Sqlite



Public Class MainForm

    Dim connString As String = "Data Source=ColaMachine.db;Version=3;"
    Dim connection As New SqliteConnection(connString)

    Dim co2Level As Double
    Dim cboSize As ComboBox = Me.Controls("cboSize")
    Dim cboFlavor1 As ComboBox = Me.Controls("cboFlavor1")
    Dim cboFlavor2 As ComboBox = Me.Controls("cboFlavor2")
    Dim cboFlavor3 As ComboBox = Me.Controls("cboFlavor3")
    Dim totalSyrupConsumed As Double = 0.0
    Dim c02Consumed As Double = 0.0
    Dim lowCo2 As Boolean = False
    Dim selectedFlavors As List(Of String) = New List(Of String)
    Dim selectedSize As String = ""
    Dim selectedFlavor1 As String = "None"
    Dim selectedFlavor2 As String = "None"
    Dim selectedFlavor3 As String = "None"
    Dim flavorLimit As Integer = 3
    Private fluidLevels As New Dictionary(Of String, Tuple(Of Integer, Double))()





    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open() 'Open the connection to the database

        ' Retrieve the current fluid levels from the Fluid table
        Dim fluidQuery As String = "SELECT FluidID, FlavorName, CurrAmount FROM Fluid"
        ' Define the query to retrieve the current fluid levels for the flavors and CO2
        Using fluidCmd As New SQLiteCommand(fluidQuery, connection)
            ' Create a new SQLiteCommand object using the query and the connection
            Using fluidReader As SQLiteDataReader = fluidCmd.ExecuteReader()
                ' Use the SQLiteDataReader object to execute the query and retrieve the results
                While fluidReader.Read() ' Loop through each record in the result set
                    Dim fluidID As Integer = fluidReader.GetInt32(0) ' Get the FluidID from the first column
                    Dim flavorName As String = fluidReader.GetString(1) ' Get the name of the flavor from the second column
                    Dim currAmount As Double = fluidReader.GetDouble(2) ' Get the current amount of fluid for the flavor from the third column
                    fluidLevels(flavorName) = Tuple.Create(fluidID, currAmount) ' Add the flavor and its current amount of fluid to the dictionary
                End While
            End Using
        End Using

        ' Retrieve the current CO2 level from the Fluid table
        Dim co2Query As String = "SELECT CurrAmount FROM Fluid WHERE FlavorName = 'CO2'"

        ' Define the query to retrieve the current CO2 level
        Using co2Cmd As New SQLiteCommand(co2Query, connection)
            ' Create a new SQLiteCommand object using the query and the connection
            co2Level = co2Cmd.ExecuteScalar() ' Execute the query and get the result (current CO2 level)
        End Using
    End Sub







    Private Sub btnMixDisp_Click(sender As Object, e As EventArgs) Handles btnMixDisp.Click

        Dim flavorAmountsToUpdate As New Dictionary(Of String, Double)()
        If selectedFlavors.Count = 0 Then
            MessageBox.Show("Please select at least one flavor.")
            Return
        End If

        ' Database connection string
        Dim connectionString As String = "Data Source=ColaMachine.db"

        ' Read fluid levels and IDs from the database
        Dim fluidLevels As New Dictionary(Of String, Tuple(Of Integer, Double))()
        Dim nextOrderID As Integer
        Dim co2Level As Double
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim orderIDQuery As String = "SELECT MAX(OrderID) FROM [Order]"
            Using orderIDCmd As New SQLiteCommand(orderIDQuery, connection)
                Dim orderIDResult = orderIDCmd.ExecuteScalar()
                nextOrderID = If(orderIDResult IsNot DBNull.Value, Convert.ToInt32(orderIDResult) + 1, 1)
            End Using

            Using command As New SQLiteCommand("SELECT FluidID, FlavorName, CurrAmount FROM Fluid", connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim flavorName As String = reader.GetString(1)
                        If flavorName = "CO2" Then
                            co2Level = reader.GetDouble(2)
                        Else
                            Dim fluidID As Integer = reader.GetInt32(0)
                            Dim currAmount As Double = reader.GetDouble(2)
                            fluidLevels.Add(flavorName, Tuple.Create(fluidID, currAmount))
                        End If
                    End While
                End Using
            End Using
        End Using

        For Each flavor As String In selectedFlavors
            If fluidLevels.ContainsKey(flavor) Then
                Dim currAmount As Double = fluidLevels(flavor).Item2
                If currAmount < 0.1 Then
                    MessageBox.Show("The flavor '" & flavor & "' is too low to dispense.")
                    Return
                ElseIf currAmount <= 0.3 Then
                    MessageBox.Show("The syrup level for '" & flavor & "' is low. Please order more syrup.")
                End If
            Else
                MessageBox.Show("The flavor " & flavor & " is not in the fluid levels dictionary. Please correct this.", "Invalid Flavor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

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

        ' Calculate the total syrup consumed based on the selected size
        Dim syrupConsumedInOz As Double
        Select Case selectedSize
            Case "8oz"
                syrupConsumedInOz = 4 ' Half of 8oz in syrup
            Case "16oz"
                syrupConsumedInOz = 8 ' Half of 16oz in syrup
            Case "24oz"
                syrupConsumedInOz = 12 ' Half of 24oz in syrup
            Case "32oz"
                syrupConsumedInOz = 16 ' Half of 32oz in syrup
        End Select

        ' Convert syrup consumed in ounces to liters
        Dim syrupConsumed As Double = syrupConsumedInOz * 0.0295735 ' Convert syrup consumed in ounces to liters

        Dim c02Consumed As Double = syrupConsumed * 0.0295735 ' CO2 consumed is equal


        ' Check if there's enough CO2 available
        If co2Level - c02Consumed < 0 Then
            MessageBox.Show("There's not enough CO2 to complete the order.", "Insufficient CO2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each flavor As String In selectedFlavors
            If fluidLevels.ContainsKey(flavor) Then
                Dim currAmount As Double = fluidLevels(flavor).Item2
                ' Check if there's enough syrup available for this flavor
                If currAmount - syrupConsumed < 0 Then
                    MessageBox.Show("There's not enough of the flavor '" & flavor & "' to complete the order.", "Insufficient Syrup", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                ElseIf currAmount < 0.1 Then
                    MessageBox.Show("The flavor '" & flavor & "' is too low to dispense.")
                    Return
                ElseIf currAmount <= 0.3 Then
                    MessageBox.Show("The syrup level for '" & flavor & "' is low. Please order more syrup.")
                End If
            Else
                MessageBox.Show("The flavor " & flavor & " is not in the fluid levels dictionary. Please correct this.", "Invalid Flavor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ' Insert a new order in the Order table
        Dim orderDesc As String = String.Join(", ", selectedFlavors)
        Dim orderAmount As Double = 0 ' Initialize order amount to 0

        ' Calculate the total order amount based on the selected size
        Select Case selectedSize
            Case "8oz"
                orderAmount = 1.5
            Case "16oz"
                orderAmount = 2.5
            Case "24oz"
                orderAmount = 3.5
            Case "32oz"
                orderAmount = 4.5
        End Select

        Dim result As DialogResult = MessageBox.Show("Dispense " & selectedSize.ToString & " of " & String.Join(", ", selectedFlavors) & "?", "Confirm Dispense", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Update the fluid levels in the database and create a new order
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Begin a transaction
                Using transaction As SQLiteTransaction = connection.BeginTransaction()
                    Try
                        ' Insert a new order in the Order table
                        For Each flavor As String In selectedFlavors
                            Using insertOrderCommand As New SQLiteCommand("INSERT INTO [Order] (OrderDesc, OrderAmount, FluidID, FluidAmount, OrderDate) VALUES (@OrderDesc, @OrderAmount, @FluidID, @FluidAmount, @OrderDate)", connection, transaction)
                                insertOrderCommand.Parameters.AddWithValue("@OrderDesc", orderDesc)
                                insertOrderCommand.Parameters.AddWithValue("@OrderAmount", orderAmount)
                                insertOrderCommand.Parameters.AddWithValue("@FluidID", fluidLevels(flavor).Item1) ' Update FluidID with the current fluid ID
                                insertOrderCommand.Parameters.AddWithValue("@FluidAmount", syrupConsumed) ' Update FluidAmount with syrup consumed in ounces
                                insertOrderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("yyyy-MM-dd")) ' Add the OrderDate parameter
                                insertOrderCommand.ExecuteNonQuery()

                                ' Get the ID of the newly inserted order
                                nextOrderID = connection.LastInsertRowId
                            End Using
                        Next


                        For Each flavor As String In selectedFlavors
                            If fluidLevels.ContainsKey(flavor) Then
                                Dim fluidID As Integer = fluidLevels(flavor).Item1
                                Dim currAmount As Double = fluidLevels(flavor).Item2 - syrupConsumed

                                ' Update fluid levels in the Fluid table
                                Using updateCommand As New SQLiteCommand("UPDATE Fluid SET CurrAmount = @CurrAmount WHERE FluidID = @FluidID", connection, transaction)
                                    updateCommand.Parameters.AddWithValue("@CurrAmount", currAmount)
                                    updateCommand.Parameters.AddWithValue("@FluidID", fluidID)
                                    updateCommand.ExecuteNonQuery()
                                End Using

                                ' Insert a new order line for each flavor in the mix
                                Using insertOrderLineCommand As New SQLiteCommand("INSERT INTO OrderLine (OrderID, FluidID, FluidAmount, OrderDate) VALUES (@OrderID, @FluidID, @FluidAmount, @OrderDate)", connection, transaction)
                                    insertOrderLineCommand.Parameters.AddWithValue("@OrderID", nextOrderID)
                                    insertOrderLineCommand.Parameters.AddWithValue("@FluidID", fluidID)
                                    insertOrderLineCommand.Parameters.AddWithValue("@FluidAmount", syrupConsumed) ' Update FluidAmount with syrup consumed in ounces
                                    insertOrderLineCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("yyyy-MM-dd")) ' Add the OrderDate parameter
                                    insertOrderLineCommand.ExecuteNonQuery()
                                End Using
                            End If
                        Next
                        If co2Level < 0.3 Then
                            MessageBox.Show("CO2 is running low. Please refill the CO2 tank.", "Low CO2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        ' Update CO2 level after committing the transaction
                        co2Level -= c02Consumed
                        Using updateCommand As New SQLiteCommand("UPDATE Fluid SET CurrAmount = @CurrAmount WHERE FlavorName = 'CO2'", connection, transaction)
                            updateCommand.Parameters.AddWithValue("@CurrAmount", co2Level)
                            updateCommand.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction
                        transaction.Commit()



                        If co2Level < 0.1 Then
                            MessageBox.Show("CO2 is running low. Please refill the CO2 tank.", "Low CO2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        ' Insert a new mixture and corresponding mixture components for each flavor in the mix
                        Using insertMixtureCommand As New SQLiteCommand("INSERT INTO Mixture (MixtureName, Description) VALUES (@MixtureName, @Description)", connection)
                            insertMixtureCommand.Parameters.AddWithValue("@MixtureName", orderDesc)
                            insertMixtureCommand.Parameters.AddWithValue("@Description", "Mixture for order #" & nextOrderID.ToString())
                            insertMixtureCommand.ExecuteNonQuery()

                            ' Get the ID of the newly inserted mixture
                            Dim newMixtureID As Integer = connection.LastInsertRowId

                            For Each flavor As String In selectedFlavors
                                If fluidLevels.ContainsKey(flavor) Then
                                    Dim fluidID As Integer = fluidLevels(flavor).Item1
                                    Dim proportion As Double = 1.0 / selectedFlavors.Count ' Assuming equal proportion for each flavor in the mix

                                    ' Insert a new MixtureComponent entry for each flavor in the mix
                                    Using insertMixtureComponentCommand As New SQLiteCommand("INSERT INTO MixtureComponent (MixtureID, FluidID, Proportion) VALUES (@MixtureID, @FluidID, @Proportion)", connection)
                                        insertMixtureComponentCommand.Parameters.AddWithValue("@MixtureID", newMixtureID)
                                        insertMixtureComponentCommand.Parameters.AddWithValue("@FluidID", fluidID)
                                        insertMixtureComponentCommand.Parameters.AddWithValue("@Proportion", proportion)
                                        insertMixtureComponentCommand.ExecuteNonQuery()
                                    End Using
                                End If
                            Next
                        End Using
                    Catch ex As Exception
                        ' Rollback the transaction if any error occurs
                        transaction.Rollback()
                        MessageBox.Show("An error occurred while updating the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End Try
                End Using
            End Using



            For Each flavor As String In selectedFlavors
                If fluidLevels.ContainsKey(flavor) Then
                    Dim currAmount As Double = fluidLevels(flavor).Item2
                    Dim newAmount As Double = currAmount - syrupConsumed
                    fluidLevels(flavor) = Tuple.Create(fluidLevels(flavor).Item1, newAmount)
                    flavorAmountsToUpdate.Add(flavor, newAmount)
                End If
            Next

            MessageBox.Show("Dispensing " & selectedSize.ToString & " of " & String.Join(", ", selectedFlavors) & ".")

            ' Update the fluid levels in the Fluid table
            For Each flavorAmountToUpdate As KeyValuePair(Of String, Double) In flavorAmountsToUpdate
                Dim flavor As String = flavorAmountToUpdate.Key
                Dim newAmount As Double = flavorAmountToUpdate.Value
                Dim updateQuery As String = $"UPDATE Fluid SET CurrAmount = @CurrAmount WHERE FlavorName = @FlavorName"

                Using updateCommand As New SQLiteCommand(updateQuery, connection)
                    updateCommand.Parameters.AddWithValue("@CurrAmount", newAmount)
                    updateCommand.Parameters.AddWithValue("@FlavorName", flavor)
                    updateCommand.ExecuteNonQuery()
                End Using
            Next
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

    ' Syrup Level Report Button Click
    Private Sub btnSyrupLvl_Click(sender As Object, e As EventArgs) Handles btnSyrupLvl.Click
        Dim fluidLevelReportForm As New FluidLevelReportForm()
        fluidLevelReportForm.ShowDialog()
    End Sub


    ' Order Syrups Button Click
    Private Sub btnOrderSyrup_Click(sender As Object, e As EventArgs) Handles btnOrderSyrup.Click
        Dim connectionString As String = "Data Source=ColaMachine.db"
        Dim lowSyrups As New List(Of String)
        Dim message As String = ""

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Get low syrups from Fluid table
            Dim getLowSyrupsQuery As String = "SELECT FlavorName, FluidID FROM Fluid WHERE CurrAmount / Capacity <= 0.3"
            Using command As New SQLiteCommand(getLowSyrupsQuery, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        lowSyrups.Add(reader("FlavorName").ToString())
                        Dim fluidID As Integer = Convert.ToInt32(reader("FluidID"))

                        ' Update the syrup level and maintenance date in the Fluid table
                        Dim updateSyrupLevelQuery As String = $"UPDATE Fluid SET CurrAmount = Capacity, MaintDt = datetime('now') WHERE FluidID = {fluidID}"
                        Using updateCommand As New SQLiteCommand(updateSyrupLevelQuery, connection)
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End While
                End Using
            End Using

            If lowSyrups.Count > 0 Then
                message = "The following syrups have been replenished: " & String.Join(", ", lowSyrups) & vbNewLine
            End If

            ' Replace this condition with the actual CO2 level check in your application
            If co2Level <= 1.5 Then
                co2Level = 5.0
                ' Update the CO2 level and maintenance date in the Fluid table for the CO2 entry
                Dim updateCO2LevelQuery As String = "UPDATE Fluid SET CurrAmount = 5.0, MaintDt = datetime('now') WHERE FluidName = 'CO2'"
                Using updateCommand As New SQLiteCommand(updateCO2LevelQuery, connection)
                    updateCommand.ExecuteNonQuery()
                End Using

                message &= "Co2 has been replenished."
            End If

            If message <> "" Then
                MessageBox.Show(message, "Order Syrups")
            End If
        End Using
    End Sub







    Private Sub btnLocalReport_Click(sender As Object, e As EventArgs) Handles btnLocalReport.Click
        Dim localReportForm As New LocalReport()
        localReportForm.ShowDialog()
    End Sub

    Private Sub btnMaintenanceReport_Click(sender As Object, e As EventArgs) Handles btnMaintenanceReport.Click
        Dim maintenanceReportForm As New MaintenanceReportForm()
        maintenanceReportForm.ShowDialog()
    End Sub

    Private Sub btnOrderReport_Click(sender As Object, e As EventArgs) Handles btnOrderReport.Click
        Dim orderReportForm As New OrderReportForm()
        orderReportForm.ShowDialog()
    End Sub

End Class