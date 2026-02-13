

using _01_CreacionInterfaces;

var documento = new Documento("Patrick");

if(documento is IOperaciones)
{
    documento.Cargar();
}

IOperaciones operaciones =   documento as IOperaciones;

if (operaciones is not null)
{ 
   operaciones.Guardar();
}