
// Variables

// Las variables son contenedores que almacenan datos en memoria. En C#, las variables deben declararse con un tipo de datos específico antes de usarlas. Por ejemplo, para declarar una variable entera, se utiliza la palabra clave "int".

// Como se almacenan los datos en memoria, es importante elegir el tipo de datos adecuado para la variable. Por ejemplo, si se necesita almacenar un número entero, se debe utilizar el tipo de datos "int". Si se necesita almacenar un número decimal, se debe utilizar el tipo de datos "double".

// Pero como es exactamente que se almacenan los datos en memoria? Cuando se declara una variable, el compilador reserva un espacio en la memoria para almacenar el valor de la variable. La cantidad de memoria reservada depende del tipo de datos de la variable. Por ejemplo, una variable de tipo "int" ocupa 4 bytes de memoria, mientras que una variable de tipo "double" ocupa 8 bytes de memoria.


int x = 10;
int y = 20;

int z = x+y;

Console.WriteLine(z);