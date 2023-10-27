Imports System.Drawing.Drawing2D

Public Class myGroupBox
    Inherits GroupBox

    Private _borderColor As Color
    Private _radius As Decimal
    Private _textColor As Color
    Public Property BorderColor() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
        End Set
    End Property

    Public Property Radius() As Decimal
        Get
            Return _radius
        End Get
        Set(ByVal value As Decimal)
            _radius = value
        End Set
    End Property

    Public Property TextColor() As Color
        Get
            Return _textColor
        End Get
        Set(ByVal value As Color)
            _textColor = value
        End Set
    End Property

    Public Sub New()
        Me._borderColor = Color.Black
        Me._textColor = Color.Black
        Me._radius = 8
    End Sub

    Protected Overloads Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim gp As New GraphicsPath()
        gp.AddArc(e.ClipRectangle.X + e.ClipRectangle.Width - 2 - (Radius * 2), e.ClipRectangle.Y + 8, Radius * 2, Radius * 2, 270, 90)
        gp.AddArc(e.ClipRectangle.X + e.ClipRectangle.Width - 2 - (Radius * 2), e.ClipRectangle.Y + e.ClipRectangle.Height - 2 - (Radius * 2), Radius * 2, Radius * 2, 0, 90)
        gp.AddArc(e.ClipRectangle.X, e.ClipRectangle.Y + e.ClipRectangle.Height - 2 - (Radius * 2), Radius * 2, Radius * 2, 90, 90)
        gp.AddArc(e.ClipRectangle.X, e.ClipRectangle.Y + 8, Radius * 2, Radius * 2, 180, 90)
        gp.CloseFigure()
        e.Graphics.DrawPath(New Pen(BorderColor), gp)
        Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X += 15
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), textRect)
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(TextColor), textRect)
    End Sub


End Class