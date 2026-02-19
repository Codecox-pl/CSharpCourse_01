

namespace _01_Reflection
{
    public class ClienteProcessor : IProcessor<Cliente>
    {
        public void Process(Cliente input)
        {
            Console.WriteLine($"Processing Cliente: {input}");
        }
    }
}
