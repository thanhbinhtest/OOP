using System.Collections.Generic;

namespace StudentManagament
{
    internal interface IManagement<T>
    {
        public bool WriteDataToFile(List<T> listT);
        public bool Add(T template);
        public bool Update(T _class);
        public T? GetByID(string ID);
        public List<T>? GetAll();
        public bool Delete(string ID);
    }
}
