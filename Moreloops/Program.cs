﻿using System;

namespace Moreloops
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            // kui sisestatu tunnus on admin ja salasõna on admin1234
            // siis konsoolis kuvatakse "tere tulemast"
            // muul juhul "vale kasutajatunnus või salasõna. Proovi uuesti"

            Console.WriteLine("Sisesta kasutajatunnus:");

            String userName = Console.ReadLine();

            Console.WriteLine("Sisesta salasõna:");

            String userPassword = Console.ReadLine();

            //AND (&&) või OR

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            // "admin1" AND "admin123" --->false

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");
            }
        }
    }
}
