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
    /// Логика взаимодействия для GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        private TestTwoEntities _db = new TestTwoEntities();
        public GuestWindow()
        {
            InitializeComponent();

            DGInfo.ItemsSource = _db.User.ToList();
        }
    }
}
