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

namespace UWPApp1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    { 
        string[] vslist = new string[10];
        string[] vslist1 = new string[10];
        double num;
        double judge;
        private int i;
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = true;
            Subtract.IsEnabled = true;
            Multiplication.IsEnabled = false;
            Division.IsEnabled = false;
            Mixture.IsEnabled = false;
            Arithmetic1.IsEnabled = false;
            i = 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = true;
            Subtract.IsEnabled = true;
            Multiplication.IsEnabled = false;
            Division.IsEnabled = false;
            Mixture.IsEnabled = false;
            Arithmetic1.IsEnabled = false;
            i = 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Multiplication.IsEnabled = true;
            Division.IsEnabled = true;
            Add.IsEnabled = true;
            Subtract.IsEnabled = true;
            Mixture.IsEnabled = false;
            Arithmetic1.IsEnabled = false;
            i = 3;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Multiplication.IsEnabled = true;
            Division.IsEnabled = true;
            Add.IsEnabled = true;
            Subtract.IsEnabled = true;
            Mixture.IsEnabled = true;
            Arithmetic1.IsEnabled = true;
            i = 4;
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.AddThemeCount();
            for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
            {
                vslist[i] = oneTheme.ArrayTheme[i];
                vslist1[i] = oneTheme.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;

        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneThemes = new OneTheme();
            oneThemes.SubThemeCount();

            for (int i = 0; i < oneThemes.ArrayTheme.Count; i++)
            {
                vslist[i] = oneThemes.ArrayTheme[i];
                vslist1[i] = oneThemes.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Text1.Text == vslist1[0])
            {
                text1.Text = "√";
                num++;
            }
            if (Text1.Text != vslist1[0])
            {
                text1.Text = "×";
            }


            if (Text2.Text == vslist1[1])
            {
                text2.Text = "√";
                num++;
            }
            if (Text2.Text != vslist1[1])
            {
                text2.Text = "×";
            }

            if (Text3.Text == vslist1[2])
            {
                text3.Text = "√";
                num++;
            }
            if (Text3.Text != vslist1[2])
            {
                text3.Text = "×";
            }

            if (Text4.Text == vslist1[3])
            {
                text4.Text = "√";
                num++;
            }
            if (Text4.Text != vslist1[3])
            {
                text4.Text = "×";
            }

            if (Text5.Text == vslist1[4])
            {
                text5.Text = "√";
                num++;
            }
            if (Text5.Text != vslist1[4])
            {
                text5.Text = "×";
            }

            if (Text5.Text == vslist1[5])
            {
                text6.Text = "√";
                num++;
            }
            if (Text5.Text != vslist1[5])
            {
                text6.Text = "×";
            }

            if (Text7.Text == vslist1[6])
            {
                text7.Text = "√";
                num++;
            }
            if (Text7.Text != vslist1[6])
            {
                text7.Text = "×";
            }

            if (Text8.Text == vslist1[7])
            {
                text8.Text = "√";
                num++;
            }
            if (Text8.Text != vslist1[7])
            {
                text8.Text = "×";
            }

            if (Text9.Text == vslist1[8])
            {
                text9.Text = "√";
                num++;
            }
            if (Text9.Text != vslist1[8])
            {
                text9.Text = "×";
            }

            if (Text10.Text == vslist1[9])
            {
                text10.Text = "√";
                num++;
            }
            if (Text10.Text != vslist1[9])
            {
                text10.Text = "×";
            }
            judge = num / 10;
            textBlock3.Text = judge + "分";
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            ThreeTheme Threes = new ThreeTheme();
            Threes.MultiplyThemeCount();

            for (int i = 0; i < Threes.ArrayTheme.Count; i++)
            {
                vslist[i] = Threes.ArrayTheme[i];
                vslist1[i] = Threes.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Print__Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {

            }

        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            ThreeTheme Threes = new ThreeTheme();
            Threes.DivisionTheme();

            for (int i = 0; i < Threes.ArrayTheme.Count; i++)
            {
                vslist[i] = Threes.ArrayTheme[i];
                vslist1[i] = Threes.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;
        }

        private void Mixture_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Division_Click_1(object sender, RoutedEventArgs e)
        {
            ThreeTheme Threes = new ThreeTheme();
            Threes.DivisionTheme();

            for (int i = 0; i < Threes.ArrayTheme.Count; i++)
            {
                vslist[i] = Threes.ArrayTheme[i];
                vslist1[i] = Threes.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;
        }

        private void Mixture_Click_1(object sender, RoutedEventArgs e)
        {
            ThreeTheme Threes = new ThreeTheme();

            for (int i = 0; i < Threes.ArrayTheme.Count; i++)
            {
                vslist[i] = Threes.ArrayTheme[i];
                vslist1[i] = Threes.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;
        }
    }
}
