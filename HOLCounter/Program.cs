using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string hw = "Hello World!".ToLower();
            
            
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < hw.Length; i++)
            {
                if (hw[i] == 'h') 
                    hCounter++;

                if (hw[i] == 'o')
                    oCounter++;
            
                if (hw[i] == 'l')
                    lCounter++;
            }
            Console.WriteLine($"Fraasis 'Hello World!' on {hCounter}, 'h' täht, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
            
        }
    }
}
