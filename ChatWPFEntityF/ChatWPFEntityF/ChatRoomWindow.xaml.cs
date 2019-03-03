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
using System.Windows.Shapes;

namespace ChatWPFEntityF
{
    /// <summary>
    /// Interaction logic for ChatRoomWindow.xaml
    /// </summary>
    public partial class ChatRoomWindow : Window
    {
        public string username { get; set; }
        public ChatRoomWindow()
        {
            InitializeComponent();

          
            

            using (ChatDb c = new ChatDb())
            {
               
                          
                foreach (var item in c.Users)
                {
                    Button b = new Button();
                    b.Background = Brushes.LightBlue;
                    b.Foreground = Brushes.White;
                    b.FontSize = 18;
                    b.Content = item.Login;
                    b.Click += Button_Click;
                    st_users.Children.Add(b);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            username = (sender as Button).Content.ToString();
            Connections con = new Connections();
          //  if(this.DialogResult==true)
            con.Show();
        }
    }
}
