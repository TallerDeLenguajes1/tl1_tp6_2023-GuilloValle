// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

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
    }
}*/

    int num1 = 0;
    bool anda = false;
    string? numString = "";

    while (!anda)
    {
        Console.WriteLine("Ingrese un numero valido:");
        numString = Console.ReadLine();
        anda = int.TryParse(numString,out num1);

        if (anda)
        {
            Console.WriteLine("El valor abosuluto es: " + Math.Abs(num1));
            Console.WriteLine("El cuadrado es: " + num1*num1);
            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(num1));
            Console.WriteLine("El seno es: " + Math.Sin(num1));
            Console.WriteLine("El coseno es: " + Math.Cos(num1));
        }

    }





    void calculadoraV1(){

    bool continuarCalculando = true;
    string? opcion;
    bool casteo;
    int num,num2,num3,resultado;

    while (continuarCalculando)
    {   



    System.Console.WriteLine("---ELIJA LA OPCION---");
    System.Console.WriteLine("0: SUMA");
    System.Console.WriteLine("1: RESTA");
    System.Console.WriteLine("2: MULTIPLICAR");
    System.Console.WriteLine("3: DIVIDIR");

    opcion = Console.ReadLine();
    casteo = int.TryParse(opcion,out num);

    if (casteo)
    {
        System.Console.Write("Ingrese el primer numero:");
        opcion = Console.ReadLine();
        casteo = int.TryParse(opcion,out num2);
        if (casteo)
        {
        System.Console.Write("Ingrese el Segundo numero:");
        opcion = Console.ReadLine();
        casteo = int.TryParse(opcion,out num3);
            if (casteo)
            {
                switch (num)
                {
                    case 0: resultado = num2 + num3;
                            System.Console.WriteLine(resultado);
                    break;
                    case 1: resultado = num2 - num3;
                            System.Console.WriteLine(resultado);
                    break; 
                    case 2: resultado = num2 * num3;
                            System.Console.WriteLine(resultado);
                    break; 
                    case 3: resultado = num2 / num3;
                            System.Console.WriteLine(resultado);
                    break;  
                    default: System.Console.WriteLine("no eligio una opcion valida");
                    break;
                }
            }else
            {
                System.Console.Write("no ingreso un numero valido");
            }

        }else
        {
            System.Console.Write("no ingreso un numero valido");
        }
    }else
    {
        System.Console.Write("no ingreso un numero valido");
    }

    Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
            string? continueResponse = Console.ReadLine();
            if (continueResponse.ToLower() != "s")
            {
                continuarCalculando = false;
            }
    
   }
}
    

calculadoraV1();


