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
    /// Логика взаимодействия для REGWIN.xaml
    /// </summary>
    public partial class REGWIN : Window
    {
        public REGWIN()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(mail.Text == null || pass.Text == null)
            {
                MessageBox.Show("Ошибка поля должны быть заполнены");
            }
            else
            {
                MainWindow.password = pass.Text;
                MainWindow.mail = mail.Text;
                MessageBox.Show("регистрация успешна");

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            this.Close();
            mwin.Show();
        }
    }
}
