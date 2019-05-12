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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.lstReaders = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblRating.Location = New System.Drawing.Point(722, 335)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(49, 25)
        Me.lblRating.TabIndex = 9
        Me.lblRating.Text = "5/10"
        Me.lblRating.Visible = False
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblAuthor.Location = New System.Drawing.Point(566, 335)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(70, 25)
        Me.lblAuthor.TabIndex = 8
        Me.lblAuthor.Text = "Author"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(562, 291)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(102, 37)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "lblTitle"
        '
        'picBook
        '
        Me.picBook.Location = New System.Drawing.Point(566, 12)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(205, 276)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook.TabIndex = 6
        Me.picBook.TabStop = False
        '
        'lstReaders
        '
        Me.lstReaders.BackColor = System.Drawing.Color.LightGray
        Me.lstReaders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstReaders.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReaders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lstReaders.FormattingEnabled = True
        Me.lstReaders.ItemHeight = 21
        Me.lstReaders.Location = New System.Drawing.Point(12, 12)
        Me.lstReaders.Name = "lstReaders"
        Me.lstReaders.Size = New System.Drawing.Size(159, 336)
        Me.lstReaders.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(200, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Method A"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(200, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 39)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Method B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(200, 210)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 39)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Method C"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lstBooks
        '
        Me.lstBooks.BackColor = System.Drawing.Color.LightGray
        Me.lstBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstBooks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.ItemHeight = 21
        Me.lstBooks.Location = New System.Drawing.Point(387, 12)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(159, 336)
        Me.lstBooks.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 374)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstReaders)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBook)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRating As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents btnBackBook As Button
    Friend WithEvents btnNextBook As Button
    Friend WithEvents btnNextReader As Button
    Friend WithEvents btnBackReader As Button
    Friend WithEvents lstReaders As ListBox
    Friend WithEvents lstRatings As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lstBooks As ListBox
End Class
