using ChatWPFEntityF.MyEntities;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace ChatWPFEntityF
{
    /// <summary>
    /// Interaction logic for Connections.xaml
    /// </summary>
    public partial class Connections : Window
    {
        public Connections()
        {

            InitializeComponent();

            Reciever r = new Reciever();
            Sender s = new Sender();


            sender_img.Source = new BitmapImage(new Uri(s.Chat.Senders.Select(u => u.Users.Select(c => c.UserPhotoPath)).ToString()));

            reciever_img.Source = new BitmapImage(new Uri(s.Chat.Recievers.Select(u => u.Users.Select(c=>c.UserPhotoPath)).ToString()));

        }

        private void Btn_Send_Click(object sender, RoutedEventArgs e)
        {
            TextBlock tb = new TextBlock();
            tb.Text = tb_message.Text;
            tb_message.Text = "";
            st_show.Children.Add(tb);

            Text t = new Text() { TextValue = tb_message.Text };



            using (ChatDb db = new ChatDb())
            {
              
            }
        }
    }
}
