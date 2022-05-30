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
using System.Timers;

namespace clock
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public System.Timers.Timer timer1 = new System.Timers.Timer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer1.Interval = 1;

            timer1.Enabled = true;
            timer1.Elapsed += OnTimedEvent;
            timer1.Start();

        
           
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                lblTime.Content = DateTime.Now.ToString("yyyy/MM/dd" + "\r\n" + "HH:mm:ss.fff");
            }));
            

        }
    }
}
