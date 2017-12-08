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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadEa_Checked(object sender, RoutedEventArgs e)
        {
            AI Easy = new AI(1);
            Easy.AIPlacement();
            RadEa.IsEnabled = false;
            RadHard.IsEnabled = false;
            RadMed.IsEnabled = false;
        }

        private void RadMed_Checked(object sender, RoutedEventArgs e)
        {
            AI Medium = new AI(2);
            Medium.AIPlacement();
            RadEa.IsEnabled = false;
            RadHard.IsEnabled = false;
            RadMed.IsEnabled = false;
        }

        private void RadHard_Checked(object sender, RoutedEventArgs e)
        {
            AI Hard = new AI(3);
            Hard.AIPlacement();
            RadEa.IsEnabled = false;
            RadHard.IsEnabled = false;
            RadMed.IsEnabled = false;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            BattleShipPlacement BSPWindow = new BattleShipPlacement();
            if (RadHard.IsEnabled == false || RadEa.IsEnabled == false || RadMed.IsEnabled == false)
            {
                BSPWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose a difficulty to begin.");
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
