Public Class ColaSelections

    Public flavor As String
    Private Sub picCola2_Click(sender As Object, e As EventArgs) Handles picCola2.Click
        ClickHandler("Coco Cola")
    End Sub

    Private Sub picColaCreme_Click(sender As Object, e As EventArgs) Handles picColaCreme.Click
        ClickHandler("Coca Cola Creme")
    End Sub

    Private Sub picColaCherry_Click(sender As Object, e As EventArgs) Handles picColaCherry.Click
        ClickHandler("Coca Cola Cherry")
    End Sub

    Private Sub picColaCherryVanilla_Click(sender As Object, e As EventArgs) Handles picColaCherryVanilla.Click
        ClickHandler("Coca Cola Cherry Vanilla")
    End Sub

    Private Sub picColaLemon_Click(sender As Object, e As EventArgs) Handles picColaLemon.Click
        ClickHandler("Coca Cola Lemon")
    End Sub

    Private Sub picColaLime_Click(sender As Object, e As EventArgs) Handles picColaLime.Click
        ClickHandler("Coca Cola Lime")
    End Sub

    Private Sub picColaOrange_Click(sender As Object, e As EventArgs) Handles picColaOrange.Click
        ClickHandler("Coca Cola Orange")
    End Sub

    Private Sub picColaRaspberry_Click(sender As Object, e As EventArgs) Handles picColaRaspberry.Click
        ClickHandler("Coca Cola Raspberry")
    End Sub

    Private Sub picColaVanilla_Click(sender As Object, e As EventArgs) Handles picColaVanilla.Click
        ClickHandler("Coca Cola Vanilla")
    End Sub

    Private Sub picColaOrangeVanilla_Click(sender As Object, e As EventArgs) Handles picColaOrangeVanilla.Click
        ClickHandler("Coca Cola Orange Vanilla")
    End Sub

    Private Sub ClickHandler(flavor As String)
        Me.flavor = flavor
        MainForm.Show()
        MainForm.Enabled = True
        Me.Close()
    End Sub
End Class
