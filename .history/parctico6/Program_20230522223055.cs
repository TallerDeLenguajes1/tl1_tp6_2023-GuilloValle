// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

//Console.WriteLine("Valor de a:"+a);

//Console.WriteLine("valor de b:"+b);

int num1 = 0;
bool anda = false;
string? numString = "";

while (!anda)
{
    Console.WriteLine("Ingrese un numero valido:");
    numString = Console.ReadLine();
    anda = int.TryParse(numString,out num1);
    if (!anda || num1 <= 0)
    {
        Console.WriteLine(numString + " no es un numero valido");
    }else
    {
        if (num1 < 10)
        {
            System.Console.WriteLine("el numero invertido es: "+ num1);
        }else
        {
            while (num1 != 0)
            {   
                int n = num1 % 10;
                System.Console.Write(n);
                num1 = num1/10;
            }
        }
    }/*------------------------*/
}



