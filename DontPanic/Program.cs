using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Dont Panic" nulliga -0
            //programm asendab kõik 'a' tähed samas lauses 4-ga

            string phrase = "Don't Panic";
   
            phrase = phrase.Replace('o', '0');
            phrase = phrase.Replace('a', '4');
            Console.WriteLine(phrase);

        }
    }
}
