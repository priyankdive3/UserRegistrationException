using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserException
{
    internal class UC8Rule4
    {
        public static void ValidatePassword()
        {
            try
            {
                Console.WriteLine("Enter a password");
                string password = Console.ReadLine();
                var LowerCase = new Regex(@"[a-z]+");
                var UpperCase = new Regex(@"[A-Z]+");
                var Length = new Regex(@".{8,}");
                var Number = new Regex(@"[0-9]+");
                var SpecialCharacter = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z][0-9]).{8,}[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]$");

                if (pattern.IsMatch(password))
                {
                    Console.WriteLine("Password is " + password);
                }
                else if (!LowerCase.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least 1 lower char"));
                }
                else if (!Number.IsMatch(password))
                {
                    throw (new CustomException("Password should have minimum 8 characters"));
                }
                else if (!UpperCase.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least one upper character"));
                }
                else if (!SpecialCharacter.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least 1 special character"));
                    
                }
                else
                {
                    throw (new CustomException("Invalid Password"));
                }
            }

            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
