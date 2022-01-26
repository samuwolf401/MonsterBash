using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MonsterBash
{
    class Player
    {
        public int x, y;
        public int health;
        public int baseSpeed;
        public int tempXSpeed, tempYSpeed;
        public int hardDirection = 1; //direction that is not a diagonal. used for the direction of the gun and sword
        public int direction = 1;
        public int size;
        public int dashLength = 0;
        public int dashSpeed = 45;
        public int dashCooldown = 0;
        public string state = "wait";
        public bool stunned;
        public int stunnedTime = 5;

        public Player(int _x, int _y, int _baseSpeed, int _health, int _size)
        {
            x = _x;
            y = _y;
            baseSpeed = _baseSpeed;
            health = _health;
            size = _size;
        }
        public void Move(int dir)
        {
            switch (dir)
            {
                case 1:
                    tempXSpeed = 0;
                    tempYSpeed = -baseSpeed;
                    break;
                case 2:
                    tempXSpeed = 7;
                    tempYSpeed = -7;
                    break;
                case 3:
                    tempXSpeed = baseSpeed;
                    tempYSpeed = 0;
                    break;
                case 4:
                    tempXSpeed = 7;
                    tempYSpeed = 7;
                    break;
                case 5:
                    tempXSpeed = 0;
                    tempYSpeed = baseSpeed;
                    break;
                case 6:
                    tempXSpeed = -7;
                    tempYSpeed = 7;
                    break;
                case 7:
                    tempXSpeed = -baseSpeed;
                    tempYSpeed = 0;
                    break;
                case 8:
                    tempXSpeed = -7;
                    tempYSpeed = -7;
                    break;
            }
        }
        public void WallColision(Wall w, string check)
        {
            Rectangle wallRec = new Rectangle(w.x, w.y, w.xSize, w.ySize);
            if (check == "y")
            {
                Rectangle yPlayerRec = new Rectangle(x, y + tempYSpeed, size, size);
                if (yPlayerRec.IntersectsWith(wallRec))
                {
                    if (Math.Sign(tempYSpeed) == 1) // down
                    {
                        tempYSpeed = 0;
                        y += y + size - w.y;
                        if (state == "dash")
                        {
                            state = "wait";
                        }
                    }
                    if (Math.Sign(tempYSpeed) == -1) // up
                    {
                        tempYSpeed = 0;
                        y += w.y + w.ySize - y;
                        if (state == "dash")
                        {
                            state = "wait";
                        }
                    }
                }
            }
            if (check == "x")
            {
                Rectangle xPlayerRec = new Rectangle(x + tempXSpeed, y, size, size);
                if (xPlayerRec.IntersectsWith(wallRec))
                {
                    if (Math.Sign(tempXSpeed) == -1)// left
                    {
                        tempXSpeed = 0;
                        x += w.x + w.xSize - x;
                        if (state == "dash")
                        {
                            state = "wait";
                        }

                    }
                    if (Math.Sign(tempXSpeed) == 1) // right
                    {
                        tempXSpeed = 0;
                        x += x + size - w.x;
                        if (state == "dash")
                        {
                            state = "wait";
                        }
                    }
                }
            }
        }
        public void Dash(int dir)
        {
            if (dashLength >= 3)
            {
                dashLength = 0;
                state = "wait";
            }
            else
            {
                dashLength++;

            }
            switch (dir)
            {
                case 1:
                    tempXSpeed = 0;
                    tempYSpeed = -dashSpeed;
                    break;
                case 2:
                    tempXSpeed = 32;
                    tempYSpeed = -32;
                    break;
                case 3:
                    tempXSpeed = dashSpeed;
                    tempYSpeed = 0;
                    break;
                case 4:
                    tempXSpeed = 32;
                    tempYSpeed = 32;
                    break;
                case 5:
                    tempXSpeed = 0;
                    tempYSpeed = dashSpeed;
                    break;
                case 6:
                    tempXSpeed = -32;
                    tempYSpeed = 32;
                    break;
                case 7:
                    tempXSpeed = -dashSpeed;
                    tempYSpeed = 0;
                    break;
                case 8:
                    tempXSpeed = -32;
                    tempYSpeed = -32;
                    break;
            }
        }
        public bool MonsterCollision(Monster m)
        {
            if (!stunned)
            {
                Rectangle PlayerRec = new Rectangle(x, y, size, size);
                Rectangle MonsterRec = new Rectangle(m.x, m.y, m.xSize, m.ySize);
                if (PlayerRec.IntersectsWith(MonsterRec))
                {
                    health -= m.damage;
                    stunnedTime = 5;
                    stunned = true;
                    
                    if (health <= 0)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;

        }
    }

}
