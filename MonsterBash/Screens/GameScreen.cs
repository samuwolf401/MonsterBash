using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace MonsterBash
{
    public partial class GameScreen : UserControl
    {
        #region globals
        //object creation
        Player player;
        Gun gun;
        Sword sword;
        List<Trap> traps = new List<Trap>();
        List<Monster> monsters = new List<Monster>();
        List<Wall> walls = new List<Wall>();
        List<Bullet> bullets = new List<Bullet>();
        //colours
        SolidBrush HatBrush = new SolidBrush(Color.Brown);
        SolidBrush WallBrush = new SolidBrush(Color.DimGray);
        SolidBrush GunBrush = new SolidBrush(Color.SaddleBrown);
        SolidBrush SwordBrush = new SolidBrush(Color.DarkGray);
        SolidBrush MonsterBrush = new SolidBrush(Color.DarkOliveGreen);
        SolidBrush TrapBrush = new SolidBrush(Color.Black);
        SolidBrush ExplosionBrush = new SolidBrush(Color.OrangeRed);
        //sounds
        
        //input detection
        public static bool leftKey = false;
        public static bool rightKey = false;
        public static bool upKey = false;
        public static bool downKey = false;
        public static bool mKey = false;
        public static bool nKey = false;
        public static bool bKey = false;
        public static bool spaceKey = false;
        //wave and levels
        public int monstersLeft = 1;
        public bool newWave = true;
        public int currentWave = 0;
        public bool newLevel = true;
        public int currentLevel = 0;
        public int difficulty = 0;
        // bullet size
        public int xBullet;
        public int yBullet;
        //trap
        public int placeWait;
        public int totalTraps = 0;
        public int trapDamage;
        //score
        public int scoreTime;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            player = new Player(600, 350, 10, 15, 50);
            gun = new Gun($"{Form1.gunType}", 100, 100, 40, 15);
            sword = new Sword(100, 100, 5, 50, 10);
        }
        #region keys
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKey = true;
                    break;
                case Keys.Right:
                    rightKey = true;
                    break;
                case Keys.Up:
                    upKey = true;
                    break;
                case Keys.Down:
                    downKey = true;
                    break;
                case Keys.M:
                    mKey = true;
                    break;
                case Keys.B:
                    bKey = true;
                    break;
                case Keys.N:
                    nKey = true;
                    break;
                case Keys.Space:
                    spaceKey = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKey = false;
                    break;
                case Keys.Right:
                    rightKey = false;
                    break;
                case Keys.Up:
                    upKey = false;
                    break;
                case Keys.Down:
                    downKey = false;
                    break;
                case Keys.M:
                    mKey = false;
                    break;
                case Keys.B:
                    bKey = false;
                    break;
                case Keys.N:
                    nKey = false;
                    break;
                case Keys.Space:
                    spaceKey = false;
                    break;
            }
        }
        #endregion
        private void GameTick_Tick(object sender, EventArgs e)
        {
            #region player
            switch (player.state)
            {
                case "dash":
                    player.Dash(player.direction);
                    foreach (Wall w in walls)
                    {
                        player.WallColision(w, "y");
                    }
                    foreach (Wall w in walls)
                    {
                        player.WallColision(w, "x");
                    }
                    player.y += player.tempYSpeed;
                    player.x += player.tempXSpeed;
                    break;
                case "slash":
                    sword.attacking = true;
                    if (sword.swordStage == 0)
                    {
                        sword.attacking = false;
                        player.state = "wait";
                    }
                    if (player.hardDirection == 1)
                    {
                        switch (sword.swordStage)
                        {
                            case 1:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 20;
                                sword.xSize = 25;
                                sword.x = player.x + player.size - 10;
                                sword.y = player.y;

                                break;
                            case 2:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 25;
                                sword.x = player.x + player.size - 10;
                                sword.y = player.y - 30;

                                break;
                            case 3:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x;
                                sword.y = player.y - 30;
                                break;
                            case 4:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x - player.size + 20;
                                sword.y = player.y - 30;
                                break;
                            case 5:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage = 0;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 20;
                                sword.xSize = 50;
                                sword.x = player.x - player.size;
                                sword.y = player.y;
                                break;
                        }
                        sword.stageCooldown--;
                    }
                    if (player.hardDirection == 3)
                    {
                        switch (sword.swordStage)
                        {
                            case 1:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.xSize = 20;
                                sword.ySize = 25;
                                sword.x = player.x + player.size - 15;
                                sword.y = player.y + player.size - 10;
                                break;
                            case 2:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.xSize = 50;
                                sword.ySize = 25;
                                sword.x = player.x + player.size - 15;
                                sword.y = player.y + player.size - 10;

                                break;
                            case 3:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x + player.size - 15;
                                sword.y = player.y;
                                break;
                            case 4:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x + player.size - 15;
                                sword.y = player.y - 30;
                                break;
                            case 5:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage = 0;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 20;
                                sword.x = player.x + player.size - 15;
                                sword.y = player.y - 50;
                                break;
                        }
                        sword.stageCooldown--;
                    }
                    if (player.hardDirection == 5)
                    {
                        switch (sword.swordStage)
                        {
                            case 1:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 20;
                                sword.xSize = 25;
                                sword.x = player.x - 15;
                                sword.y = player.y + player.size - 15;

                                break;
                            case 2:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 25;
                                sword.x = player.x - 15;
                                sword.y = player.y + player.size - 15;

                                break;
                            case 3:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x;
                                sword.y = player.y + player.size - 15;
                                break;
                            case 4:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x + player.size - 15;
                                sword.y = player.y + player.size - 15;
                                break;
                            case 5:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage = 0;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 20;
                                sword.xSize = 50;
                                sword.x = player.x + player.size;
                                sword.y = player.y + player.size - 15;
                                break;
                        }
                        sword.stageCooldown--;
                    }
                    if (player.hardDirection == 7)
                    {
                        switch (sword.swordStage)
                        {
                            case 1:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.xSize = 20;
                                sword.ySize = 25;
                                sword.x = player.x;
                                sword.y = player.y - 10;
                                break;
                            case 2:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.xSize = 50;
                                sword.ySize = 25;
                                sword.x = player.x - 30;
                                sword.y = player.y - 10;

                                break;
                            case 3:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x - 30;
                                sword.y = player.y;
                                break;
                            case 4:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage++;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 50;
                                sword.x = player.x - 30;
                                sword.y = player.y + player.size - 15;
                                break;
                            case 5:
                                if (sword.stageCooldown <= 0)
                                {
                                    sword.swordStage = 0;
                                    sword.stageCooldown = 2;
                                }
                                sword.ySize = 50;
                                sword.xSize = 20;
                                sword.x = player.x;
                                sword.y = player.y + player.size;
                                break;
                        }
                        sword.stageCooldown--;
                    }
                    break;
                case "wait":

                    #region player Move
                    // direction 1 is up, then is goes around clockwise
                    if (GameScreen.rightKey && GameScreen.upKey)
                    {
                        player.Move(2);
                        player.direction = 2;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.rightKey && GameScreen.downKey)
                    {
                        player.Move(4);
                        player.direction = 4;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.leftKey && GameScreen.downKey)
                    {
                        player.Move(6);
                        player.direction = 6;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.leftKey && GameScreen.upKey)
                    {
                        player.Move(8);
                        player.direction = 8;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.upKey)
                    {
                        player.Move(1);
                        player.direction = 1;
                        player.hardDirection = 1;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.rightKey)
                    {
                        player.Move(3);
                        player.direction = 3;
                        player.hardDirection = 3;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.downKey)
                    {
                        player.Move(5);
                        player.direction = 5;
                        player.hardDirection = 5;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    else if (GameScreen.leftKey)
                    {
                        player.Move(7);
                        player.direction = 7;
                        player.hardDirection = 7;
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    #endregion

                    #region start player Dash
                    //dash detection
                    if (nKey && player.dashCooldown <= 0)
                    {
                        player.state = "dash";
                        player.dashCooldown = 20;
                    }
                    if (player.dashCooldown > 0)
                    {
                        player.dashCooldown--;
                    }

                    #endregion

                    #region start player Slash
                    if (mKey && sword.swordCooldown <= 0)
                    {
                        sword.attacking = true;
                        sword.swordCooldown = 4;
                        player.state = "slash";
                        sword.swordStage = 1;
                        mKey = false;
                    }
                    else
                    {
                        sword.swordCooldown--;
                        sword.attacking = false;
                        foreach (Monster m in monsters)
                        {
                            m.hit = false;
                        }
                    }
                    #endregion

                    #region player Shoot
                    if (spaceKey && gun.bulletReload <= 0 && gun.bulletCount > 0)
                    {
                        if (gun.type == "shotgun")
                        {
                            gun.bulletReload = 15;
                        }
                        else
                        {
                            gun.bulletReload = 5;
                        }


                        gun.bulletCount--;
                        switch (player.hardDirection)
                        {
                            case 1:
                                Bullet b1 = new Bullet(gun.x + 1, gun.y, 25, 5, yBullet, xBullet, player.hardDirection);
                                bullets.Add(b1);
                                if (gun.type == "shotgun")
                                {
                                    player.tempYSpeed = 15;
                                    player.tempXSpeed = 0;
                                }
                                else
                                {
                                    player.tempYSpeed = 5;
                                    player.tempXSpeed = 0;
                                }
                                break;
                            case 3:
                                Bullet b2 = new Bullet(gun.x + gun.length, gun.y + (yBullet / 3), 25, 5, xBullet, yBullet, player.hardDirection);
                                bullets.Add(b2);
                                if (gun.type == "shotgun")
                                {
                                    player.tempYSpeed = 0;
                                    player.tempXSpeed = -15;
                                }
                                else
                                {
                                    player.tempYSpeed = 0;
                                    player.tempXSpeed = -5;
                                }
                                break;
                            case 5:
                                Bullet b3 = new Bullet(gun.x + (yBullet / 3), gun.y + gun.length, 25, 5, yBullet, xBullet, player.hardDirection);
                                bullets.Add(b3);
                                if (gun.type == "shotgun")
                                {
                                    player.tempYSpeed = -15;
                                    player.tempXSpeed = 0;
                                }
                                else
                                {
                                    player.tempYSpeed = -5;
                                    player.tempXSpeed = 0;
                                }
                                break;
                            case 7:
                                Bullet b4 = new Bullet(gun.x + 1, gun.y, 25, 5, xBullet, yBullet, player.hardDirection);
                                bullets.Add(b4);
                                if (gun.type == "shotgun")
                                {
                                    player.tempYSpeed = 0;
                                    player.tempXSpeed = 15;
                                }
                                else
                                {
                                    player.tempYSpeed = 0;
                                    player.tempXSpeed = 5;
                                }
                                break;
                        }
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "y");
                        }
                        foreach (Wall w in walls)
                        {
                            player.WallColision(w, "x");
                        }
                        player.y += player.tempYSpeed;
                        player.x += player.tempXSpeed;
                    }
                    #endregion

                    #region  place trap
                    if (bKey && totalTraps > 0)
                    {
                        if (placeWait <= 0)
                        {
                            Trap t = new Trap($"{Form1.trapType}", player.x, player.y, 25);
                            traps.Add(t);
                            totalTraps--;
                            placeWait = 15;
                        }
                    }
                    placeWait--;
                    #endregion

                    break;
            }
            healthLabel.Text = $"Health: {player.health}";
            if (player.stunned) player.stunnedTime--;
            if (player.stunnedTime <= 0) player.stunned = false;
            #endregion
            #region weapons
            //gun position logic
            switch (player.hardDirection)
            {
                case 1:
                    gun.x = player.x + 35;
                    gun.y = player.y - 20;
                    gun.ySize = gun.width;
                    gun.xSize = gun.length;
                    break;
                case 3:
                    gun.x = player.x + 30;
                    gun.y = player.y + 35;
                    gun.ySize = gun.length;
                    gun.xSize = gun.width;
                    break;
                case 5:
                    gun.x = player.x;
                    gun.y = player.y + 30;
                    gun.ySize = gun.width;
                    gun.xSize = gun.length;
                    break;
                case 7:
                    gun.x = player.x - 20;
                    gun.y = player.y;
                    gun.ySize = gun.length;
                    gun.xSize = gun.width;
                    break;
            }
            //sword postion logic
            if (sword.swordStage == 0)
            {
                switch (player.hardDirection)
                {
                    case 1:
                        sword.x = player.x;
                        sword.y = player.y - 20;
                        sword.ySize = sword.length;
                        sword.xSize = sword.width;
                        break;
                    case 3:
                        sword.x = player.x + 25;
                        sword.y = player.y;
                        sword.ySize = sword.width;
                        sword.xSize = sword.length;
                        break;
                    case 5:
                        sword.x = player.x + 46;
                        sword.y = player.y + 25;
                        sword.ySize = sword.length;
                        sword.xSize = sword.width;
                        break;
                    case 7:
                        sword.x = player.x - 25;
                        sword.y = player.y + 45;
                        sword.ySize = sword.width;
                        sword.xSize = sword.length;
                        break;
                }
            }

            //bullet logic
            foreach (Bullet b in bullets)
            {
                b.Move();
                foreach (Wall w in walls)
                {
                    if (b.WallCollision(w))
                    {
                        b.remove = true;
                    }
                }
            }
            foreach (Bullet b in bullets)
            {
                if (b.remove == true)
                {
                    bullets.Remove(b);
                    break;
                }
            }
            if (gun.bulletCount <= 0)
            {
                if (gun.gunReload > 0)
                {
                    gun.gunReload--;
                }
                else
                {
                    if (gun.type == "shotgun") gun.bulletCount = 4;
                    else gun.bulletCount = 30;
                    gun.gunReload = 100;
                }
            }
            gun.bulletReload--;
            bulletCountLabel.Text = $"Bullets Left: {gun.bulletCount}";
            //trap logic
            foreach (Trap t in traps)
            {
                if (t.explosionActive)
                {
                    t.explostionTime--;
                    Explosion(t);
                }
                if (t.explostionTime <= 0 && t.explosionActive)
                {
                    t.explosionActive = false;
                    traps.Remove(t);
                    break;
                }
            }


            trapCount.Text = $"Traps Left: {totalTraps}";
            #endregion          
            #region monsters     
            if (monstersLeft > 0)
            {
                foreach (Monster m in monsters)
                {
                    if (m.attackStart)
                    {
                        m.attackStage++;
                        MonsterAttack(m);
                    }
                    else
                    {
                        if (!m.stuned)
                        {
                            m.GetDir(player.x, player.y);
                            if (m.x < player.x + 75 && m.x > player.x - 50 && m.y < player.y + 75 && m.y > player.y - 50)
                            {
                                MonsterAttack(m);
                            }
                            else
                            {
                                
                                m.x += m.speed * m.xDir;
                                m.y += m.speed * m.yDir;
                            }
                        }
                        else m.stunTime--;
                        if (m.stunTime <= 0)
                        {
                            m.stunTime = 5;
                            m.stuned = false;
                        }
                    }

                    if (player.MonsterCollision(m))
                    {
                        GameOver();
                    }

                }
                foreach (Monster m in monsters)
                {
                    if (MonsterBulletCollision(m)) break;
                    if (MonsterSwordCollision(m)) break;
                    if (MonsterTrapCollision(m)) break;
                }
            }
            #endregion
            #region waves and levels
            scoreTime--;
            scoreLabel.Text = $"Score: {Form1.score}";
            if (newLevel)
            {
                Form1.score += Convert.ToInt32(scoreTime / 50);
                currentLevel++;
                CreateLevel();
                newLevel = false;
                scoreTime = 8000;
            }

            if (newWave)
            {
                newWave = false;
                currentWave++;
                CreateMonsters(currentWave, currentLevel);
            }
            if (monstersLeft <= 0)
            {
                if (currentWave == 3)
                {
                    newLevel = true;
                    currentWave = 0;

                    if (currentLevel == 3)
                    {
                        currentLevel = 0;
                        difficulty++;
                        if (Form1.trapType == "bearTrap") totalTraps = 8;
                        else totalTraps = 4;
                    }

                }
                newWave = true;
            }
            levelLabel.Text = $"Level: {currentLevel}";
            waveLabel.Text = $"Wave: {currentWave}";
            difficultyLabel.Text = $"Difficulty: {difficulty}";
            #endregion          
            Refresh();
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            GameTick.Enabled = true;
            
            if (Form1.gunType == "shotgun") //shotgun
            {
                gun.damage = 11;
                gun.bulletCount = 8;
                gun.bulletReload = 15;
                xBullet = 24;
                yBullet = 15;
            }
            else //assualt rifle
            {
                gun.damage = 3;
                gun.bulletCount = 24;
                gun.bulletReload = 3;
                xBullet = 16;
                yBullet = 5;
            }
            if (Form1.trapType == "bearTrap") //bear trap
            {
                totalTraps = 8;
                trapDamage = 25;
            }
            else // land mine
            {
                totalTraps = 4;
                trapDamage = 20; //in a radius
            }
            switch (Form1.difficultyType)
            {
                case 0:
                    difficulty = 0;
                    break;
                case 1:
                    difficulty = 1;
                    break;
                case 2:
                    difficulty = 2;
                    break;
                case 3:
                    difficulty = 3;
                    break;
                case 4:
                    difficulty = 4;
                    break;
                case 5:
                    difficulty = 5;
                    break;
                case 6:
                    difficulty = 6;
                    break;
                case 7:
                    difficulty = 7;
                    break;
                case 8:
                    difficulty = 8;
                    break;
                case 9:
                    difficulty = 9;
                    break;
            }

        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle(SwordBrush, b.x, b.y, b.xSize, b.ySize);
            }
            foreach (Wall w in walls)
            {
                e.Graphics.FillRectangle(WallBrush, w.x, w.y, w.xSize, w.ySize);
            }
            foreach (Monster m in monsters)
            {
                e.Graphics.FillRectangle(MonsterBrush, m.x, m.y, m.xSize, m.ySize);
            }
            foreach (Trap t in traps)
            {
                if (t.explosionActive) e.Graphics.FillRectangle(ExplosionBrush, t.expX, t.expY, t.expSize, t.expSize);
                else e.Graphics.FillRectangle(TrapBrush, t.x, t.y, t.size, t.size);
            }
            e.Graphics.FillRectangle(SwordBrush, sword.x, sword.y, sword.xSize, sword.ySize);
            e.Graphics.FillRectangle(GunBrush, gun.x, gun.y, gun.xSize, gun.ySize);
            e.Graphics.FillEllipse(HatBrush, player.x, player.y, player.size, player.size);
        }
        public void CreateMonsters(int wave, int level)
        {
            switch (currentLevel)
            {
                case 1:
                    switch (currentWave)
                    {
                        case 1:
                            Monster a1 = new Monster("goblin", 1200, 300, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster a2 = new Monster("cyclops", 1200, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster a3 = new Monster("troll", 0, 100, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster a4 = new Monster("cyclops", 0, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            monsters.Add(a4);
                            monsters.Add(a3);
                            monsters.Add(a2);
                            monsters.Add(a1);
                            monstersLeft = 4;
                            break;
                        case 2:
                            Monster b1 = new Monster("troll", 0, 350, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster b2 = new Monster("goblin", 1200, 300, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster b3 = new Monster("goblin", 0, 100, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster b4 = new Monster("goblin", 700, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster b5 = new Monster("goblin", 100, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            monsters.Add(b1);
                            monsters.Add(b2);
                            monsters.Add(b3);
                            monsters.Add(b4);
                            monsters.Add(b5);
                            monstersLeft = 5;
                            break;
                        case 3:
                            Monster c1 = new Monster("cyclops", 0, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster c2 = new Monster("goblin", 1200, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster c3 = new Monster("troll", 1200, 100, 1, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster c4 = new Monster("goblin", 400, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster c5 = new Monster("troll", 0, 350, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            monsters.Add(c1);
                            monsters.Add(c2);
                            monsters.Add(c3);
                            monsters.Add(c4);
                            monsters.Add(c5);
                            monstersLeft = 5;
                            break;
                    }
                    break;
                case 2:
                    switch (currentWave)
                    {
                        case 1:
                            Monster d1 = new Monster("goblin", 1200, 350, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster d2 = new Monster("goblin", 900, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster d3 = new Monster("troll", 0, 350, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster d4 = new Monster("troll", 1200, 350, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster d5 = new Monster("troll", 300, 700, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster d6 = new Monster("cyclops", 0, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            monsters.Add(d1);
                            monsters.Add(d2);
                            monsters.Add(d3);
                            monsters.Add(d4);
                            monsters.Add(d5);
                            monsters.Add(d6);
                            monstersLeft = 6;
                            break;
                        case 2:
                            Monster e1 = new Monster("cyclops", 0, 100, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster e2 = new Monster("cyclops", 1200, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster e3 = new Monster("cyclops", 600, 600, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster e4 = new Monster("troll", 0, 350, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster e5 = new Monster("goblin", 1200, 350, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster e6 = new Monster("troll", 100, 700, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            monsters.Add(e1);
                            monsters.Add(e2);
                            monsters.Add(e3);
                            monsters.Add(e4);
                            monsters.Add(e5);
                            monsters.Add(e6);
                            monstersLeft = 6;
                            break;
                        case 3:
                            Monster f1 = new Monster("cyclops", 0, 600, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster f2 = new Monster("cyclops", 1200, 500, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster f3 = new Monster("cyclops", 200, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster f4 = new Monster("goblin", 0, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster f5 = new Monster("goblin", 0, 100, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster f6 = new Monster("goblin", 1200, 100, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster f7 = new Monster("goblin", 1200, 0, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster f8 = new Monster("goblin", 350, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            monsters.Add(f1);
                            monsters.Add(f2);
                            monsters.Add(f3);
                            monsters.Add(f4);
                            monsters.Add(f5);
                            monsters.Add(f6);
                            monsters.Add(f7);
                            monsters.Add(f8);
                            monstersLeft = 8;
                            break;
                    }
                    break;
                case 3:
                    switch (currentWave)
                    {
                        case 1:
                            Monster g1 = new Monster("troll", 1200, 500, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster g2 = new Monster("troll", 0, 500, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster g3 = new Monster("troll", 100, 700, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster g4 = new Monster("goblin", 0, 350, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster g5 = new Monster("goblin", 1200, 350, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster g6 = new Monster("cyclops", 10, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster g7 = new Monster("cyclops", 1200, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            monsters.Add(g1);
                            monsters.Add(g2);
                            monsters.Add(g3);
                            monsters.Add(g4);
                            monsters.Add(g5);
                            monsters.Add(g6);
                            monsters.Add(g7);
                            monstersLeft = 7;
                            break;
                        case 2:
                            Monster h1 = new Monster("goblin", 0, 100, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h2 = new Monster("goblin", 0, 600, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h3 = new Monster("goblin", 1200, 100, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h4 = new Monster("goblin", 1200, 600, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h5 = new Monster("goblin", 150, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h6 = new Monster("goblin", 350, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h7 = new Monster("goblin", 1000, 700, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster h8 = new Monster("troll", 1200, 500, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster h9 = new Monster("troll", 0, 500, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            monsters.Add(h1);
                            monsters.Add(h2);
                            monsters.Add(h3);
                            monsters.Add(h4);
                            monsters.Add(h5);
                            monsters.Add(h6);
                            monsters.Add(h7);
                            monsters.Add(h8);
                            monsters.Add(h9);
                            monstersLeft = 9;
                            break;
                        case 3:
                            Monster i1 = new Monster("cyclops", 0, 100, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster i2 = new Monster("cyclops", 0, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster i3 = new Monster("cyclops", 1200, 100, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster i4 = new Monster("cyclops", 1200, 700, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster i5 = new Monster("cyclops", 600, 600, 3, 12 + (2 * difficulty), 2 + (difficulty), 35, 35, 20);
                            Monster i6 = new Monster("troll", 1200, 700, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster i7 = new Monster("troll", 0, 350, 2, 15 + (2 * difficulty), 2 + (difficulty), 50, 50, 30);
                            Monster i8 = new Monster("goblin", 1200, 350, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            Monster i9 = new Monster("goblin", 0, 350, 4, 9 + (2 * difficulty), 2 + (difficulty), 25, 25, 25);
                            monsters.Add(i1);
                            monsters.Add(i2);
                            monsters.Add(i3);
                            monsters.Add(i4);
                            monsters.Add(i5);
                            monsters.Add(i6);
                            monsters.Add(i7);
                            monsters.Add(i8);
                            monsters.Add(i9);
                            monstersLeft = 9;
                            break;
                    }
                    break;
            }
        }
        private bool MonsterBulletCollision(Monster m)
        {
            foreach (Bullet b in bullets)
            {
                Rectangle bulletRec = new Rectangle(b.x, b.y, b.xSize, b.ySize);
                Rectangle monsterRec = new Rectangle(m.x, m.y, m.xSize, m.ySize);
                if (bulletRec.IntersectsWith(monsterRec))
                {
                    if (gun.type == "shotgun") m.stuned = true;
                    MonsterDamage(m, gun.damage);
                    bullets.Remove(b);
                    return true;
                }
            }
            return false;
        }
        private bool MonsterSwordCollision(Monster m)
        {
            if (sword.attacking)
            {
                Rectangle swordRec = new Rectangle(sword.x, sword.y, sword.xSize, sword.ySize);
                Rectangle monsterRec = new Rectangle(m.x, m.y, m.xSize, m.ySize);
                if (swordRec.IntersectsWith(monsterRec))
                {
                    if (!m.hit)
                    {
                        m.hit = true;
                        MonsterDamage(m, sword.damage);
                        return true;
                    }
                    else return false;
                }
                return false;
            }
            else return false;

        }
        private bool MonsterTrapCollision(Monster m)
        {
            foreach (Trap t in traps)
            {
                Rectangle trapRec = new Rectangle(t.x, t.y, t.size, t.size);
                Rectangle monsterRec = new Rectangle(m.x, m.y, m.xSize, m.ySize);
                if (trapRec.IntersectsWith(monsterRec))
                {
                    if (t.type == "bearTrap")
                    {
                        if (MonsterDamage(m, trapDamage))
                        {
                            traps.Remove(t);
                            return true;
                        }             
                        traps.Remove(t);
                        break;
                    }
                    else
                    {
                        t.explosionActive = true;
                        t.expX = t.x - 50;
                        t.expY = t.y - 50;
                        t.expSize = t.size + 100;

                        if (Explosion(t)) return true;                        
                        else return false;
                        
                    }
                }
            }
            return false;
        }
        private void MonsterAttack(Monster m)
        {
            m.attackStart = true;
            switch (m.type)
            {
                case "goblin":
                    if (m.attackStage > 23)
                    {
                        m.attackStart = false;
                        m.attackStage = 0;
                    }
                    else if (m.attackStage > 18)
                    {
                        //wait
                    }
                    else if (m.attackStage > 10)
                    {
                        m.x += 15 * m.xDir;
                        m.y += 15 * m.yDir;

                    }
                    break;
                case "cyclops":
                    if (m.attackStage > 10)
                    {
                        m.attackStart = false;
                        m.attackStage = 0;
                    }
                    else if (m.attackStage > 7)
                    {
                        //wait
                    }
                    else if (m.attackStage == 7)
                    {
                        m.x += 25 * -m.xDir;
                        m.y += 25 * -m.yDir;
                    }
                    else if (m.attackStage == 6)
                    {
                        //wait
                    }
                    else if (m.attackStage == 5)
                    {
                        m.x += 25 * m.xDir;
                        m.y += 25 * m.yDir;
                    }
                    break;
                case "troll":
                    if (m.attackStage == 6)
                    {
                        m.attackStart = false;
                        m.attackStage = 0;
                    }
                    else if (m.attackStage == 5)
                    {
                        m.x += 25 * m.xDir;
                        m.y += 25 * m.yDir;
                    }


                    break;
            }
        }
        private bool Explosion(Trap t)
        {
            Rectangle ExplosionRec = new Rectangle(t.expX, t.expY, t.expSize, t.expSize);
            for (int i = 0; i < 10; i++)
            {
                foreach (Monster m in monsters)
                {
                    Rectangle MonsterRec = new Rectangle(m.x, m.y, m.xSize, m.ySize);
                    if (MonsterRec.IntersectsWith(ExplosionRec))
                    {
                        if (MonsterDamage(m, trapDamage)) return true;                        
                    }                    
                }
            }
            return false;
        }
        private void CreateLevel()
        {
            LevelPrep();
            switch (currentLevel)
            {
                case 3:
                    walls.Clear();
                    BaseWalls();
                    Wall w1 = new Wall(150, 150, 300, 50);
                    walls.Add(w1);
                    Wall w2 = new Wall(750, 150, 300, 50);
                    walls.Add(w2);
                    Wall w3 = new Wall(150, 500, 300, 50);
                    walls.Add(w3);
                    Wall w4 = new Wall(750, 500, 300, 50);
                    walls.Add(w4);
                    break;
                case 2:
                    walls.Clear();
                    BaseWalls();
                    Wall w5 = new Wall(200, 100, 50, 150);
                    walls.Add(w5);
                    Wall w6 = new Wall(950, 100, 50, 150);
                    walls.Add(w6);
                    Wall w7 = new Wall(200, 450, 50, 150);
                    walls.Add(w7);
                    Wall w8 = new Wall(950, 450, 50, 150);
                    walls.Add(w8);
                    break;
                case 1:
                    walls.Clear();
                    BaseWalls();
                    Wall w9 = new Wall(350, 325, 50, 50);
                    walls.Add(w9);
                    Wall w10 = new Wall(800, 325, 50, 50);
                    walls.Add(w10);
                    break;
            }
        }
        private void LevelPrep()
        {
            player.x = 575;
            player.y = 325;
            if (Form1.gunType == "shotgun") gun.bulletCount = 8;
            else gun.bulletCount = 24;
            traps.Clear();
            bullets.Clear();
        }
        private void BaseWalls()
        {
            Wall w1 = new Wall(0, 0, 50, 700);
            walls.Add(w1);
            Wall w2 = new Wall(0, 0, 1200, 50);
            walls.Add(w2);
            Wall w3 = new Wall(0, 650, 1200, 50);
            walls.Add(w3);
            Wall w4 = new Wall(1150, 0, 50, 700);
            walls.Add(w4);
        }
        public void GameOver()
        {
            //get score
            GameTick.Enabled = false;
            Thread.Sleep(50);

            Form f = this.FindForm();
            EndScreen es = new EndScreen();
            f.Controls.Add(es);
            f.Controls.Remove(this);
        }
        private bool MonsterDamage(Monster m, int damage)
        {
            m.health -= damage;
            if (m.health <= 0)
            {
                monsters.Remove(m);
                monstersLeft--;
                Form1.score += m.xp + 2 * difficulty;
                return true;
            }
            else return false;
        }

    }
}
