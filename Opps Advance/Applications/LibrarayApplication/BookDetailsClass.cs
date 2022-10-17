using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarayApplication
{
    public class BookDetailsClass
    {
        private static int s_bookId=100;
        public  static string BookId{get;set;}
        public static string BookName{get;set;}
        public static string AuthorName{get;set;}
        public static int BookCount{get;set;}
        public BookDetailsClass(String bookName,string authorName,int bookCount)
        {
            s_bookId++;
            BookId = "BID"+s_bookId;
            BookName = bookName;
            AuthorName = authorName;
            BookCount = bookCount;
        }
       
    }
}