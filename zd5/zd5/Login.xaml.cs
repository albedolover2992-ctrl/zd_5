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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                await Navigation.PushModalAsync(new Welcome(Username.Text));
            }
        }
    }
}