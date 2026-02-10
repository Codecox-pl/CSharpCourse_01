//Crear un stack collection

Stack<string> miStack = new Stack<string>();

//Insertar elementos al stack
miStack.Push("uno");
miStack.Push("dos");
miStack.Push("tres");
miStack.Push("cuatro");
miStack.Push("cinco");
miStack.Push("seis");
miStack.Push("siete");



//Buscar al primer elementos
string top = miStack.Peek();

Console.WriteLine($"Este es mi primer elemento: {top}");

//Remover eliminar un elemento
string elementoParEliminar = miStack.Pop();
Console.WriteLine($"Este elemento a sido eliminado: {elementoParEliminar}");


//Imprimir elementos

foreach (string s in miStack)
{
    Console.WriteLine(s);
}

//Buscamos elementos con el Contains
var existeElemento = miStack.Contains("cinco");
Console.WriteLine($"Existe el elemento en la coleccion?:{existeElemento} ");
