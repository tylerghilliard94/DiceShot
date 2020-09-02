using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next((DiceSize / 2), DiceSize) + 1;
        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object\



            try
            {



                int myRoll = Roll();
                int otherRoll = other.Roll();

                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine("No...NO NO No NO *throws dice*");
                    throw new Exception();

                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("*screeching ensues*");
                Console.WriteLine("");
                Console.WriteLine("DiCEShOt...>..e.x..e ha     s  stope     wo kin   g");
                Console.WriteLine("Unhandled exception. System.Exception: Exception of type 'System.Exception' was thrown.");
                Console.WriteLine("ajkabgfljblgkjbsfgbsafjbdgls;zjhgf;ksfzbgsfgghlsfg'sarldjkgksfhgknslga;ngsk;sgb;leg");
                Console.WriteLine("akjhfnjkasbfil;oasnlgsdfg,.smfg;akdhjftoialskhfoiahgfiagdksfjklanflkagflaisdhkjasbfjkad");
                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("DiceShot.exe Resuming....");
                Console.WriteLine("");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(3000);

                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".......");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".........");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("............");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("...............");

            }

        }




    }
}