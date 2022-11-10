using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 5000);
        Player player2 = new Player("Water Turtle");

        player1.PrintHealth();
        player2.PrintHealth();
    }
}
