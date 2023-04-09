Imports System.Security.Policy
Imports System.Text
Imports System.Windows
Imports System.Data.SQLite
Imports System.Collections.ObjectModel
Imports System.Data.Common

Public Class LocalReport


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


    Private Function GetClosestSize(fluidAmountInLiters As Double) As Double
        Dim fluidAmountInOunces As Double = fluidAmountInLiters * 33.814
        Dim sizes As New List(Of Double)({8.0, 16.0, 24.0, 32.0})

        Dim closestSize As Double = sizes(0)
        Dim closestSizeDifference As Double = Math.Abs(fluidAmountInOunces - closestSize)

        For Each size As Double In sizes
            Dim currentDifference As Double = Math.Abs(fluidAmountInOunces - size)
            If currentDifference < closestSizeDifference Then
                closestSize = size
                closestSizeDifference = currentDifference
            End If
        Next

        Return closestSize
    End Function




    Private Sub GenerateLocationManagementReport()


        ' Retrieve the required data from the database
        Dim totalRevenueQuery As String = "SELECT SUM(OrderAmount) FROM [Order]"
        Dim totalCountQuery As String = "SELECT COUNT(*) FROM [Order]"
        Dim avgOrderSizeQuery As String = "SELECT FluidAmount FROM [Order] WHERE FluidAmount IS NOT NULL"


        Dim averageOrderRevenueQuery As String = "SELECT AVG(OrderAmount) FROM [Order]"
        Dim mostRequestedFlavorQuery As String = "SELECT FlavorName, COUNT(*) as Count FROM [Order] INNER JOIN Fluid ON [Order].FluidID = Fluid.FluidID GROUP BY FlavorName ORDER BY Count DESC LIMIT 1"
        Dim leastRequestedFlavorQuery As String = "SELECT FlavorName, COUNT(*) as Count FROM [Order] INNER JOIN Fluid ON [Order].FluidID = Fluid.FluidID GROUP BY FlavorName ORDER BY Count ASC LIMIT 1"


        Dim totalRevenue As Double = CDbl(ExecuteQuery(totalRevenueQuery).Rows(0)(0))
        Dim totalCount As Integer = CInt(ExecuteQuery(totalCountQuery).Rows(0)(0))

        Dim avgOrderRevenue As Double = CDbl(ExecuteQuery(averageOrderRevenueQuery).Rows(0)(0))

        Dim mostRequestedFlavorResult As DataTable = ExecuteQuery(mostRequestedFlavorQuery)
        Dim mostRequestedFlavor As String = mostRequestedFlavorResult.Rows(0)("FlavorName").ToString()

        Dim leastRequestedFlavorResult As DataTable = ExecuteQuery(leastRequestedFlavorQuery)
        Dim leastRequestedFlavor As String = leastRequestedFlavorResult.Rows(0)("FlavorName").ToString()

        Dim fluidAmounts As DataTable = ExecuteQuery(avgOrderSizeQuery)
        Dim totalSizes As Double = 0
        Dim orderCount As Integer = fluidAmounts.Rows.Count

        For Each row As DataRow In fluidAmounts.Rows
            Dim fluidAmountInLiters As Double = CDbl(row(0))
            totalSizes += GetClosestSize(fluidAmountInLiters)
        Next

        Dim avgOrderSize As Double = totalSizes / orderCount

        ' Format and display the report (e.g., in a multiline TextBox or a RichTextBox)
        Dim report As New StringBuilder()
        report.AppendLine("Location Management Report")
        report.AppendLine("Location: Grand Rapids Community College")
        report.AppendLine("Date/Time: " & DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"))
        report.AppendLine()
        report.AppendLine("Total revenue: $" & totalRevenue.ToString("N2"))
        report.AppendLine("Total number of orders: " & totalCount)
        report.AppendLine("Average Orders size: " & avgOrderSize.ToString("N2") & " oz")
        report.AppendLine("Average Orders revenue: $" & avgOrderRevenue.ToString("N2"))
        report.AppendLine("Most requested flavor: " & mostRequestedFlavor)
        report.AppendLine("Least requested flavor: " & leastRequestedFlavor)
        ' Add code to display the most requested mixture

        ' Display the report (change 'txtReport' to the name of your TextBox or RichTextBox control)
        txtReport.Text = report.ToString()

    End Sub


    Private Sub LocationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateLocationManagementReport()
    End Sub

    Private Sub btnLocalOk_Click(sender As Object, e As EventArgs) Handles btnLocalOk.Click
        Me.Close()
    End Sub

End Class