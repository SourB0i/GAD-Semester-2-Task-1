using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAD_Semester__2_Task_1
{
    class Goblin: Enemy
    {
        public Goblin(int x, int y) : base(x, y) 
        {

        }

        public void returnMove() 
        {
            Random r = new Random();
        }
    }
}
