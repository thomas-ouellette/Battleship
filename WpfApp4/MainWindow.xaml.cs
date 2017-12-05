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

      

        public class AIlevel
        {
            private int level;
            public AIlevel()
            {
                level = 1;
            }
            public AIlevel(int lvl)
            {
                if(lvl >3 || lvl <1)
                {
                    throw new InvalidOperationException("Level entered does not meet requirments. Enter a level between 1 and 3");
                }
                level = lvl;
            }

            public void AIAction()
            {
                if(level == 1)
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
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            WindowBattleShip winBS = new WindowBattleShip();
            winBS.Show();
            this.Close();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
