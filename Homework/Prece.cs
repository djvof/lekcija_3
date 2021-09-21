using System;


namespace Homework
{
    class Prece
    {
        public Prece(string name)
        {
            Name = name;
        }
        public string Name { get; }

        private int _garums;
        private int _platums;
        private int _svars;

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
        public int Svars
        {
            get { return _svars; }
            set { _svars = Math.Abs(value); }
        }
        public string Result()
        {
            return "Jauna Prece:  \"" + Name + "\" ar izmēriem (g,p,svars) : " + Garums + " * " + Platums + " * " + Svars + " izveidota !";
        }

    }
}
