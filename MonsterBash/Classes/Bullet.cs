using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MonsterBash
{
    class Bullet
    {
        public int x, y;
        public int speed;
        public int direction;
        public int xSize, ySize;
        public bool remove = false;

        public Bullet(int _x, int _y, int _speed, int _damage, int _xSize, int _ySize, int _direction)
        {
            x = _x;
            y = _y;
            speed = _speed;
            xSize = _xSize;
            ySize = _ySize;
            direction = _direction;
        }

        public void Move()
        {
            switch (direction)
            {
                case 1:
                    y -= speed;
                    break;
                case 3:
                    x += speed;
                    break;
                case 5:
                    y += speed;
                    break;
                case 7:
                    x -= speed;
                    break;

            }
        }

        public bool WallCollision(Wall w)
        {
            Rectangle wallRec = new Rectangle(w.x, w.y, w.xSize, w.ySize);
            Rectangle bulletRec = new Rectangle(x, y, xSize, ySize);
            if (bulletRec.IntersectsWith(wallRec))  return true;           
            else return false;

        }

    }
}
