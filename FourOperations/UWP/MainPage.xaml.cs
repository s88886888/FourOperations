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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace UWP
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int Correct;
        public int Mistake;
        OneTheme one = new OneTheme();
        private string a;

        public int num { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            Topic.Visibility = Visibility;
            textBlock_Copy.Visibility = Visibility;
            textBox.Visibility = Visibility;
            button_Copy1.Visibility = Visibility;
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            one.Randomnum();
            one.AddTheme();
            Topic.Text = one.Theme;
            a = one.Answer.ToString();


        }
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            one.Randomnum();
            one.SubTheme();
            Topic.Text = one.SubTheme();
            a = one.Answer.ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBlock1.Visibility = Visibility;

                textBlock1.Text = "你还没输入答案呢";

            }
            else
            {
                if (textBox.Text ==a)
                {
                    Correct++;
                    textBlock2.Text = "√";
                    textBlock2.Visibility = Visibility;
                    textBlock1.Text = "";

                }
                else
                {
                    Mistake++;
                    textBlock2.Visibility = Visibility;
                    textBlock2.Text = "×";
                }
            }
            }
    }
}
