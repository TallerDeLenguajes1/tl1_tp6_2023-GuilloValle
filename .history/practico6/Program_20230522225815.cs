    double num1 = 0;
    bool anda = false;
    string? numString = "";

    while (!anda)
    {
        Console.WriteLine("Ingrese un numero valido:");
        numString = Console.ReadLine();
        anda = double.TryParse(numString,out num1);

        if (anda)
        {
            Console.WriteLine("El valor abosuluto es: " + Math.Abs(num1));
            Console.WriteLine("El cuadrado es: " + num1*num1);
            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(num1));
            Console.WriteLine("El seno es: " + Math.Sin(num1));
            Console.WriteLine("El coseno es: " + Math.Cos(num1));
        }

    }





    