Imports Microsoft.VisualBasic

Public Class Class1


    Private nom As String

    Function getNombreApellido() As String
        Return Me.nom
    End Function

    Sub setNombreApellido(ByVal nombreApellido As String)
        Me.nom = nombreApellido
    End Sub

End Class
