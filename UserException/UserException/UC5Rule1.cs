using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserException
{
    public class UC5Rule1
    {
        public static void ValidatePassword()
        {
            try
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                var hasLowerChar = new Regex("^([a-z]){8,}$");

                if (!hasLowerChar.IsMatch(password))
                {
                    throw (new CustomException("Password is not valid... Password should have minimum 8 characters"));
                }
                else
                {
                    Console.WriteLine("Password : " + password);
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
