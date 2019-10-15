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

    public void turnOn()
    {
      if (State == States.Off)
      {
        State = States.Welcome;
        Console.WriteLine("Turning ATM...");
        Thread.Sleep(2000);
      }
    }
    public bool isTurned()
    {
      return State != States.Off ? true : false;
    }
    public void checkAndWriteState()
    {
      switch (State)
      {
        case States.Welcome:
          Console.WriteLine("State: Welcome to ATM");
          break;
        case States.Authorizing:
          Console.WriteLine("State: Authorizing");
          Card card = new Card();
          if(authorizeCard(card)) State = States.Authorized;
          break;
        case States.Authorized:
          Console.WriteLine("State: Authorized");
          break;
        case States.Balance:
          Console.WriteLine("State: Balance");
          break;
        default:
          Console.WriteLine("State: Unexpected");
          break;
      }
    }
    public void commandToState(String[] command){
      switch (command[0]) {
        case "insert":
          State = States.Authorizing;
          break;
        default:
          Console.WriteLine("Command not recognized");
          break;
      }
    }

    private bool authorizeCard(Card card) {
      for(int i = 0; i < 3; i++){
        Console.Write("Type PIN: ");
        string pin = Console.ReadLine();
        if(pin == "1234") return true;
      }
      return false;
    }
  }
}