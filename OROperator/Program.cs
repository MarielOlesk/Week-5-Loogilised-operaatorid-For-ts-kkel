using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            // kui sisestatu tunnus on admin ja salasõna on admin1234
            // siis konsoolis kuvatakse "tere tulemast"
            // muul juhul "vale kasutajatunnus või salasõna. Proovi uuesti"

            //OR (või) || (pipes)

            // true || true --> true
            // false || true --> true
            // true || false --> true
            // false || false --> false 


            Console.WriteLine("Sisesta kasutajatunnus:");

            String userName = Console.ReadLine();

            Console.WriteLine("Sisesta salasõna:");

            String userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }

            // "admin1" != "admin" || "admin1234" != "admin 1234" --> true || false --> true
            // "admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            // "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
            // "admin" != "admin" || "admin1234" != "admin 1234" --> false || false --> false
        }
    }
}
