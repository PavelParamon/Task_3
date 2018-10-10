using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    interface IShip
    {
        string Name
        {
            get;
            set;
        }

        void Swim(int state);
        double PowerDensity();

    }
}
