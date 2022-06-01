using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Infraestructures
{
     public interface Imodel<T>
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        List<T> GetAll();
    }
}
