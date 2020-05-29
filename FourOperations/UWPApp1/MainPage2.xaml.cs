using ConsoleApp2.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class MainPage2 : Page
    {
        OneTheme oneTheme = new OneTheme();
        private double i;
        public MainPage2()
        {
            this.InitializeComponent();
            oneTheme.AddTheme();
            Textbox1.Text = oneTheme.Theme;
            i = oneTheme.Answer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (textbox2.Text == Convert.ToString(i))
                {
                this.Frame.Navigate(typeof(MainPage));
            }
            else
            {
                Textbox1.Text = "";
                textbox2.Text = "";
                Text1.Text = "验证码出错了";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.AddTheme();
            Textbox1.Text = oneTheme.Theme;
            i = oneTheme.Answer;


        }
    }
}
