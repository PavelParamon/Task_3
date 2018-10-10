using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    abstract class WarShip : IShip
    {
        protected string name;
        protected string commander;
        protected int power;
        protected int mass;
        protected int countCannon;
        protected string stateNow;

        public WarShip(string name, string commander, int power, int mass, int countCannon)
        {
            this.name = name;
            this.commander = commander;
            this.power = power;
            this.mass = mass;
            this.countCannon = countCannon;
        }

        public int Power
        {
            get
            {
                return power;
            }
        }

        public int Mass
        {
            get
            {
                return mass;
            }
        }

        public int CountCannon
        {
            get
            {
                return countCannon;
            }
        }

        public string Commander
        {
            get
            {
                return commander;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string StateNow
        {
            get
            {
                return stateNow;
            }
        }

        public double PowerDensity()
        {
            return (double)(mass / power);
        }


        public void Swim(int state)
        {
            if (state == 1)
                stateNow = "Плывет";
            if(state == 2)
                stateNow = "Стоит";
        }

        public abstract double Rating();

    }
}
