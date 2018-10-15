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

namespace Morabaraba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuScreen : Window, IQuit
    {
        Loading begin;
        PlayScreen launch;
        PlayerMenu trail;

        private DispatcherTimer timer;
        private DispatcherTimer t;

        public MenuScreen()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.IsEnabled = true;
            timer.Tick += Load;
            trail = new PlayerMenu();
            trail.Hide();
            begin = new Loading();

            launch = new PlayScreen();
            begin.Show();

           
            launch.Hide();
            
            menu.Hide();


        }

        private void Load(object sender, EventArgs e)
        {
            menu.Show();
            timer.IsEnabled = false;
        }

        public void Quit_Click(object sender, RoutedEventArgs e)
        {
            begin.Close();

        }

        public void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            menu.Hide();
            trail.ShowDialog();
        }

        private void Saved_Click(object sender, RoutedEventArgs e)
        {
            
            /*int dwStartTime = System.Environment.TickCount;

            while (true)

            {

                if (System.Environment.TickCount - dwStartTime > 1000) break; //1000 milliseconds 

            }*/      
        }
    }
}
