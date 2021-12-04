using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //program palub kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb neist on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta enda eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta enda perekonnanimi:");
            string lastName = Console.ReadLine();
            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimes on rohkem sümboleid, kui perekonnanimes.");
            }
            else if (lastName.Length > firstName.Length)
            {
                Console.WriteLine("Sinu perekonnanimes on rohkem sümboleid, kui eesnimes.");
            }
            else
            {
                Console.WriteLine("Sinu ees-ja perekonna nimes on samapalju sümboleid.");
            }


        }
    }
}
