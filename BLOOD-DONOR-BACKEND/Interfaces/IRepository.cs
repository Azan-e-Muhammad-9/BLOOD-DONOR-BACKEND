namespace BLOOD_DONOR_BACKEND.Interfaces
{
    public interface IRepository<T>
    {


        Task<T> GetByID(Guid id);
        Task<List<T>> GetAll();

        Task<bool> Add(T entity);

        Task<bool> Update(Guid id, T entity);
        Task<bool> Delete(Guid id);

    }

}
