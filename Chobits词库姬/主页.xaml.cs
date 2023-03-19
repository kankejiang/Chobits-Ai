
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
using MySqlX.XDevAPI;
using static System.Collections.Specialized.BitVector32;
using System.Net.WebSockets;
using System.Threading;


namespace Chobits词库姬
{
    /// <summary>
    /// 主页.xaml 的交互逻辑
    /// </summary>
    public partial class 主页 : Page
    {
        public 主页()
        {
            InitializeComponent();
        }



        public void api地址框_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public async void api连接_Click(object sender, RoutedEventArgs e)
        {

            Uri uri = new Uri(api地址框.Text);
            var webSocket = new ClientWebSocket();
            try
            {
                await webSocket.ConnectAsync(uri, CancellationToken.None);
                // 连接成功后可进行相关操作
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败：" + ex.Message);
            }

        }

    }
}
