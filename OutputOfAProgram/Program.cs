using System;

namespace OutputOfAProgram
{
    class Program
    {
        static String location;
        static DateTime time;
        //What is the output of the short program below? Explain your answer.
        static void Main(string[] args)
        {
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
        }

        //The output will be:
        //location is null
        //1/1/0001 12:00:00 AM
        //Although both variables are uninitialized, String is a reference type and DateTime is a value type.As a value type, 
        //an unitialized DateTime variable is set to a default value of midnight of 1/1/1 (yup, that’s the year 1 A.D.), not null.
    }
}
