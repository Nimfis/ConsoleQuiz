using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE
{
    static class InputBlocker
    {
        public static void BlockUserInput()
        {
            Console.TreatControlCAsInput = true;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                    if (keyInfo.Key != ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break; 
                    }
                }
            }

            Console.TreatControlCAsInput = false;
        }
    }
}

