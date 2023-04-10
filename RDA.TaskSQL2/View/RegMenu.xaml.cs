using RDA.TaskSQL2.Model;
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

namespace RDA.TaskSQL2.View
{
    /// <summary>
    /// Логика взаимодействия для RegMenu.xaml
    /// </summary>
    public partial class RegMenu : Window
    {
        private TestTwoEntities _db = new TestTwoEntities();
        public RegMenu()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(TbLogin.Text) ||
                    string.IsNullOrEmpty(PbPassword.Password))


                {
                    MessageBox.Show($"Не все строки заполнены!");
                }
                else
                {
                    _db.User.Add(new User()
                    {
                        login = TbLogin.Text,
                        password = PbPassword.Password,
                    });
                    _db.SaveChanges();
                    MessageBox.Show($"Успешно!");
                    TbLogin.Text = string.Empty;
                    PbPassword.Password = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error 3");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
