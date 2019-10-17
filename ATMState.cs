using System;
using System.Threading;

namespace atm
{
    public class ATMState
    {
        public enum States { Welcome, Authorizing, Authorized, Withdrawal, ChangePIN, Balance, Transfering, PullingOut, Off }
        public States State { get; set; }

        public ATMState()
        {
            State = States.Off;
        }

        public void TurnOn()
        {
            if (State == States.Off)
            {
                Console.WriteLine("Turning ATM...");
                Thread.Sleep(2000);
                State = States.Welcome;
            }
        }
        public bool IsTurned()
        {
            return State != States.Off ? true : false;
        }
        public void CheckAndWriteState()
        {
            switch (State)
            {
                case States.Welcome:
                    Console.WriteLine("Welcome to ATM");
                    break;
                case States.Authorizing:
                    Console.WriteLine("Authorizing");
                    break;
                case States.Authorized:
                    Console.WriteLine("Authorized");
                    break;
                case States.Balance:
                    Console.WriteLine("Balance");
                    break;
                case States.PullingOut:
                    Console.WriteLine("Card pulling out");
                    break;
                case States.Withdrawal:
                    Console.WriteLine("Withdraw");
                    break;
                default:
                    Console.WriteLine("Unexpected");
                    break;
            }
        }
        public void CommandToState(String[] command)
        {
            switch (command[0])
            {
                case "insert":
                    State = States.Authorizing;
                    break;
                case "exit":
                    State = States.PullingOut;
                    break;
                default:
                    Console.WriteLine("Command not recognized");
                    break;
            }
        }
    }
}