Imports System.Data.SQLite
Imports System.Text
Imports Microsoft.Data.Sqlite

Public Class MaintenanceReportForm

    Private Function ExecuteQuery(query As String) As DataTable
        Dim result As New DataTable
        Dim connectionString As String = "Data Source=ColaMachine.db"
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(query, connection)
                Using dataAdapter As New SQLiteDataAdapter(command)
                    dataAdapter.Fill(result)
                End Using
            End Using
        End Using

        Return result
    End Function

    Public Sub GenerateMaintenanceReport()
        Dim query As String = "SELECT Fluid.FlavorName, Fluid.ExpDate, Fluid.MaintDt, Fluid.Capacity, Fluid.CurrAmount, 
                              CASE 
                                  WHEN Fluid.FlavorName = 'CO2' THEN 
                                      (SELECT SUM(OrderLine.FluidAmount) * 0.0295735 FROM OrderLine)
                                  ELSE 
                                      SUM(OrderLine.FluidAmount)
                              END AS TotalUsed
                       FROM Fluid
                       LEFT JOIN OrderLine ON Fluid.FluidID = OrderLine.FluidID
                       GROUP BY Fluid.FlavorName, Fluid.ExpDate, Fluid.MaintDt, Fluid.Capacity, Fluid.CurrAmount"


        Dim dataTable As DataTable = ExecuteQuery(query)
        Dim report As New StringBuilder()

        report.AppendLine("Maintenance Report")
        report.AppendLine()

        For Each row As DataRow In dataTable.Rows
            Dim fluidName As String = row("FlavorName").ToString()
            Dim expiryDate As String = CType(row("ExpDate"), Date).ToShortDateString()
            Dim lastFillDate As String = CType(row("MaintDt"), Date).ToShortDateString()
            Dim capacity As Double = CDbl(row("Capacity"))
            Dim currentLevel As Double = CDbl(row("CurrAmount"))
            Dim totalUsed As Double

            If Not IsDBNull(row("TotalUsed")) Then
                totalUsed = CDbl(row("TotalUsed"))
            Else
                totalUsed = 0.0
            End If

            report.AppendLine($"Fluid: {fluidName}")
            report.AppendLine($"Expiry Date: {expiryDate}")
            report.AppendLine($"Last Fill Date: {lastFillDate}")
            report.AppendLine($"Capacity: {capacity.ToString("0.0")} liters")
            report.AppendLine($"Current Level: {currentLevel.ToString("0.0")} liters")
            report.AppendLine($"Total Used: {totalUsed.ToString("0.0")} liters")
            report.AppendLine()
        Next


        txtMaintenanceReport.Text = report.ToString()
    End Sub

    Private Sub btnMaintOkay_Click(sender As Object, e As EventArgs) Handles btnMaintOkay.Click
        Me.Close()
    End Sub

    Private Sub MaintenanceReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateMaintenanceReport()
    End Sub

End Class
