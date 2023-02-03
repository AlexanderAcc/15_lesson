using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_class
{
    internal class Class1<T>
    {
        public T local; // Переменная с T типом

        public Class1(T inp) // Конструктор
        {
            local = inp; // Присваивание переменной  
        }
    }
}
