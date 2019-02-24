using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
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


namespace ChatWPFEntityF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 3.Чат.
            //Краткое описание: Чат на основе базы данных.Клиентские приложения оставляют
            //сообщения на сервере баз данных в базе и забирают нужные им сообщения.Принцип
            //действия.Клиент подключается к серверу БД.При посылке сообщения программа вносит
            //запись в базу. Остальные клиенты, при проверке обновлений в БД, видят это сообщение и
            //забирают себе его. Таким образом, чат функционирует без серверной части. В базе хранятся
            //также списки контактов, история сообщений, история подключений. По запросу
            //пользователя, программа должна показать, статистику общения с различными
            //пользователями.
            //Рабочая среда: Локальная сеть.
            //База данных: Удаленная база данных на сервере, в пределах локальной сети.
            //Данные для хранения: пользователи, контакты, сообщения.
            //Пользователи: клиенты локальной сети.
            //Информация, поступающая в базу: новые пользователи, новые контакты, сообщения.
            //Отчеты: статистика интенсивности общения за указанный период.


            using (ChatDb ctx = new ChatDb())
            {
                ctx.Users.Count();
                ctx.SaveChanges();


            }


        }

     

        private void ServerList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Connections_Click(object sender, RoutedEventArgs e)
        {
            Connections connections = new Connections();
            connections.ShowDialog();



        }

        private void Btn_signup_Click(object sender, RoutedEventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }
    }
}
