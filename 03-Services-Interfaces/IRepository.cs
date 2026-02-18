
namespace _03_Services_Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
    }
}
