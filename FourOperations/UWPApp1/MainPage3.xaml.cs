using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace UWPApp1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage3 : Page
    {
        public MainPage3()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text=="123"&&textBox_Copy.Text=="123")
            {

                this.Frame.Navigate(typeof(MainPage2));
            }
            else
            {
                textBlock2.Text = "账号或密码出错了！！！";
                textBox.Text = "";
                textBox_Copy.Text = "";
            }
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
