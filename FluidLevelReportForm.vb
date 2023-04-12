Imports System.Data.SQLite
Imports System.Text

Public Class FluidLevelReportForm

    Private Function ExecuteQuery(query As String) As DataTable
        Dim connectionString As String = "Data Source=ColaMachine.db"
        Dim result As New DataTable()

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using

        Return result
    End Function

    Public Sub GenerateFluidLevelReport()
        Dim report As New StringBuilder()
        report.AppendLine("Fluid Level Report")
        report.AppendLine()
        report.AppendLine("Syrup levels:")

        Dim getFluidLevelsQuery As String = "SELECT FlavorName, CurrAmount FROM Fluid"
        Dim fluidLevels As DataTable = ExecuteQuery(getFluidLevelsQuery)

        For Each row As DataRow In fluidLevels.Rows
            Dim FlavorName As String = row("FlavorName").ToString()
            Dim CurrAmount As Double = CDbl(row("CurrAmount"))

            ' Use the ToString method with the "F2" format string to display the value with 2 decimal places
            report.AppendLine($"{FlavorName}: {CurrAmount.ToString("0.00")} liters (low threshold: 0.3 liters)")

<<<<<<< Updated upstream





=======
>>>>>>> Stashed changes
        Next

        txtFluidLevelReport.Text = report.ToString()
    End Sub


    Private Sub FluidLevelReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateFluidLevelReport()
    End Sub

    Private Sub btnFluidLevelOk_Click(sender As Object, e As EventArgs) Handles btnFluidLevelOk.Click
        Me.Close()
    End Sub
End Class
