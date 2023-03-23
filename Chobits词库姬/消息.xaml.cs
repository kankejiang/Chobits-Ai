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
using System.Net.WebSockets;
using System.Threading;
using System.ComponentModel;



namespace Chobits词库姬
{
    /// <summary>
    /// 消息.xaml 的交互逻辑
    /// </summary>
    public partial class 消息 : Page
    {

        public 消息()
        {
            InitializeComponent();
        }
       

        private async void ConnectToWebSocket()
        {
            try
            {
                主页 new主页 = new 主页();
                TextBox textBox = new主页.api地址框;
                string text = new主页.api地址框.Text;
                using var socket = new ClientWebSocket();
                var uri = new Uri(text);
                await socket.ConnectAsync(uri, CancellationToken.None);

                var buffer = new byte[1024 * 4];

                while (socket.State == WebSocketState.Open)
                {
                    var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        Dispatcher.Invoke(() => MessageRichTextBox.AppendText(message));
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void MessageRichTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            ConnectToWebSocket();
        }

        private void MessageRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageRichTextBox.ScrollToEnd();
        }
    }
            
    
    
}
