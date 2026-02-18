
namespace _03_Services_Interfaces
{
    public class AutorPrinterService
    {
        private readonly IRepository<Autor> _repository;

        public AutorPrinterService(IRepository<Autor> repository)
        {
            _repository = repository;
        }

        public void PrintAutores(int max = 100)
        {
            var autores = _repository.List().Take(max).ToArray();
            //Array.Sort(autores);

            //Console.WriteLine("Imprimiendo Lista de autores desde el metodo Printautores");

            //for (int i = 0; i < autores.Length; i++)
            //{
            //    Console.WriteLine(autores[i]);
            //}
            PrintAutoresConsola(autores);
        }

        private void PrintAutoresConsola(IEnumerable<Autor> autores)
        {
            Console.WriteLine("Autores: ");

            foreach (var autor in autores)
            {
                Console.WriteLine(autor);
            }
        }
    }
}
