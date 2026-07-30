// Los arreglos en C# son estructuras de datos que permiten almacenar múltiples valores del mismo tipo en una sola variable. Los arreglos tienen un tamaño fijo y se accede a sus elementos mediante índices, comenzando desde cero. A continuación, se presentan algunos ejemplos de cómo declarar, inicializar y utilizar arreglos en C#.


string[] nombres = new string[5]; // Declaración de un arreglo de cadenas con tamaño 5

nombres[0] = "Juan"; // Asignación de valores a los elementos del arreglo
nombres[1] = "María";
nombres[2] = "Pedro";   

for (int i = 0; i < 5; i++)
    Console.WriteLine(nombres[i]); // Acceso a los elementos del arreglo mediante índices{ }


string?[] frutas = { "Manzana", null, "Naranja", "Uva", "Pera" }; // Declaración e inicialización de un arreglo de cadenas
foreach (string? fruta in frutas)
    Console.WriteLine(fruta); // Iteración sobre los elementos del arreglo utilizando foreach
