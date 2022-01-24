using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBash
{
    class Gun
    {
        public String type;
        public int x, y;
        public int width, length;
        public int xSize, ySize;
        public int damage = 5;
        public int bulletCount;
        public int bulletReload = 15;
        public int gunReload = 100;

        public Gun(string _type, int _x, int _y, int _width, int _length)
        {
            type = _type;
            x = _x;
            y = _y;
            width = _width;
            length = _length;
        }

    }
}
