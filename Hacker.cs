using System;

namespace Heist2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            if (bank.AlarmScore > 0)
            {
                Console.WriteLine($"{Name} is hacking the alarm. Decrease security {SkillLevel} points.");
            }
            else
            {
                Console.WriteLine($"{Name} has taken down the alarm.");
            }
        }
    }
}