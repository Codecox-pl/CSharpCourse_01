
namespace _03_Services_Interfaces
{
    public class AutorPrinterService
    {
        private readonly IAutorRepository _repository;

        public AutorPrinterService(IAutorRepository repository)
        {
            _repository = repository;
        }

        public void PrintAutores()
        {
            var autores = _repository.List();
            Array.Sort(autores);

            Console.WriteLine("Imprimiendo Lista de autores desde el metodo Printautores");

            for (int i = 0; i < autores.Length; i++)
            {
                Console.WriteLine(autores[i]);
            }
        }
    }
}
