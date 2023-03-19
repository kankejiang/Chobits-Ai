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

namespace Chobits词库姬
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            //设置初始页面
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Source = new Uri("主页.xaml", UriKind.Relative);
        }


        private void 主页按钮_Click(object sender, RoutedEventArgs e)
        {
            // 设置Border的颜色
            主页背景.Background = new SolidColorBrush(Color.FromRgb(0x6F, 0x9C, 0xEF));

            // 取消Border的颜色
            消息背景.Background = Brushes.Transparent;
            插件背景.Background = Brushes.Transparent;
            数据背景.Background = Brushes.Transparent;
            设置背景.Background = Brushes.Transparent;
            //切换页面
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Source = new Uri("主页.xaml", UriKind.Relative);
        }

       
        private void 消息按钮_Click(object sender, RoutedEventArgs e)
        {


            // 设置Border的颜色
            消息背景.Background = new SolidColorBrush(Color.FromRgb(0x6F, 0x9C, 0xEF));

            // 取消Border的颜色
            主页背景.Background = Brushes.Transparent;
            插件背景.Background = Brushes.Transparent;
            数据背景.Background = Brushes.Transparent;
            设置背景.Background = Brushes.Transparent;
            //切换页面
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Source = new Uri("消息.xaml", UriKind.Relative);

        }

        private void 插件按钮_Click(object sender, RoutedEventArgs e)
        {
            // 设置Border的颜色
            插件背景.Background = new SolidColorBrush(Color.FromRgb(0x6F, 0x9C, 0xEF));

            // 取消Border的颜色
            主页背景.Background = Brushes.Transparent;
            消息背景.Background = Brushes.Transparent;
            数据背景.Background = Brushes.Transparent;
            设置背景.Background = Brushes.Transparent;
            //切换页面
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Source = new Uri("插件.xaml", UriKind.Relative);
        }

        private void 数据按钮_Click(object sender, RoutedEventArgs e)
        {
            // 设置Border的颜色
            数据背景.Background = new SolidColorBrush(Color.FromRgb(0x6F, 0x9C, 0xEF));

            // 取消Border的颜色
            主页背景.Background = Brushes.Transparent;
            插件背景.Background = Brushes.Transparent;
            消息背景.Background = Brushes.Transparent;
            设置背景.Background = Brushes.Transparent;
            //切换页面
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Source = new Uri("数据.xaml", UriKind.Relative);
        }

        private void 设置按钮_Click(object sender, RoutedEventArgs e)
        {
            // 设置Border的颜色
            设置背景.Background = new SolidColorBrush(Color.FromRgb(0x6F, 0x9C, 0xEF));

            // 取消Border的颜色
            主页背景.Background = Brushes.Transparent;
            插件背景.Background = Brushes.Transparent;
            消息背景.Background = Brushes.Transparent;
            数据背景.Background = Brushes.Transparent;
            //切换页面
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Source = new Uri("设置.xaml", UriKind.Relative);
        }

       
    }
}
