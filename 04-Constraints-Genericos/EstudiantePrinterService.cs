



namespace _04_Constraints_Genericos
{
    public class EstudiantePrinterService
    {
        private readonly IRepository<Estudiante> _estudianteRepository;

        public EstudiantePrinterService(IRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void Prinautores()
        {
           var autores =  _estudianteRepository.List().ToArray();
            Array.Sort(autores);

            Console.WriteLine("Imprimiendo Lista de autores desde el metodo Printautores");

            for (int i = 0; i < autores.Length; i++)
            {
                Console.WriteLine(autores[i]);
            }
        }
    }
}
