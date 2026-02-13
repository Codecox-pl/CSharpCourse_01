

using _01_CreacionEvento;
using _02_EventosDotNet;

var obj = new EventPublisher();

obj.miEvento += delegate (object sender, MiEventoArgs e)
{
    Console.WriteLine($"{sender.GetType} la propiedad de cambio es {e.data}");
};

string str;

do
{
    Console.WriteLine("Ingrese un valor");
    str = Console.ReadLine()!;

    if (!str.Equals("salir"))
    {
        obj.Val = str;
    }

} while (!str.Equals("salir"));