Public Class Form1
    Dim testRating As Rating
    Structure Rating
        Public numberOfRatings As Integer
        Public Owner As Reader
        Public Recipient As Book
        Dim valRating As Single
        Public Property Rating As Single
            Get
                Return valRating
            End Get
            Set(value As Single)
                Select Case value
                    Case 0
                        valRating = 0
                        numberOfRatings = 1
                    Case Is > 0
                        If Rating > 0 Then
                            numberOfRatings += 1
                            valRating += (1.5 * value / numberOfRatings) 'add the shrinking amount
                        Else
                            valRating = 1
                            numberOfRatings = 1
                        End If
                    Case Is < 0
                        If Rating < 0 Then
                            numberOfRatings += 1
                            valRating += (1.25 * value / numberOfRatings)
                        Else
                            valRating = -1
                            numberOfRatings = 1
                        End If
                End Select
            End Set
        End Property
    End Structure
    Class RatingData
        Public rating As Single
        Public ratings(-1) As Rating
        Sub AddRating(value As Integer)
            rating += value
        End Sub

    End Class

    Class Book
        Public author As String
        Public title As String
        Public numberOfRatings As Integer
        'Property thumbRating As single
        '    Get
        '        Return starRating
        '    End Get
        '    Set(value As Integer)

        '        'starRating = 
        '    End Set
        'End Property


        Public Overrides Function ToString() As String
            Return """" + title + """ by " + author
        End Function

    End Class

    Class Reader
        Public name As String
        Public ratings


    End Class

    Class List
        Public collection(-1) As Object

        Sub AddItem()

        End Sub

        Sub RemoveItem()

        End Sub
    End Class

    Class Booklist
        Inherits List
    End Class

    Class ReaderList
        Inherits List
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        testRating.Rating = -1
        Label1.Text = testRating.Rating
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        testRating.Rating = 0
        Label1.Text = testRating.Rating

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        testRating.Rating = 1
        Label1.Text = testRating.Rating

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        testRating = New Rating


    End Sub
End Class


