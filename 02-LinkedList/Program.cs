
string[] canciones =
{
    "Wake Up!",
    "Beatiful Colors",
    "We are!",
    "Take Top!!",
    "Golden",
    "YES OR YES"
};


// Creando un LinkedList
LinkedList<String> cancionesLinkedList = new LinkedList<String>(canciones);

//Agregando elementos al inicio y al final de la lista
cancionesLinkedList.AddFirst("Mi primera Cancion");
cancionesLinkedList.AddLast("Mi ultima cancion");



//Buscando el primero y el ultimo elementos de la lista
LinkedListNode<string> primeraCancion = cancionesLinkedList.First!;
LinkedListNode<string> ultimaCancion = cancionesLinkedList.Last!;

Console.WriteLine($"La primera cancion: {primeraCancion.Value} y la ultima cancion: {ultimaCancion.Value}");


//Los elementos pueden ser agregados o removidos dependiendo de un elemento existente
cancionesLinkedList.AddAfter(primeraCancion, "Mi segunda cancion");



//imprimir elementos de la lista

foreach (string str in cancionesLinkedList)
{
    Console.WriteLine(str);
}

//Buscar elementos utilizando el metodo Contains
Console.WriteLine($"Existe la cancion Wake Up! : {cancionesLinkedList.Contains("Wake Up!")}");

//Acceder a la data utilizando los metodos siguiente(Next) y Anterior](Previous)
Console.WriteLine($"La cancion que continua despues de la primera cancion: {primeraCancion.Next!.Value}");