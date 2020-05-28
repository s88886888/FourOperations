using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfFourOperationsApp
{
    /// <summary>
    /// LoginWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow1 : Window
    {
        public LoginWindow1()
        {
            InitializeComponent();
        }
        string a = "123456";
        //string b = "123";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text == a )
            {
                LoginWindoTest login = new LoginWindoTest();
                log.Close();
                login.Show();
            }
            else
            {
                MessageBox.Show("账号密码错误");
            }

        }
    }
}
