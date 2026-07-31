

// Que es y como funciona un bucle while y do while en C#, el bucle while ejecuta un bloque de código mientras una condición sea verdadera, y el bucle do while ejecuta un bloque de código al menos una vez y luego verifica la condición para decidir si continuar o no.


int i = 0;

while (i < 10)
{
    if (i == 8)
        break;

    Console.WriteLine($"Iteración de {i}");
    i++;
}

// Ex. Menu

Console.WriteLine("=== Menú ===");
Console.WriteLine("1. Opción 1");
Console.WriteLine("2. Opción 2");
Console.WriteLine("3. Opción 3");
Console.WriteLine("0. Salir");

int opcion = Convert.ToInt32(Console.ReadLine());

while (opcion != 0)
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Elegiste la opción 1");
            break;
        case 2:
            Console.WriteLine("Elegiste la opción 2");
            break;
        case 3:
            Console.WriteLine("Elegiste la opción 3");
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

}



// Do While Loop Example
Console.WriteLine($"=== Do While Loop ===");

bool run = false;

do
{
    Console.WriteLine($"Entro una vez {i}");
} while (run);


