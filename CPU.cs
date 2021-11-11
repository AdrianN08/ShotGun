using System;
using System.Collections.Generic;
using System.Text;

namespace ShotGun
{
    class CPU : Player
    {
        public bool firstGame;
        public void Action()
        {
            Random rn = new Random();
            if (firstGame)
            {
                Choice = "reload";
                firstGame = false;
            }
            else if (Ammo == 3)
            {
                Choice = "shot gun";
                Ammo = 0;
            }
            else if (Ammo < 1)
            {
                
                switch (rn.Next(0, 3)) // la in dubbla alternativ då det blev mer random val
                {
                    case 0:
                        Choice = "reload";
                        break;
                    case 1:
                        Choice = "block";
                        break;
                    case 2:
                        Choice = "block";
                        break;
                    case 3:
                        Choice = "reload";
                        break;
                }
            }
            else
            {
                
                switch (rn.Next(0, 5)) // la in dubbla alternativ då det blev mer random val
                {
                    case 0:
                        Choice = "shoot";
                        break;
                    case 1:
                        Choice = "reload";
                        break;
                    case 2:
                        Choice = "block";
                        break;
                    case 3:
                        Choice = "reload";
                        break;
                    case 4:
                        Choice = "block";
                        break;
                    case 5:
                        Choice = "shoot";
                        break;
                }
            }
        }
    }
}
