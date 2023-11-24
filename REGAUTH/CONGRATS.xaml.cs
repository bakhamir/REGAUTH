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

namespace REGAUTH
{
    /// <summary>
    /// Логика взаимодействия для CONGRATS.xaml
    /// </summary>
    public partial class CONGRATS : Window
    {
        public CONGRATS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            this.Close();
            mwin.Show();
        }
    }
}
