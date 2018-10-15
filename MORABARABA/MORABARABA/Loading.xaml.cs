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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Morabaraba
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : Window
    {
        private DispatcherTimer timer;

        public Loading()
        {
            InitializeComponent();
            Duration duration = new Duration(TimeSpan.FromSeconds(20));
            DoubleAnimation doubleAnimation = new DoubleAnimation(200, duration);
            progress_bar.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);
            //  istrue = true;
            //Thread.Sleep(100);
            timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(10);
            timer.IsEnabled = true;
            timer.Tick += buffer;
        }

        private void buffer(object sender, EventArgs e)
        {
            timer.IsEnabled = false;
            Load.Close();
        }

        private void progress_bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        public void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Load.Close();
        }
    }
}
