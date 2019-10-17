using System;

namespace atm
{
    class ATM
    {
        private ATMState atmState = new ATMState();
        private Account customer = null;
        private bool exit = false;

        public void startATM()
        {
            atmState.TurnOn();
            do
            {
                atmState.CheckAndWriteState();
                getCommand();
            }
            while (atmState.IsTurned());
        }

        public void getCommand()
        {
            Console.Write("$: ");
            string input = Console.ReadLine();
            atmState.CommandToState(SplitCommand(input));
            Console.Clear();
            atmState.CheckAndWriteState();
            DoCommand(SplitCommand(input));
        }

        private String[] SplitCommand(string command)
        {
            return command.Split(" ");
        }

        private void DoCommand(string[] command)
        {
            if(customer == null && command[0] != "insert" && command[0] != "exit")
            {
                Console.WriteLine("Not logged! Type: insert card");
                return;
            }
            switch (command[0])
            {
                case "insert":
                    customer = new Account();
                    AuthorizeCard(customer.Card);
                    break;
                case "balance":
                    Console.WriteLine("Your balance: {0} PLN", customer.Balance);
                    break;
                case "withdraw":
                    int amount = Convert.ToInt32(command[1]);
                    customer.changeBalance(-amount);
                    Console.WriteLine("Withdraw {0} PLN. Your balance: {1}", amount, customer.Balance);
                    break;
                case "exit":
                    Console.Clear();
                    Console.WriteLine("Exiting");
                    System.Threading.Thread.Sleep(1000);
                    atmState.State = ATMState.States.Off;
                    break;
                default:
                    Console.WriteLine("Command not recognized");
                    break;
            }
        }

        private void AuthorizeCard(Card card)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Type PIN: ");
                int pin = Convert.ToInt32(Console.ReadLine());
                if (card.CheckPIN(pin))
                {
                    atmState.State = ATMState.States.Authorized;
                    return;
                }
                else Console.WriteLine("Try again");
            }
            atmState.State = ATMState.States.Welcome;
        }
    }
}
