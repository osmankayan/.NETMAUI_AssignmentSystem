using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE33.DataTransActions
{
    public interface IBaseRepository<T> : IDisposable
    {
        List<T> GetAll();
        void Add(T item);
        void Delete(T item);
    }
}
