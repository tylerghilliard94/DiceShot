using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            OneHigherPlayer player2 = new OneHigherPlayer();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer player3 = new SmackTalkingPlayer();
            player3.Name = "Wilma";
            player3.Taunt = "Wilma: Wow you suck!";

            player3.Play(player2);

            Console.WriteLine("-------------------");
            HumanPlayer player4 = new HumanPlayer();
            player4.Name = "Willy";

            player4.Play(player3);

            Console.WriteLine("-------------------");
            CreativeSmackTalkingPlayer player5 = new CreativeSmackTalkingPlayer();
            player5.Name = "Kelly";

            player5.Play(player4);


            Console.WriteLine("-------------------");



            UpperHalfPlayer player7 = new UpperHalfPlayer();
            player7.Name = "Shelly";

            player7.Play(player5);


            Console.WriteLine("-------------------");
            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");
            SoreLoserPlayer player6 = new SoreLoserPlayer();
            player6.Name = "Brandon";

            player6.Play(player5);


            Console.WriteLine("-------------------");

            SoreLoserUpperHalfPlayer player8 = new SoreLoserUpperHalfPlayer();
            player8.Name = "Amanda";

            player8.Play(player7);


            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, player4,player5, player6, player7, player8, large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}