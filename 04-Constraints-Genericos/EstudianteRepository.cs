

namespace _04_Constraints_Genericos
{
    public class EstudianteRepository : IPersonaRepository<Estudiante>
    {
        public IEnumerable<Estudiante> Buscar(string nombre)
        {
            return List().Where( x => x.Nombre!.Contains(nombre) || x.Apellido!.Contains(nombre));
        }

        public Estudiante Crear(NombreCompleto nombre)
        {
            return new Estudiante(nombre.Nombre,nombre.Apellido);
        }

        public Estudiante CrearPorDefecto()
        {
            return new Estudiante();
        }

        public IEnumerable<Estudiante> List()
        {
            var autores = new Estudiante[10];

            autores[0] = new Estudiante("Patrick", "Luis");
            autores[1] = new Estudiante("Claudia", "Ruiz");
            autores[2] = new Estudiante("Camilo", "Flores");
            autores[3] = new Estudiante("Valentina", "Quispe");
            autores[4] = new Estudiante("Zoro", "Montezco");
            autores[5] = new Estudiante("Sanji", "Aguero");
            autores[6] = new Estudiante("Luffy", "Ramirez");
            autores[7] = new Estudiante("Luffy", "Ramirez");
            autores[8] = new Estudiante("Luffy", "Ramirez");
            autores[9] = new Estudiante("Luffy", "Ramirez");

            return autores;
        }

        public IEnumerable<Estudiante> OrdenarList()
        {
            var estudiantes = List().ToList();
            estudiantes.Sort();
            return estudiantes;
        }
    }
}
