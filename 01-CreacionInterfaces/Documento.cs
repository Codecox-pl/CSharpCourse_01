
namespace _01_CreacionInterfaces
{
    public class Documento : IOperaciones
    {
        private string nombre;

        public Documento(string s)
        {
            this.nombre = s;
        }

        public void Cargar()
        {
            Console.WriteLine("Este metodo es para cargar un documento");
        }

        public void Guardar()
        {
            Console.WriteLine("Este metodo es para guardar un documento");
        }

        public bool NecesitaGuardar()
        {
            return false;
        }
    }
}
