using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public enum BookingStatus{Default,booked,Cancelled}
    public class BookingDetailsClass
    {
       public static  int  s_bookingId=7001;
       public string BookingId{get;set;}
       public string UserId{get;}
       public string MovieId{get;}
       public string TheatreId{get;set;}
       public int SeatCount{get;set;}
       public double TotalAmount{get;set;}
       public BookingStatus BookingStatus{get;set;}
       public BookingDetailsClass(string userId,string theatreId,string movieId,int seatCount,double totalAmount,BookingStatus bookingStatus)
       {
        s_bookingId++;
        BookingId="BID"+s_bookingId;
        UserId=userId;
        MovieId=movieId;
        TheatreId=theatreId;
        SeatCount=seatCount;
        TotalAmount=totalAmount;
        BookingStatus=bookingStatus;
       }
       public BookingDetailsClass(string data)
       {
        string[] values = data.Split(',');
        s_bookingId = int.Parse(values[0].Remove(0,3));
        UserId=values[1];
        MovieId=values[2];
        TheatreId=values[3];
        SeatCount=int.Parse(values[4]);
        TotalAmount=double.Parse(values[5]);
        BookingStatus=Enum.Parse<BookingStatus>(values[6]);
       }
    }
}