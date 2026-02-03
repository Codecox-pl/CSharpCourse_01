// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingrese el primer numero: ");
string res = Console.ReadLine();

//if(res is null || res == "")
//{
//    Console.WriteLine("El valor ingresado no es valido");
//    return;
//}

//Convertir un texto a un numero

int resultadoPosible = 0;

if( !int.TryParse(res, out resultadoPosible) )
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}
int resInt = int.Parse(res!);



Console.WriteLine("Ingrese el segundo numero: ");
string res2 = Console.ReadLine();
int resInt2 = int.Parse(res2!);


Console.WriteLine("///---MENU---///");
Console.WriteLine("1.-Suma");
Console.WriteLine("2.-Resta");
Console.WriteLine("3.- Multiplicacion");
Console.WriteLine("4.- Division");
Console.WriteLine("Elige una opcion: ");

int tipoOperacion = int.TryParse(Console.ReadLine(),out tipoOperacion) ? tipoOperacion : 0;

var total = 0;

switch(tipoOperacion)
{
    case 1:
        total = resInt + resInt2;
        Console.WriteLine($"{resInt} + {resInt2} = {total}");
        break;
    case 2:
        total = resInt - resInt2;
        Console.WriteLine($"{resInt} - {resInt2} = {total}");
        break;
    case 3:
        total = resInt * resInt2;
        Console.WriteLine($"{resInt} * {resInt2} = {total}");
        break;
    case 4:
        total = resInt / resInt2;
        Console.WriteLine($"{resInt} / {resInt2} = {total}");
        break;
    default:
        Console.WriteLine("Ingreso erroneo, debe ingresar un valor del 1 al 4");
        return;
}

//int resSuma = resInt + resInt2;

//Console.WriteLine($"El resultado de la suma es: {resSuma}");

//int resResta = resInt - resInt2;

//Console.WriteLine($"El resultado de la resta es: {resResta}");

//int resMult = resInt * resInt2;

//Console.WriteLine($"El resultado de la multiplicacion es: {resMult}");

//int resDiv = resInt / resInt2;

//Console.WriteLine($"El resultado de la division es: {resDiv}");