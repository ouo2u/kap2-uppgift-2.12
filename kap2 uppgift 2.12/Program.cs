   using System;

   namespace Uppgift_2._12
    {
        class Program
        {
            static void Main(string[] args)
            {

            Console.WriteLine(" Hur många dagar vill du hyra billen? ");
             string strdagarText = Console.ReadLine();
            Console.WriteLine("hur många kilometer kommer du att köra?");
            string strkilometer = Console.ReadLine();

            int intdagarText = int.Parse(strdagarText);
            int intkilometer = int.Parse(strkilometer);

            int sum = 300 + intdagarText * 500 + intkilometer * 1 -500;

            Console.WriteLine("Priset kommer at vara " + sum + "kr");



         



        }
        }
    }
 