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
        private string _state = " in parking";
        private int _speed;

        public string State
        {
            get
            {
                return "Car '" + this.Name +"' " + Marka + " ar Valsts numuru " + Numurzime + " " + _state + " \n";
            }
            set 
            {

                if (value == "start")
                {
                    _speed = 1;
                    _state = " currently starting drive at " + _speed + "km/h";
                }
                else if (value == "stop" && _state== "is in parking")
                {
                    _state = " You can't stop non driving car it's in Parking !!! Please start Driving first !";
                }
                else if (value == "stop")
                {
                    _speed = 0;
                    _state = " stoped.";
                }
                else if (int.TryParse(value, out int numericValue))
                {
                   Speed=numericValue;
                    _state = " running at " + _speed + " km/h" ;
                }
                else if (value == "beep")
                {
                     this.Beep();
                }

            }
        }
        private int Speed
        {
            get { return _speed; }
            set { _speed = _speed + Math.Abs(value); }
        }

        public void Beep() {
            Console.WriteLine("!!!!!!!!!! Beep beep !!!!!!!!!");
        }


    }
}
