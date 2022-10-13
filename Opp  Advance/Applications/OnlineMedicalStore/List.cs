using System;
namespace OnlineMedicalStore
{
    public partial class List<Type>
    {
       private Type[] Array{get;set;} 
       private int _count;
       private int _capacity;
       public int Count{get{return _count;}} //do not use set because  do not modify
       public int Capacity{get{return _capacity;}} //do not use set because  do not modify
       public Type this[int i] //Indexer used for access Object Array
    {
        get{return Array[i];}
        set {Array[i]=value;}
    }
    
    //creating constructor of the class that initiazlize the values
    public List()
    {
        _count=0;
        _capacity=4;
        Array =new Type[_capacity];

    }
    public List(int size)
    {
        _count =0;
        _capacity=size;
        Array=new Type[_capacity];
    }
    //creating a function that appends an element at the end of the array
    public void Add(Type data)
    {
        if(_count==_capacity)
        {
        GrowSize();
        }
        Array[_count]=data;
        _count++;
    }
    public void GrowSize()
    {
        _capacity=_capacity*2;
        Type[] Array2=new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            Array2[i]=Array[i];
        }
        Array=Array2;
    }
}
}