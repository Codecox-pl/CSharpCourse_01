
using System.Reflection;

namespace _01_Reflection
{
    public class ReflectionEjemplo
    {
        private static void ListGenericMethods(Type type)
        {
            var metodos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine($"Metodos son del tipo {type.Name}");

            Console.WriteLine("Nombre     |IsGeneric     |IsGenericDefinition      |ContainsGenParam");
            int colWidth = 12;

            foreach ( MethodInfo mi in metodos ) 
            {
                int masNombreLength = Math.Min(mi.Name.Length, colWidth);
                Console.Write(mi.Name.Substring(0, masNombreLength).PadRight(colWidth));
                Console.Write("|");
                Console.Write(mi.IsGenericMethod.ToString().PadRight(colWidth));
                Console.Write('|');
                Console.Write(mi.IsGenericMethodDefinition.ToString().PadRight(colWidth));
                Console.Write('|');
                Console.WriteLine(mi.ContainsGenericParameters.ToString().PadRight(colWidth));
            }

            Console.WriteLine();
        }

        private static void ListTypeDetails(List<Type> types)
        {
            Console.WriteLine("Type Nombre".PadRight(20) + "|" + "IsGenericType?".PadRight(20)
                + "|" + "IsGenericDefinition?".PadRight(20)
                );
            foreach (var type in types)
            {
                string output = type.Name.PadRight(20) + "|";
                output += type.IsGenericType.ToString().PadRight(20) + "|";
                output += type.IsGenericTypeDefinition;

                ListGenericMethods(type);
                Console.WriteLine(output);
            }
        }
        public static void execute()
        {

            var types = new List<Type>
            {
                typeof(IProcessor<>),
                typeof(IProcessor<Cliente>),
                typeof(Processor<>),
                typeof(Processor<Cliente>),
                typeof(ClienteProcessor)
            };

            ListTypeDetails(types);

            //var openInterface = typeof(IProcessor<>);
            //Console.WriteLine($"El IProcessor es genero? {openInterface.IsGenericType}");

            //Console.WriteLine($"El IProcessor su definicion es generica? {openInterface.IsGenericTypeDefinition}");

            //var closeInterface = typeof(IProcessor<Cliente>);
            //Console.WriteLine($"El IProcessor<Cliente es generico? {closeInterface.IsGenericType}");

            //Console.WriteLine($"El IProcessor<Cliente> su definicion es generica? {closeInterface.IsGenericTypeDefinition}");

            //var definition = closeInterface.GetGenericTypeDefinition();

            //var resultado = definition == openInterface;
            //Console.WriteLine($"El resultado de las definiciones es: {resultado}");
        }
    }
}
