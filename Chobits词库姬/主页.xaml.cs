
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
using MySqlX.XDevAPI.Common;
using System.Net.Sockets;
using Org.BouncyCastle.Bcpg;
using static Chobits词库姬.消息;
using System.Xml.Linq;
using System.IO;

namespace Chobits词库姬
{
    /// <summary>
    /// 主页.xaml 的交互逻辑
    /// </summary>
    public partial class 主页 : Page
    {
        private string configFilePath = @"config.ini";
        public 主页()
        {
            InitializeComponent();
            // 检查config.ini是否存在，若不存在则新建一个
            if (!File.Exists(configFilePath))
            {
                File.Create(configFilePath).Close();
            }

            // 读取config.ini文件中保存的内容并自动输入到TextBox中
            if (File.Exists(configFilePath))
            {
                string content = File.ReadAllText(configFilePath);
                api地址框.Text = content;
            }

        }

        public void api地址框_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // 声明异步点击事件处理函数
        public async void api连接_Click(object sender, RoutedEventArgs e)
        {
            // 获取输入框中的API地址
            Uri uri = new Uri(api地址框.Text+"");

            // 创建客户端WebSocket对象
            var webSocket = new ClientWebSocket();

            try
            {
                // 异步连接到指定的API地址
                await webSocket.ConnectAsync(uri, CancellationToken.None);
                string content = api地址框.Text;
                File.WriteAllText(configFilePath, content);

            }
            
            catch (Exception ex)
            {
                // 异常处理，显示错误信息
                MessageBox.Show("连接失败：" + ex.Message);
            }
        }
        

    }

}

