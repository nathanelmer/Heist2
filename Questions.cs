using System;
using System.Collections.Generic;

namespace Heist2
{
    public class Questions
    {
        public static void AskQuestions(List<IRobber> rolodex)
        {
            Console.WriteLine($"There are {rolodex.Count} operatives currently available to select from.");
            Console.WriteLine("Please enter the name of the new robber.");
            string newRobberName = Console.ReadLine();

            Console.WriteLine("Choose a speciality.");
            Console.WriteLine("1. Hacker");
            Console.WriteLine("2. Lock Specialist");
            Console.WriteLine("3. Muscle");
            int newRobberSpecialty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new robber's skill level. (0-100)");
            int newRobberSkill = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percentage cut of the new robber.");
            int newRobberCut = int.Parse(Console.ReadLine());


            switch (newRobberSpecialty)
            {
                case 1:
                    rolodex.Add(new Hacker(newRobberName, newRobberSkill, newRobberCut));
                    break;
                case 2:
                    rolodex.Add(new LockSpecialist(newRobberName, newRobberSkill, newRobberCut));
                    break;
                case 3:
                    rolodex.Add(new Muscle(newRobberName, newRobberSkill, newRobberCut));
                    break;
                default:
                    throw new Exception("yo wtf did you do???");
            }




        }
    }
}