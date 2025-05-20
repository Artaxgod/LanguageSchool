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

namespace LanguageSchool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void VhodButtonClick(object sender, RoutedEventArgs e)
        {
            string phone = PhoneBox.Text;
            string password = PasswordBox.Password;

            if (phone.Length < 5)
            {
                PhoneBox.ToolTip = "Данные заполнены некорректно!";
                PhoneBox.Background = Brushes.Gray;
            }
            else if (password.Length < 3)
            {
                PasswordBox.ToolTip = "Данные заполнены некорректно!";
                PasswordBox.Background = Brushes.Gray;
            }
            else
            {
                PhoneBox.ToolTip = "";
                PhoneBox.Background = Brushes.Transparent;
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;
                MessageBox.Show("Alright!");
            }

        }
    }
}
