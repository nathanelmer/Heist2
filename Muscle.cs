using System;

namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            if (bank.SecurityGuardScore > 0)
            {
                Console.WriteLine($"{Name} is distracting the security guard. Decrease security {SkillLevel} points.");
            }
            else
            {
                Console.WriteLine($"{Name} murdered the security guard.");
            }
        }
    }
}