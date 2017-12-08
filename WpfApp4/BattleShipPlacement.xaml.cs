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
        double mouseX, mouseY;
        Image selected;
        Ship[] ships = new Ship[5];
        int counter = 0;
        public BattleShipPlacement()
        {
            InitializeComponent();
        }

        private void ShipPlacementNextButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO if the ships are not all places display an error message saying that 
            //the user must place all the ships in order to be able to play the game.

            WindowBattleShip WBS = new WindowBattleShip();
            WBS.Show();
            this.Close();
        }

        private void GridBattleShipPlacement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(selected != null)
            {

                mouseX = e.GetPosition(GridBattleShipPlacement).X;
                mouseY = e.GetPosition(GridBattleShipPlacement).Y;
                
                Image i = new Image();
                i.Width = selected.Width;
                i.Height = selected.Height;
                i.Source = selected.Source;
                /*
                Thickness margin = selected.Margin;
                margin.Left = 700 + mouseX;
                margin.Top = 100 + mouseY;
                i.Margin = margin;
                */
                Grid.SetColumn(i, (int)(mouseX/40));
                Grid.SetColumn(i, (int)(mouseX / 40));
                Grid.SetRow(i, (int)(mouseY / 40));
                GridBattleShipPlacement.Children.Add(i);

                selected.Visibility = Visibility.Hidden;
                selected = null;
            }
        }

        private void Boat31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = Boat31;
            
        }

        private void Boat32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = Boat32;
        }

        private void Boat4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = Boat4;
        }

        private void Boat5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = Boat5;
        }

        private void Boat2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            selected = Boat2;
        }

        

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
