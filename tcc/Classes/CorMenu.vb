Public Class CorMenu
    Inherits ProfessionalColorTable
    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As System.Drawing.Color
        Get
            'Return System.Drawing.Color.FromArgb(64, 64, 64)
            'Return Color.Silver
            Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As System.Drawing.Color
        Get
            Return Color.Silver

        End Get
    End Property
    Public Overrides ReadOnly Property MenuStripGradientBegin As System.Drawing.Color
        Get
            Return Color.WhiteSmoke
            'Return Color.Black
        End Get
    End Property
    Public Overrides ReadOnly Property MenuStripGradientEnd As System.Drawing.Color
        Get
            Return Color.DarkGray
        End Get
    End Property
    Public Overrides ReadOnly Property MenuBorder As System.Drawing.Color
        Get
            Return Color.LightGray
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelected As System.Drawing.Color
        Get
            Return Color.LightGray

        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemBorder As System.Drawing.Color
        Get
            Return Color.LightGray

        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As System.Drawing.Color
        Get
            'Return Color.White
            Return Color.Black
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientMiddle As System.Drawing.Color
        Get
            Return Color.NavajoWhite
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As System.Drawing.Color
        Get
            Return Color.Silver
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientBegin As System.Drawing.Color
        Get
            Return Color.Gray

        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientMiddle As System.Drawing.Color
        Get
            Return Color.LightGray
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientEnd As System.Drawing.Color
        Get
            Return Color.WhiteSmoke
        End Get
    End Property
End Class
