using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> Taunt = new List<string>(){
            "Wow you suck!", "That's crazy that you're that dumb...", "Learn to throw down the gauntlet!", "welp...sucks to be you.."
        };



        public override int Roll()
        {
            Random randomNumber = new Random();
            int randomInt = randomNumber.Next(0, Taunt.Count);

            string comboTaunt = Taunt[randomInt];
            Console.WriteLine($"{Name}: {comboTaunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}