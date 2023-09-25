Module Module1


    Sub Main() 'CALCULO DE LA VELOCIDAD 
        'PromediosD() 'INFRACCIONES
        'DeterminarDiv2() 'NUMEROS DIVISIBLES  
        TresvaloresE()  ''VALORES MAYOR,MEDIO Y MENOR 



        ' Datos de entrada
        Dim distanciaKm As Double = 42.195
        Dim tiempoHoras As Double
        Dim tiempoMinutos As Double

        ' Solicitar al usuario el tiempo en horas y minutos
        Console.Write("Ingrese el tiempo en horas: ")
        tiempoHoras = Double.Parse(Console.ReadLine())
        Console.Write("Ingrese el tiempo en minutos: ")
        tiempoMinutos = Double.Parse(Console.ReadLine())

        ' Calcular la velocidad media en diferentes unidades
        Dim velocidadKmPorHora As Double = distanciaKm / (tiempoHoras + tiempoMinutos / 60)
        Dim velocidadKmPorMinuto As Double = distanciaKm / (tiempoHoras * 60 + tiempoMinutos)
        Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoHoras * 3600 + tiempoMinutos * 60)
        Dim velocidadMPorMinuto As Double = distanciaKm * 1000 / (tiempoHoras * 60 + tiempoMinutos)
        Dim velocidadMPorSegundo As Double = distanciaKm * 1000 / (tiempoHoras * 3600 + tiempoMinutos * 60)

        ' Imprimir resultados
        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora)
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto)
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo)
        Console.WriteLine("Velocidad media en m/min: " & velocidadMPorMinuto)
        Console.WriteLine("Velocidad media en m/s: " & velocidadMPorSegundo)

        Console.ReadLine()

        'BRYAN SAUL GARCIA CARIAS 

    End Sub
    Sub PromediosD() 'INFRACCIONES 

        ' Datos de entrada
        Dim totalInfracciones As Integer
        Console.Write("Ingrese el total de infracciones en el mes: ")
        totalInfracciones = Integer.Parse(Console.ReadLine())

        ' Calcular promedios
        Dim promedioMatutino As Double = 0.2 * totalInfracciones / 30
        Dim promedioTarde As Double = 0.35 * totalInfracciones / 30
        Dim promedioNocturno As Double = 0.45 * totalInfracciones / 30

        ' Imprimir resultados
        Console.WriteLine("Promedio diario matutino de infracciones: " & promedioMatutino)
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioTarde)
        Console.WriteLine("Promedio diario nocturno de infracciones: " & promedioNocturno)

        Console.ReadLine()

        'BRYAN SAUL GARCIA CARIAS 

    End Sub

    Sub DeterminarDiv2() 'NUMEROS DIVISIBLE 
        ' Datos de entrada
        Dim num1 As Integer
        Dim num2 As Integer

        Console.Write("Ingrese el primer número: ")
        num1 = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        num2 = Integer.Parse(Console.ReadLine())

        ' Verificar si num1 es divisor de num2
        If num2 Mod num1 = 0 Then
            Console.WriteLine(num1 & " es divisor de " & num2)
        Else
            Console.WriteLine(num1 & " no es divisor de " & num2)
        End If

        Console.ReadLine()

        'BRYAN SAUL GARCIA CARIAS

    End Sub

    Sub TresvaloresE() 'VALORES MAYOR,MEDIO Y MENOR 
        ' Datos de entrada
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer

        Console.Write("Ingrese el primer número: ")
        num1 = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        num2 = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el tercer número: ")
        num3 = Integer.Parse(Console.ReadLine())

        ' Encontrar el mayor, medio y menor
        Dim mayor As Integer = Math.Max(Math.Max(num1, num2), num3)
        Dim menor As Integer = Math.Min(Math.Min(num1, num2), num3)
        Dim medio As Integer = num1 + num2 + num3 - mayor - menor

        ' Imprimir resultados
        Console.WriteLine("El mayor es: " & mayor)
        Console.WriteLine("El medio es: " & medio)
        Console.WriteLine("El menor es: " & menor)

        Console.ReadLine()

        'BRYAN SAUL GARCIA CARIAS 
    End Sub

End Module
