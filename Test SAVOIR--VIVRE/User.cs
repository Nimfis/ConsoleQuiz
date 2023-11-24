using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE
{
    internal class User
    {
        public string UserName { get; private set; }

        public string ValidUserName()
        {
            bool invalidUserName;

            do
            {
                Console.WriteLine();
                Console.Write("Podaj swoje imię:");

                UserName = Console.ReadLine();

                invalidUserName = string.IsNullOrWhiteSpace(UserName);

                if (invalidUserName)
                {
                    Console.WriteLine("To pole nie może być puste.");
                }
            } while (invalidUserName);

            return UserName;
        }
    }
}

