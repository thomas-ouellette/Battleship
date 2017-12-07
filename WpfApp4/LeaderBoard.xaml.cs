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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LeaderBoard: Window
    {
        public LeaderBoard()
        {
            InitializeComponent();
        }
       
        public class Leaderboard
        {
            private String playerName;
            private int Score;
            public String[] names;



            public Leaderboard()
            {
                playerName = "";
                Score = 0;
            }
            
            public Leaderboard(String name, int ScoreNum)
            {
                playerName = name;
                Score = ScoreNum;
            }

            public String getName()
            {
                return playerName;
            }
            public int getScore()
            {
                return Score;
            }
            public String setName(String str)
            {
                return this.playerName = str;
            }

            public int setScore(int scr)
            {
                return this.Score = scr;
            }
           
            public void UpdateLeader(String name, int score)
            {
                /*if(gameisOver = true)
                {

                }*/


            }
        }
       
    }
}
