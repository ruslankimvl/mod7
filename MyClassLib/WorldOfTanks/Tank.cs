using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    class Tank
    {
        protected string name; // Название
        protected int ammo; // Боекомплект
        protected int armor; // Броня
        protected int mobility; // Манёвренность
        public Tank(int ammo, int armor, int mobility, string name)
        {
            this.ammo = ammo;
            this.armor = armor;
            this.mobility = mobility;
            this.name = name;
        }
        public Tank()
        {
            ammo = 0;
            armor = 0;
            mobility = 0;
            name = "null";
        }
        public void Print()
        {
            Console.WriteLine("Name - {0}", name);
            Console.WriteLine("Ammunation = {0} Armor = {0} Mobility = {0}", ammo, armor, mobility);
        }

        public static Tank operator *(Tank T34, Tank pantera)
        {
            if (T34.ammo > pantera.ammo && T34.armor > pantera.armor)
                return T34;

            if (T34.ammo > pantera.ammo && T34.mobility > pantera.mobility)
                return T34;

            if (T34.armor > pantera.armor && T34.mobility > pantera.mobility)
                return T34;
            else
                return pantera;
        }
    }
}
