﻿Imports System.IO
Public Class Form1
    Dim myBookList As New Booklist
    Dim myReaderList As New ReaderList
    Dim myViewController As New viewManager

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

        Sub New(ByVal rating As Single)
            valRating = rating

        End Sub
    End Structure

    Class RatingData
        Public ratings(54) As Rating
        Sub AddRating(value As Integer)

        End Sub

        Sub New(raw As String())
            ReDim ratings(54)
            For i = 0 To UBound(raw) - 1
                Me.ratings(i) = New Rating(Int(Trim(raw(i))))
            Next

        End Sub

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
        Public ratings As RatingData

        Sub New(name As String, ByVal Ratings As RatingData)
            Me.name = name
            Me.ratings = Ratings
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

                tempRatings = New RatingData(tempSplitString)
                collection(numberOfLines) = New Reader(strline, tempRatings)
                numberOfLines += 1
            Loop

            sr.Close()
        End Sub
    End Class

    Class viewManager

        Sub updateReaderLst()
            Form1.lstReaders.Items.Clear()
            For Each reader In Form1.myReaderList.collection

                Form1.lstReaders.Items.Add(reader.ToString)
            Next
        End Sub

        Sub updateBookLst()
            Form1.lstBooks.Items.Clear()
            For Each book In Form1.myBookList.collection

                Form1.lstBooks.Items.Add(book.ToString)
            Next
        End Sub

        Sub updateRatingsLst(reader As Reader)
            Form1.lstRatings.Items.Clear()
            For Each rating In reader.ratings.ratings
                Form1.lstRatings.Items.Add(rating.Rating)
            Next
        End Sub

        Sub updateSelectedBook(book As Book)
            Form1.picBook.ImageLocation = book.getImageLocation
            Form1.lblAuthor.Text = book.author
            Form1.lblTitle.Text = book.title
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        myBookList.OpenFile()
        myReaderList.OpenFile()
        myViewController.updateBookLst()
        myViewController.updateReaderLst()
    End Sub

    Private Sub LstReaders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReaders.SelectedIndexChanged
        Dim selected As Integer
        selected = lstReaders.SelectedIndex
        myViewController.updateRatingsLst(myReaderList.collection(selected))
    End Sub

    Private Sub LstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        Dim selected As Integer
        selected = lstBooks.SelectedIndex
        myViewController.updateSelectedBook(myBookList.collection(selected))
    End Sub
End Class


