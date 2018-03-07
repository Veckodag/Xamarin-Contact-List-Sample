using System;
using System.Collections.Generic;

namespace XamarinLab2
{
    public class ContactGenerator
    {
        private static List<string> firstNames = new List<string> { "Alessandro", "Bartholomew", "Gwendolyn", "Magdalena", "Veronica", "Bradley", "James", "Hussein", "Rudolf", "Anna", "Sune", "Sture", "Konrad", "Gary", "Magnus", "Berit", "Cecilia", "Jörgen", "Sara", "Lina", "Dorothea", "Nils", "Eva", "Filippa", "Fredrik", "Irina", "Stephen", "Andrew", "Klay", "Tomas", "Sven", "Hakim", "Joakim", "Charlie", "Naomi", "Kaori", "Kevin", "Mark", "Arnold", "Frank", "Chris", "Giannis", "Luc", "Lauri" };
        private static List<string> lastNames = new List<string> { "Chamberlain", "Carter-Williams", "Dellavedova", "Weatherspoon", "Funderburke", "Hjalmarsson", "Tripo", "Miyagi", "Vivaldi", "Brown", "Powalski", "Andersson", "Svensson", "Roux", "Sandström", "Berg", "Colt", "Bengtsson", "Eriksson", "Fransson", "Curry", "Lee", "Forsberg", "Park", "Bogut", "Thompson", "Barnes", "Harden", "Villanueva", "Noah", "Jordan", "Takawa", "Nishidake", "Kiwaka", "Tokogawa", "Smith", "Håkansson", "O'neil", "Antetokounmpo", "Mbah a Moute", "Markkanen" };
        static DateTime start = new DateTime(1950, 1, 1);
        static DateTime end = new DateTime(2000, 1, 1);
        static Random gen = new Random();
        static int range = (end - start).Days;

        public static List<Contact> CreateContacts()
        {
            var random = new Random();
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < 30; i++)
            {
                string first = firstNames[random.Next(firstNames.Count - 1)];
                string last = lastNames[random.Next(lastNames.Count - 1)];
                string email = first + "." + last + "@mailinator.com";
                string phone = "08-12" + randomInt();
                DateTime birthDateTime = randomDateTime();
                Contact contact = new Contact { FirstName = first, LastName = last, Email = email, PhoneNumber = phone, BirthDate = birthDateTime};
                contacts.Add(contact);
            }
            return contacts;
        }

        public static int randomInt()
        {
            return gen.Next(10000, 99999);
        }
        public static DateTime randomDateTime()
        {
            return start.AddDays(gen.Next(range));
        }
    }
}
