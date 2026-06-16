Console.WriteLine("Hello, World!");

int a;
int b;
int c, aux, invertido=0;

a = 10;
b = a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("Ingrese un numero para invertir: ");
if (int.TryParse(Console.ReadLine(), out c))
{
    Console.WriteLine("El numero fue ingresado correctamente");
    if (c > 0)
    {
        while (c != 0)
        {
            aux = c % 10;
            invertido = invertido *10 + aux;
            c = c / 10;
        }
    Console.WriteLine("El numero invertido es: "+invertido);
    }
} else
{
    Console.WriteLine("Es numero ingresado no es valido");
}

int opcion, resultado=0, num1, num2;
char repetir;

do
{
    Console.WriteLine("Ingrese la operacion que quiere realizar:\n1)Sumar\n2)Restar\n3)Multiplicar\n4)Dividir");
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opcion Valida");
    }
    Console.WriteLine("Ingrese el primer numero a operar");
    if (int.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("numero valido");
    }
    Console.WriteLine("Ingrese el segundo numero a operar");
    if (int.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("numero valido");
    }

    switch (opcion)
    {
        case 1: 
            resultado = num1 + num2;
            break;
        case 2: 
            resultado = num1 - num2;
            break;
        case 3: 
            resultado = num1 * num2;
            break;
        case 4: 
            resultado = num1 / num2;
            break;
        default:
            Console.WriteLine("Ingreso una opcion incorrecta");
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? (s/n)");
    repetir = Console.ReadLine()[0];
} while (repetir == 's' || repetir == 'S');
    //Console.WriteLine("");
int numero, nuevoNum, nuevoNum2;

Console.WriteLine("Ingrese un numero:");
if (int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("El numero ingresado es valido");
} else
{
    Console.WriteLine("Numero invalido");    
}

Console.WriteLine("Su valor absoluto es:"+Math.Abs(numero));
Console.WriteLine("Su cuadrado es:"+Math.Pow(numero, 2));
Console.WriteLine("Su raiz cuadrada es:"+Math.Sqrt(numero));
Console.WriteLine("Su seno es:"+Math.Sin(numero));
Console.WriteLine("Su coseno es:"+Math.Cos(numero));
Console.WriteLine("Su parte entera es:"+(int)numero);

Console.WriteLine("Ingrese un nuevo numero:");
if (int.TryParse(Console.ReadLine(), out nuevoNum))
{
    Console.WriteLine("El numero ingresado es valido");
} else
{
    Console.WriteLine("Numero invalido");    
}
Console.WriteLine("Ingrese otro numero:");
if (int.TryParse(Console.ReadLine(), out nuevoNum2))
{
    Console.WriteLine("El numero ingresado es valido");
} else
{
    Console.WriteLine("Numero invalido");    
}

if (nuevoNum > nuevoNum2)
{
    Console.WriteLine("El maximo entre los dos numeros es:"+nuevoNum);
} else
{
    Console.WriteLine("El maximo entre los dos numeros es:"+nuevoNum2);
}

//ejercicio 4
/*Conversor de tipo: ToString()
Comparador de cadenas: Compare(), CompareTo() == y !=
Mayúsculas y minúsculas: ToUpper() o ToLower()
Acceso a los caracteres individuales: SubString(), Replace(),Split() y Trim(),
Búsqueda y manipulación de una cadena: IndexOf() LastIndexOf, StartsWith y
EndsWith. Split()*/

Console.WriteLine("Ingrese una cadena de texto: ");
string cadena = Console.ReadLine();

//longitud de la cadena
Console.WriteLine("La longitud de la cadena es: "+cadena.Length);

Console.WriteLine("Ingrese otra cadena de texto: ");
string cadena2 = Console.ReadLine();

//concatenar cadenas
string concatenada = $"{cadena} {cadena2}";
Console.WriteLine("cadena concatenada: "+concatenada);

//extraer subcadena
string subcadena = concatenada.Substring(0, 2);
Console.WriteLine("subcadena extraida: "+subcadena);

//muestra de resultado
Console.WriteLine($"la resta de {num1} y {num2} es igual a: {resultado}");

//recorrer cadena
foreach (var caracter in concatenada)
{
    Console.WriteLine(caracter);
}

//buscar ocurrencia
string buscar = "jr";
if (concatenada.Contains(buscar))
{
    Console.WriteLine("La palabra fue encontrada.");
}
else
{
    Console.WriteLine("La palabra no fue encontrada.");
}

//Convertir a mayusculas y a minusculas
Console.WriteLine("En mayusculas: "+concatenada.ToUpper());
Console.WriteLine("En minusculas: "+concatenada.ToLower());

//Separacion por caracteres
Console.WriteLine("Ingrese una cadena con separacion de caracteres: ");
string cadena3 = Console.ReadLine();
string[] separados = cadena3.Split(',');
foreach (var separado in separados)
{
    Console.WriteLine(separado);
}
