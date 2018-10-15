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

namespace Morabaraba
{
    /// <summary>
    /// Interaction logic for PlayerMenu.xaml
    /// </summary>
    public partial class PlayerMenu : Window, IQuit
    {
        PlayScreen launch;

        public PlayerMenu()
        {
            InitializeComponent();
        }

        public void Quit_Click(object sender, RoutedEventArgs e)
        {
            PlayerPick.Close();
        }
        public void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            launch = new PlayScreen(avatar1.Source, p1Name.Text, avatar2.Source, p2Name.Text);

            PlayerPick.Hide();
            launch.ShowDialog();
            PlayerPick.Close();

        }

        private void avatar1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (avatar1selection.SelectedIndex)
            {
                case 0:
                    avatar1.Source = new BitmapImage(new Uri("Images/ninja.png", UriKind.Relative));
                    break;
                case 1:
                    avatar1.Source = new BitmapImage(new Uri("Images/Afro.png", UriKind.Relative));
                    break;
                case 2:
                    avatar1.Source = new BitmapImage(new Uri("Images/cameron.jpg", UriKind.Relative));
                    break;
            }              
        }

        private void avatar2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (avatar2selection.SelectedIndex)
            {
                case 0:
                    avatar2.Source = new BitmapImage(new Uri("Images/ninja.png", UriKind.Relative));
                    break;
                case 1:
                    avatar2.Source = new BitmapImage(new Uri("Images/Afro.png", UriKind.Relative));
                    break;
                case 2:
                    avatar2.Source = new BitmapImage(new Uri("Images/cameron.jpg", UriKind.Relative));
                    break;
            }
        }
    }
}
