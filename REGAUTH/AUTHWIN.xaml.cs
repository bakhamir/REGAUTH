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
    /// Логика взаимодействия для AUTHWIN.xaml
    /// </summary>
    public partial class AUTHWIN : Window
    {
        public AUTHWIN()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                MainWindow mwin = new MainWindow();
                this.Close();
                mwin.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (mail.Text == null || pass.Text == null)
            {
                MessageBox.Show("Ошибка поля должны быть заполнены");
            }
            else
            {
                if(MainWindow.password.CompareTo(pass.Text) == 0 && MainWindow.mail.CompareTo(mail.Text) == 0)
                {
                    MessageBox.Show("Авторизация УСПЕШНА");
                    CONGRATS yay = new CONGRATS();
                    this.Close();
                    yay.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль или адрес Эл. Почты");
                }
            }
        }
    }
}
