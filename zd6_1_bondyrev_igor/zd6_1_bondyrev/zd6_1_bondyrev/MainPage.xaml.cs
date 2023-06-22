using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zd6_1_bondyrev
{
    public partial class MainPage :CarouselPage
    {
        public MainPage (string Login, string Password)
        {
            InitializeComponent();
            login.Text = $"Ваш логин: {Login}";
            password.Text = $"Ваш пароль: {Password}";
            pickerText.Text = $"{pickerText.Text}";
        }

        private void switch1 (object sender, ToggledEventArgs e)
        {
            if (swich1.IsToggled == true)
            {
                OnOff1.Text = "On";
                OnOff1.Margin = new Thickness(0, 8, -8, 0);
            } else
            {
                OnOff1.Text = "Off";
                OnOff1.Margin = new Thickness(0, 8, -7, 0);
            }
        }

        private void switch2 (object sender, ToggledEventArgs e)
        {
            if (swich2.IsToggled == true)
            {
                OnOff2.Text = "On";
            } else
            {
                OnOff2.Text = "Off";
            }
        }

        private void switch3 (object sender, ToggledEventArgs e)
        {
            if (swich3.IsToggled == true)
            {
                OnOff3.Text = "✓";
            } else
                OnOff3.Text = "✕";
        }

        private void switch4 (object sender, ToggledEventArgs e)
        {
            if (swich4.IsToggled == true)
            {
                OnOff4.Text = "✓";
            } else
                OnOff4.Text = "✕";
        }
        private void Button_Clicked (object sender, EventArgs e)
        {
            double[] array = new double[2] { Convert.ToDouble(slider1.Value), Convert.ToDouble(slider2.Value) };
            double Max = array.Max();
            MaxVlue.Text = $"Максимальное значение Слайдеров: {Max}";
            login.IsVisible = true;
            password.IsVisible = true;
            pickerText.IsVisible = true;
        }

        private void picker_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (picker.SelectedIndex == 0)
                pickerText.Text = "Вы выбрали: Select one";
            else if (picker.SelectedIndex == 1)
                pickerText.Text = "Вы выбрали: Select two";
            else if (picker.SelectedIndex == 2)
                pickerText.Text = "Вы выбрали: Select three";
            else if (picker.SelectedIndex == 3)
                pickerText.Text = "Вы выбрали: Select four";
            else
                pickerText.Text = "Вы ничего не выбрали";
        }
    }
}
