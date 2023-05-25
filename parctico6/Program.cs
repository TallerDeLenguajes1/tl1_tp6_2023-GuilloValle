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



/* PUNTO 4 --------------------------------------------------------------------------*/




/*Console.WriteLine("Ingrese la primera cadena:");
string cadena1 = Console.ReadLine();
int longitud = cadena1.Length;
Console.WriteLine("La longitud de la primer cadena es: " + longitud);

Console.WriteLine("Ingrese la segunda cadena:");
string cadena2 = Console.ReadLine();

string concatenacion = cadena1 + cadena2;

Console.WriteLine("La concatenación de las dos cadenas es: " + concatenacion);

string subcadena1 = cadena1.Substring(0, 4); 
Console.WriteLine("la subcadena de cadena 1 es: "+ subcadena1);


foreach (char caracter in cadena1)
{
    Console.WriteLine(caracter);
}


Console.WriteLine("Ingrese la palabra a buscar en cadena 2:");
string? palabra = Console.ReadLine();

bool contienePalabra = cadena2.Contains(palabra);

if (contienePalabra)
{
    Console.WriteLine("La palabra '" + palabra + "' se encuentra en la cadena 2.");
}
else
{
    Console.WriteLine("La palabra '" + palabra + "' no se encuentra en la cadena 2.");
}


string cadenaMayusculas = cadena1.ToUpper();
string cadenaMinusculas = cadena1.ToLower();

Console.WriteLine("Cadena 1 en mayúsculas: " + cadenaMayusculas);
Console.WriteLine("Cadena 1 en minúsculas: " + cadenaMinusculas);*/

string cadena3 = "Hola, Mundo, Perro, Chau";
char delimitador = ','; // Utilizamos una coma como delimitador

string[] subcadenas = cadena3.Split(delimitador);

foreach (string subcadena in subcadenas)
{
    Console.WriteLine(subcadena);
}

int numer,numer2;

Console.WriteLine("Ingrese una ecuación simple:");
string ecuacion = Console.ReadLine();

string[] operandos = ecuacion.Split("+");
bool funci = int.TryParse(operandos[0],out numer);
bool funci2 = int.TryParse(operandos[1],out numer2);
int suma = numer + numer2;
Console.WriteLine("La suma es: " + suma);