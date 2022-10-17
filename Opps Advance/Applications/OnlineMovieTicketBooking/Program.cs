using System;
using System.Collections.Generic;
namespace OnlineMovieTicketBooking;

public class Program
{
    //PersonalList
     public static List<PersonalDetailsClass> personalList=new List<PersonalDetailsClass>();
     //UserList
     public static List<UserDetailsClass> userList=new List<UserDetailsClass>();

     //BookingList
     public static List<BookingDetailsClass> BookingList= new List<BookingDetailsClass>();
    
     //Theatre details List
     public static List<TheatereDetailsClass> theatreList=new List<TheatereDetailsClass>();

     //Movie Details List
     public static List<MovieDetailsClass> movieList=new List<MovieDetailsClass>();

     //Screening Details List
     public static List<ScreeningDetailsClass> screeningList=new List<ScreeningDetailsClass>();
     //nullable value for current User
     public static UserDetailsClass currentuser=null;
     public static BookingDetailsClass cuurentBooking=null;


     //mainfunction
    public static void Mainmenu()
    {
        AddDefaultValues();
        System.Console.WriteLine("****Welcome to OnlineTicket Booking******"); 
        //doloop 
        string choice="yes";
        do
        {
        System.Console.WriteLine("*****Welcome To Mainmenu******\n Select an Option \n1.UserRegistration \n2.UserLogin \n3.Exit");
        int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("****Welcome to the UserRegistration Folder*****");
                    //UserRegistration method
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("*****Welcome to the User Login Folder*****");
                    //User Login Method
                    UserLogin();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("******Selected Exit Folder*****");
                    break;
                }   
            }  
        } 
        while(choice=="yes"); 
    }
     //UserRegistrationMethod  
     public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your Name");
            //UserName
            string name=Console.ReadLine();

            System.Console.WriteLine("Enter your Age");
            //UserAge
            int age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("User PhoneNumber");
            //User PhoneNumber
            long phoneNumber=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter User WalletBalance");
            //User WalletBalance
            double walletBalance=double.Parse(Console.ReadLine());
            PersonalDetailsClass object1=new PersonalDetailsClass(currentuser.Name,currentuser.Age,currentuser.PhoneNumber);
            personalList.Add(object1);
            //System.Console.WriteLine(currentuser.Name,currentuser.Age,currentuser.PhoneNumber);
            //System.Console.WriteLine("UserId "+currentuser.UserId);
            
        }
    public  static void UserLogin()
    {
        System.Console.WriteLine("Enter your UserId");
        string userId1=Console.ReadLine();
        foreach(UserDetailsClass user in userList)
        {
             //geting userid as input
        //checking the userId
        if(userId1==user.UserId)
        {
            System.Console.WriteLine("User Id matched & Succesfully Logined");
            //SubmenuCalling
            SubMenu();
        }
        else
        {
            System.Console.WriteLine("Invalid UserId");
        }
        }
    }
    public static void AddDefaultValues()
    {
        //UserDetails Default values
        UserDetailsClass objectA1=new UserDetailsClass("Ravichandran",30,8599488003,"UID1001",1000);
        UserDetailsClass objectA2=new UserDetailsClass("Baskaran",30,9857747327,"UID1002",2000);
        userList.Add(objectA1);
        userList.Add(objectA2);

        //Booking details Default Values
        BookingDetailsClass objectB1=new BookingDetailsClass("UID1001","TID301","MID501",1,200,BookingStatus.booked);
        BookingDetailsClass objectB2=new BookingDetailsClass("UID1002","TID302","MID502",1,400,BookingStatus.booked);
        BookingDetailsClass objectB3=new BookingDetailsClass("UID1003","TID303","MID503",1,300,BookingStatus.booked);
        BookingList.Add(objectB1);
        BookingList.Add(objectB2);
        BookingList.Add(objectB3);

        //Default Theatre Details
        TheatereDetailsClass objectC1=new TheatereDetailsClass("TID301","Inox","Anna Nagar");
        TheatereDetailsClass objectC2=new TheatereDetailsClass("TID302","Ega Theatre","Anna Nagar");
        TheatereDetailsClass objectC3=new TheatereDetailsClass("TID303","kamala","vadapalani");
        theatreList.Add(objectC1);
        theatreList.Add(objectC2);
        theatreList.Add(objectC3);

        //Default Movie Details
        MovieDetailsClass objectD1= new MovieDetailsClass("MID501","Bagubali 2","Telugu");
        MovieDetailsClass objectD2= new MovieDetailsClass("MID502","Ponniyin Selvan","Tamil");
        MovieDetailsClass objectD3= new MovieDetailsClass("MID503","Cobra","Tamil");
        MovieDetailsClass objectD4= new MovieDetailsClass("MID504","Vikram","Tamil");
        MovieDetailsClass objectD5= new MovieDetailsClass("MID505","Vikram","Tamil");
        MovieDetailsClass objectD6= new MovieDetailsClass("MID506","Bagubali 2","Hindi");
        movieList.Add(objectD1);
        movieList.Add(objectD2);
        movieList.Add(objectD3);
        movieList.Add(objectD4);
        movieList.Add(objectD5);
        movieList.Add(objectD6);

        //Screening Details
        ScreeningDetailsClass objectE1=new ScreeningDetailsClass("MID501","TID301",5,200);
        ScreeningDetailsClass objectE2=new ScreeningDetailsClass("MID502","TID302",4,400);
        ScreeningDetailsClass objectE3=new ScreeningDetailsClass("MID503","TID303",2,900);
        ScreeningDetailsClass objectE4=new ScreeningDetailsClass("MID504","TID304",10,100);
        ScreeningDetailsClass objectE5=new ScreeningDetailsClass("MID505","TID305",7,250);
        ScreeningDetailsClass objectE6=new ScreeningDetailsClass("MID506","TID306",8,600);
        ScreeningDetailsClass objectE7=new ScreeningDetailsClass("MID507","TID307",5,670);
        ScreeningDetailsClass objectE8=new ScreeningDetailsClass("MID508","TID308",9,20);


    }
    public static void SubMenu()
    {
        System.Console.WriteLine("***Welcome to Submenu***");
        string choice="yes";
        do
        {
        System.Console.WriteLine("Enter the Option \n1. TicketBooking \n2.Ticket Cancellation \n3.Booking History \n4. WalletBalance  \n5.Exit");
        int option2 =int.Parse(Console.ReadLine());
        switch(option2)
        {
            case 1:
            {
                System.Console.WriteLine("Entered TicketBooking Folder");
                //TicketBooking method
                ShowTheaterDetails();
                ShowMovieDetails();
                ShowScreeningDeatails();
                TicketBooking();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Entered Ticket Cancellation Folder");
                CancelOrder();
                //Ticket cancellation
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Entered Booking History");
                //Booking History
                BookingHistory();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Reachagre Wallet");
                WalletRecharge();
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Entered Exit Folder");
                break;
            }
        }
        }
        while(choice =="yes");
    }
    public static void ShowTheaterDetails()
    {
        foreach(TheatereDetailsClass theatere in theatreList)
        {
            System.Console.WriteLine(theatere.TheatreId+","+theatere.TheatreName+","+theatere.TheatreLocation);
        }
    }
    public static void ShowMovieDetails()
    {
        foreach(MovieDetailsClass movie in movieList)
        {
            System.Console.WriteLine(movie.MovieId+","+movie.MovieName+","+movie.Language);
        }
    }
    public static void ShowScreeningDeatails()
    {
        foreach(ScreeningDetailsClass screen in screeningList)
        {
            System.Console.WriteLine(screen.MovieId+","+screen.TheatreId+","+screen.NoOfSeatsAvailable+","+screen.TicketPrice);
        }
    }
     List<BookingDetailsClass> tempbook= new List<BookingDetailsClass>();
     
    public static void TicketBooking()
    {
        System.Console.WriteLine("****Entered to the Ticket Booking Folder");
        //User entering movie Id
        System.Console.WriteLine("Enter the MovieId you want to Book");
        string movieId1=Console.ReadLine();
        
        //User entering Seatcount
        System.Console.WriteLine("Enter the number of seat you want to book");
        int noOfSeats=int.Parse(Console.ReadLine());

        foreach(ScreeningDetailsClass bookk in screeningList)
        {
            if(movieId1==bookk.MovieId)
            {
                if(noOfSeats==bookk.NoOfSeatsAvailable)
                {
                    System.Console.WriteLine("Required Seat count is  availablethe  for the entered movieId");
                    double TotalAmount=((noOfSeats*bookk.TicketPrice)+0.18);
                    foreach(UserDetailsClass user in userList)
                    {
                        if(TotalAmount<=user.WalletBalance)
                        {
                            BookingDetailsClass booking = new BookingDetailsClass(currentuser.UserId,cuurentBooking.TheatreId,cuurentBooking.MovieId,cuurentBooking.SeatCount,cuurentBooking.TotalAmount,cuurentBooking.BookingStatus);
                            BookingList.Add(booking);
                            System.Console.WriteLine(BookingList);
                        }
                        else
                        {
                            System.Console.WriteLine("Insufficinent Balance Please Reacher");
                            
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Required Seat count not available");
                }
            }
            else
            {
                System.Console.WriteLine(" You entered Invalid  movieId");
            }
        }  
    }
    public static void WalletRecharge()
    {
    
    }
    public static void CancelOrder()
    {
        System.Console.WriteLine(BookingList);
        System.Console.WriteLine("Are you want top cancel the booking Id");
        string answer=Console.ReadLine().ToLower();
        if(answer=="yes")
        {
        }
    }
    public static void BookingHistory()
    {
        System.Console.WriteLine("Movie Id is :"+cuurentBooking.MovieId+"Theater Id :"+cuurentBooking.TheatreId+"Number of seats Booked"+cuurentBooking.SeatCount+"Total Amount  is :"+cuurentBooking.TotalAmount+" your Booking status is :"+cuurentBooking.BookingStatus);
    }
    
    
}