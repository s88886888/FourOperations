using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
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

namespace WpfFourOperationsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        string[] vslist = new string[10];
        string[] vslist1 = new string[10];
        public bool? IsChecked { get; set; }
        //public void ToggleButton()
        //{
        //    return;
        //}
        private void BtnSystem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnL1_Checked(object sender, RoutedEventArgs e)
        {
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            lbxQuestion.ItemsSource = "";
            if (btnL1.IsChecked == true)
            {
                OneTheme oneTheme = new OneTheme();
                oneTheme.AddThemeCount();
                for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = oneTheme.ArrayTheme[i];
                    vslist1[i] = oneTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;
            }
            else if(btnL2.IsChecked == true)
            {
                TwoTheme twoTheme = new TwoTheme();
                twoTheme.AddThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }

        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.SubThemeCount();

            for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
            {
                vslist[i] = oneTheme.ArrayTheme[i];
                vslist1[i] = oneTheme.ArrayAnswer[i];
            }
            lbxQuestion.ItemsSource = vslist;
        }

        private void btnL2_Checked(object sender, RoutedEventArgs e)
        {
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnL1.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnL4_Checked(object sender, RoutedEventArgs e)
        {
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL1.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnL3_Checked(object sender, RoutedEventArgs e)
        {
            btnL2.IsChecked = false;
            btnL1.IsChecked = false;
            btnL4.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtAnswer1.Text == vslist1[0])
            {
                txtJudge.Text = "正确";

            }
             else if  (txtAnswer1.Text != vslist1[0])
            {
                txtJudge.Text = "×";
               
            }
        }
    }
}
