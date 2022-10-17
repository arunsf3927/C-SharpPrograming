using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace OnlineMovieTicketBooking
{
    public partial class Files
    {
        public static void Create()
        {
            //MovieTicket Folder
           if(!Directory.Exists("MovieTicket"))
            {
                System.Console.WriteLine("Folder not Found So creating a folder");
                Directory.CreateDirectory("MovieTicket");
            }
            if(!File.Exists("MovieTicket/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicket/UserDetails.csv");
            }
             if(!File.Exists("MovieTicket/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicket/TheatreDetails.csv");
            }
            if(!File.Exists("MovieTicket/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicket/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicket/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicket/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieTicket/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("MovieTicket/BookingDetails.csv");
            }
            
            

        }
        public static void ReadFile()
        {
            string[] theatre =File.ReadAllLines("MovieTicket/TheatreDetails.csv");
            foreach(string data in theatre)
            {
                TheatereDetailsClass theatere1 = new TheatereDetailsClass(data);
                Program.theatreList.Add(theatere1);
            }
            string[] movie =File.ReadAllLines("MovieTicket/MovieDetails.csv");
            foreach(string data in movie)
            {
                MovieDetailsClass movie1 = new MovieDetailsClass(data);
                Program.movieList.Add(movie1);
            }
            
            string[] screening =File.ReadAllLines("MovieTicket/ScreeningDetails.csv");
            foreach(string data1 in screening)
            {
                ScreeningDetailsClass screening1 = new ScreeningDetailsClass (data1);
                Program.screeningList.Add(screening1);
            }
            string[] booking =File.ReadAllLines("MovieTicket/BookingDetails.csv");
            foreach(string data2 in booking)
            {
                BookingDetailsClass booking1 = new BookingDetailsClass (data2);
                Program.BookingList.Add(booking1);
            }
        }
        public static void WriteToFiles()
        {
            string [] theatre = new string[Program.theatreList.Count];
            for(int i=0;i<Program.theatreList.Count;i++)
            {
                theatre[i]=Program.theatreList[i].TheatreId+","+Program.theatreList[i].TheatreName+","+Program.theatreList[i].TheatreLocation;
            }
                File.WriteAllLines("MovieTicket/MovieDetails.csv",theatre);
            string [] movie = new string[Program.movieList.Count];
            for(int i=0;i<Program.movieList.Count;i++)
            {
                movie[i]=Program.movieList[i].MovieId+","+Program.movieList[i].MovieName+","+Program.movieList[i].Language;
            }
                File.WriteAllLines("MovieTicket/MovieDetails.csv",movie);
            string[] screening = new string[Program.screeningList.Count];
            for (int i=0; i<Program.screeningList.Count;i++)
            {
                screening[i]=Program.screeningList[i].MovieId+","+Program.screeningList[i].TheatreId+","+Program.screeningList[i].TicketPrice+","+Program.screeningList[i].NoOfSeatsAvailable;
            }
               File.WriteAllLines("MovieTicket/MovieDetails.csv",screening);

            string[] booking=new string[Program.BookingList.Count];
            for(int i=0;i<Program.BookingList.Count;i++)
            {
                booking[i]=Program.BookingList[i].BookingId+","+Program.BookingList[i].UserId+","+Program.BookingList[i].MovieId+","+Program.BookingList[i].TheatreId+","+Program.BookingList[i].SeatCount+","+Program.BookingList[i].TotalAmount+","+Program.BookingList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicket/BookingDetails.csv",booking);
        }
    }

}