using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAD_Semester__2_Task_1
{
    class Character
    {

        private int HP;
        private int maxHp;
        private int damage;
        private int[] tile;
        private int distanceTo;

        public int HP1 { get => HP; set => HP = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Damage { get => damage; set => damage = value; }
        public int[] Tile { get => tile; set => tile = value; }
        public int DistanceTo { get => distanceTo; set => distanceTo = value; }

        enum movement {idle, up, down, right, left}

        public Character(int hp, int damage, int maxHP, int y, int x) : base(x, y) 
        {

        }
        public virtual void character() 
        {

        }
        public bool Isdead()// This method returns a bool to see if the characters healthis less than 0 to see if the character is dead 
        {
            if (HP > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
            return true;
        }

        public virtual bool CheckRange(Character target)// This checks the distance to opposite characters 
        {
            distanceTo = 0;
            return true;
        }

        public virtual void Attack(Character target)// When the character is attacked the target takes damage 
        {
            target.HP -= Damage;
        }

        public void Move(movement move) 
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

        public abstract movement returnMove(movement move = 0);

        public abstract override string ToString();


    }
}
