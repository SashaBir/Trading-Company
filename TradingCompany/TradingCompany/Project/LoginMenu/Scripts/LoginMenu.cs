using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TradingCompany.Project.LoginMenu.Scripts
{
    internal class LoginMenu
    {
        private readonly TextBox _login;
        private readonly TextBox _password;
        private readonly Button _enter;

        private const string DEFUALT_LOGIN = "Admin";
        private const string DEFUALT_Password = "Admin";

        public LoginMenu(TextBox login, TextBox password, Button enter)
        {
            _login = login;
            _password = password;
            _enter = enter;

            _enter.Click += EnterInApplication_Click;
        }

        private void EnterInApplication_Click(object sender, RoutedEventArgs e)
        {
            if (_login.Text == DEFUALT_LOGIN && _password.Text == DEFUALT_Password)
            {
                // вход в приложение
            }
        }
    }
}
