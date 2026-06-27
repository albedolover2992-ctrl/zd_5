using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        string login;
        public Welcome(string _login)
        {
            InitializeComponent();
            welcomeLabel.Text = "Добро пожаловать, " + _login;
            login = _login;
        }

        
    }
}