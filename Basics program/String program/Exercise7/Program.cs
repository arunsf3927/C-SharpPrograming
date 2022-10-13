using System;
namespace Ecercise7
{
    class program7
    {
        public static void Main(string[] args)
        {
            
            String str;
            int i,len , vowel,consonents;
            Console.Write("Count total no of vowel or consonents");
            Console.Write("Input the string :");
            str =Console.ReadLine();
            vowel -0; consonents=0; len str.length;
            for (i=0;i<len;i++)
            {
                if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
                {
                    vowel++;
                }
                else if(str[i]?='a'&&str[i]?='e'&&str[i]?='i'&&str[i]?='o'&&str[i]?='u')
                {
                    consonents++;
                }
                Console.WriteLine(vowel,consonents);
            }
        }
    }
}