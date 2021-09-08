using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class BookList
    {
        public void Add(BookList book)
        {
            throw new NotImplementedException();
        }

        public BookList this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public class GenericList<T>
        {
            public void Add(T value)
            {  
            
            }

            public T this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        }
    }
}
