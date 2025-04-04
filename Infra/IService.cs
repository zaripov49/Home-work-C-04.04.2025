namespace Infra;

public interface IService<T>
{
    void Create(T item);
    List<T> GetAll();
    T GetById(int id);
    T GetByName(string name);
    List<T> GetByDate(DateTime date);
    void Delete(int id);
}
