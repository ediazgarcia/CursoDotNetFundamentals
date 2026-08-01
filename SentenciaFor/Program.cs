// La sentencia for es una estructura de control de flujo que permite ejecutar un bloque de código repetidamente mientras se cumpla una condición. Se utiliza cuando se conoce de antemano el número de iteraciones que se desea realizar.


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Iteración {i}");
//}


// La tabla de multiplicar del del 1 al 12 utilizando un bucle for

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"\nTabla de multiplicar del {i}");
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }

}

// Tabla de multiplicar del 1 al 12:
