Public Class OrderSyrup
    Private syrupOrders As New Dictionary(Of String, Integer)

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        ' Get the number of boxes to order for each syrup flavor and add them to the syrupOrders dictionary
        If Not String.IsNullOrEmpty(txtCola.Text) Then
            syrupOrders.Add("Cola", Integer.Parse(txtCola.Text))
        End If

        If Not String.IsNullOrEmpty(txtDietCola.Text) Then
            syrupOrders.Add("Diet Cola", Integer.Parse(txtDietCola.Text))
        End If
        If Not String.IsNullOrEmpty(txtColaZero.Text) Then
            syrupOrders.Add("Cola Zero", Integer.Parse(txtColaZero.Text))
        End If
        If Not String.IsNullOrEmpty(txtRoot.Text) Then
            syrupOrders.Add("Root Beer", Integer.Parse(txtRoot.Text))
        End If
        If Not String.IsNullOrEmpty(txtSprite.Text) Then
            syrupOrders.Add("Sprite", Integer.Parse(txtSprite.Text))
        End If
        If Not String.IsNullOrEmpty(txtSpriteZero.Text) Then
            syrupOrders.Add("Sprite Zero", Integer.Parse(txtSpriteZero.Text))
        End If
        If Not String.IsNullOrEmpty(txtPibb.Text) Then
            syrupOrders.Add("Pibb Xtra", Integer.Parse(txtPibb.Text))
        End If
        If Not String.IsNullOrEmpty(txtPowerade.Text) Then
            syrupOrders.Add("Powerade", Integer.Parse(txtPowerade.Text))
        End If
        If Not String.IsNullOrEmpty(txtFanta.Text) Then
            syrupOrders.Add("Fanta", Integer.Parse(txtFanta.Text))
        End If
        If Not String.IsNullOrEmpty(txtMinute.Text) Then
            syrupOrders.Add("Minute Maid", Integer.Parse(txtMinute.Text))
        End If
        If Not String.IsNullOrEmpty(txtPepper.Text) Then
            syrupOrders.Add("Dr. Pepper", Integer.Parse(txtPepper.Text))
        End If
        If Not String.IsNullOrEmpty(txtYello.Text) Then
            syrupOrders.Add("Mello Yello", Integer.Parse(txtYello.Text))
        End If


        ' Repeat for other flavors...

        ' Close the form and return the result
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Public ReadOnly Property OrderedSyrups As Dictionary(Of String, Integer)
        Get
            Return syrupOrders
        End Get
    End Property
End Class
