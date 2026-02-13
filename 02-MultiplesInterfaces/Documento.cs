
using _02_MultiplesInterfaces;
using System.ComponentModel;

namespace _01_CreacionInterfaces
{
    public class Documento : IOperaciones, IMensajeria, INotifyPropertyChanged
    {
        private string nombre;

        public string DocumentoNombre 
        { 
          get { return nombre; } 
          set {  
                nombre = value;
                NotifyPropChanged("DocumentoNombre");
            }
        }

        public Documento(string s)
        {
            this.nombre = s;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropChanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


        public void Cargar()
        {
            Console.WriteLine("Este metodo es para cargar un documento");
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Enviar correo electronico por gmail");
        }

        public void EnviarMensajeTexto()
        {
            Console.WriteLine("Enviar mensaje de texto por celular");
        }

        public void Guardar()
        {
            Console.WriteLine("Este metodo es para guardar un documento");
        }

        public bool NecesitaGuardar()
        {
            return false;
        }

        public void RecibirMensaje()
        {
            Console.WriteLine("Recibir respuesta del usuario");
        }
    }
}
