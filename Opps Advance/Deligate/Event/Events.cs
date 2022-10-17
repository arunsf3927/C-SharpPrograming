using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager(); //User Defined deligate
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;//User Defined Event    //eventlink is an Object
        static int i;
    public Events(string eventName)
    {
        _eventName=eventName;
    }
    public static void HandleEvent() //Event trigerring method
    {
        i=0;
        System.Console.WriteLine("User Registration");
        System.Console.WriteLine("Strating the Following events");
        eventlink();
    }
    public void ShowEvent()
    {
        ++i;
        System.Console.WriteLine("Event Number :"+i+" is :"+_eventName+"Started");
    }
    }
    
}