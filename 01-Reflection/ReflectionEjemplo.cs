
using System.Reflection;

namespace _01_Reflection
{
    public class ReflectionEjemplo
    {
        private static void ListGenericMethods(Type type)
        {
            var metodos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(m => m.DeclaringType!.Name != "Object");
            Console.WriteLine($"Metodos son del tipo {type.Name}");

            Console.WriteLine("Nombre     |IsGeneric     |IsGenericDefinition      |ContainsGenParam");
            int colWidth = 12;

            foreach ( var mi in metodos ) 
            {
                int masNombreLength = Math.Min(mi.Name.Length, colWidth);
                Console.Write(mi.Name.Substring(0, masNombreLength).PadRight(colWidth));
                Console.Write("|");
                Console.Write(mi.IsGenericMethod.ToString().PadRight(colWidth));
                Console.Write('|');
                Console.Write(mi.IsGenericMethodDefinition.ToString().PadRight(colWidth));
                Console.Write('|');
                Console.WriteLine(mi.ContainsGenericParameters.ToString().PadRight(colWidth));

                if(mi.IsGenericMethod)
                {
                    Console.WriteLine("Ejecutando un metodo generico..");
                    var parametros = mi.GetGenericArguments();

                    foreach(var parametro in parametros)
                    {
                        if(parametro.IsGenericParameter)
                        {
                            Console.WriteLine($"parametro generico: {parametro.GenericParameterPosition}  {parametro.Name}");
                        }
                    }
                    MethodInfo genericMethod = mi.MakeGenericMethod(typeof(Cliente));

                    object? instancia = null;
                    if(!genericMethod.IsStatic)
                    {
                        instancia = Activator.CreateInstance(type)!;
                    }

                    
                    genericMethod.Invoke(instancia, new[] { new Cliente("Patrick", "Luis") });
                }
            }

            Console.WriteLine();
        }

        private static void ListTypeDetails(List<Type> types)
        {
            Console.WriteLine("Type Nombre".PadRight(20) + "|" + "IsGenericType?".PadRight(20)
                + "|" + "IsGenericDefinition?".PadRight(20) + "|" + "Generic Arguments"
                );
            foreach (var type in types)
            {
                string output = type.Name.PadRight(20) + "|";
                output += type.IsGenericType.ToString().PadRight(20) + "|";
                output += type.IsGenericTypeDefinition + "|";
                output += type.GetGenericArguments().Count();

                //ListGenericMethods(type);
                Console.WriteLine(output);
                ListParameterDetails(type);
            }
        }

        private static void ListParameterDetails(Type type)
        {
           var parameters = type.GetGenericArguments();

            foreach (var parameter in parameters)
            {
               if(parameter.IsGenericParameter)
                {
                    DisplayGenericParameter(parameter);
                }
                else
                {
                    DisplayTypeArgument(parameter);
                }
            }
        }

        private static void DisplayGenericParameter(Type parameter)
        {
            var constraints = parameter.GetGenericParameterConstraints();
            Console.WriteLine($"Type Parameter position: {parameter.GenericParameterPosition}" +
                $"nombre: {parameter.Name}" +
                $"contraints: {constraints.Length}" +
                $"attributeMask: {parameter.GenericParameterAttributes}");

            if(constraints.Any())
            {
                Console.WriteLine("  Nombre   |   Interface?  |     Class?   |  Enum? ");
                foreach (var constraint in constraints)
                {
                    Console.WriteLine("   " + constraint.Name.PadRight(16) + "|" +
                        constraint.IsInterface.ToString().PadRight(11) + "|" +
                        constraint.IsClass.ToString().PadRight(7) + "|" +
                        constraint.IsEnum.ToString().PadRight(6));
                }
            }
        }

        private static void DisplayTypeArgument(Type parameter)
        {
            Console.WriteLine($"Type Argument: {parameter.Name}");
        }

        public static void execute()
        {

            var types = new List<Type>
            {
                //typeof(IProcessor<>),
                //typeof(IProcessor<Cliente>),
                //typeof(Processor<>),
                //typeof(Processor<Cliente>),
                //typeof(ClienteProcessor)
                typeof(IPipeline<,>)
            };

            ListTypeDetails(types);

            Type[] typeArguments = { typeof(Request), typeof(Response) };

            var specificType = typeof(Pipeline<,>).MakeGenericType(typeArguments);
            var crearInstancia = Activator.CreateInstance(specificType);

            ListTypeDetails(new List<Type> { crearInstancia!.GetType() });

            

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
