using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();
            
            Muscle muscleRoy = new Muscle();
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
            rolodex.Add(hackerHarold);

            Questions.AskQuestions(rolodex);
        }
    }
}
