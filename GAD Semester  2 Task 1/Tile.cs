using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAD_Semester__2_Task_1
{
    abstract class Tile
    {
        private int posX;
        private int posY;

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }

        enum TileType {Hero, Enemy, Gold, Weapon}

        public Tile(int x, int y) 
        {
            this.PosX = 0;
            this.posY = 0;
        }

    }
}
