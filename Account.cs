using System;

namespace atm
{
  class Account
  {
    private int Balance { get; set; }
  }
  class Card
  {
    public string Id { get; set; }

    public Card()
    {
      Id = Guid.NewGuid().ToString();
    }
  }
}