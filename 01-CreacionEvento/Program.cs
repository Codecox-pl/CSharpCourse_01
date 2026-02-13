
using _01_CreacionEvento;

var obj = new EventPublisher();
obj.valueChanged += delegate (string value)
{
    Console.WriteLine($"El valor de la propiedad cambio {value}");
};
//obj.valueChanged += Obj_valueChanged;

//void Obj_valueChanged(string value)
//{
//    Console.WriteLine($"El valor de la propiedad cambio {value}");
//}

string str;

do
{
    Console.WriteLine("Ingrese un valor");
    str = Console.ReadLine()!;

    if(!str.Equals("salir"))
    {
        obj.Val = str;
    }

} while (!str.Equals("salir"));


Console.WriteLine("Culmino el programa porque escribio salir");

public delegate void MiEventoHandler(string value);