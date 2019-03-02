using Microsoft.Win32;
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
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        User MainUser;
      
        public CreateUser()
        {
            InitializeComponent();

            n_img.Source = new BitmapImage(new Uri(@"C:\Users\User\Source\Repos\CourseEF\ChatWPFEntityF\ChatWPFEntityF\img\no_photo.png"));

        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(btn_save.Content.ToString()))
            {
                User u = new User() { Login = tb_login.Text, Password = tb_password.Text, UserPhotoPath = tb_img.Text };
                MainUser = u;
                using (ChatDb c = new ChatDb())
                {
                    c.Users.Add(u);
                    c.SaveChanges();
                }
                //this.DialogResult = true;
                ChatRoomWindow chatRoomWindow = new ChatRoomWindow();
                chatRoomWindow.Show();
            }

        }

        private void Btn_img_Click(object sender, RoutedEventArgs e)
        {
           
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    tb_img.Text = openFileDialog.FileName;
                    n_img.Source= new BitmapImage(new Uri(openFileDialog.FileName));
            }
               
           
        }
    }
}
