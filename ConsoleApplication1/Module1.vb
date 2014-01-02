Module Module1
    Sub Main()
        'Declaramos 9 variables de tipo entero
        Dim a, b, c, d, e, f, g, h, opcion As Integer
        'Inicial izamos las variables d,e,f,g,h, opción
        d = 0
        e = 0
        f = 0
        g = 0
        h = 0
        opcion = 0

        'Instrucción do while
        Do
            'Mensajes para ingresar el valor desde la consola
            Console.Write("Escribe el coeficiente a :")
            'Método que convierte en un tipo entero el valor que se ingrese por la consola 
            a = Integer.Parse(Console.ReadLine())
            Console.Write("Escribe el coeficiente b :")
            'Método que convierte en un tipo entero el valor que se ingrese por la consola 
            b = Integer.Parse(Console.ReadLine())
            Console.Write("Escribe el coeficiente c :")
            'Método que convierte en un tipo entero el valor que se ingrese por la consola 
            c = Integer.Parse(Console.ReadLine())
            ' Multiplicaciónes de las variables a, c, b 
            ' y el resultado de las dos multiplicaciónes se restarán y el resultado
            'se almacena en la variable d 
            d = ((b * b) - (4 * a * c))
            ' Multiplicación de las variables a 
            'y el resultado se almacena en la variable e
            e = ((2) * (a))
            'Condición que evalúa la variable e si es menor o igual a 0
            If e <= 0 Then
                'Mensajes que despliega un mensaje con la opción si y no si el
                'resultado es negativo 
                Console.Write(" El coeficiente a es negativo, no se puede dividir Repetir 1-Si 2-No:")
                'Método que convierte en un tipo entero el valor que se ingrese por la consola
                'ya que el mensaje nos pide ingresar el valor de 1 o el valor de 2 y el valor
                ' ingresado se almacena en la variable opción
                opcion = Integer.Parse(Console.ReadLine())
            Else
                'Condicon que evalúa la variable d si es menor o igual a 0
                If d <= 0 Then
                    Console.Write("No existe raiz de un  numero negativo, Repetir 1-Si 2-No:")
                    opcion = Integer.Parse(Console.ReadLine())
                Else
                    'Método para sacar la raíz cuadrada del dato almacenado en 
                    'la variable d y el resultado se almacena en la variable h
                    h = Math.Sqrt(d)
                    'a las variables b,e,h funciones de suma resta multiplicación y división 
                    f = (((-b) + (h)) / e)
                    g = (((-b) - (h)) / e)
                    'Mensajes que muestran el resultado que esta almacenados en la
                    ' variable f, g 
                    Console.Write("La raiz x1_:" & f)
                    Console.Write("La raiz x2_:" & g)
                    Console.Write("Repetir 1-Si 2-No:")
                    opcion = Integer.Parse(Console.ReadLine())

                End If

            End If

        Loop While opcion = 1
    End Sub
End Module
