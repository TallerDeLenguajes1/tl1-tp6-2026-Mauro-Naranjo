Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

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