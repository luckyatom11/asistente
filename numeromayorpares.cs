
Console.WriteLine("introduzca el primer numero:");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("introduzca el segundo numero:");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("introduzca el tercer numero:");
int numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1>numero2 && numero1>numero3)
{
    Console.WriteLine("el numero mayor es: " + numero1);
    int impart=numero1%2;
    if (impart==0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}
else if (numero2>numero1 && numero2>numero3)
{
    Console.WriteLine("el numero mayor es: " + numero2);
    int impart=numero2%2;
    if (impart==0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}
else
{
    Console.WriteLine("el numero mayor es: " + numero3);
    int impart=numero3%2;
    if (impart==0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}
Console.WriteLine("fin del programa");