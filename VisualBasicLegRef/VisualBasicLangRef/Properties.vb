Class Properties
    Public Property Property1 As Integer
    Public Property Property2 As String
    Public Property Property3 As MyType
    Public Property Property4 As MyType.MySubType
    Public Property Property5 As List(Of String)
    Public Property Property6 As Object
    Public Property Property7 As ISomething
    Public Property Property8() As String
    Public Property Property9 As MyType.MyGenericType(Of Integer)

    Public Property Property11 As Integer?
    Public Property Property12 As List(Of Integer?)
    Public Property Property13() As Integer?
    Public Property Property14 As MyType.MyGenericType(Of Integer?)
    Public Property Property15 As Nullable(Of Integer)
    Public Property Property16 As List(Of Nullable(Of Integer))
    Public Property Property17() As Nullable(Of Integer)
    Public Property Property18 As MyType.MyGenericType(Of Nullable(Of Integer))

    Public Property Property21 As List(Of MyType)
    Public Property Property22 As List(Of MyType.MySubType)
    Public Property Property23 As List(Of MyType.MyGenericType(Of Integer))
    Public Property Property24 As List(Of List(Of String))
    Public Property Property25 As List(Of ISomething)



    Public Property Property41 As (Integer, String)
    Public Property Property42 As (id As Integer, name As String)

End Class
