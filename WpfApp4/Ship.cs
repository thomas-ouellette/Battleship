namespace WpfApp4
{
    [System.Serializable()]
    public class Ship
    {
        // public int Id { get { return _id; } set { _id = value; } }


        private int healthPoints;
        // 1 = left, 2 = up, 3 = right, 4 = down
        private int facing;
        private string type;
        private bool isSunk;

        // propreties
        public int Health { get { return healthPoints; } private set { } }
        public int Direction { get { return facing; } private set { } }
        public string ShipType { get { return type; } private set { } }

        public Ship() { }

        public Ship(string type, int healthPoints, int direction)
        {
            this.healthPoints = healthPoints;
            this.isSunk = false;
            this.type = type;
            this.facing = direction;


        }

        public void hit()
        {
            if (healthPoints > 0)
            {
                healthPoints--;

                if (healthPoints == 0)
                {
                    isSunk = true;
                }
            }
        }
    }
}
