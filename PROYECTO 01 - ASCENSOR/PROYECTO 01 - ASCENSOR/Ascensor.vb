Public Class Ascensor
    Private elevator As New Button 'elemento para representar el ascensor'
    Private motionTo As Integer = 0 'True esta en movimeinto o trabajando'
    Private isUp As Integer '1 es subiendo, 2 bajando 0 es stop'
    Private desde As Integer = 0
    Private hasta As Integer = 10
    Private todos As Boolean = True
    Private par As Boolean = False
    Private impar As Boolean = False
    Private mantenimiento As Boolean = False
    Public Property Desdevalue() As Integer
        Get
            Return desde
        End Get
        Set(ByVal value As Integer)
            desde = value
        End Set
    End Property
    Public Property Hastavalue() As Integer
        Get
            Return hasta
        End Get
        Set(ByVal value As Integer)
            hasta = value
        End Set
    End Property
    Public Property Todosvalue() As Boolean
        Get
            Return todos
        End Get
        Set(ByVal value As Boolean)
            todos = value
        End Set
    End Property
    Public Property Parvalue() As Boolean
        Get
            Return par
        End Get
        Set(ByVal value As Boolean)
            par = value
        End Set
    End Property
    Public Property Imparvalue() As Boolean
        Get
            Return impar
        End Get
        Set(ByVal value As Boolean)
            impar = value
        End Set
    End Property
    Public Property Mantevalue() As Boolean
        Get
            Return mantenimiento
        End Get
        Set(ByVal value As Boolean)
            mantenimiento = value
        End Set
    End Property
    Public Sub SetElevator(btn As Button)
        elevator = btn
    End Sub
    Public Function GetElevator() As Button
        Return elevator
    End Function
    Public Sub SetPosition(yvalue As Integer)
        Y += yvalue
    End Sub
    Public Property X As Integer
        Get
            Return elevator.Location.X
        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property Y As Integer
        Get
            Return elevator.Location.Y
        End Get
        Set(value As Integer)
            elevator.Location = New Point(X, value)
        End Set
    End Property
    Public Sub SetText(value As String)
        elevator.Text = value
    End Sub
    Public Sub SetcolorBackground(value As Color)
        elevator.BackColor = value
    End Sub
    Public Property MotionToFloor As Integer
        Get
            Return motionTo
        End Get
        Set(value As Integer)
            motionTo = value
        End Set
    End Property
    Public Property MotionDirection As Integer
        Get
            Return isUp
        End Get
        Set(value As Integer)
            isUp = value
        End Set
    End Property
    Public Function CheckElevator(piso As Integer) As Boolean
        Dim result As Boolean = False

        If mantenimiento = False Then
            If piso = 0 Then
                result = True
            Else
                If piso >= desde And piso <= hasta Then
                    If par Then
                        If piso Mod 2 = 0 Then
                            result = True
                        End If
                    ElseIf impar Then
                        If piso Mod 2 = 1 Then
                            result = True
                        End If
                    ElseIf todos Then
                        result = True
                    End If
                End If
            End If

        End If
        Return result
    End Function
End Class
