using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public class TheatereDetailsClass
    {
        /// <summary>
        /// Used for Assigning a unique Id for theatre Id
        /// </summary>
        public static  int s_theatreId=301;
        public string TheatreId{get;set;}
        /// <summary>
        /// Used  for create a name for theatre id
        /// </summary>
        /// <value></value>
        public string TheatreName{get;set;}
        /// <summary>
        /// Used for Location of the theatre
        /// </summary>
        /// <value></value>
        public string TheatreLocation{get;set;}
        public TheatereDetailsClass(string theatreId,string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }  
        /// <summary>
        /// used for creating a files for Theatre Details
        /// </summary>
        /// <param name="data"></param>
        public TheatereDetailsClass (string data)
        {
            string[] values = data.Split(',');
            s_theatreId= int.Parse(values[0].Remove(0,3));
            TheatreId=values[1];
            TheatreName=values[2];
            TheatreLocation=values[3];
        }
    }
}