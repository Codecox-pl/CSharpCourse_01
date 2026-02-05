// Bucle para imprimir 80 veces el texto: Bienvenido al curso de C# avanzado


//for (int i = 1; i <= 80; i++)
//{
//    Console.WriteLine($"{i}.- Bienvenido al curso de C# avanzado");

//}


// 1.- usuario ingresa u nnumero
// 2.- el programa multiplica por los primeros 10 numeros
// 3.- se debe imprimir el resultado de cada operacion


//var num = int.Parse( Console.ReadLine() );

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{num} * {i}= {num * i}");
//}


//Bucle WHILE

// el usuario ingresa un numero
// el programa captura el numero e imprime una lista de numero superiores hasta el maximo de 100
// regla: el numero ingresado por el usuario no debe ser mayo o igual que 100

Console.WriteLine("Ingrese un numero");


try
{
    var num = int.Parse(Console.ReadLine()!);

    if (num <= 100 || num >= 0)
    {
        Console.WriteLine("El numero no es valido");
    }

    while (num <= 100)
    {
        Console.WriteLine(num);
        num += 1;
    }

}
catch (Exception e) {
     Console.WriteLine("Error:" + e.ToString());     
}

