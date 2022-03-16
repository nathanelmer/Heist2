using System;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Specialty { get; } = "Lock Specialist";
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            if (bank.VaultScore > 0)
            {
                Console.WriteLine($"{Name} is hacking the vault. Decrease security {SkillLevel} points.");
            }
            else
            {
                Console.WriteLine($"{Name} has opened the vault.");
            }
        }

        public LockSpecialist(string nayme, int skeel, int pct)
        {
            Name = nayme;
            SkillLevel = skeel;
            PercentageCut = pct;
        }
    }
}