using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace _015Task2Professional
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            btnCloseDB.IsEnabled = false;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
            
        }
        async void timer_Tick(object sender, EventArgs e)
        {
            txtMessage.Text += await Task.Run(()=> "Данные получены\n");
        }

        private async void btnConnectDB_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            btnConnectDB.IsEnabled = false;
            Thread.Sleep(3000);
            txtMessage.Text += await Task.Run(()=> 
                "Подключен к базе данных\n"
            );
            btnCloseDB.IsEnabled = true;
        }

        private async void btnCloseDB_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            btnCloseDB.IsEnabled = false;
            Thread.Sleep(3000);
            txtMessage.Text += await Task.Run(() =>
                "Отключен от базы данных\n"
            );
            btnConnectDB.IsEnabled = true;
        }
    }
}
