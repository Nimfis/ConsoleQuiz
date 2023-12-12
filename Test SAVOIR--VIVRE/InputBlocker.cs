namespace Test_SAVOIR__VIVRE
{
    static class InputBlocker
    {
        public static void WaitForEnter()
        {
            Console.TreatControlCAsInput = true;
            Console.WriteLine();
            TextCenterer.PrintCenteredText("Nacisnij <ENTER> aby kontynuować.");
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

