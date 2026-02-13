

using _01_CreacionInterfaces;
using System.ComponentModel;

var documento = new Documento("Patrick");

documento.EnviarEmail();
documento.EnviarMensajeTexto();
documento.RecibirMensaje();

documento.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($" La propiedad del documento que cambio es {e.PropertyName}");
};


documento.DocumentoNombre = "Claudia";