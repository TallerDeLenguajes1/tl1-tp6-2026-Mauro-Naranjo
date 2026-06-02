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

int opcion, resultado, num1, num2;
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
    Console.WriteLine("");