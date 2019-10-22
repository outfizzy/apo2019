using System;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w Bankomacie. Co Chcesz zrobić?");
            Console.WriteLine("1. Wypłacić pieniadze");
            Console.WriteLine("2. Zobaczyć saldo");
            Console.WriteLine("3. zmienić pin");
            int choose;
            string choosestring = Console.ReadLine();
            int.TryParse(choosestring, out choose);
            switch (choose)
            {
                case 1:
                    Console.WriteLine("1. Ile pieniedzy chcesz wypłacić");
                    string money = Console.ReadLine();
                    Console.WriteLine("Wyplaciłeś {0} złoty", money);
                    Console.ReadKey();
                    break;
                case 2:
                    string saldo = "580";
                    Console.WriteLine("Saldo: {0} złoty", saldo);
                    Console.ReadKey();
                    break;
                case 3:
                    string pin = "5800";
                    Console.WriteLine("Wprowadż Pin");
                    string pin2 = Console.ReadLine();
                    if (pin == pin2)
                    {
                        Console.WriteLine("Wprowadż nowy Pin");
                        string nowyPin1 = Console.ReadLine();
                        Console.WriteLine("Wprowadż ponownie nowy Pin");
                        string nowyPin2 = Console.ReadLine();
                        if (nowyPin1 == nowyPin2)
                        {
                            Console.WriteLine("Pin zostal zmieniony");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Podałeś dwa rózne piny");
                            Console.ReadKey();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Podałeś zly pin");
                        Console.ReadKey();
                    }
                    break;


            }

        }
    }
}
