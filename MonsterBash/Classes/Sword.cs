using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBash
{
    class Sword
    {
        public int x, y;
        public int xSize, ySize;
        public int width, length;
        public int damage;
        public int swordStage = 0;
        public int stageCooldown = 2;
        public bool attacking;
        public int swordCooldown = 0;
        public Sword(int _x, int _y, int _width, int _length, int _damage)
        {
            x = _x;
            y = _y;
            damage = _damage;
            width = _width;
            length = _length;
        }


    }
}
