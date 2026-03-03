

namespace _01_Reflection
{
    public class ClienteProcessor : IProcessor<Cliente>, ILogger
    {
        public void Process(Cliente input)
        {
            Console.WriteLine($"Processing Cliente: {input}");
        }

        public static void GenericStaticProcess<TGeneric>(TGeneric input)
        {
            Console.WriteLine($"Ejecutando GenericStaticProcess {input}");
        }

        public void Log<T>(T input)
        {
            Console.WriteLine($"Ejecutando el metodo generico void LOG: {input}");
        }
    }
}
