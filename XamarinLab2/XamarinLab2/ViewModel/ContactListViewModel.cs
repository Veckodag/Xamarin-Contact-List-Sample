using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XamarinLab2.ViewModel
{
    public class ContactListViewModel
    {
        public List<Contact> Contacts { get; set; }
        public List<ContactViewModel> ContactsVM { get; set; }

        public ContactListViewModel()
        {
            Contacts = new List<Contact>();
            Contacts = ContactGenerator.CreateContacts();
            ContactsVM = ContactsList(Contacts);
        }

        public List<ContactViewModel> ContactsList(List<Contact> contacts)
        {
            var list = new List<ContactViewModel>();

            foreach (Contact contact in contacts)
            {
                var cvm = new ContactViewModel(contact);
                list.Add(cvm);
            }
            return list;
        }
    }
}
