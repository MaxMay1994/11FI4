using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack
{
    public class Stacker<T>
    {

        List<T> list = new List<T>();

        public bool IsEmpty()
        {
            return list.Any();
        }

        public void Push(T obj)
        {
            list.Add(obj);
        }

        public T Pop()
        {
            return list.First();
        } 


    }
}
