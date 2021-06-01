using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

namespace _012Task3Basic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime Date;
        DispatcherTimer timer = new DispatcherTimer();
        private TimeSpan SpanTime;
        Stopwatch sw = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Date = DateTime.Now;
            
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += new EventHandler(tickTimer);
            timer.Start();

        }
        private void tickTimer(object sender, EventArgs e) {
            long tick = DateTime.Now.Ticks - Date.Ticks;
            DateTime stopWath = new DateTime();
            stopWath = stopWath.AddTicks(tick);
            label1.Content = String.Format("{0:HH:mm:ss:ff}", stopWath);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {   
            timer.Stop();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            label1.Content = "00:00:00:00";
        }
    }
}
