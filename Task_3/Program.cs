using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        public static AirCarrier GetCarrier()
        {
            Console.Clear();

            int state;
            int airPlaneInAir;

                Console.WriteLine("Введите название авианосца");
                string name = Console.ReadLine();

                Console.WriteLine("Введите класс авианосца");
                string classShip = Console.ReadLine();

                Console.WriteLine("Введите командира авианосца");
                string commander = Console.ReadLine();

                Console.WriteLine("Введите мощьность двигателя авианосца");
                int power = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите массу авианосца");
                int mass = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите кол-во орудий авианосца");
                int countCannon = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите макс число самолетов на авианосце");
                int maxAirPlane = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Авианосец в движенни?\n 1)Да\n 2)Нет");
                    state = Convert.ToInt32(Console.ReadLine());
                }
                while (state < 1 || state > 2);

                do
                {
                    Console.WriteLine("Сколько самлётов на авианосце в данный момент?");
                    airPlaneInAir = Convert.ToInt32(Console.ReadLine());
                }
                while (airPlaneInAir >= maxAirPlane);

                AirCarrier airCarrier = new AirCarrier(name, commander, power, mass, countCannon, classShip, maxAirPlane);

                airCarrier.Swim(state);
                airCarrier.AirPlaneInAir = airPlaneInAir;
                return airCarrier;

        }

        static void Main(string[] args)
        {
            List<AirCarrier> AirCarriers = new List<AirCarrier>();

            int i = 0;

            while (i < 3)
            {
                do
                {

                    Console.WriteLine("1)Добавить авианосец\n 2)Вывести информацию\n 3)Завершить работу\n");
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                while (i < 1 || i > 3);

                if (i == 1)
                    AirCarriers.Add(GetCarrier());

                if (i == 2)
                {
                    if (AirCarriers.Count == 0)
                    {
                        Console.WriteLine("Список пуст\n");
                    }

                    for (int j = 0; j < AirCarriers.Count; j++)
                    {
                        AirCarriers[j].PrintShip();
                    }
                }

            }

            Console.ReadKey();

        }

    }
}   
