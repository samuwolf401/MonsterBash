using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBash
{
    class Wall
    {
        public int x, y;
        public int xSize, ySize;

        public Wall(int _x, int _y, int _xSize, int _ySize)
        {
            x = _x;
            y = _y;
            xSize = _xSize;
            ySize = _ySize;
        }
    }
}
