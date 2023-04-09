Imports System.Data.SQLite
Imports System.Runtime.InteropServices.ComTypes
Imports System.Text

Public Class OrderReportForm

    Private Function ExecuteQuery(query As String) As DataTable
        Dim result As New DataTable
        Dim connectionString As String = "Data Source=ColaMachine.db"
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(query, connection)
                Using dataAdapter As New System.Data.SQLite.SQLiteDataAdapter(command)
                    dataAdapter.Fill(result)
                End Using
            End Using
        End Using

        Return result
    End Function

    Public Sub GenerateOrderReport(startDate As Date, endDate As Date)
        ' Query for the order report data
        Dim query As String = $"SELECT ""Order"".OrderID AS OrderNumber, OrderLine.OrderLineID AS LineNumber, ""Order"".OrderDate, Fluid.FlavorName, Mixture.MixtureName, OrderLine.FluidAmount AS OrderAmount FROM ""Order"" INNER JOIN OrderLine ON ""Order"".OrderID = OrderLine.OrderID INNER JOIN Fluid ON OrderLine.FluidID = Fluid.FluidID INNER JOIN Mixture ON OrderLine.MixtureID = Mixture.MixtureID WHERE ""Order"".OrderDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' ORDER BY ""Order"".OrderID, OrderLine.OrderLineID"

        Dim dataTable As DataTable = ExecuteQuery(query)
        Dim report As New StringBuilder()

        ' Add the additional information to the report
        Dim mostRequestedFlavor As DataRow
        Dim mostRequestedMixture As DataRow
        Dim leastRequestedFlavor As DataRow
        Dim mostCommonSize As DataRow

        ' Define the missing queries
        Dim mostRequestedFlavorQuery As String = $"SELECT Fluid.FlavorName, COUNT(OrderLine.FluidID) AS FlavorCount FROM Fluid INNER JOIN OrderLine ON Fluid.FluidID = OrderLine.FluidID INNER JOIN ""Order"" ON OrderLine.OrderID = ""Order"".OrderID WHERE ""Order"".OrderDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY Fluid.FlavorName ORDER BY COUNT(OrderLine.FluidID) DESC LIMIT 1"
        Dim mostRequestedMixtureQuery As String = $"SELECT Mixture.MixtureName, COUNT(OrderLine.MixtureID) AS MixtureCount FROM Mixture INNER JOIN OrderLine ON Mixture.MixtureID = OrderLine.MixtureID INNER JOIN ""Order"" ON OrderLine.OrderID = ""Order"".OrderID WHERE ""Order"".OrderDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY Mixture.MixtureName ORDER BY COUNT(OrderLine.MixtureID) DESC LIMIT 1"
        Dim leastRequestedFlavorQuery As String = $"SELECT Fluid.FlavorName, COUNT(OrderLine.FluidID) AS FlavorCount FROM Fluid INNER JOIN OrderLine ON Fluid.FluidID = OrderLine.FluidID INNER JOIN ""Order"" ON OrderLine.OrderID = ""Order"".OrderID WHERE ""Order"".OrderDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY Fluid.FlavorName ORDER BY COUNT(OrderLine.FluidID) ASC LIMIT 1"
        Dim mostCommonSizeQuery As String = $"SELECT CASE WHEN OrderLine.FluidAmount BETWEEN 0.23659 * 0.95 AND 0.23659 * 1.05 THEN 8 WHEN OrderLine.FluidAmount BETWEEN 0.47318 * 0.95 AND 0.47318 * 1.05 THEN 16 WHEN OrderLine.FluidAmount BETWEEN 0.70977 * 0.95 AND 0.70977 * 1.05 THEN 24 WHEN OrderLine.FluidAmount BETWEEN 0.94636 * 0.95 AND 0.94636 * 1.05 THEN 32 END AS Size, COUNT(*) AS SizeCount FROM OrderLine INNER JOIN ""Order"" ON OrderLine.OrderID = ""Order"".OrderID WHERE OrderLine.OrderDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY CASE WHEN OrderLine.FluidAmount BETWEEN 0.23659 * 0.95 AND 0.23659 * 1.05 THEN 8 WHEN OrderLine.FluidAmount BETWEEN 0.47318 * 0.95 AND 0.47318 * 1.05 THEN 16 WHEN OrderLine.FluidAmount BETWEEN 0.70977 * 0.95 AND 0.70977 * 1.05 THEN 24 WHEN OrderLine.FluidAmount BETWEEN 0.94636 * 0.95 AND 0.94636 * 1.05 THEN 32 END ORDER BY COUNT(*) DESC LIMIT 1"













        Dim mostRequestedFlavorResult As DataTable = ExecuteQuery(mostRequestedFlavorQuery)
        If mostRequestedFlavorResult.Rows.Count > 0 Then
            mostRequestedFlavor = mostRequestedFlavorResult.Rows(0)
            report.AppendLine($"Most Requested Flavor: {mostRequestedFlavor("FlavorName")} ({mostRequestedFlavor("FlavorCount")} times)")
        End If

        Dim mostRequestedMixtureResult As DataTable = ExecuteQuery(mostRequestedMixtureQuery)
        If mostRequestedMixtureResult.Rows.Count > 0 Then
            mostRequestedMixture = mostRequestedMixtureResult.Rows(0)
            report.AppendLine($"Most Requested Mixture: {mostRequestedMixture("MixtureName")} ({mostRequestedMixture("MixtureCount")} times)")
        End If

        Dim leastRequestedFlavorResult As DataTable = ExecuteQuery(leastRequestedFlavorQuery)
        If leastRequestedFlavorResult.Rows.Count > 0 Then
            leastRequestedFlavor = leastRequestedFlavorResult.Rows(0)
            report.AppendLine($"Least Requested Flavor: {leastRequestedFlavor("FlavorName")} ({leastRequestedFlavor("FlavorCount")} times)")
        End If

        Dim mostCommonSizeResult As DataTable = ExecuteQuery(mostCommonSizeQuery)
        If mostCommonSizeResult.Rows.Count > 0 Then
            mostCommonSize = mostCommonSizeResult.Rows(0)
            report.AppendLine($"Most Common Size Dispensed: {mostCommonSize("Size")}oz ({mostCommonSize("SizeCount")})")

        End If


        txtOrderReport.Text = report.ToString()

    End Sub




    Private Sub btnOrderReportOkay_Click(sender As Object, e As EventArgs) Handles btnOrderReportOkay.Click
        Me.Close()
    End Sub

    Private Sub OrderReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim startDate As Date = dtpStartDate.Value
        Dim endDate As Date = dtpEndDate.Value

        GenerateOrderReport(startDate, endDate)
    End Sub


End Class