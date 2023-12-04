Public Class Profesional

    Private Property idProfesional As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Private Property nombre As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Private Property apellidos As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Private Property telefono As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Private Property correo As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Private Property Oficio As Oficio
        Get
            Return Nothing
        End Get
        Set(value As Oficio)
        End Set
    End Property
    
    Private Property estado As Boolean
        Get
            Return Nothing
        End Get
        Set(value As Boolean)
        End Set
    End Property

    Public Sub verOfertas()

    End Sub

    Public Sub verHistorialDeTrabajos()

    End Sub

    Public Sub verMontoGenerado()

    End Sub

    Public Sub transferirDinero()

    End Sub
    
    Public Function verListaServicios() as Servicio()
        
    End Function
    
    Public Function verListaAnunciosPorIdServicio(idServicio As Integer) As Anuncio()
        
    End Function
End Class
