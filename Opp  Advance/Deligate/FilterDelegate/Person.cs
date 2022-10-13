using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterDelegates;
    public delegate bool FilterDelegate(Person p); //Our delegate
    public class Person
    {
        public string Name{get;set;}
        public int Age{get;set;}
    }
