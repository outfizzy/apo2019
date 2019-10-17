namespace atm
{
    class Account
    {
        public int Balance { get; set; }
        public Card Card = new Card(123456);

        public Account()
        {
            Balance = 1000;
        }

        public bool changeBalance(int amount)
        {
            if (amount <= Balance && (Balance + amount) >= 0)
            {
                Balance = Balance + amount;
                return true;
            }
            else return false;
        }
    }
    class Card
    {
        public int number;
        private int pin = 1234;

        public Card(int number)
        {
            this.number = number;
        }

        public bool CheckPIN(int pin)
        {
            if (pin == this.pin) return true;
            else return false;
        }

        public bool ChangePIN(int oldPIN, int newPIN)
        {
            if (oldPIN == this.pin)
            {
                this.pin = newPIN;
                return true;
            }
            else return false;
        }
    }
}