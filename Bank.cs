using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure { get; set; }
        public Bank()
        {
            AlarmScore = new Random().Next(0, 101);
            VaultScore = new Random().Next(0, 101);
            SecurityGuardScore = new Random().Next(0, 101);
            CashOnHand = new Random().Next(50000, 1000001);
        }
        public void ReconReport()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>()
            {
                {"Alarm score", AlarmScore},
                {"Vault score", VaultScore},
               { "Security guard score", SecurityGuardScore}
            };
            Console.WriteLine($"{scores.OrderBy(s => s.Value).First().Key} is the weakest security point!");
            Console.WriteLine($"{scores.OrderBy(s => s.Value).Last().Key} is the strongest security point!");


            // var orderedScores = scores.OrderBy(s => s.Value);
            // foreach (KeyValuePair<string, int> item in orderedScores)
            // {
            //     Console.WriteLine($"{item.Key} is the string name");
            //     Console.WriteLine($"{item.Value} is the int value");
            // }
        }

        public void DidYaWin(List<IRobber> thiefs)
        {
            foreach (IRobber thief in thiefs)
            {
                thief.PerformSkill(this);
            }

            if (AlarmScore > 0 || SecurityGuardScore > 0 || VaultScore > 0)
            {
                Console.WriteLine("Mission Failed, We will get them nmext time");
            }
            else
            {
                Console.WriteLine("You did it!");
                foreach (IRobber rob in thiefs)
                {
                    Console.WriteLine($"{rob.Name} took {CashOnHand * (rob.PercentageCut / 100)}");
                }
            }
        }


    }
}