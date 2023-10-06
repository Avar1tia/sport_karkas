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
            connect.modeldb = new Models.dbo();
        }

        private void Vhod(object sender, RoutedEventArgs e)
        {
            var userObj = connect.modeldb.type.FirstOrDefault(x => x.login == Login.Text && Password.Password == x.pass);
            if (userObj.id_type == 1)
            {
                manager.MainFrame.Navigate(new Admin());
            }
            if (userObj.id_type == 2)
            {
                manager.MainFrame.Navigate(new Manager());
            }
            if (userObj.id_type == 3)
            {
                manager.MainFrame.Navigate(new User());
            }
        }
    }
}
