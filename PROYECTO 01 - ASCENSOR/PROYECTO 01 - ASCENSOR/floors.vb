Public Class floors
    Private up As Boolean = False
    Private Down As Boolean = False
    Private name As String
    Private X As Integer
    Private Y As Integer
    Private btnUp As New Button
    Private btnDown As New Button

    Public Sub SetbtnUp(btn As Button)
        btnUp = btn
    End Sub
    Public Function GetbtnUp() As Button
        Return btnUp
    End Function
    Public Sub SetbtnDown(btn As Button)
        btnDown = btn
    End Sub
    Public Function GetbtnDown() As Button
        Return btnDown
    End Function

    Public Property Xvalue As Integer
        Get
            Return X
        End Get
        Set(value As Integer)
            X = value
        End Set
    End Property
    Public Property Yvalue As Integer
        Get
            Return Y
        End Get
        Set(value As Integer)
            Y = value
        End Set
    End Property
    Public Property UP_value As Boolean
        Get
            Return up
        End Get
        Set(value As Boolean)
            up = value
        End Set
    End Property
    Public Property Down_value As Boolean
        Get
            Return Down
        End Get
        Set(value As Boolean)
            Down = value
        End Set
    End Property
    Public Property name_value As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
End Class
