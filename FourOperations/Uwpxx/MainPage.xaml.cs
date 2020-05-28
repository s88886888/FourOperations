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

namespace Uwpxx
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string[] vs = new string[10];
        string[] vs1 = new string[10];
        string[] vslist1 = new string[10];

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.AddThemeCount();
            for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
            {
                vs[i] = oneTheme.ArrayTheme[i];//题目

                vs1[i] = oneTheme.ArrayAnswer[i];
            }
            LisBox.ItemsSource = vs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Buttonjia.IsEnabled = true;
            Buttonjian.IsEnabled = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.SubThemeCount();
            for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
            {
                vs[i] = oneTheme.ArrayTheme[i];//题目

                vs1[i] = oneTheme.ArrayAnswer[i];
            }
            LisBox.ItemsSource = vs;
            //oneTheme.SubThemeCount();
            //this.LisBox.ItemsSource = oneTheme.ArrayTheme;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (box1.Text == vs1[0])
            {
                text1.Text = "√";
            }
            if (box1.Text != vs1[0])
            {
                text1.Text = "×";
            }
            if (box1.Text == "")
            {
                text1.Text = "请输入正确答案";
            }


            if (box2.Text == vs1[1])
            {
                text2.Text = "√";
            }
            if (box2.Text != vs1[1])
            {
                text2.Text = "×";
            }
            if (box2.Text == "")
            {
                text2.Text = "请输入正确答案";
            }

            if (box3.Text == vs1[2])
            {
                text3.Text = "√";
            }
            if (box3.Text != vs1[2])
            {
                text3.Text = "×";
            }
            if (box3.Text == "")
            {
                text3.Text = "请输入正确答案";
            }

            if (box4.Text == vs1[3])
            {
                text4.Text = "√";
            }
            if (box4.Text != vs1[3])
            {
                text4.Text = "×";
            }
            if (box4.Text == "")
            {
                text4.Text = "请输入正确答案";
            }

            if (text5.Text == vs1[4])
            {
                text5.Text = "√";
            }
            if (text5.Text != vs1[4])
            {
                text5.Text = "×";
            }
            if (box5.Text == "")
            {
                text5.Text = "请输入正确答案";
            }

            if (text5.Text == vs1[5])
            {
                text6.Text = "√";
            }
            if (text5.Text != vs1[5])
            {
                text6.Text = "×";
            }
            if (box6.Text == "")
            {
                text6.Text = "请输入正确答案";
            }

            if (box7.Text == vs1[6])
            {
                text7.Text = "√";
            }
            if (box7.Text != vs1[6])
            {
                text7.Text = "×";
            }
            if (box7.Text == "")
            {
                text7.Text = "请输入正确答案";
            }

            if (box8.Text == vs1[7])
            {
                text8.Text = "√";
            }
            if (box8.Text != vs1[7])
            {
                text8.Text = "×";
            }
            if (box8.Text == "")
            {
                text8.Text = "请输入正确答案";
            }

            if (box9.Text == vs1[8])
            {
                text9.Text = "√";
            }
            if (box9.Text != vs1[8])
            {
                text9.Text = "×";
            }
            if (box9.Text == "")
            {
                text9.Text = "请输入正确答案";
            }

            if (box10.Text == vs1[9])
            {
                text10.Text = "√";
            }
            if (box10.Text != vs1[9])
            {
                text10.Text = "×";
            }
            if (box10.Text == "")
            {
                text10.Text = "请输入正确答案";
            }
        }

        private void dy_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.SubOutPutTxt();

        }

    }



}