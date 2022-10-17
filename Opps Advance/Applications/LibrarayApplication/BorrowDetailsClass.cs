using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarayApplication;
public enum  Status{Default,Issued,Return}

    public class BorrowDetailsClass
    {
        private static int s_borrowId = 301;
        public static string BorrowId{get;set;}
        public  static int BookId{get;set;}  
        public static int RegisterationNumber{get;} 
        public static DateTime BorrowDate{get;set;}
        public static Status Status{get;set;}
        public BorrowDetailsClass(int bookId,int registerationNumber,DateTime borrowDate,Status status)
        {
            s_borrowId++;
            BorrowId = "LB"+s_borrowId;
            BorrowDate = borrowDate;
            Status=status;
            
            


        }

    }
