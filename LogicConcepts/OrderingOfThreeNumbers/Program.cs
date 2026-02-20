using Shared;
using System.Timers;


do
{
    Console.WriteLine("Ingrese tres números diferentes:");
    var a = ConsoleExtension.GetInt("Ingrese el primer número: "); 
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
   
    if (a == b)
    {
        Console.WriteLine("Los numeros deben ser diferentes");
        continue;
    }

    var c = ConsoleExtension.GetInt("Ingrese el tercer número: ");

    if (b == c || a == c)
    {
        Console.WriteLine("Los numeros deben ser diferentes");
        continue;
    }


    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"el numero mayor es {a},el numero del medio es {b},el numero menor es {c}");
           
        }else
        {
            Console.WriteLine($"el numero mayor es {a},el numero del medio es {c},el numero menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if(a > c)
        {
            Console.WriteLine($"el numero mayor es {b} el numero del medio es {a},el numero menor es {c}");

        }else
        {
            Console.WriteLine($"el numero mayor es {b},el numero del medio es {c},el numero menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"el numero mayor es {c} el numero del medio es {a},el numero menor es {b}");

        }
        else
        {
            Console.WriteLine($"el numero mayor es {c},el numero del medio es {b},el numero menor es {a}");
        }
    }

} while (true);
