using ChatWPFEntityF;
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



            using (ChatDb c = new ChatDb())
            {

                ChatRoom chat = new ChatRoom() {/* Senders = s, Recievers = c.Messages.Select(d => d.Recievers.First()).ToList() */};
                Reciever r = new Reciever() { Chat = chat, };
                Sender s = new Sender() { Chat = chat };




                //  sender_img.Source = new BitmapImage(new Uri(c.Users.Select(u =>u.Sender.Users.Select().ToString());

                //    reciever_img.Source = new BitmapImage(new Uri(s.Chat.Senders.Select(u => u.Users.First().UserPhotoPath).ToString()));
            }

        }

        private void Btn_Send_Click(object sender, RoutedEventArgs e)
        {
            TextBlock tb = new TextBlock();
            tb.Text = tb_message.Text;

            using (ChatDb db = new ChatDb())
            {
                Text t = new Text() { TextValue = tb_message.Text };

                var txt = db.Messages.Select(m => m.Texts);
                db.Texts.Add(t);
             
                Message message = db.Messages.Add(new Message() { Texts = db.Texts.Where(g=>g.Id==1).ToList() });
            tb_message.Text = "";
            tbpanel.Children.Add(tb);
                db.SaveChanges();
                
            };
           

    }
            
       



               // db.Messages.Select()


       
    }
}
