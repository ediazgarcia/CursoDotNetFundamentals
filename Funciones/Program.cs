// Las funciones en C# son bloques de código reutilizables que realizan una tarea específica. Se pueden definir dentro de una clase o estructura y se pueden invocar desde otras partes del programa. A continuación, se presentan algunos ejemplos de funciones en C#:


Saludar();
Sumar(5, 10);
// cacheo de resultado de la multiplicación en una variable
int resultadoMultiplicacion = Multiplicar(5, 2);
Console.WriteLine($"El resultado de la multiplicación es: {resultadoMultiplicacion}");

double area = CalcularArea(resultadoMultiplicacion, 2);
Console.WriteLine($"El área del rectángulo es: {area}");


// Ejemplo 1: Función que no recibe parámetros y no devuelve ningún value
static void Saludar()
{
    Console.WriteLine($"Hola, bienvenido a C#!");                                                                
}


// Ejemplo 2: Función que recibe parámetros

void Sumar(int x, int y)
{
    int resultado = x + y;
    Console.WriteLine($"El resultado de la suma es: {resultado}");
}

// Ejemplo 3: Función que devuelve un valor
int Multiplicar(int x, int y)
{
    return x * y;
}


// Ejemplo 4: Función con parámetros opcionales
double CalcularArea(double baseRectangulo, double alturaRectangulo = 1)
{
    return baseRectangulo * alturaRectangulo;
}

