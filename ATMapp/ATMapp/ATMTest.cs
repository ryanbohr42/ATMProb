using System;

namespace ATMapp
{
    class ATMTest
    {
        static void Main(string[] args)
        {
            ATM machine = new ATM();

            bool quit = false;
            while (!quit)
            {
                String order = Console.ReadLine();
                String[] breakdown = order.Split(" ");
                char command;
                if (breakdown[0].Equals(""))
                    command = 'F';
                else
                    command = Convert.ToChar(breakdown[0].ToUpper().Substring(0,1));

                switch (command)
                {
                    case 'R':
                        {
                            machine.reset();
                            machine.displayAmounts();
                            break;

                        }
                    case 'W':
                        {
                            if (machine.withdraw(int.Parse(breakdown[1].Substring(1))))
                            {
                                Console.WriteLine("Success: Dispensed " + breakdown[1]);
                                machine.displayAmounts();
                            }
                            else
                                Console.WriteLine("Failure: insufficient funds");
                            break;
                        }
                    case 'I':
                        {
                            machine.denominations(breakdown);
                            break;
                        }
                    case 'Q':
                        {
                            Console.WriteLine("Thank you.");
                            quit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Failure: Invalid Command");
                            break;
                        }

                }
            }
        }
    }
}
