using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack
{
    public class Stacker
    {

        ArrayList list = new ArrayList();

        public bool IsEmpty()
        {
            return (list.Count == 0);
        }

        public void Push(Object obj)
        {
            list.Add(obj);
        }

        public Object Pop()
        {

            if (!IsEmpty())
            { 
            Object obj = list[(list.Count - 1)];
            list.Remove(obj);
            return obj;
            }
            else
            {
                return null;
            }
        } 

        public Object Top()
        {
            if (!IsEmpty())
            {
                Object obj = list[(list.Count - 1)];
                return obj;
            }
            else
            {
                return null;
            }
        }


    }
}
