using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;// if there is last name defined, the full name is the lastname with no commas
                if(!string.IsNullOrWhiteSpace(FirstName))//if there is only a firstname, the fullname is initially null, follow p2--
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";// if there is both the firstname and the lastname, we start with the last name, add a coma and a space before appending the firstname
                    }
                    fullName += FirstName; // p2.-- so we set the fullname to the firstname
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;

        //public string LastName { get; set; }

        // Горното или долното, и двете извършват една и съща функция в момента,
        // ако нямаме допълнителна логика в долното, може да използваме горното

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
    }
}
