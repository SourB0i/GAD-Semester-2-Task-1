using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAD_Semester__2_Task_1
{
    abstract class Enemy: Character
    {
        private Random r = new Random();
        public Enemy(int x, int y, int damage, int HP): base(x, y , damage, HP)
        {
          
        }
    }
}
