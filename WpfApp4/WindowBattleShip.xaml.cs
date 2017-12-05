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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for WindowBattleShip.xaml
    /// </summary>
    public partial class WindowBattleShip : Window
    {
        public WindowBattleShip()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeadB_Click(object sender, RoutedEventArgs e)
        {
            LeaderBoard stats = new LeaderBoard();
            stats.Show();
            
        }

        private void RadEa_Checked(object sender, RoutedEventArgs e)
        {
            AIlevel Easy = new AIlevel(1);
            Easy.AIAction();
        }

        private void RadMed_Checked(object sender, RoutedEventArgs e)
        {
            AIlevel Medium = new AIlevel(2);
            Medium.AIAction();
        }

        private void RadHard_Checked(object sender, RoutedEventArgs e)
        {
            AIlevel Hard = new AIlevel(3);
            Hard.AIAction();
        }
    }
}
