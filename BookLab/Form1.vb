Public Class Form1



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

    Interface IItem

    End Interface

    Class Book
        Implements IItem
        Public author As String
        Public title As String
        Public Ratings As New RatingData
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

        Sub New(inputString As String)
            Dim tempString() As String = Split(inputString, ",")
            author = tempString(0)
            title = tempString(1)
        End Sub
        Sub New(author As String, title As String)
            Me.author = author
            Me.title = title
        End Sub

    End Class

    Class Reader
        Implements IItem
        Public name As String
        Public ratings


    End Class

    Class List
        Public collection(-1) As IItem

        Sub AddItem(item As IItem, index As Integer)

        End Sub

        Sub RemoveItem(index As Integer)

        End Sub
    End Class

    Class Booklist
        Inherits List

        Sub OpenFile()

        End Sub
    End Class

    Class ReaderList
        Inherits List

        Sub OpenFile()

        End Sub
    End Class


End Class


