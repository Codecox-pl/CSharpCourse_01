

using _01_DiseñoObjetos;

namespace _03_Services_Interfaces
{
    public class EstudianteRepository : IRepository<Estudiante>
    {
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


    }
}
