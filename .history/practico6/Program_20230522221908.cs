﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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





