
using _01_Creacion;

var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;

Console.WriteLine($"El resultado es {f(10, 100)}");

f = objeto.func2;

Console.WriteLine($"El resultado es {f(5,10)}");

var objeto2 = new Miclase();
f = objeto2.InstanciaDeMetodo;

Console.WriteLine($"El resultado del objeto 2 es {f(20, 50)}");

public delegate string MiDelegate(int arg1, int arg2);


