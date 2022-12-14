using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public partial class List<Type>
    {
        private Type[] Array{get;set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity {get{return _capacity;}}   
    public Type this[int i]
    {
        get {return Array[i];}
        set{Array[i]=value;}  
    }
    public List()
    {
        _count =0;
        _capacity=4;
        Array =new Type[_capacity];
    }
    public List(int size)
    {
        _count =0;
        _capacity=size;
        Array =new Type[_capacity];
    }
    public void Add(Type data)
    {
        if(_capacity==_count)
        {
        Growsize();
        }
        else
        {
            Array[_count]=data;
        }
    }
    public void Growsize()
    {
        _capacity=_capacity*2;
        Type[] Aarray2 = new Type[_capacity];
        for(int i=0;i<_capacity;i++)
        {
            Aarray2[i]=Array[i];
        }
        Array=Aarray2;
    }
    }
    
}