using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public class ScreeningDetailsClass
    {
        /// <summary>
        /// used for Number of Details 
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable{get;set;}
        /// <summary>
        /// for ticketprice 
        /// </summary>
        /// <value></value>
        public double TicketPrice{get;set;}
        /// <summary>
        /// used to indentify the movieId
        /// </summary>
        /// <value></value>
        public string MovieId{get;}
        /// <summary>
        /// used to find the theatre Id
        /// </summary>
        /// <value></value>
        public string TheatreId{get;}
        public ScreeningDetailsClass(string movieId, string theatreId, int noOfSeatsAvailable, double ticketPrice )
        {
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetailsClass(String data)
        {
            string[] values = data.Split(',');
            NoOfSeatsAvailable=int.Parse(values[0].Remove(0,3));
            TicketPrice=double.Parse(values[1]);
        }
    }
}