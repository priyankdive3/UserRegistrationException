using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserException
{
    internal class UC1First
    {
        public static void ValidateFirstName()
        {
            try
            {
                Console.WriteLine("Enter First Name");
                String firstName = Console.ReadLine();
                string pattern = "^[A-Z]{1}[a-z]{2,}$";
                if(Regex.IsMatch(firstName, pattern))
                {
                    Console.WriteLine("First Name : "+firstName);
                }
                else
                {
                    throw (new CustomException("First name should be first letter capital and more then 2 characters"));
                }
            }
            catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
    }
}
