using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    internal class RegisterStaff
    {
        private string _name;
        private string _description;
        private int _age = 10;
        private List<Staff> staff = new List<Staff>();
        public void CreateStaff()
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter short description about yourself");
            var bio = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            var age = Console.ReadLine();

            try
            {
                _name = Convert.ToString(bio);
                _description = Convert.ToString(bio);
                _age = Convert.ToInt32(age);
                if(_age < 18)
                {
                    throw new NullStaffRegistrationException();
                }
                
            }
            catch (NullStaffRegistrationException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
