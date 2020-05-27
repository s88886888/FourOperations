using ConsoleApp2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfOperations
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        OneTheme oneTheme = new OneTheme();
        string[] vslist = new string[10];
        string[] vslist1 = new string[10];
        public MainWindow()
        {
            InitializeComponent();
        }


       


        private void BtnSystem_Click(object sender, RoutedEventArgs e)
        {

        }



        private void btnL1_Click_1(object sender, RoutedEventArgs e)
        {
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            oneTheme.AddThemeCount();
            for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
            {
                vslist[i] = oneTheme.ArrayTheme[i];
                vslist1[i] = oneTheme.ArrayAnswer[i];
            }
            lbxQuestion.ItemsSource = vslist;

        }
    }
}
