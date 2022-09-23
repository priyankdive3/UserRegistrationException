namespace UserException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option:\n1.Valid first name\n2.Valid last name\n3.Valid Email\n4.Valid Mobile number(+91 1234567890)\n5.Minimum 8 characters\n6.At least 1 upper case\n7.At least 1 numberic value\n8.At least 1 special character\n9.Email sample");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UC1First.ValidateFirstName();
                    break;
                case 2:
                    UC2Last.ValidateLastName();
                    break;
                case 3:
                    UC3Email.ValidateEmail();
                    break;
                case 4:
                    UC4Mobile.ValidateMobileNumber();
                    break;
                case 5:
                    UC5Rule1.ValidatePassword();
                    break;
                case 6:
                    UC6Rule2.ValidatePassword();
                    break;
                case 7:
                    UC7Rule3.ValidatePassword();
                    break;
                case 8:
                    UC8Rule4.ValidatePassword();
                    break;
                
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
        }
    }
}