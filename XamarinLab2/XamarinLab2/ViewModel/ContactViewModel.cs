using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinLab2.ViewModel
{
    public class ContactViewModel
    {
        public ContactViewModel(Contact contact)
        {
            FullName = $"{contact.FirstName} {contact.LastName}";
            Email = contact.Email;
            Phone = contact.PhoneNumber;
            Age = CalculateAge(contact.BirthDate);
        }

        private int CalculateAge(DateTime birthDate)
        {
            var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
            var dob = float.Parse(birthDate.ToString("yyyy.MMdd"));
            var age = (int)(now - dob);
            return age;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

    }
}
