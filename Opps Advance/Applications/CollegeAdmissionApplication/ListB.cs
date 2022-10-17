using System;
using System.Collections;

namespace CollegeAdmissionApplication
{
    // method Used For foreach Accesing
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        private int i;   
        public IEnumerator GetEnumerator()
        {
            i =-1;
            return(IEnumerator)this;
        }   
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;
            }
            Reset();//Reset position value if no element in list
            return false;
        }  
        public void Reset()//Rests i for next turn
        {
            i=-1;
        }
        public object Current
        {
            get{return Array[i];}
        }
    }
}