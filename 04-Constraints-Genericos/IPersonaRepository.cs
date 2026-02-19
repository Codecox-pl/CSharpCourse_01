

namespace _04_Constraints_Genericos
{
    public interface IPersonaRepository<T> : IRepository<T> where T : Persona, IComparable<T>, new()
    {
        IEnumerable<T> Buscar(string nombre);
        T Crear(NombreCompleto nombre);

        T CrearPorDefecto();
    }

    //public interface IPersonaRepository
    //{
    //    IEnumerable<T> Buscar<T>(string nombre) where T : Persona;

    //    T Crear<T>(NombreCompleto nombre) where T : Persona;

    //    T CrearPorDefecto<T>() where T: Persona;
    //}
}
