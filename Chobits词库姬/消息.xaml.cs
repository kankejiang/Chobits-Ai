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
                var socket = new ClientWebSocket();
                var uri = new Uri(""); // specify your WebSocket URL
                await socket.ConnectAsync(uri, CancellationToken.None);

                var buffer = new byte[1024 * 4];
                while (socket.State == WebSocketState.Open)
                {
                    var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        Dispatcher.Invoke(() => { MessageRichTextBox.AppendText(message); }); // update UI in main thread
                    }
                }
            }
            catch (Exception ex)
            {
                // handle exception
            }
        }

        private void MessageRichTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            ConnectToWebSocket();

        }
            

    }
            
    
    
}
