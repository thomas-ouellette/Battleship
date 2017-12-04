using System;

public class Ship
{
    // public int Id { get { return _id; } set { _id = value; } }

    // number of hits ship has left before it is sunk
    private int healthPoints;
    // 1 = left, 2 = up, 3 = right, 4 = down
    private int facing;

    // propreties
    public int Health { get { return healthPoints; } private set { } }
    public int Direction { get { return facing; } private set { } }
    private string shipType;


	public Ship(string type, int healthPoints, int direction)
	{
        this.healthPoints = healthPoints;
        this.shipType = type;
        this.facing = direction;

    }

    public void hit()
    {
        if (healthPoints > 0)
            healthPoints--;
        else
        {

        }
    }
}
