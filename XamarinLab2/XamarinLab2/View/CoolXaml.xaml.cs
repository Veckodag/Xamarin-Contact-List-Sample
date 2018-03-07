using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinLab2.ViewModel;

namespace XamarinLab2
{
    public partial class CoolXaml : ContentPage
    {
        private ContactViewModel _ContactViewModel;
        public CoolXaml(ContactViewModel contact)
        {
            _ContactViewModel = contact;
            InitializeComponent();
            BindingContext = _ContactViewModel;
        }
    }
}
