using System.Windows;
using TradingCompany.Project.LoginMenu.Scripts;

namespace TradingCompany
{
    public partial class MainWindow : Window
    {
        private readonly LoginMenu _loginMenu;

        public MainWindow()
        {
            InitializeComponent();

            _loginMenu = new LoginMenu(null, null, enterButton);
        }
    }
}
