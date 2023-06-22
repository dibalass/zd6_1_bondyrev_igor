using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_1_bondyrev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start :ContentPage
    {
        static string login;
        static string password;
        public Start ()
        {
            InitializeComponent();
        }
        private bool CheckFields (string _login, string _password)
        {
            if (_login == null)
            {
                this.DisplayToastAsync("Заполни логин");
                return false;
            }
            if (_password == null)
            {
                this.DisplayToastAsync("Заполни пароль");
                return false;
            }
            login = _login;
            password = _password;
            return true;
        }

        private void LogButton_Clicked (object sender, EventArgs e)
        {
            if (CheckFields(Login.Text, Password.Text))
            {
                Navigation.PushAsync(new NavigationPage(new MainPage(login, password)));
            }
        }
    }
}