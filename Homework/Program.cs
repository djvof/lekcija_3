using System;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //1. Uzdevums - Telefons
            Telefons telefons = new Telefons("Vit phone")
            {
                Marka = "Nokia",
                Modelis = "Nokia",
                Garums = 10,
                Platums = 15,
                Augstums = 5
            };
            Console.WriteLine(telefons.Result());
            telefons.Call(22255533);
            telefons.Sms("+222548577", "Sveiks Jeks :)");
            Console.ReadLine();

            //2. uzdevums - Mašīna

            Masina masina = new Masina("Vit car")
            {
                Marka = "DODGE",
                Numurzime = "GB5588"
            };
            Console.WriteLine(masina.State);
            string input;
            do
            {
                Console.WriteLine("Please enter  (stop/start/beep or desired speed)");
                Console.WriteLine("To exit simulator just type \"exit\".");
                input= Console.ReadLine();
                masina.State = input;
                Console.WriteLine(masina.State);
            } while (input != "exit");
           
            //3. uzdevums - Prece
            string input5;
            int input6;
            int input7;
            int input8;
            int score;
            input5 = "";
            score= input6 = input7 = input8 = 0;
            Console.WriteLine("Vispirms ievadiet preces vertības ");
            do
            {
                if (input5 == "") Console.WriteLine("Nosaukums: ");  input5 = Console.ReadLine(); score++;
                if (input6 == 0) Console.WriteLine("Garums: ");  input6 = int.Parse(Console.ReadLine()) ; score++;
                if (input7 == 0) Console.WriteLine("Platums: ");  input7 = int.Parse(Console.ReadLine()); score++;
                if (input8 == 0) Console.WriteLine("Svars: ");  input8 = int.Parse(Console.ReadLine()); score++;

            } while (score != 4);


            Prece prece = new Prece(input5)
            {
                Garums = input6,
                Platums = input7,
                Svars = input8
            };
            Console.WriteLine(prece.Result());
            Console.ReadLine();
        }
    }
}
