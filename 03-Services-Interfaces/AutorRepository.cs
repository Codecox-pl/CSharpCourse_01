
namespace _03_Services_Interfaces
{
    public class AutorRepository : IRepository<Autor>
    {
        private NombreCompleto[] _nombres = new NombreCompleto[10];

        public AutorRepository()
        {
            _nombres[0] = new ("Patrick", "Luis");
            _nombres[1] = new ("Claudia", "Ruiz");
            _nombres[2] = new ("Camilo", "Flores");
            _nombres[3] = new ("Valentina", "Quispe");
            _nombres[4] = new ("Zoro", "Montezco");
            _nombres[5] = new ("Sanji", "Aguero");
            _nombres[6] = new ("Luffy", "Ramirez");
            _nombres[7] = new ("Luffy", "Ramirez");
            _nombres[8] = new ("Luffy", "Ramirez");
            _nombres[9] = new ("Luffy", "Ramirez");
        }

        public IEnumerable<Autor> List()
        {
            int index = 0;

            while(index < _nombres.Length)
            {
                yield return new Autor(_nombres[index].Nombre, _nombres[index].Apellido);
                index++;
            }
        }
    }
}
