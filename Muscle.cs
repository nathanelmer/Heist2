using System;

namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Specialty { get; } = "Muscle";
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            if (bank.SecurityGuardScore > 0)
            {
                Console.WriteLine($"{Name} is distracting the security guard. Decrease security {SkillLevel} points.");
            }
            else
            {
                Console.WriteLine($"{Name} brutally murdered the security guard... like WTF bruh? You coulda just knocked him out?!");
            }
        }

        public Muscle(string nayme, int skeel, int pct)
        {
            Name = nayme;
            SkillLevel = skeel;
            PercentageCut = pct;
        }
    }
}