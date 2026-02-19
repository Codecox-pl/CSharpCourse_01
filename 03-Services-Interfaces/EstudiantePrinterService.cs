
namespace _04_Constraints_Genericos
{
    public class EstudiantePrinterService
    {
        private readonly IPersonaRepository<Estudiante> _estudianteRepository;

        public EstudiantePrinterService(IPersonaRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void PrintEstudiantes(int max = 100)
        {
            //var autores =  _estudianteRepository.List().ToArray();
            // Array.Sort(autores);

            // Console.WriteLine("Imprimiendo Lista de autores desde el metodo Printautores");

            // for (int i = 0; i < autores.Length; i++)
            // {
            //     Console.WriteLine(autores[i]);
            // }
            var estudiantes = _estudianteRepository.OrdenarList().Take(max).ToArray();

            PrintAutoresConsola(estudiantes);

            var estudiantesBuscados = _estudianteRepository.Buscar("Luis");
            PrintEstudiantesBuscados(estudiantesBuscados);
        }

        private void PrintAutoresConsola(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes: ");

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }

        private void PrintEstudiantesBuscados(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes: ");

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }
    }
}
