using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRRGame
{
    class Game_logic
    {
        public int load; //Variable to hold the situation of the shot at the hour of stacking slug in chamber
        public int spin_Bullet; // variable to hold the position of bullet after rotating the chamber
        public int Total_Fire = 6;//set the total number of fire
        public int Point_Away = 2;//set the number of chances to shoot away bullet

        public int Bulleteloop(int skip)
        {
            if (skip == 6)
            {
                skip = 1;
            }
            else
            {
                skip++;
            }
            return skip;
        }
    }
}

