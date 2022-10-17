using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    class Operation
    {
       public static void Main(string[] args)
       {
        Files.Create();
        Files.ReadFile();
        Program.Mainmenu();
        Files.WriteToFiles();
       }
    }
}