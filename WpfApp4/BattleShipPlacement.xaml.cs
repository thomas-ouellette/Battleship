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
    /// Interaction logic for BattleShipPlacement.xaml
    /// </summary>
    public partial class BattleShipPlacement : Window
    {
        int x, y;
        public BattleShipPlacement()
        {
            InitializeComponent();
            ButtonGeneratorV2(10,10);
        }

        private void ShipPlacementNextButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO if the ships are not all places display an error message saying that 
            //the user must place all the ships in order to be able to play the game.

            WindowBattleShip WBS = new WindowBattleShip();
            WBS.Show();
            this.Close();
        }

        private void ButtonGeneratorV2(int col, int rows)
        {
            Grid newGrid = new Grid();
            for (int i = 0; i < rows; i++)
                newGrid.RowDefinitions.Add(new RowDefinition());
            for (int i = 0; i < col; i++)
                newGrid.ColumnDefinitions.Add(new ColumnDefinition());

            for (x = 0; x < rows; x++)
            {
                for (y = 0; y < col; y++)
                {
                    Button btn = new Button();
                    btn.Height = 40;
                    btn.Width = 40;
                    Grid.SetColumn(btn, y);
                    Grid.SetRow(btn, x);
                    newGrid.Children.Add(btn);
                }
            }

            GridBattleShipPlacement.Children.Add(newGrid);
        }
    }
}
