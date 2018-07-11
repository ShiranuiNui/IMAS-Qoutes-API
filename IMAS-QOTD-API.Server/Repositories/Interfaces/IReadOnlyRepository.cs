using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace IMAS_QOTD_API.Repository.Interface
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();
        T Get(int id);
        Task<T> GetAsync(int id);
        int Count();
    }
}