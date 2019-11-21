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
using System.Windows.Shapes;

namespace FINE_GIBDD
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LoginText_MouseEnter(object sender, MouseEventArgs e)
        {
            if (LoginText.Text == "Логин")
            {
                LoginText.Text = "";
                LoginText.Foreground = Brushes.Black;
            }
        }

        private void PasswordText_MouseEnter(object sender, MouseEventArgs e)
        {
            if (PasswordText.Text == "Пароль")
            {
                 PasswordText.Text = "";
                PasswordText.Foreground = Brushes.Black;
            }
        }
    }
}
