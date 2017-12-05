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

        public class AIlevel
        {
            private int level;

            public AIlevel()
            {
                level = 1;
            }
            public AIlevel(int lvl)
            {
                if (lvl > 3 || lvl < 1)
                {
                    throw new InvalidOperationException("Level entered does not meet requirments. Enter a level between 1 and 3");
                }
                level = lvl;
            }

            public void AIAction()
            {
                if (level == 1)
                {

                }
                else if (level == 2)
                {

                }
                else if (level == 3)
                {

                }
            }
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
