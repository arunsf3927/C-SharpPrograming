using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public class MovieDetailsClass
    {
        public static int s_movieId=1001;
        public string MovieId{get;}
        public string MovieName{get;set;}
        public string Language{get;set;}
        public MovieDetailsClass(string movieId, string movieName,string language)
        {
            s_movieId++;
            MovieId="MID"+s_movieId;
            MovieName=movieName;
            Language=language;
        }
        public MovieDetailsClass(string data)
        {
            string[] values = data.Split(',');
            s_movieId=int.Parse(values[0].Remove(0,3));
            MovieId=values[1];
            MovieName=values[2];
            Language=values[3];
        }
    }
}