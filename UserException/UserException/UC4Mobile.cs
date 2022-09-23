using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserException
{
    public class UC4Mobile
    {
        public static void ValidateMobileNumber()
        {
            try
            {
                Console.WriteLine("Enter mobile number");
                string mobileNumber = Console.ReadLine();

                string pattern = "^[+][91]{2}[: :][6-9]{1}[0-9]{9}$";

                if (Regex.IsMatch(mobileNumber, pattern))
                {
                    Console.WriteLine("Mobile number : " + mobileNumber);
                }
                else
                {
                    throw (new CustomException("Mobile number is not valid... Mobile number should be 10 numeric numbers"));
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
