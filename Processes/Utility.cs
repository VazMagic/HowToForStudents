using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.Processes
{
    public class Utility
    {
        public static bool TryConvertToInt(string input, out int result)
        {
            //Trim the input and attempt to parse it as an integer
            input = input.Trim();
            if (int.TryParse(input, out result))
            {
                //Successfully converted to integer
                return true; 
            }

            //Conversion failed, set result to 0
            result = 0;
            //Not an integer
            return false; 
        }
    }
}
