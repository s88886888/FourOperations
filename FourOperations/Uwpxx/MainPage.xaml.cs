using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
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
        double  zql;
        double a;
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
            Cheng.IsEnabled = false;
            chuf.IsEnabled = false;
            Sz.IsEnabled = false;
            HZ.IsEnabled = false;
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
            OneTheme oneTheme = new OneTheme();

            if (box1.Text == vs1[0])
            {
                text1.Text = "√";
                zql++;
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
                zql++;
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
                zql++;
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
                zql++;
            }
            if (box4.Text != vs1[3])
            {
                text4.Text = "×";
            }
            if (box4.Text == "")
            {
                text4.Text = "请输入正确答案";
            }

            if (box5.Text == vs1[4])
            {
                text5.Text = "√"; 
                zql++;
            }
            if (box5.Text != vs1[4])
            {
                text5.Text = "×";
            }
            if (box5.Text == "")
            {
                text5.Text = "请输入正确答案";
            }

            if (box6.Text == vs1[5])
            {
                text6.Text = "√"; 
                zql++;
            }
            if (box6.Text != vs1[5])
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
                zql++;
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
                zql++;
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
                zql++;
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
                zql++;
            }
            if (box10.Text != vs1[9])
            {
                text10.Text = "×";
            }
            if (box10.Text == "")
            {
                text10.Text = "请输入正确答案";
            }
            a = zql / 10*100;
            Zq.Text = Convert.ToString(a)+"%";
            
        }

        private void dy_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.AddThemeCount();
            oneTheme.AddOutPutTxt();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Buttonjia.IsEnabled = true;
            Buttonjian.IsEnabled = true;
            Cheng.IsEnabled = false;
            chuf.IsEnabled = false;
            Sz.IsEnabled = false;
            HZ.IsEnabled = false;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Buttonjia.IsEnabled = false;
            Buttonjian.IsEnabled = false;
            Cheng.IsEnabled = true;
            chuf.IsEnabled = true;
            HZ.IsEnabled = true;
        }



        private void Cheng_Click_1(object sender, RoutedEventArgs e)
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.MultiplyThemeCount();
            for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
            {
                vs[i] = threeTheme.ArrayTheme[i];//题目

                vs1[i] = threeTheme.ArrayAnswer[i];
            }
            LisBox.ItemsSource = vs;
        }

        private void chuf_Click(object sender, RoutedEventArgs e)
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.DivisionThemeCount();
            for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
            {
                vs[i] = threeTheme.ArrayTheme[i];//题目

                vs1[i] = threeTheme.ArrayAnswer[i];
            }
            LisBox.ItemsSource = vs;
        }

        private void HZ_Click(object sender, RoutedEventArgs e)
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.HybridOperationCount();
            for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
            {
                vs[i] = threeTheme.ArrayTheme[i];//题目

                vs1[i] = threeTheme.ArrayAnswer[i];
            }
            LisBox.ItemsSource = vs;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Cheng.IsEnabled = true;
            chuf.IsEnabled = true;
            HZ.IsEnabled = true;
            Sz.IsEnabled = true;
        }

        private void Sz_Click(object sender, RoutedEventArgs e)
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.HybridOperationCount();
            for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
            {
                vs[i] = threeTheme.ArrayTheme[i];//题目

                vs1[i] = threeTheme.ArrayAnswer[i];
            }
            LisBox.ItemsSource = vs;
        }       
    }
}