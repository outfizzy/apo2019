using System;

namespace atm
{
  class ATM
  {
    private ATMState atmState = new ATMState();

    public void startATM()
    {
      atmState.turnOn();
      do
      {
        atmState.checkAndWriteState();
        getCommand();

      }
      while (atmState.isTurned());
    }

    public void getCommand()
    {
      Console.Write("$: ");
      string input = Console.ReadLine();
      atmState.commandToState(splitCommand(input));
    }

    private String[] splitCommand(string command)
    {
      return command.Split(" ");
    }
  }
}
