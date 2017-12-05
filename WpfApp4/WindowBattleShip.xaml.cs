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

        Ship[] playerShips = new Ship[5];
        Ship[] enemyShips = new Ship[5];

        Point p;

        // string saves = ".//saves//";

        public WindowBattleShip()
        {
            InitializeComponent();
            /*
            Ship s = new Ship("asdfghjkl", 5, 1);

            Serialize(s, "ship1");
            Ship newship = (Ship)(DeSerialize("ship1"));

            MessageBox.Show(newship.ShipType);*/
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString().Substring(sender.ToString().LastIndexOf(" ")));

        }

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

    }
}
