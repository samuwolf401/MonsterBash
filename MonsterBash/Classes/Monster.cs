using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MonsterBash
{
    class Monster
    {
        public String type;
        public int xp;
        public int x, y;
        public int health;
        public int speed;
        public int damage;
        public int xDir;
        public int yDir;
        public int xSize;
        public int ySize;
        public bool stuned = false;
        public int stunTime = 5;
        public bool hit = false;
        public bool attackStart = false;
        public int attackStage = 0;
        public Monster(string _type, int _x, int _y, int _speed, int _health, int _damage, int _xSize, int _ySize, int _xp)
        {
            type = _type;
            x = _x;
            y = _y;
            speed = _speed;
            health = _health;
            damage = _damage;
            xSize = _xSize;
            ySize = _ySize;
            xp = _xp;
        }
        public void GetDir(int pX, int pY)
        {
            if (pX < x - 15)
            {
                xDir = -1;
            }
            else if (pX > x + 15)
            {
                xDir = 1;
            }
            else if (pX == x)
            {
                xDir = 0;
            }

            if (pY < y - 15)
            {
                yDir = -1;
            }
            else if (pY > y + 15)
            {
                yDir = 1;
            }
            else if (pY == y)
            {
                yDir = 0;
            }
        }
    }
}
