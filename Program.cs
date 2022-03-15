using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            /* Muscle muscleRoy = new Muscle("");
             Muscle muscleMike = new Muscle();
             LockSpecialist lockSpecialistLenny = new LockSpecialist();
             LockSpecialist lockSpecialistLloyd = new LockSpecialist();
             Hacker hackerHank = new Hacker();
             Hacker hackerHarold = new Hacker();

             rolodex.Add(muscleMike);
             rolodex.Add(muscleRoy);
             rolodex.Add(lockSpecialistLenny);
             rolodex.Add(lockSpecialistLloyd);
             rolodex.Add(hackerHank);
             rolodex.Add(hackerHarold); */
            bool cont = true;
            while (cont)
            {
                Questions.AskQuestions(rolodex);
                Console.WriteLine("you wanna continue or nah? Y/N");
                string yn = Console.ReadLine().ToUpper();

                switch (yn)
                {
                    case "N":
                        cont = false;
                        break;
                    case "Y":
                        cont = true;
                        break;
                    default:
                        throw new Exception("FFS how do you keep doing this???");
                }
            }
            Bank RandomizedBank = new Bank();
            RandomizedBank.ReconReport();
        }
    }
}
