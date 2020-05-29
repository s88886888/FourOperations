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
            Mixture.IsEnabled = true;
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

        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            if (Text1.Text == vslist1[0])
            {
                text1.Text = "√";
                num++;

            }
            if (Text1.Text != vslist1[0])
            {
                text1.Text = "×";
                oneTheme.tempTheme.Add(vslist[0]);
                oneTheme.tempAnswer.Add(vslist1[0]);

            }


            if (Text2.Text == vslist1[1])
            {
                text2.Text = "√";
                num++;
            }
            if (Text2.Text != vslist1[1])
            {
                text2.Text = "×";
                oneTheme.tempTheme.Add(vslist[1]);
                oneTheme.tempAnswer.Add(vslist1[1]);
            }

            if (Text3.Text == vslist1[2])
            {
                text3.Text = "√";
                num++;
            }
            if (Text3.Text != vslist1[2])
            {
                text3.Text = "×";
                oneTheme.tempTheme.Add(vslist[2]);
                oneTheme.tempAnswer.Add(vslist1[2]);
            }

            if (Text4.Text == vslist1[3])
            {
                text4.Text = "√";
                num++;
            }
            if (Text4.Text != vslist1[3])
            {
                text4.Text = "×";
                oneTheme.tempTheme.Add(vslist[3]);
                oneTheme.tempAnswer.Add(vslist1[3]);
            }

            if (Text5.Text == vslist1[4])
            {
                text5.Text = "√";
                num++;
            }
            if (Text5.Text != vslist1[4])
            {
                text5.Text = "×";
                oneTheme.tempTheme.Add(vslist[4]);
                oneTheme.tempAnswer.Add(vslist1[4]);
            }

            if (Text5.Text == vslist1[5])
            {
                text6.Text = "√";
                num++;
            }
            if (Text5.Text != vslist1[5])
            {
                text6.Text = "×";
                oneTheme.tempTheme.Add(vslist[5]);
                oneTheme.tempAnswer.Add(vslist1[5]);
            }

            if (Text7.Text == vslist1[6])
            {
                text7.Text = "√";
                num++;
            }
            if (Text7.Text != vslist1[6])
            {
                text7.Text = "×";
                oneTheme.tempTheme.Add(vslist[6]);
                oneTheme.tempAnswer.Add(vslist1[6]);
            }

            if (Text8.Text == vslist1[7])
            {
                text8.Text = "√";
                num++;
            }
            if (Text8.Text != vslist1[7])
            {
                text8.Text = "×";
                oneTheme.tempTheme.Add(vslist[7]);
                oneTheme.tempAnswer.Add(vslist1[7]);
            }

            if (Text9.Text == vslist1[8])
            {
                text9.Text = "√";
                num++;
            }
            if (Text9.Text != vslist1[8])
            {
                text9.Text = "×";
                oneTheme.tempTheme.Add(vslist[8]);
                oneTheme.tempAnswer.Add(vslist1[8]);
            }

            if (Text10.Text == vslist1[9])
            {
                text10.Text = "√";
                num++;
            }
            if (Text10.Text != vslist1[9])
            {
                text10.Text = "×";
                oneTheme.tempTheme.Add(vslist[9]);
                oneTheme.tempAnswer.Add(vslist1[9]);
            }
            judge = num / 10 * 100;
            textBlock3.Text = judge + "分";
            button.IsEnabled = false;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = true;
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

        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = true;
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
            button.IsEnabled = true;
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
            button.IsEnabled = true;
            ThreeTheme Threes = new ThreeTheme();
            Threes.HybridOperationCount();
            for (int i = 0; i < Threes.ArrayTheme.Count; i++)
            {
                vslist[i] = Threes.ArrayTheme[i];
                vslist1[i] = Threes.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;
        }

        private void Arithmetic1_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = true;
            FourTheme fourTheme = new FourTheme();
            fourTheme.FourOperationsThemeCount();
            for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
            {
                vslist[i] = fourTheme.ArrayTheme[i];
                vslist1[i] = fourTheme.ArrayAnswer[i];
            }
            listBox.ItemsSource = vslist;

        }

        private void Mistakes_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.ErrorsText();
        }

        private void One_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Checked(object sender, RoutedEventArgs e)
        {
            if (One.IsChecked == true)
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
            else if (Two.IsChecked == true)
            {

                TwoTheme twoTheme = new TwoTheme();
                twoTheme.AddThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
            }
            else if (Three.IsChecked == true)
            {

                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.AddThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
            }
            else if (Four.IsChecked == true)
            {

                FourTheme fourTheme = new FourTheme();
                fourTheme.AddThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
            }
        }

        private void Subtract_Checked(object sender, RoutedEventArgs e)
        {
            if (One.IsChecked == true)
            {
                OneTheme oneTheme = new OneTheme();
                oneTheme.AddThemeCount();
                for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = oneTheme.ArrayTheme[i];
                    vslist1[i] = oneTheme.ArrayAnswer[i];


                }
                listBox.ItemsSource = vslist;
                oneTheme.AddOutPutTxt();

            }
            else if (Two.IsChecked == true)
            {

                TwoTheme twoTheme = new TwoTheme();
                twoTheme.AddThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
                twoTheme.AddOutPutTxt();
            }
            else if (Three.IsChecked == true)
            {

                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.AddThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
                threeTheme.AddOutPutTxt();
            }
            else if (Four.IsChecked == true)
            {

                FourTheme fourTheme = new FourTheme();
                fourTheme.AddThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
                fourTheme.AddOutPutTxt();
            }
        }

        private void Multiplication_Checked(object sender, RoutedEventArgs e)
        {
            if (Three.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.MultiplyThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
                threeTheme.AddOutPutTxt();
            }
            else if (Four.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.MultiplyThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
                fourTheme.AddOutPutTxt();
            }
        }

        private void Division_Checked(object sender, RoutedEventArgs e)
        {
            if (Three.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.DivisionThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;

            }
            else if (Four.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.DivisionThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;

            }
        }

        private void Mixture_Checked(object sender, RoutedEventArgs e)
        {
            if (Four.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.HybridOperationCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                }
                listBox.ItemsSource = vslist;

            }
            else if (Four.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.HybridOperationThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];

                }
                listBox.ItemsSource = vslist;
            }
        }

        private void Print__Checked(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            for (int i = 0; i < vslist.Length; i++)
            {
                oneTheme.ArrayTheme.Add(vslist[i]);
                oneTheme.ArrayAnswer.Add(vslist[i]);
            }
            oneTheme.AddOutPutTxt();
        }
    }
}

