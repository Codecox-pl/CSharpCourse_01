
namespace _03_Services_Interfaces
{
    public class AutorRepository : IAutorRepository
    {
        public Autor[] List()
        {
            var autores = new Autor[10];

            autores[0] = new Autor("Patrick", "Luis");
            autores[1] = new Autor("Claudia", "Ruiz");
            autores[2] = new Autor("Camilo", "Flores");
            autores[3] = new Autor("Valentina", "Quispe");
            autores[4] = new Autor("Zoro", "Montezco");
            autores[5] = new Autor("Sanji", "Aguero");
            autores[6] = new Autor("Luffy", "Ramirez");
            autores[7] = new Autor("Luffy", "Ramirez");
            autores[8] = new Autor("Luffy", "Ramirez");
            autores[9] = new Autor("Luffy", "Ramirez");

            return autores;
        }
    }
}
