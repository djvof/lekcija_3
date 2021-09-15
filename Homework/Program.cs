using System;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefons telefons = new Telefons ("Vit phone");
            telefons.Marka = "Nokia";
            telefons.Modelis = "Nokia";
            telefons.Garums = 10;
            telefons.Platums = 15;
            telefons.Augstums = 5;
            Console.WriteLine(telefons.Result());
            telefons.Call(22255533);
            telefons.Sms("+222548577", "Sveiks Jeks :)");
            Console.ReadLine();
            /*
            Masina masina = new Masina("Vit phone");
            masina.Marka = "Nokia";
            masina.Modelis = "Nokia";
            masina.Garums = 10;
            masina.Platums = 15;
            masina.Augstums = 5;
            Console.WriteLine(masina.Result());
            telefons.Call(22255533);
            telefons.Sms("+222548577", "Sveiks Jeks :)");
            */
        }
    }
}
