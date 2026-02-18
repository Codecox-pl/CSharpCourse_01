

using _01_DiseñoObjetos;
using _03_Services_Interfaces;

var autoreservice = new AutorPrinterService(new AutorRepository());

autoreservice.PrintAutores(5);


Console.WriteLine($"Total de autores {Autor.AutorCount}");




