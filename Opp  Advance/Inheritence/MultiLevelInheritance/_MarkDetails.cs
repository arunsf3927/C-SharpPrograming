using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    //added
    public interface IMarkDetails
    {
    // Fields not allowed
        int Physics {get;set;}   //Property Declaration only Allowed
        int Chemistry {get;set;}
        int Maths {get;set;}
        int Total {get;set;}
        double Average {get;set;}

        // No constructor and Object
        void GetMark(int Physics,int Chemistry,int Maths);
        
        void Calculation();  //Method declaration Only allowed
        void ShowMark();
    }
}
//added