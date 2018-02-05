using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MoviesLAB9
{
    public class Validation
    {
        public static bool validate(string temp )
        {
            
                
            while (true)
            {
                

                if (temp == "y"  )
                {

                    bool choice = true;
                    Console.Clear();
                    return choice;
                }
                else if (temp == "n" )
                {
                    Console.WriteLine("GOODBYE");
                    bool choice = false;
                    return choice;

                }
               
            }


        }
    }
}
