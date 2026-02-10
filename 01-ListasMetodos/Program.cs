
string[] personas = { "Patrick Luis Muñoz", "Claudia", "Jaime", "Luz","Kirito"};
//

//List Collection - Creacion
List<string> listaPersonas = new List<string>();

//Agregar data al list desde un array string[]
listaPersonas.AddRange(personas);

//Agregar un elemento a la lista
listaPersonas.Add("Carlos");

//Calcular la cantidad de la lista
listaPersonas.Count();

//Consultar un elemento de la lista

Console.WriteLine(listaPersonas[0]);

//Elimina un elemento a la lista
//listaPersonas.RemoveAt(3);
//listaPersonas.Remove("Kirito");

//Ordenando Alfabeticamente
listaPersonas.Sort();


//Metodo para imprimir todos los elementos de la lista
void listaElementos(List<string> lista)
{
    int cont = 0;
    foreach (var item in lista)
    {
        Console.WriteLine($"{cont + 1}- {item}");
        cont++;
    }
}

listaElementos(listaPersonas);

//Metodo para saber si existe un elemento en la lista
Console.WriteLine($"Existe Patrick en la lista {listaPersonas.Contains("Patrick")}");

//Busque aquellos nombres en la lista que tengan más de 10 caracteres
var result = listaPersonas.Exists(x => x.Length > 10);

Console.WriteLine($"Existe un nombre de más de 10 caracteres?: {result}");

//Busqueda de un nombre que comience con la letra V
var elementoConC = listaPersonas.Find(x => x.StartsWith("C"));
Console.WriteLine($"El nombre que comience con la letra C es: {elementoConC}");