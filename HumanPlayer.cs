using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write("What number did you roll? ");
            try
            {


                return int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("You must input a number!");
                return int.Parse(Console.ReadLine());
            }
        }
    }
}