
namespace _04_Constraints_Genericos
{
    public interface IRepository<T> where T: Persona,IComparable<T>
    {
        IEnumerable<T> List();
        IEnumerable<T> OrdenarList();
    }
}
