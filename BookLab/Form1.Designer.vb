<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.btnBackBook = New System.Windows.Forms.Button()
        Me.btnNextBook = New System.Windows.Forms.Button()
        Me.btnNextReader = New System.Windows.Forms.Button()
        Me.btnBackReader = New System.Windows.Forms.Button()
        Me.lstReaders = New System.Windows.Forms.ListBox()
        Me.lstRatings = New System.Windows.Forms.ListBox()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.Location = New System.Drawing.Point(356, 335)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(49, 25)
        Me.lblRating.TabIndex = 9
        Me.lblRating.Text = "5/10"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(200, 335)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(70, 25)
        Me.lblAuthor.TabIndex = 8
        Me.lblAuthor.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "lblTitle"
        '
        'picBook
        '
        Me.picBook.Location = New System.Drawing.Point(200, 12)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(205, 276)
        Me.picBook.TabIndex = 6
        Me.picBook.TabStop = False
        '
        'lstBooks
        '
        Me.lstBooks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.ItemHeight = 21
        Me.lstBooks.Location = New System.Drawing.Point(12, 12)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(159, 256)
        Me.lstBooks.TabIndex = 10
        '
        'btnBackBook
        '
        Me.btnBackBook.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackBook.Location = New System.Drawing.Point(12, 283)
        Me.btnBackBook.Name = "btnBackBook"
        Me.btnBackBook.Size = New System.Drawing.Size(75, 45)
        Me.btnBackBook.TabIndex = 11
        Me.btnBackBook.Text = "Back"
        Me.btnBackBook.UseVisualStyleBackColor = True
        '
        'btnNextBook
        '
        Me.btnNextBook.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextBook.Location = New System.Drawing.Point(94, 283)
        Me.btnNextBook.Name = "btnNextBook"
        Me.btnNextBook.Size = New System.Drawing.Size(75, 45)
        Me.btnNextBook.TabIndex = 12
        Me.btnNextBook.Text = "Next"
        Me.btnNextBook.UseVisualStyleBackColor = True
        '
        'btnNextReader
        '
        Me.btnNextReader.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextReader.Location = New System.Drawing.Point(520, 283)
        Me.btnNextReader.Name = "btnNextReader"
        Me.btnNextReader.Size = New System.Drawing.Size(75, 45)
        Me.btnNextReader.TabIndex = 19
        Me.btnNextReader.Text = "Next"
        Me.btnNextReader.UseVisualStyleBackColor = True
        '
        'btnBackReader
        '
        Me.btnBackReader.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackReader.Location = New System.Drawing.Point(438, 283)
        Me.btnBackReader.Name = "btnBackReader"
        Me.btnBackReader.Size = New System.Drawing.Size(75, 45)
        Me.btnBackReader.TabIndex = 18
        Me.btnBackReader.Text = "Back"
        Me.btnBackReader.UseVisualStyleBackColor = True
        '
        'lstReaders
        '
        Me.lstReaders.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReaders.FormattingEnabled = True
        Me.lstReaders.ItemHeight = 21
        Me.lstReaders.Location = New System.Drawing.Point(438, 12)
        Me.lstReaders.Name = "lstReaders"
        Me.lstReaders.Size = New System.Drawing.Size(159, 256)
        Me.lstReaders.TabIndex = 17
        '
        'lstRatings
        '
        Me.lstRatings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRatings.FormattingEnabled = True
        Me.lstRatings.ItemHeight = 21
        Me.lstRatings.Location = New System.Drawing.Point(629, 12)
        Me.lstRatings.Name = "lstRatings"
        Me.lstRatings.Size = New System.Drawing.Size(159, 256)
        Me.lstRatings.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 374)
        Me.Controls.Add(Me.lstRatings)
        Me.Controls.Add(Me.btnNextReader)
        Me.Controls.Add(Me.btnBackReader)
        Me.Controls.Add(Me.lstReaders)
        Me.Controls.Add(Me.btnNextBook)
        Me.Controls.Add(Me.btnBackBook)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBook)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRating As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents btnBackBook As Button
    Friend WithEvents btnNextBook As Button
    Friend WithEvents btnNextReader As Button
    Friend WithEvents btnBackReader As Button
    Friend WithEvents lstReaders As ListBox
    Friend WithEvents lstRatings As ListBox
End Class
