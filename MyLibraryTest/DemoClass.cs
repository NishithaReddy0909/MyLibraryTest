using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryTest
{
    public class DemoClass
    {
        public int AddNumbers(int n1,int n2)
        {
            return n1 + n2;
        }
        public int DivideNumber(int n1,int n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("The value of n2 cannot be zero");
            }
            return n1 / n2;
        }
        public int Multiply(int n1,int n2)
        {
            return n1 * n2;
        }
        public string Validate(int age)
        {
            if (age >= 18 && age <= 60)
            {
                return "Valid Age";
            }
            else
            {
                return "Invalid Age";
            }
        }
            public bool Validate(string userId,string password)
            {
                if (string.IsNullOrWhiteSpace(userId))
                {
                    throw new ArgumentNullException();
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentNullException();
                }
                if(userId=="nishitha" && password == "nishitha@123")
                {
                    return true;
                }
                else
                {
                    return false;
                    
                }
            }
        
    }
}
