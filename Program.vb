Imports System

Module Program
    Sub Main(args As String())
        Dim variable As Integer
        Console.WriteLine("esto es un texto o string DEL MENÚ")
        Do Until variable = 4
            Console.WriteLine("Elija 1 para ingresar correctamente el dato")
            Console.WriteLine("Elija 2 si el datos está ingresado incorrectamente")
            Console.WriteLine("opción 3")
            Console.WriteLine("presione 4 para salir")
            variable = Console.ReadLine
            If variable = 1 Then
                Console.WriteLine("ingrese su nombre")
            ElseIf variable = 2 Then
                Console.WriteLine("ingrese su apellido")
            ElseIf variable = 4 Then
                Console.WriteLine("SALIR")
            End If
            Console.WriteLine("SALIR/CANCELAR/CERRAR")
        Loop
    End Sub
End Module
