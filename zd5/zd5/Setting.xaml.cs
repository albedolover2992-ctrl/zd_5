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
    public partial class Setting : ContentPage
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Day_text.Text = picker.SelectedItem.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.White;
            switch1.IsToggled = false;
            switch2.IsToggled = false;
            picker.SelectedItem = null;
            StaticBtn.Text = "STATIC";
        }

        private void Effects_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ColorButton.BackgroundColor = Color.FromRgb(Math.Round(Slider1.Value), Math.Round(Slider2.Value), Math.Round(Slider3.Value));
        }

        private void StaticBtn_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.FromRgb(Math.Round(Slider1.Value), Math.Round(Slider2.Value), Math.Round(Slider3.Value));
            int index = picker.SelectedIndex;
            switch (index)
            {
                case 0:
                    {
                        StaticBtn.Text = "Понедельник";
                        break;
                    }
                case 1:
                    {
                        StaticBtn.Text = "Вторник";
                        break;
                    }
                case 2:
                    {
                        StaticBtn.Text = "Среда";
                        break;
                    }
                case 3:
                    {
                        StaticBtn.Text = "Четверг";
                        break;
                    }
                case 4:
                    {
                        StaticBtn.Text = "Пятница";
                        break;
                    }
                case 5:
                    {
                        StaticBtn.Text = "Суббота";
                        break;
                    }
                case 6:
                    {
                        StaticBtn.Text = "Воскресенье";
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }
    }
}