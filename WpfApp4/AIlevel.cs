using System;
using System.Windows;
using WpfApp4;

public class AI
{
    private int level;
    public Random rnd = new Random();
    public int directionAI;
    private String[,] BOARD = new String[10,10];
  


    public AI()
    {
        BOARD = new string[,]{
            { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" }, { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10" },
            { "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10" },{ "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10" },{ "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10" },
            { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10" },{ "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" },{ "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10" },
            { "J1", "J2", "J3", "J4", "J5", "J6", "J7", "J8", "J9", "J10" }
        };

        level = 1;
        directionAI = rnd.Next(1, 5);
        


    }
    public AI(int lvl) : this()
    {
        if (lvl > 3 || lvl < 1)
        {
            throw new InvalidOperationException("Level entered does not meet requirments. Enter a level between 1 and 3");
        }
        level = lvl;

       
    }
    public String[,] getBoardCord()
    {
        return BOARD;
    }
    public void AIPlacement()
    {
        Ship Carrier = new Ship("Carrier", 5);
        Ship Battleship = new Ship("Battleship", 4);
        Ship Cruiser = new Ship("Cruiser", 3);
        Ship Submarine = new Ship("Submarine", 3);
        Ship Destroyer = new Ship("Destroyer", 2);

        int CarLength = Carrier.Health;
        int BSLength = Battleship.Health;
        int CruLength = Cruiser.Health;
        int SubLength = Submarine.Health;
        int DesLength = Destroyer.Health;
        
    }
    public int AI_Attack()
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
        return 0;
    }
}