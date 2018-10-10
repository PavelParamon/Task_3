using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class AirCarrier : WarShip
    {
        private string classShip;
        private int maxAirPlane;
        private int airPlaneInAir;

        public AirCarrier(string name, string commander, int power, int mass, int countCannon, string classShip, int maxAirPlane) : base(name, commander, power, mass, countCannon)
        {
            this.classShip = classShip;
            this.maxAirPlane = maxAirPlane;
        }

        public string ClassShip
        {
            get
            {
                return classShip;
            }
        }

        public int MaxAirPlane
        {
            get
            {
                return maxAirPlane;
            }
        }

        public int AirPlaneInAir
        {
            get
            {
                return airPlaneInAir;
            }
            set
            {
                if (value <= maxAirPlane)
                    airPlaneInAir = value;               
            }
        }

        public override double Rating()
        {
            return (double)(PowerDensity() * maxAirPlane * countCannon);
        }

        public int AirPlaneOnShip()
        {
            return (maxAirPlane - airPlaneInAir);
        }

        public void PrintShip()
        {
            Console.WriteLine("-------------\n\n Авианосец - {0}\n Тип авианосца - {1}\n Коммандир - {2}\n {3}\n Удельная мощность = {4}л/т\n " +
                "Кол-во орудий = {5}\n Рейтинг авианосца = {6}ед.\n Макс кол-во самолетов = {7}\n Самолетов на корабле в данный момент = {8}\n---------------\n\n",
                Name, ClassShip, Commander, StateNow, PowerDensity(), CountCannon, Rating(), MaxAirPlane, AirPlaneOnShip());
        }
    }
}
