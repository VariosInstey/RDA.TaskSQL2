using RDA.TaskSQL2.Model;
using RDA.TaskSQL2.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace RDA.TaskSQL2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestTwoEntities _db = new TestTwoEntities();
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                User UserModel = await _db.User.FirstOrDefaultAsync(d => d.login == TbLogin.Text && d.password == PbPassword.Password);
                if (UserModel != null)
                {
                    switch (UserModel.id) 
                    {
                        case 1:
                            new AdminWindow().ShowDialog();
                            break;
                            case 2:
                            new DevWindow().ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show($"Неправильный пароль или логин!");
                }
            }
            catch (Exception)
            {

            }
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TbLogin.Text = string.Empty;
            PbPassword.Password = string.Empty;
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PackIcon_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            TbLogin.Text = "Devloper";
            PbPassword.Password = "dev";
        }

        private void PackIcon_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            TbLogin.Text = "Admin";
            PbPassword.Password = "admin";
        }

        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            new RegMenu().ShowDialog();
        }
    }
}
