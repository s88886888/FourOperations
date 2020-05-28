using ConsoleApp2.Base;
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
    /// LoginWindoTest.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindoTest : Window
    {
        private int number_1;
        private int number_2;
        private int result;

        public LoginWindoTest()
        {
            InitializeComponent();
        }

        //无边框窗体拖动
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            Point position = e.GetPosition(this);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (position.X >= 0 && position.X < this.ActualWidth && position.Y >= 0 && position.Y < this.ActualHeight)
                {
                    this.DragMove();
                }
            }
        }
        private void LoginWindoTest_Load(object sender, EventArgs e)
        {


            Test.MouseMove += delegate (object sender_d, MouseEventArgs e_d)
            {
                if (e_d.LeftButton == MouseButtonState.Pressed)
                {
                    if (e_d.MouseDevice.Target is Control)
                        return;
                    this.DragMove();

                }

            };



        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow1 login1 = new LoginWindow1();
            login1.Show();
            this.Hide();
        }

        private void BtnFalse_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow1 login1 = new LoginWindow1();
            login1.Show();
            this.Hide();
        }

        private void BtnTrue_Click(object sender, RoutedEventArgs e)
        {

            if (txtTestAnswer.Text == "") return;

            if (txtTestAnswer.Text == result.ToString())
            {
                MainWindow window = new MainWindow();
                this.Close();
                window.Show();
            }
            else
            {
                MessageBox.Show("输入错误", "提示信息");

            }


        }
        public void question()
        {

            //取2个随机数
            Random random = new Random();
            number_1 = random.Next(1, 10);
            number_2 = random.Next(1, 10);

            result = number_1 + number_2;
            txtTest.Text = number_1 + " + " + number_2 + " =";


        }

        private void txtTestNext_Click(object sender, RoutedEventArgs e)
        {
            question();

        }

      
    }
}
