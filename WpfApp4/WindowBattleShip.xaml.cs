﻿using System;
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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
            /*
            Ship s = new Ship("asdfghjkl", 5, 1);

            Serialize(s, "ship1");
            Ship newship = (Ship)(DeSerialize("ship1"));

            MessageBox.Show(newship.ShipType);*/
        }




        private void LeadB_Click(object sender, RoutedEventArgs e)
        {
            LeaderBoard stats = new LeaderBoard();
            stats.Show();

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

        Ship[] playerShips = new Ship[5];
        Ship[] enemyShips = new Ship[5];
       

        Point p;

        // string saves = ".//saves//";

        
        // EVENT HANDLERS
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString().Substring(sender.ToString().LastIndexOf(" ")));

        }

        private void StartBut_Click(object sender, RoutedEventArgs e)
        {

            if (RadHard.IsEnabled == false || RadEa.IsEnabled == false || RadMed.IsEnabled == false)
            {
                MessageBox.Show("Let the Battle Begin!");
            }
            else
            {
                MessageBox.Show("Please choose a difficulty to begin.");
            }
        }


        /*public string hasWon()
        {
            if (playerShips.Health() == 0)
            {
                return "AI Has won!";
            }
            else if (enemyShips.Health() == 0)
            {
                return "You Win!";
            }
            else
                return "Draw!";
        }*/






        // UTILITY METHODS
        public static void Serialize(Object o, string filespec)
        {
            IFormatter f = new BinaryFormatter();
            Stream writer = new FileStream(filespec, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            f.Serialize(writer, o);
            writer.Close();
        }

        public static Object DeSerialize(string filespec)
        {
            IFormatter f = new BinaryFormatter();
            Stream reader = new FileStream(filespec, FileMode.Open, FileAccess.Read, FileShare.None);
            Object o = f.Deserialize(reader);
            reader.Close();

            return o;
        }

        private void save()
        {
            //Serialize();
        }

        private void load()
        {

        }

    }



}
