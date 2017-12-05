using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Player
    {
        private string playername;

        public string PlayerName { get { return playername; } }

        public Player(string name)
        {
            this.playername = name;
        }

        public void move()
        {

        }
    }
}
