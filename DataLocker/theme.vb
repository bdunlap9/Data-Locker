Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.ComponentModel

Partial Public Class Wow
    Inherits Panel
    Public Sub New()
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        Me.Padding = New Padding(1, 55, 1, 1)
    End Sub
    Dim x, y As Integer
    Public Enum Type
        Teacher = 0
        Student = 1
        Locker = 2
    End Enum
    Public _Type As Type = Type.Student
    Public Property Tyype As Type
        Get
            Return _Type
        End Get
        Set(ByVal value As Type)
            _Type = value
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim bm As New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bm)
        ' Dim rect As New Rectangle(0, 0, Me.Width, (Me.Height - 35))
        ' Dim brush As New LinearGradientBrush(rect, Color.FromArgb(250, 250, 250), Color.FromArgb(206, 206, 206), 90.0!)
        'Begin
        'Form
        g.DrawRectangle(New Pen(Color.FromArgb(242, 242, 242)), 0, 0, Me.Width, Me.Height)
        g.FillRectangle(New SolidBrush(Color.FromArgb(242, 242, 242)), 0, 0, Me.Width, Me.Height)
        'Splitter
        g.DrawRectangle(New Pen(Color.FromArgb(229, 229, 229)), 0, 0, Me.Width, 51)
        g.FillRectangle(New SolidBrush(Color.FromArgb(229, 229, 229)), 0, 0, Me.Width, 51)
        'Top
        Dim rect = New Rectangle(0, 0, Me.Width, 50)
        g.DrawRectangle(New Pen(Color.FromArgb(255, 255, 255)), 0, 0, Me.Width, 50)
        g.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), 0, 0, Me.Width, 50)
        'String
        g.DrawString(FindForm.Text, New Font("Arial", 12.5, FontStyle.Regular), New SolidBrush(Color.FromArgb(130, 130, 130)), 14, 17)
        g.DrawString(_Type.ToString, New Font("Arial", 12.5, FontStyle.Bold), New SolidBrush(Color.FromArgb(45, 114, 160)), 93, 17)
        'Buttons
        '//Close button
        If New Rectangle(Width - 40, 10, 24, 24).Contains(New Point(mouseX, mouseY)) Then
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillRectangle(New SolidBrush(Color.FromArgb(237, 237, 237)), New Rectangle(Width - 40, 10, 24, 24))
            g.DrawString("r", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 40, 10))
        Else
            g.SmoothingMode = SmoothingMode.HighQuality
            ' g.FillRectangle(New SolidBrush(Color.FromArgb(237, 237, 237)), New Rectangle(Width - 40, 10, 24, 24))
            g.DrawString("r", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 40, 10))
        End If
        '//Minimize Button
        If New Rectangle(Width - 100, 10, 24, 24).Contains(New Point(mouseX, mouseY)) Then
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillRectangle(New SolidBrush(Color.FromArgb(237, 237, 237)), New Rectangle(Width - 100, 10, 24, 24))
            g.DrawString("0", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 100, 10))
        Else
            g.SmoothingMode = SmoothingMode.HighQuality
            ' g.FillRectangle(New SolidBrush(Color.FromArgb(237, 237, 237)), New Rectangle(Width - 40, 10, 24, 24))
            g.DrawString("0", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 100, 10))
        End If
        '//Fullscreen
        If New Rectangle(Width - 70, 10, 24, 24).Contains(New Point(mouseX, mouseY)) Then
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillRectangle(New SolidBrush(Color.FromArgb(237, 237, 237)), New Rectangle(Width - 70, 10, 24, 24))
            If FindForm.WindowState = FormWindowState.Maximized Then
                g.DrawString("2", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 70, 10))
            Else
                g.DrawString("1", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 70, 10))
            End If
        Else
            g.SmoothingMode = SmoothingMode.HighQuality
            ' g.FillRectangle(New SolidBrush(Color.FromArgb(237, 237, 237)), New Rectangle(Width - 40, 10, 24, 24))
            If FindForm.WindowState = FormWindowState.Maximized Then
                g.DrawString("2", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 70, 10))
            Else
                g.DrawString("1", New Font("Webdings", 14), New SolidBrush(Color.FromArgb(130, 130, 130)), New Point(Width - 70, 10))
            End If
        End If
        'End
        e.Graphics.DrawImage(DirectCast(bm.Clone(), Bitmap), 0, 0)
        g.Dispose()
        bm.Dispose()
        MyBase.OnPaint(e)

    End Sub
#Region "ThemeDraggable"

    Private savePoint As New Point(0, 0)
    Private isDragging As Boolean = False

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Dim dragRect As New Rectangle(0, 0, Me.Width - 103, 50)
        If dragRect.Contains(New Point(e.X, e.Y)) Then
            isDragging = True
            savePoint = New Point(e.X, e.Y)
        End If
        Dim clickRect As New Rectangle(Width - 40, 10, 24, 24)
        If clickRect.Contains(New Point(e.X, e.Y)) Then
            Environment.[Exit](0)
        End If
        If New Rectangle(Width - 70, 10, 24, 24).Contains(New Point(mouseX, mouseY)) Then
            If FindForm.WindowState = FormWindowState.Maximized Then
                FindForm.WindowState = FormWindowState.Normal
            Else
                FindForm.WindowState = FormWindowState.Maximized
            End If
        End If
        If New Rectangle(Width - 100, 10, 24, 24).Contains(New Point(mouseX, mouseY)) Then
            FindForm.WindowState = FormWindowState.Minimized
        End If
        '
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        isDragging = False
        MyBase.OnMouseUp(e)
    End Sub

    Private mouseX As Integer
    Private mouseY As Integer
    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)

        mouseX = e.X
        mouseY = e.Y
        If isDragging Then
            Dim screenPoint As Point = PointToScreen(e.Location)

            FindForm().Location = New Point(screenPoint.X - Me.savePoint.X, screenPoint.Y - Me.savePoint.Y)
        End If
        MyBase.OnMouseMove(e)
        Invalidate()
    End Sub

#End Region
    Public Function Base64ToImage(ByVal base64String As String) As Image
        'I did not write this Function
        ' Convert Base64 String to byte[]
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim image__1 As Image = Image.FromStream(ms, True)
        Return image__1
    End Function
End Class