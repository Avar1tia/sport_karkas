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
using test.Classes;

namespace test.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
            connect.modeldb = new Models.sport();
        }

        private void Vhod(object sender, RoutedEventArgs e)
        {
            var userObj = connect.modeldb.id_type.FirstOrDefault(x => x.login == Login.Text && Password.Password == x.pass);
            if (userObj == null)
            {
                // Пользователь не найден
                MessageBox.Show("Пользователь не найден"); // Пользователь не найденw
            }
            else
            {
                if (userObj.id == 1)
                {
                    manager.MainFrame.Navigate(new ListProducts());
                }
                else if (userObj.id == 2)
                {
                    Windows.WindowOrder secondWindow = new Windows.WindowOrder();
                    secondWindow.Show();
                }
                else if (userObj.id == 3)
                {
                    manager.MainFrame.Navigate(new ListProducts()); 
                }
            }
        }
    }
}
