using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace XML
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
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (textName.Text == "1" && textPassword.Text == "123")
            {

                //this.Frame.Navigate(typeof(Uwpxx.MainPage));
                MessageDialog aa = new MessageDialog("欢迎");
                await aa.ShowAsync();

            }
            else
            {
                MessageDialog aa = new MessageDialog("账号或密码错误!");
                await aa.ShowAsync();
            }



        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("版本号V_1.1");

            await dialog.ShowAsync();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("暂未开放该功能");

            await dialog.ShowAsync();
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("正道的光黄琳盛设计，盗版必究");

            await dialog.ShowAsync();
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("我也无能为力啊!!!");

            await dialog.ShowAsync();
        }
    }
}
