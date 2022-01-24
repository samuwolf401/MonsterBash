using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MonsterBash
{
    class Trap
    {
        public String type;
        public int x, y;
        public int size;
        public bool explosionActive = false;
        public int explostionTime = 8;
        public int expX, expY, expSize;

        public Trap(string _type,int _x, int _y, int _size)
        {
            type = _type;
            x = _x;
            y = _y;
            size = _size;
        }

        public bool Collision(Monster m)
        {
            Rectangle MonsterRec = new Rectangle(m.x, m.y, m.xSize, m.ySize);
            Rectangle TrapRec = new Rectangle(x, y, size, size);
            if (MonsterRec.IntersectsWith(TrapRec))
            {
                return true;                
            }             
            else return false;
        } 

    }
}
