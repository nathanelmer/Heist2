using System;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
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
    }
}