using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConstructorLab
{
    internal class House
    {
        private int floors;

        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value > 0)
                {
                    floors = value;
                }
                else
                {
                    Console.WriteLine("Ошибка колличества этажей, оно не может быть меньше 1");
                    floors = 5;
                }
            }
        }

        public House(int floors)
        {           
            Floors = floors;
        }

        public override string ToString()
        {
            if ( floors % 10 == 1 && floors != 11)
            {
                return "дом с " + floors + " этажом";
            }
            else
            {
                return "дом с " + floors + " этажами";
            }
        }
    }
}
