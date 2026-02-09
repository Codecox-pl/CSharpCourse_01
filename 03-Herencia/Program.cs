

using _01_Clases;
using _03_Herencia;

Libro lbr = new Libro("Corkyvel", "Carlos Esquivel", 225, 46.5m);

var lbrResultado = lbr.GetDescripcion();
Console.WriteLine(lbrResultado);

Revista rvst = new Revista("Corre", 10, 23.4m, "Patrick Luis");
var rvstResultado = rvst.GetDescripcion();
Console.WriteLine(rvstResultado);