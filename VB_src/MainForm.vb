Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        HideAll()
    End Sub

    Private Sub MainForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'Write to console mouse click 
        Console.WriteLine("Mouse Co-Ordinates: " + e.X.ToString + "," + e.Y.ToString)

        'Calculate grid position
        Dim GridX As Decimal = Math.Floor(((e.X - 61) / 96) + 1)
        Dim GridY As Decimal = Math.Floor(((e.Y - 287) / 96) + 1)

        'Write GridPosition to Console
        Console.WriteLine("Grid Co-Ordinates: " + GridY.ToString + "," + GridX.ToString)

        'Set to 0 if out of bounds
        If 1 > GridX Or GridX > 5 Then
            Console.WriteLine("Out of bounds, Exiting...")
            Exit Sub
        End If
        If 1 > GridY Or GridY > 5 Then
            Console.WriteLine("Out of bounds, Exiting...")
            Exit Sub
        End If



        Me.Controls("B" + GridY.ToString + GridX.ToString).Show()
    End Sub

    Private Sub HideAll()
        Dim HideArray As New List(Of Integer)
        HideArray.Add(11)
        HideArray.Add(12)
        HideArray.Add(13)
        HideArray.Add(14)
        HideArray.Add(15)
        HideArray.Add(21)
        HideArray.Add(22)
        HideArray.Add(23)
        HideArray.Add(24)
        HideArray.Add(25)
        HideArray.Add(31)
        HideArray.Add(32)
        HideArray.Add(33)
        HideArray.Add(34)
        HideArray.Add(35)
        HideArray.Add(41)
        HideArray.Add(42)
        HideArray.Add(43)
        HideArray.Add(44)
        HideArray.Add(45)
        HideArray.Add(51)
        HideArray.Add(52)
        HideArray.Add(53)
        HideArray.Add(54)
        HideArray.Add(55)


        For Each i In HideArray
            Me.Controls("B" + i.ToString).Hide()
        Next
    End Sub
#Region "Strikes"

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        B11.Hide()
    End Sub

    Private Sub B12_Click(sender As Object, e As EventArgs) Handles B12.Click
        B12.Hide()
    End Sub
    Private Sub B13_Click(sender As Object, e As EventArgs) Handles B13.Click
        B13.Hide()
    End Sub

    Private Sub B14_Click(sender As Object, e As EventArgs) Handles B14.Click
        B14.Hide()
    End Sub

    Private Sub B15_Click(sender As Object, e As EventArgs) Handles B15.Click
        B15.Hide()
    End Sub

    Private Sub B21_Click(sender As Object, e As EventArgs) Handles B21.Click
        B21.Hide()
    End Sub

    Private Sub B22_Click(sender As Object, e As EventArgs) Handles B22.Click
        B22.Hide()
    End Sub

    Private Sub B23_Click(sender As Object, e As EventArgs) Handles B23.Click
        B23.Hide()
    End Sub

    Private Sub B24_Click(sender As Object, e As EventArgs) Handles B24.Click
        B24.Hide()
    End Sub

    Private Sub B25_Click(sender As Object, e As EventArgs) Handles B25.Click
        B25.Hide()
    End Sub

    Private Sub B31_Click(sender As Object, e As EventArgs) Handles B31.Click
        B31.Hide()
    End Sub

    Private Sub B32_Click(sender As Object, e As EventArgs) Handles B32.Click
        B32.Hide()
    End Sub

    Private Sub B33_Click(sender As Object, e As EventArgs) Handles B33.Click
        B33.Hide()
    End Sub

    Private Sub B34_Click(sender As Object, e As EventArgs) Handles B34.Click
        B34.Hide()
    End Sub

    Private Sub B35_Click(sender As Object, e As EventArgs) Handles B35.Click
        B35.Hide()
    End Sub

    Private Sub B41_Click(sender As Object, e As EventArgs) Handles B41.Click
        B41.Hide()
    End Sub

    Private Sub B42_Click(sender As Object, e As EventArgs) Handles B42.Click
        B42.Hide()
    End Sub

    Private Sub B43_Click(sender As Object, e As EventArgs) Handles B43.Click
        B43.Hide()
    End Sub

    Private Sub B44_Click(sender As Object, e As EventArgs) Handles B44.Click
        B44.Hide()
    End Sub

    Private Sub B45_Click(sender As Object, e As EventArgs) Handles B45.Click
        B45.Hide()
    End Sub

    Private Sub B51_Click(sender As Object, e As EventArgs) Handles B51.Click
        B51.Hide()
    End Sub

    Private Sub B52_Click(sender As Object, e As EventArgs) Handles B52.Click
        B52.Hide()
    End Sub

    Private Sub B53_Click(sender As Object, e As EventArgs) Handles B53.Click
        B53.Hide()
    End Sub

    Private Sub B54_Click(sender As Object, e As EventArgs) Handles B54.Click
        B54.Hide()
    End Sub

    Private Sub B55_Click(sender As Object, e As EventArgs) Handles B55.Click
        B55.Hide()
    End Sub
#End Region

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        HideAll()
    End Sub
End Class
