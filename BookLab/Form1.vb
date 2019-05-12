Imports System.IO
Public Class Form1
    Public DataModel As New DataManager
    Public ViewController As New viewManager
    Structure Rating
        Implements IComparable
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
                            valRating = 5 * (Math.E ^ (numberOfRatings / 20))
                            'valRating += (1.5 * value / numberOfRatings) 'add the shrinking amount
                        Else
                            numberOfRatings = 1
                            valRating = 5 * (Math.E ^ (numberOfRatings / 20))
                        End If
                    Case Is < 0
                        If Rating < 0 Then
                            numberOfRatings += 1
                            valRating = -5 * (Math.E ^ (numberOfRatings / 20))
                            'valRating += (1.25 * value / numberOfRatings)
                        Else
                            numberOfRatings = 1
                            valRating = -5 * (Math.E ^ (numberOfRatings / 20))
                        End If
                End Select
            End Set
        End Property

        Sub setFromFile(value As Single)
            numberOfRatings = -20 * Math.Log((-Math.Abs(value) / 5.0339) + 1)
            valRating = value
        End Sub

        Sub New(ByVal rating As Single, ByRef Owner As Reader, ByRef Recipient As Book)
            Me.Owner = Owner
            setFromFile(rating)
            Me.Recipient = Recipient
        End Sub

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
            Return DirectCast(obj, Rating).Rating - Rating
        End Function

        Public Overrides Function ToString() As String
            Return Owner.name + " - " + Recipient.title
        End Function
    End Structure

    Structure similarity
        Implements IComparable
        Public score As Single
        Public owner As Reader
        Public reader As Reader

        Sub New(score As Single, owner As Reader, reader2 As Reader)
            Me.score = score
            Me.owner = owner
            Me.reader = reader2
        End Sub

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
            Return DirectCast(obj, similarity).score - Me.score
        End Function
    End Structure

    Class RatingData
        Public ratings(54) As Rating

        Sub AddRating(value As Integer)

        End Sub

        Sub New(raw As String(), Owner As Reader, booklist As Booklist)
            ReDim ratings(54)
            For i = 0 To UBound(raw) - 1

                ratings(i) = New Rating(Int(Trim(raw(i))), Owner, DirectCast(booklist.collection(i), Book))
            Next
            Array.Sort(ratings)
        End Sub

        Function hasRead(book As Book) As Boolean
            Dim found As Boolean
            Dim search As Integer
            found = False
            While search <= 54
                If ratings(search).Recipient.title = book.title And ratings(search).Rating <> 0 Then
                    found = True
                End If

                search += 1
            End While
            Return found
        End Function
    End Class

    Class Recomendation
        Public book As Book
        Public confidenceRating As Rating

        Sub New(confidence As Rating)
            Me.book = confidence.Recipient
            Me.confidenceRating = confidence
        End Sub
    End Class

    Class Recommender
        Public recommendations(54) As Recomendation

        Sub New()

        End Sub
    End Class

    Class SimilarityRecommender
        Inherits Recommender

        Sub New(target As Reader)
            For Each similarity In target.similarities

                Dim numBooks As Integer
                numBooks = 0
                While numBooks < 4
                    For j = 0 To UBound(similarity.reader.ratingData.ratings)
                        If Not target.ratingData.hasRead(similarity.reader.ratingData.ratings(j).Recipient) Then
                            recommendations(numBooks) = New Recomendation(similarity.reader.ratingData.ratings(j))
                            numBooks += 1
                        End If
                    Next

                End While
            Next
        End Sub

    End Class

    Class PopuluarityRecommender
        Inherits Recommender

    End Class

    Class CustomRecommender
        Inherits Recommender

    End Class

    Interface IItem

    End Interface

    Class Book
        Implements IItem
        Public author As String
        Public title As String
        Public Ratings As RatingData

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

        Friend Function getImageLocation() As String
            Return "D:\Documents\Schoolwork\Computer Programing 2\VB.NET\BookLab\BookLab\55 Book Covers - Accurate Titles\" + title + ".jpg"
        End Function
    End Class

    Class Reader
        Implements IItem
        Public name As String
        Public ratingData As RatingData
        Public similarities(85) As similarity

        Sub fillSimilarities()
            For i = 0 To UBound(Form1.DataModel.myReaderList.collection)
                similarities(i).score = 0
                similarities(i).owner = Me
                similarities(i).reader = Form1.DataModel.myReaderList.collection(i)
                For j = 0 To UBound(DirectCast(Form1.DataModel.myReaderList.collection(i), Reader).ratingData.ratings)
                    similarities(i).score += ratingData.ratings(j).Rating * DirectCast(Form1.DataModel.myReaderList.collection(i), Reader).ratingData.ratings(j).Rating
                Next
            Next
        End Sub

        Sub New(name As String)
            Me.name = name
        End Sub

        Sub setRatings(ratings As RatingData)
            Me.ratingData = ratings
        End Sub

        Public Overrides Function ToString() As String
            Return name
        End Function

    End Class

    Class List
        Public collection(-1) As IItem

        Sub AddItem(item As IItem, Optional index As Integer = 0)
        End Sub

        Sub RemoveItem(index As Integer)

        End Sub
    End Class

    Class Booklist
        Inherits List
        Dim workingFileName

        Sub OpenFile()
            'Dim OfOpen = New OpenFileDialog()
            'OfOpen.ShowDialog()
            'workingFileName = OfOpen.FileName
            'If String.IsNullOrEmpty(workingFileName) Then
            '    MsgBox("FileName error please correct")
            '    Exit Sub
            'End If
            workingFileName = "D:\Documents\Schoolwork\Computer Programing 2\VB.NET\BookLab\BookLab\BookRecomendationProject-20190430T153921Z-001\BookRecomendationProject\books.txt"
            Dim sr As StreamReader = File.OpenText(workingFileName)
            Dim strline As String
            Dim numberOfLines As Integer
            ReDim collection(54)
            numberOfLines = 0
            Do While Not sr.EndOfStream
                strline = sr.ReadLine
                collection(numberOfLines) = New Book(strline)
                numberOfLines += 1
            Loop
            sr.Close()
            '' CALL Apply Ratings
        End Sub
    End Class

    Class ReaderList
        Inherits List
        Dim workingFileName As String

        Sub OpenFile()
            'Dim OfOpen = New OpenFileDialog()
            'OfOpen.ShowDialog()
            'workingFileName = OfOpen.FileName
            'If String.IsNullOrEmpty(workingFileName) Then
            '    MsgBox("FileName error please correct")
            '    Exit Sub
            'End If
            workingFileName = "D:\Documents\Schoolwork\Computer Programing 2\VB.NET\BookLab\BookLab\BookRecomendationProject-20190430T153921Z-001\BookRecomendationProject\readerratings.txt"
            Dim sr As StreamReader = File.OpenText(workingFileName)
            Dim strline As String
            Dim strline2 As String
            Dim numberOfLines As Integer
            ReDim collection(85)
            Dim tempSplitString(54) As String

            Dim tempRatings As RatingData
            numberOfLines = 0
            Do While Not sr.EndOfStream
                strline = sr.ReadLine
                strline2 = sr.ReadLine
                tempSplitString = Split(strline2, " ")
                collection(numberOfLines) = New Reader(strline)
                tempRatings = New RatingData(tempSplitString, collection(numberOfLines), Form1.DataModel.myBookList)

                'SHOW KUMMER THIS    & look into generals and the whole, (Of T) thing
                DirectCast(collection(numberOfLines), Reader).setRatings(tempRatings)
                numberOfLines += 1
            Loop

            sr.Close()
        End Sub
    End Class

    Class DataManager
        Public myBookList As New Booklist
        Public myReaderList As New ReaderList

        Sub updateBookRatings()
            Dim numberOfRatings
        End Sub


        Sub fillSimilarity()
            For Each comparedReader In myReaderList.collection
                DirectCast(comparedReader, Reader).fillSimilarities()
                Array.Sort(DirectCast(comparedReader, Reader).similarities)
            Next
        End Sub

        Function getRecommendation(algorithm As Integer, targetReader As Reader) As Recommender
            Select Case algorithm
                Case 1

                Case 2
                    Return getBRec(targetReader)
                Case 3
            End Select
        End Function

        Function getBRec(targetReader As Reader) As Recommender
            Return New SimilarityRecommender(targetReader)
        End Function

    End Class

    Class viewManager
        ReadOnly Property selectedReader As Reader
            Get
                If Form1.lstReaders.SelectedIndex = -1 Then
                    Return Nothing
                End If
                Return DirectCast(Form1.DataModel.myReaderList.collection(Form1.lstReaders.SelectedIndex), Reader)
            End Get
        End Property


        Sub updateReaderLst()
            Form1.lstReaders.Items.Clear()
            For Each reader In Form1.DataModel.myReaderList.collection

                Form1.lstReaders.Items.Add(reader.ToString)
            Next
        End Sub

        Sub updateBookLst()
            Form1.lstBooks.Items.Clear()
            If selectedReader Is Nothing Then
                Exit Sub
            End If

            Dim temp = Form1.DataModel.getRecommendation(2, selectedReader).recommendations
            For Each book In Form1.DataModel.getRecommendation(2, selectedReader).recommendations
                If book IsNot Nothing Then
                    Form1.lstBooks.Items.Add(book.book.ToString)
                End If
            Next
        End Sub

        Sub updateRatingsLst(reader As Reader)
            'Form1.lstRatings.Items.Clear()
            'For Each rating In reader.ratingData.ratings
            '    Form1.lstRatings.Items.Add(rating.Rating)
            'Next
        End Sub

        Sub updateSelectedBook(book As Book)
            Form1.picBook.ImageLocation = book.getImageLocation
            Form1.lblAuthor.Text = book.author
            Form1.lblTitle.Text = book.title
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataModel.myBookList.OpenFile()
        DataModel.myReaderList.OpenFile()
        ViewController.updateBookLst()
        ViewController.updateReaderLst()
        DataModel.fillSimilarity()
    End Sub

    Private Sub LstReaders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReaders.SelectedIndexChanged
        Dim selected As Integer
        selected = lstReaders.SelectedIndex
        ViewController.updateRatingsLst(DataModel.myReaderList.collection(selected))
    End Sub

    Private Sub LstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        Dim selected As Integer
        selected = lstBooks.SelectedIndex
        ViewController.updateSelectedBook(DataModel.getRecommendation(2, ViewController.selectedReader).recommendations(selected).book)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim temp As Book = DirectCast(DataModel.getRecommendation(2, ViewController.selectedReader).recommendations(0).book, Book)
        ViewController.updateSelectedBook(temp)
        ViewController.updateBookLst()
    End Sub

End Class
