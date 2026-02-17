

namespace _03_Services_Interfaces
{
    public class EstudiantePrinterService
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudiantePrinterService(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void Prinautores()
        {
           var autores =  _estudianteRepository.List();
            Array.Sort(autores);

            Console.WriteLine("Imprimiendo Lista de autores desde el metodo Printautores");

            for (int i = 0; i < autores.Length; i++)
            {
                Console.WriteLine(autores[i]);
            }
        }
    }
}
