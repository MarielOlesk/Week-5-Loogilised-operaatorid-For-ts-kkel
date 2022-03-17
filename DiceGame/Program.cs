using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi võitja.
            //*täringuid visatakse 3x 
            //programm kuulutab võitja


            
            Random rnd = new Random();

            
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i ++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise

                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}, kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    cpuScore = cpuScore + 1;
                }
            }
            if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne");
            }
            else if (userScore < cpuScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud. Palju õnne");
            }
            else
            {
                Console.WriteLine("Viik");
            }
        }
    }
}
