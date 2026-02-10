
//Crear Queue Collection

Queue<string> miQueue = new Queue<string>();

//agregar elementos
miQueue.Enqueue("1");
miQueue.Enqueue("2");
miQueue.Enqueue("3");
miQueue.Enqueue("4");
miQueue.Enqueue("5");


//Buscar al primer elementos del queue

var miPrimerElemento = miQueue.Peek();
Console.WriteLine($"Mi primero elemento: {miPrimerElemento}");

//Eliminar elemento del queue
string elementoParaEliminar = miQueue.Dequeue();
Console.WriteLine($"Se elimino el elemento: {elementoParaEliminar}");


//Utilizando foreach
foreach (var item in miQueue)
{
    Console.WriteLine(item);
}

//Buscar elemento con el Contains
var existeElemento = miQueue.Contains("4");
Console.WriteLine($"Existe el elemento cuatro en la lista?: {existeElemento}");