
//Crear un diccionario

Dictionary<string,int> miDiccionario = new Dictionary<string,int>();

//Agregar elementos a un diccionario
miDiccionario.Add("Juan", 27);
miDiccionario.Add("Luz", 30);
miDiccionario.Add("Patrick", 40);
miDiccionario.Add("Claudia", 31);


//intentado agregar un elemento con un key repetido
//miDiccionario.Add("Juan", 30);
var sePuedeAgregarElemento = miDiccionario.TryAdd("Juan", 30);

if (!sePuedeAgregarElemento)
{
    Console.WriteLine("No se pudo agregar el elemento duplicado");
}

//Actualizar el valor de un elemento en el diccionario
miDiccionario["Juan"] = 50;

//Buscar elementos de un diccionario por el key y por el valor
Console.WriteLine($"Buscando un key Claudia: {miDiccionario.ContainsKey("Claudia")}");

//Buscar elementos de un diccionario por el key y por el valor
Console.WriteLine($"Buscando un key Claudia: {miDiccionario.ContainsValue(40)}");

//Eliminar un elemento de un diccionario
miDiccionario.Remove("Juan");

//Acceder a un elemento del diccionario
var valorPatrick =  miDiccionario["Patrick"];
Console.WriteLine(valorPatrick);

//Imprimir elementos

foreach (var item in miDiccionario)
{
    Console.WriteLine($"Nombre: {item.Key} - Edad: {item.Value}");
}