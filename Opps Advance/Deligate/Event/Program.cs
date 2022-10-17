using System;
namespace Event;
class Program
{
    public static void Main(string[] args)
    {
        Events event1 =new Events("Quizz");
        Events event2=new Events("Debugging");
        Events event3=new Events("Presentation");
        Events event4 =new Events("games");
        //event Registration by the management
        //Subscribe the events
        Events.eventlink+=new EventManager(event1.ShowEvent);
        Events.eventlink+=new EventManager(event2.ShowEvent);
        Events.eventlink+=new EventManager(event3.ShowEvent);
        Events.eventlink+=new EventManager(event4.ShowEvent);

        //Process Initialation
        Events.HandleEvent(); //Indirectly using a method
        
        //Unsubscribe from the event
        Events.eventlink-=new EventManager(event4.ShowEvent);
        Events.HandleEvent();

    }
}
