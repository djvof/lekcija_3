using System;


namespace Homework
{
    class Masina
    {
        public Masina(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public string Marka { get; set; }
        public string Numurzime { get; set; }
        private int _atrums;
        private int _speed;

        public int Atrums
        {
            get { return _atrums; }
            set { _atrums = Math.Abs(value); }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = Math.Abs(value); }
        }

        public void Beep() {
            Console.WriteLine("Beep beep");
        }
                 
    }
}
