using System;
using System.Collections.Generic;
using System.Text;

namespace ShotGun
{
    class Player
    {
        public string Choice { get; set; }
        public int Ammo { get; set; }

        public void Action(string choice)
        {
            Choice = choice;
        }
    }
}
