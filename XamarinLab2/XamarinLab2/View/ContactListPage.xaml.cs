using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinLab2.ViewModel;

namespace XamarinLab2
{
    public partial class ContactListPage : ContentPage
    {
        private ContactListViewModel ContactListViewModel;
        public ContactListPage()
        {
            ContactListViewModel = new ContactListViewModel();
            InitializeComponent();
            BindingContext = ContactListViewModel;
        }

        private void ContactList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myContact = (ContactViewModel) e.Item;
            if (e != null)
                Navigation.PushAsync(new CoolXaml(myContact));
        }
    }
}
