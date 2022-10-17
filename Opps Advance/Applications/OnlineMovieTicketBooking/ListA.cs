using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public  partial class List<Type>:IEnumerable,IEnumerator
    {
        private int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator) this;
        
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                i++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Reset()
        {
            i=-1;
        }
        public object current
        {
            get{return Array[i];}
        }
        public void RemoveAt(int index)
        {
            for(int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
            }
        }
        
    }
}