namespace BlazorApp1.Services
{
    public interface IServices<T>
    {
        List<T> GetAll();
        T GetByID(int id);
        void Insert(T obj);
        void Edit(int id,T obj);
        void Delete(int id);

    }
}
