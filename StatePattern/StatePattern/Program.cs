using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine aVendingMachine = new VendingMachine();

            Console.WriteLine("Enter 1 for Insert Coin");
            Console.WriteLine("Enter 2 for Eject Coin");
            Console.WriteLine("Enter 3 for Select Coin");
            Console.WriteLine("Enter 4 To End");

            while (true)
            {

                Console.WriteLine("Enter command");
                string command = Console.ReadLine();

                if (command == "4")
                {
                    break;
                }

                if (command == "1")
                {

                    aVendingMachine.InsertCoin();

                }
                else if (command == "2")
                {
                    aVendingMachine.EjectCoin();
                }
                else if (command == "3")
                {
                    aVendingMachine.SelectItem();
                }


            }
        }
    }
}
