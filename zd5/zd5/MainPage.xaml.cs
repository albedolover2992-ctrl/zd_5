using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zd5
{
    public partial class MainPage : CarouselPage
    {
        public MainPage(string log)
        {
            InitializeComponent();
            this.Children.Add(new Welcome(log));
            this.Children.Add(new Setting());
        }
    }
}
