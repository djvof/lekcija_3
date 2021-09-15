using System;


namespace Homework
{
    class Telefons
    {
        public Telefons(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public string Marka { get; set; }
        public string Modelis { get; set; }
        private int _garums;
        private int _platums;
        private int _augstums;

        public int Garums
        {
            get { return _garums; }
            set { _garums = Math.Abs(value); }
        }
        public int Platums
        {
            get { return _platums; }
            set { _platums = Math.Abs(value); }
        }
        public int Augstums
        {
            get { return _augstums; }
            set { _augstums = Math.Abs(value); }
        }
        public void Call(int numurs) {
            Console.WriteLine("Calling to "+ numurs+"...");
        }
        public void Sms (string numurs,string txt) {
            Console.WriteLine("Sutu SMS to "+ numurs + " ar tekstu ("+ txt + ") sent...");
        }

        public string Result()
        {
            return "Your phone is " + Name + " marka  " + Marka + " modelis  " + Modelis + " ar izmeriem (g,p,a)  " + Garums + " ,  " + Platums + " ," + Augstums;
        }

    }
}
