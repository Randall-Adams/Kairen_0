Public Class NPCFile001
    Private vnameSafe As String
    Private vnameGame As String
    Private vX As Integer
    Private vY As Integer
    Private vZ As Integer
    Private vF As Integer

    Public Property nameSafe() As String
        Get
            Return vnameSafe
        End Get
        Set(value As String)
            vnameSafe = value
        End Set
    End Property

    Public Property nameGame() As String
        Get
            Return vnameGame
        End Get
        Set(value As String)
            vnameGame = value
        End Set
    End Property

    Public Property X() As String
        Get
            Return vX
        End Get
        Set(value As String)
            vX = value
        End Set
    End Property

    Public Property Y() As String
        Get
            Return vY
        End Get
        Set(value As String)
            vY = value
        End Set
    End Property

    Public Property vZ() As String
        Get
            Return Z
        End Get
        Set(value As String)
            vZ = value
        End Set
    End Property

    Public Property F() As String
        Get
            Return vF
        End Get
        Set(value As String)
            vF = value
        End Set
    End Property
End Class
