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
        Dim query As String = $"SELECT ""Order"".OrderID AS OrderNumber, ""Order"".OrderDate, GROUP_CONCAT(Fluid.FlavorName, ', ') AS FlavorNames, GROUP_CONCAT(OrderLine.FluidAmount, ', ') AS FluidAmounts, SUM(OrderLine.FluidAmount * Fluid.Cost) AS TotalPrice
                       FROM ""Order""
                       INNER JOIN OrderLine ON ""Order"".OrderID = OrderLine.OrderID
                       INNER JOIN Fluid ON OrderLine.FluidID = Fluid.FluidID
                       WHERE ""Order"".OrderDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
                       GROUP BY ""Order"".OrderID, ""Order"".OrderDate
                       ORDER BY ""Order"".OrderID"



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




        Dim totalSales As Double = 0

        For Each row As DataRow In dataTable.Rows
            Dim orderDate As Date = CType(row("OrderDate"), Date)
            Dim orderNumber As Integer = CInt(row("OrderNumber"))
            Dim flavorNames As String = row("FlavorNames").ToString()
            Dim fluidAmounts As String = row("FluidAmounts").ToString()
            Dim totalPrice As Double = CDbl(row("TotalPrice"))

            report.AppendLine($"Date of Purchase: {orderDate:MM/dd/yyyy}")
            report.AppendLine($"Order #: {orderNumber}")
            report.AppendLine($"Syrup(s) Ordered: {flavorNames}")
            report.AppendLine($"Size(s) Dispensed: {fluidAmounts}")
            report.AppendLine($"Price: ${totalPrice:0.00}")
            report.AppendLine()

            totalSales += totalPrice
        Next

        report.AppendLine($"Total Sales: ${totalSales:0.00}")



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