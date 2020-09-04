using System;
using System.Threading;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
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
                Thread.Sleep(6 * 1000);
                Console.WriteLine(""); Console.WriteLine("");
                Console.WriteLine("DiceShot.exe Resuming....");
                Thread.Sleep(3 * 1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine(".....");
                Thread.Sleep(1000);
                Console.WriteLine(".......");
                Thread.Sleep(1000);
                Console.WriteLine(".........");
                Thread.Sleep(1000);
                Console.WriteLine("............");
                Thread.Sleep(1000);
                Console.WriteLine("...............");

            }

        }
    }
}