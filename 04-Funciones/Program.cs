// 1.- El usuario ingresa el numero que representa cuantas veces se generara este valor aleatorio
//2.- En el bucle se generara un numero aleatorio entre 1 a 100
//3.- Imprimir dentro del bucle este numero aleatorio previamente generado.


//void GeneradorNum(int num = 1)
//{
//    int i;
//    for (i = 1; i < num; i++)
//    {
//        Random rdn = new Random();
//        int n = rdn.Next(1, 50);
//        Console.WriteLine(n);
//    }
//}


//Console.WriteLine("Ingrese un numero: ");
//var num = int.Parse(Console.ReadLine());


//GeneradorNum();
//-----------------------------------------

//Objetivo el sueldo total de un empleado
// 1.- El metodo recibe los valos de salario, impuesto y salud
// 2.- Calcula el total que debe recibir de salario en funcion a estos parametros
// 3.- El metodo debe devolver el salario total

//int salarioTotal = 0;
//CalcularSalarioTotal(salario: 1000, impuesto: 200, salud: 50, out salarioTotal);

//Console.WriteLine(salarioTotal);
//void CalcularSalarioTotal(int salario, int impuesto, int salud, out int total)
//{
//    total = salario - impuesto - salud;
//}
//-----------------------------------------

//Tuplas

//1 forma
//(int a, string b, bool c) miTupla = (20, "Patrick", false);


//2 forma
//var miTupla = (20, "Patrick", false);


//Console.WriteLine($"Imprime mi primer valor de tupla {miTupla.Item1}");


//Console.WriteLine($"Imprime mi segundo valor de tupla {miTupla.Item2}");

//Console.WriteLine($"Imprime mi tercer valor de tupla {miTupla.Item3}");


//objetivo: registrar un nuevo producto en una tienda
// 1.- el usuario ingresa la data del producto como: nombre, precio, stock
// 2.- el programa va a capturar la data y procedera a poner un precio de venta
// 3.- El metodo de registro de producto debe devolver la data del producto
// 4.- El programa debe imprimior lada del producto registrado


Console.WriteLine("Ingrese el nombre del producto:");
var nombreProducto = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto:");
var precioProducto = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese el stock del producto:");
var stockProducto = int.Parse(Console.ReadLine()!);


(double, int, string) GetProducto(string nombreProducto, int precioProducto, int stock)
{
    var precioFinal = precioProducto + precioProducto * 0.2;

    return (precioFinal, stock, nombreProducto);

}

var tupla = GetProducto(nombreProducto!, precioProducto, stockProducto);
Console.WriteLine($"Datos del producto {tupla.Item3} \n Precio Final: {tupla.Item1} \n Stock: {tupla.Item2} ");