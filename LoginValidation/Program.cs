using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // küsib kasutajalt tunnus ja salasõna
            // kui sisestatud tunnus on admin ja salasõna on admin1234
            // siis kuvatakse "tere tulemast"
            // muul juhul "vale kasutajatunnus või parool. Proovi uuesti"
            // kasutajal on kolm katset

            int counter = 0;

            while (counter < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");

                String userName = Console.ReadLine();

                Console.WriteLine("Sisesta salasõna:");

                String userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");

                    counter++;
                }
                else
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
            }
        }
    }
}
