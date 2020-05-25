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

namespace UWPApp1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            OneTheme ones = new OneTheme();
            ones.AddThemeCount();
            this.listBox.ItemsSource = ones.ArrayTheme;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Addition.IsEnabled = true;
            Subtraction.IsEnabled = true;
            Multiplication.IsEnabled = false;
            Division.IsEnabled = false;
            Mixture.IsEnabled = false;
            Arithmetic1.IsEnabled = false;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Addition.IsEnabled = true;
            Subtraction.IsEnabled = true;
            Multiplication.IsEnabled = false;
            Division.IsEnabled = false;
            Mixture.IsEnabled = false;
            Arithmetic1.IsEnabled = false;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Multiplication.IsEnabled = true;
            Division.IsEnabled = true;
            Addition.IsEnabled = true;
            Subtraction.IsEnabled = true;
            Mixture.IsEnabled = false;
            Arithmetic1.IsEnabled = false;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Multiplication.IsEnabled = true;
            Division.IsEnabled = true;
            Addition.IsEnabled = true;
            Subtraction.IsEnabled = true;
            Mixture.IsEnabled = true;
            Arithmetic1.IsEnabled = true;
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            OneTheme ones = new OneTheme();
            ones.SubThemeCount();
            this.listBox.ItemsSource = ones.ArrayTheme;
        }
    }
}
