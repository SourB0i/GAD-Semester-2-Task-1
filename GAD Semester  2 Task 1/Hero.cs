using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAD_Semester__2_Task_1
{
    class Hero: Character
    {

        public Hero(int x, int y, int hp) : base(x, y, hp) 
        {

        }

        public void ReturnMove(movement move) 
        {
            switch (move)
            {
                case movement.idle:
                    break;
                case movement.up:
                    break;
                case movement.down:
                    break;
                case movement.right:
                    break;
                case movement.left:
                    break;
                default:
                    break;
            }
        }

        public void ToString() 
        {

        }

        public void updateVision() 
        {

        }


    }
}
