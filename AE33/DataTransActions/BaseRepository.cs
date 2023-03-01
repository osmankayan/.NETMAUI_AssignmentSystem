using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE33.DataTransActions
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        SQLiteConnection conn;
        public BaseRepository()
        {
            conn = new SQLiteConnection(Constants.DBPath);
            conn.CreateTable<T>();
        }
        public void Add(T item)
        {
            conn.Insert(item);
        }

        public void Delete(T item)
        {
            conn.Delete(item);
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<T> GetAll()
        {
            return conn.Table<T>().ToList();
        }
        //public void DeleteDb(T t)
        //{
        //    conn.Execute($"DELETE FROM {t}");
        //}
    }
}
