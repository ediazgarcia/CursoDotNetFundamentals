// Las condiciones if y else se utilizan para ejecutar diferentes bloques de código según si una condición es verdadera o falsa. La sintaxis básica es la siguiente:


// if (condición)

bool areYouHungry = true;
bool youHaveMoney = true;

// Que lo que hace !areYouHungry : significa "no tienes hambre". Si la variable areYouHungry es verdadera, entonces !areYouHungry será falsa, y viceversa. Por lo tanto, el bloque de código dentro del if se ejecutará si no tienes hambre.

// and(&&), or(||)

if (areYouHungry && youHaveMoney && IsOpenRestaurant("RestauranTEddy", 10))
{
    Console.WriteLine("¡Vamos a comer!");
}
else
{
    Console.WriteLine("No tengo hambre ni dinero.");
}     



static bool IsOpenRestaurant(string name, int hour = 0)
{
    if (name == "RestauranTEddy" && hour >= 10 && hour < 22)
    {
        return true;
    }
    else if (name == "RestauranTito" && hour >= 9 && hour < 21)
    {
        return true;
    }
    else if (name == "RestauranTina" && hour >= 11 && hour < 23)
    {
        return true;
    }
    else if (name == "RestauranTaco 24 horas")
    {
        return true;
    }
    else
    {
        return false;
    }
}