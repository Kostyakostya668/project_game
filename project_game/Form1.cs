using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace project_game
{
    // Размер окна 500 на 570
    public partial class game_lev_1 : Form
    {
        bool move_right = false, move_left = false, move_down = false, move_up = false;
        int enemy_max = 0;
        int enemy_plus = 0;
        int count_kills = 0;
        int number_wave = 1;
        bool menu = true;
        bool inter = false;
        bool choose_lev = true;
        bool next_lev = true;
        bool pause = false;
        bool itogi = false;
        bool spawn_hero = false;
        bool rocket_timer_state = false;
        bool rocket_explosion = false;
        Point rocket_loc_vrem;

        Image[] explosion_image = new Image[3];
        int image_time = 0;

        const float immortalityTime = 0.35f;
        const float suppliesTime = 10f;
        const int rocketTime = 10;
        const int menu_Time = 100;

        Diff diff;

        public enum State
        {
            Moving,
            Shooting,
            Stands
        }

        public enum Diff
        {
            easy,
            middle,
            hard,
            Test
        }

        struct Supplies
        {
            public int bullet_count;
            public int hp_count;
            public int rocket_count;
            public PictureBox pic;
        }
        List<Supplies> sup = new List<Supplies>();

        struct bullet
        {
            public int x1, y1;
            public int x2, y2;
            public PictureBox pic;
        }
        List<bullet> bullets = new List<bullet>();

        struct rocket
        {
            public int x1, y1;
            public int x2, y2;
            public int timer_life;
            public PictureBox pic;
        }
        List<rocket> rocket_list = new List<rocket>();

        struct hero
        {
            public int hp;
            public int damage;
            public int bullets_count;
            public int rocket_count;
            public int speed;
            public PictureBox pic;
            public State state;
        }
        hero HERO = new hero();

        struct enemy
        {
            public int hp;
            public int damage;
            public int speed;
            public PictureBox pic;
        }
        List<enemy> enemies = new List<enemy>();

        public game_lev_1()
        {
            InitializeComponent();
            explosion_image[0] = Properties.Resources.explosion_1;
            explosion_image[1] = Properties.Resources.explosion_2;
            explosion_image[2] = Properties.Resources.explosion_3;
            //DoubleBuffered = true;
        }

        //Кнопки

        private void start_bt1_Click(object sender, EventArgs e)
        {
            //BackgroundImage
            //generate_HERO();
            //timer1.Start();
            inter = false;
            menu = false;
            choose_lev = true;
            next_lev = false;
            pause = false;
            this.Location = new Point(0, 0);
            choose_slo();
        }

        private void exit_bt2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void slo_1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Tag)
            {
                case "easy":
                    DialogResult result1 = MessageBox.Show("Выбрана ЛЕГКАЯ сложность", "Уроень сложности", MessageBoxButtons.OKCancel);

                    if (result1 == DialogResult.OK)
                    {
                        enemy_max = 5;
                        diff = Diff.easy;
                        Debug.WriteLine("Game mode = " + diff);
                        inter = true;
                        choose_lev = false;
                        next_lev = false;
                        spawn_hero = true;
                        BackgroundImage = Properties.Resources.фон1;
                        choose_slo();
                    }
                    else { return; };
                    break;
                case "mid":
                    result1 = MessageBox.Show("Выбрана СРЕДНЯЯ сложность", "Уроень сложности", MessageBoxButtons.OKCancel);

                    if (result1 == DialogResult.OK)
                    {
                        enemy_max = 10;
                        diff = Diff.middle;
                        Debug.WriteLine("Game mode = " + diff);
                        inter = true;
                        choose_lev = false;
                        next_lev = false;
                        spawn_hero = true;
                        BackgroundImage = Properties.Resources.фон1;
                        choose_slo();
                    }
                    else { return; };
                    break;
                case "dif":
                    result1 = MessageBox.Show("Выбрана СЛОЖНАЯ сложность", "Уроень сложности", MessageBoxButtons.OKCancel);

                    if (result1 == DialogResult.OK)
                    {
                        enemy_max = 15;

                        diff = Diff.hard;
                        Debug.WriteLine("Game mode = " + diff);
                        inter = true;
                        choose_lev = false;
                        spawn_hero = true;
                        next_lev = false;
                        BackgroundImage = Properties.Resources.фон1;
                        choose_slo();
                    }
                    else { return; };
                    break;
                case "test":
                    enemy_max = 0;
                    diff = Diff.Test;
                    Debug.WriteLine("Game mode = " + diff);
                    inter = true;
                    choose_lev = false;
                    next_lev = false;
                    spawn_hero = true;
                    BackgroundImage = Properties.Resources.фон1;
                    choose_slo();
                    break;
                default: break;
            }
        }

        private void next_wave_bt4_Click(object sender, EventArgs e)
        {
            number_wave++;
            counter_menutime = 100;
            inter = true;
            next_lev = false;
            spawn_hero = true;
            choose_slo();
            switch (diff)
            {
                case Diff.easy:
                    enemy_plus += 5; enemy_max = enemy_plus;
                    break;
                case Diff.middle:
                    enemy_plus += 10; enemy_max += enemy_plus;
                    break;
                case Diff.hard:
                    enemy_plus += 15; enemy_max += enemy_plus;
                    break;
                default:
                    break;
            }
        }

        private void main_menu_bt5_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // Меню

        private void Pause()
        {
            timer1.Stop();
            inter = false;
            menu = false;
            choose_lev = false;
            pause = true;
            next_lev = false;
            choose_slo();
        }

        private void Reset()
        {
            timer1.Stop();
            count_kills = 0;
            this.Controls.Remove(HERO.pic);
            foreach (var x in enemies)
            {
                this.Controls.Remove(x.pic);
            }
            enemies.Clear();
            foreach (var x in bullets)
            {
                this.Controls.Remove(x.pic);
            }
            bullets.Clear();
            foreach (var x in sup)
            {
                this.Controls.Remove(x.pic);
            }
            sup.Clear();

            BackgroundImage = Properties.Resources.white_fone;
            inter = false;
            menu = true;
            next_lev = false;
            choose_lev = false;
            pause = false;
            itogi = false;
            choose_slo();
        }

        private void Itogi_game()
        {
            timer1.Stop();
            this.Controls.Remove(HERO.pic);
            foreach (var x in enemies)
            {
                this.Controls.Remove(x.pic);
            }
            enemies.Clear();
            foreach (var x in bullets)
            {
                this.Controls.Remove(x.pic);
            }
            bullets.Clear();
            foreach (var x in sup)
            {
                this.Controls.Remove(x.pic);
            }
            sup.Clear();
            BackgroundImage = Properties.Resources.white_fone;
            inter = false;
            menu = false;
            next_lev = false;
            choose_lev = false;
            pause = false;
            itogi = true;
            lab_itogi.Text = "Всего врагов добито: " + count_kills;
            choose_slo();
        }

        void Next_lev()
        {
            explosion_rocket.Visible = false;
            timer1.Stop();
            this.Controls.Remove(HERO.pic);
            foreach (var x in enemies)
            {
                this.Controls.Remove(x.pic);
            }
            enemies.Clear();
            foreach (var x in bullets)
            {
                this.Controls.Remove(x.pic);
            }
            bullets.Clear();
            foreach (var x in sup)
            {
                this.Controls.Remove(x.pic);
            }
            sup.Clear();
            foreach (var x in rocket_list)
            {
                this.Controls.Remove(x.pic);
            }
            rocket_list.Clear();
            inter = false;
            next_lev = true;
            choose_slo();
        }

        private void bt7_continue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            inter = true;
            pause = false;
            choose_slo();
        }

        private void choose_slo()
        {
            start_bt1.Visible = menu;
            start_bt1.Enabled = menu;

            exit_bt2.Visible = menu;
            exit_bt2.Enabled = menu;

            pers_bt3.Visible = menu;
            pers_bt3.Enabled = menu;

            slo_1.Visible = choose_lev;
            slo_1.Enabled = choose_lev;
            slo_1.Location = start_bt1.Location;

            slo_2.Visible = choose_lev;
            slo_2.Enabled = choose_lev;
            slo_2.Location = pers_bt3.Location;

            slo_3.Visible = choose_lev;
            slo_3.Enabled = choose_lev;
            slo_3.Location = exit_bt2.Location;

            main_menu_bt6.Enabled = choose_lev;
            main_menu_bt6.Visible = choose_lev;

            wave_lab.Visible = inter;

            test_mod.Visible = choose_lev;
            test_mod.Enabled = choose_lev;
            test_mod.Location = new Point(slo_1.Left, slo_1.Top - 75);

            next_wave_bt4.Enabled = next_lev;
            next_wave_bt4.Visible = next_lev;
            next_wave_bt4.Location = start_bt1.Location;

            main_menu_bt5.Enabled = next_lev;
            main_menu_bt5.Visible = next_lev;
            main_menu_bt5.Location = pers_bt3.Location;

            bt7_continue.Enabled = pause;
            bt7_continue.Visible = pause;
            bt7_continue.Location = new Point(start_bt1.Left - 9, start_bt1.Top);

            main_menu_bt8.Enabled = pause;
            main_menu_bt8.Visible = pause;
            main_menu_bt8.Location = new Point(start_bt1.Left, bt7_continue.Top + bt7_continue.Height);

            lab_itogi.Visible = itogi;
            lab_itogi.Location = wave_lab.Location;

            main_menu_bt9.Enabled = itogi;
            main_menu_bt9.Visible = itogi;
            main_menu_bt9.Location = new Point(lab_itogi.Left, lab_itogi.Top + lab_itogi.Height);

            hpBar_lb1.Visible = inter;
            hp_bar.Visible = inter;
            lab2_kills.Visible = inter;
            lab3_bullets_count.Visible = inter;
            lab_4_rocketcount.Visible = inter;
            rocket_bar.Visible = inter;

            if (spawn_hero == true) { timer1.Start(); generate_HERO(); spawn_hero = false; }
        }

        //Генерация

        private void generate_HERO()
        {
            HERO.hp = 100;
            HERO.damage = 25;
            HERO.bullets_count = 30;
            HERO.rocket_count = 2;
            HERO.speed = 8;

            HERO.pic = new PictureBox();
            HERO.pic.Size = new Size(20, 35);
            HERO.pic.BackgroundImage = Properties.Resources.HERO;
            HERO.pic.BackgroundImageLayout = ImageLayout.Stretch;
            HERO.pic.Location = new Point((this.Width / 2) - (HERO.pic.Width / 2), (this.Height / 2));
            this.Controls.Add(HERO.pic);
        }

        private void generate_enemy()
        {
            enemy enem = new enemy();

            Random rnd = new Random();

            enem.pic = new PictureBox();
            enem.pic.Tag = "ENEMY";
            enem.hp = 100;
            enem.damage = 10;
            enem.speed = 2;
            enem.pic.Size = new Size(20, 35);
            enem.pic.BackColor = Color.Red;
            enem.pic.BorderStyle = BorderStyle.FixedSingle;

            int sto = rnd.Next(0, 4);
            switch (sto)
            {
                case 0: enem.pic.Location = new Point(HERO.pic.Left + rnd.Next(275, 500), HERO.pic.Top + rnd.Next(40, 170)); break;
                case 1: enem.pic.Location = new Point(HERO.pic.Left - rnd.Next(275, 500), HERO.pic.Top + rnd.Next(40, 170)); break;
                case 2: enem.pic.Location = new Point(HERO.pic.Left + rnd.Next(-300, 300), HERO.pic.Top - rnd.Next(275, 350)); break;
                case 3: enem.pic.Location = new Point(HERO.pic.Left + rnd.Next(-300, 300), HERO.pic.Top - rnd.Next(-275, -175)); break;
                default:
                    break;
            }
            enemies.Add(enem);
            this.Controls.Add(enem.pic);
        }

        private void generate_supplies()
        {
            Supplies supplies = new Supplies();
            Random random = new Random();

            supplies.bullet_count = 10;
            supplies.hp_count = 20;
            supplies.rocket_count = 2;

            supplies.pic = new PictureBox();
            supplies.pic.Tag = "SUPPLIES";
            supplies.pic.Size = new Size(10, 10);
            supplies.pic.BackColor = Color.Brown;
            supplies.pic.Location = new Point(random.Next(150, 300), random.Next(150, 480));

            sup.Add(supplies);
            this.Controls.Add(supplies.pic);

        }

        int offsetX = 0;
        int offsetY = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            int image_Width = BackgroundImage.Width;
            int image_Height = BackgroundImage.Height;

            double startX = 0;
            double startY = 0;

            offsetX = offsetX % image_Width;
            offsetY = offsetY % image_Height;

            if (offsetX > 0)
            {
                startX = offsetX - Width;
            }
            else
            {
                startX = offsetX;
            }

            if (offsetY > 0)
            {
                startY = offsetY - Height;
            }
            else
            {
                startY = offsetY;
            }

            for (double i = startY; i < ClientSize.Height; i += image_Height)
            {
                for (double j = startX; j < ClientSize.Width; j += image_Width)
                {
                    graphics.DrawImage(this.BackgroundImage, (float)j, (float)i, image_Width, image_Height);
                }
            }
        }

        //Таймер

        float counter_hero_damage = 0.0f;
        float counter_suppliesTime = suppliesTime * 10;
        int counter_rocketTime = rocketTime * 10;
        int counter_menutime = 100;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();

            //Меню
            wave_lab.Visible = true;
            counter_menutime--;
            if (diff == Diff.Test)
            {
                wave_lab.Text = "Сложность: " + diff;
            }
            else
            {
                wave_lab.Text = "Волна:" + number_wave + "\n" + "Сложность: " + diff;
            }
            if (counter_menutime <= 0)
            {
                wave_lab.Visible = false;
            }

            //герой

            Debug.WriteLine(HERO.state);
            //if (HERO.state == State.Shooting)
            //{
            //    //Debug.WriteLine(HERO.state);
            //}
            //if (HERO.state == State.Moving)
            //{
            move_hero();
            //Debug.WriteLine(HERO.state);
            //}
            if (HERO.hp <= 0)
            {
                Itogi_game();
                //Reset();
            }
            if (bullets.Count != 0)
            {
                Bullet_move();
            }
            if (rocket_list.Count != 0)
            {
                Rocket_move();
            }

            lab2_kills.Text = "Убийтсва: " + count_kills;
            lab3_bullets_count.Text = "Патроны: " + HERO.bullets_count;
            lab_4_rocketcount.Text = "Ракеты: " + HERO.rocket_count;
            if (HERO.hp >= 0)
            {
                hp_bar.Value = HERO.hp;
            }
            lab4_info.Text = Convert.ToString(sup.Count); //Количетсво патронов на карте
            bullet bullet;
            bullet.y1 = Cursor.Position.Y;
            bullet.x1 = Cursor.Position.X;
            test_lb.Text = Convert.ToString("x= " + bullet.x1 + " " + "y= " + bullet.y1);



            // Спавн припасов

            if ((HERO.hp < 80 || HERO.bullets_count < 20) && sup.Count < 5)
            {
                counter_suppliesTime--;
                if (counter_suppliesTime == 0)
                {
                    generate_supplies();
                    counter_suppliesTime = suppliesTime * 10;
                }
            }
            hero_col_supplies();
            test_lb2.Text = counter_suppliesTime.ToString();

            //Ракеты

            if (rocket_timer_state == true)
            {
                counter_rocketTime--;
                rocket_bar.Value = counter_rocketTime;
                if (counter_rocketTime == 0)
                {
                    rocket_timer_state = false;
                    counter_rocketTime = rocketTime * 10;
                }
            }

            //Взрыв

            if (rocket_explosion == true)
            {
                rocket_exp();
            }

            // Враг

            enemy_moving();
            enemy_get_damage();
            enemy_col_rocket();
            if (counter_hero_damage > 0)
            {
                counter_hero_damage--;
            }
            else if (counter_hero_damage == 0)
            {
                enemy_col_hero();
            }
            if (enemies.Count < enemy_max)
            {
                generate_enemy();
            }
            if (diff != Diff.Test && enemies.Count <= 0)
            {
                Next_lev();
            }
        }

        //Герой

        private void move_hero()
        {


            if (move_up == true)
            {
                Invalidate();
                HERO.pic.Top -= HERO.speed;
                offsetY += HERO.speed;
            }
            if (move_down == true)
            {
                Invalidate();
                HERO.pic.Top += HERO.speed;
                offsetY -= HERO.speed;
            }
            if (move_right == true)
            {
                Invalidate();
                HERO.pic.Left += HERO.speed;
                offsetX -= HERO.speed;
            }
            if (move_left == true)
            {
                Invalidate();
                HERO.pic.Left -= HERO.speed;
                offsetX += HERO.speed;
            }

            if (move_right && HERO.pic.Left < 420)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Name != "HERO")
                    {
                        x.Left -= HERO.speed;
                    }
                }
            }
            if (move_left && HERO.pic.Left > 10)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Name != "HERO")
                    {
                        x.Left += HERO.speed;
                    }
                }
            }
            if (move_up && HERO.pic.Top > 10)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Name != "HERO")
                    {
                        x.Top += HERO.speed;
                    }
                }
            }
            if (move_down && HERO.pic.Top < 420)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Name != "HERO")
                    {
                        x.Top -= HERO.speed;

                    }
                }
            }
        }

        private void hero_col_supplies()
        {

            for (int i = sup.Count - 1; i >= 0; i--)
            {
                if (sup[i].pic == null) continue;

                if (sup[i].pic.Bounds.IntersectsWith(HERO.pic.Bounds))
                {
                    HERO.bullets_count += sup[i].bullet_count;
                    HERO.hp += sup[i].hp_count;
                    HERO.rocket_count += sup[i].rocket_count;

                    if (HERO.bullets_count >= 60)
                    {
                        HERO.bullets_count = 60;
                    }
                    if (HERO.hp >= 100)
                    {
                        HERO.hp = 100;
                    }
                    if (HERO.rocket_count >= 5)
                    {
                        HERO.rocket_count = 5;
                    }

                    this.Controls.Remove(sup[i].pic);
                    sup[i].pic.Dispose();
                    sup.RemoveAt(i);
                    break;
                }
            }
        }

        private void enemy_col_hero()
        {
            foreach (var x in enemies)
            {
                if (x.pic.Bounds.IntersectsWith(HERO.pic.Bounds))
                {
                    HERO.hp -= x.damage;
                    counter_hero_damage = immortalityTime * 100;
                }
            }
        }

        private void game_lev_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Pause();
            }

            if (e.KeyCode == Keys.E && HERO.rocket_count != 0 && rocket_timer_state == false)
            {
                rocket_timer_state = true;
                createAmmunition(HERO.pic.Location, "rocket");
            }

            if (e.KeyCode == Keys.W)
            {
                move_up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                move_down = true;
            }
            if (e.KeyCode == Keys.D)
            {
                move_right = true;
            }
            if (e.KeyCode == Keys.A)
            {
                move_left = true;
            }
        }

        private void createAmmunition(Point spawnpoint, string what_spawn)
        {
            //пули
            if (what_spawn == "bullet")
            {
                PictureBox bulletPic = new PictureBox();
                bulletPic.BackColor = Color.Red;
                bulletPic.Tag = "bullet";
                bulletPic.Size = new Size(7, 9);
                bulletPic.Location = spawnpoint;
                bullet newBullet;
                newBullet.x1 = (ClientSize.Width / 2);
                newBullet.y1 = ClientSize.Height / 2;
                newBullet.x2 = Cursor.Position.X;
                newBullet.y2 = Cursor.Position.Y;

                HERO.bullets_count--;

                newBullet.pic = bulletPic;

                bullets.Add(newBullet);

                bulletPic.Location = HERO.pic.Location;
                Controls.Add(bulletPic);
            }
            //ракеты
            if (what_spawn == "rocket")
            {

                rocket newRocket;
                PictureBox rocketPic = new PictureBox();
                rocketPic.BackColor = Color.Black;
                rocketPic.Tag = "rocket";
                rocketPic.Size = new Size(16, 14);
                rocketPic.Location = spawnpoint;
                rocketPic.Location = HERO.pic.Location;
                newRocket.pic = rocketPic;
                newRocket.timer_life = 140;
                newRocket.x1 = (ClientSize.Width / 2);
                newRocket.y1 = ClientSize.Height / 2;
                newRocket.x2 = Cursor.Position.X;
                newRocket.y2 = Cursor.Position.Y;
                newRocket.pic = rocketPic;

                HERO.rocket_count--;

                rocket_list.Add(newRocket);

                Controls.Add(newRocket.pic);
            }
        }

        private void Bullet_move()
        {
            foreach (bullet bullet in bullets)
            {
                float lenght = (float)Math.Sqrt((Math.Pow(bullet.x2 - bullet.x1, 2)) + (Math.Pow(bullet.y2 - bullet.y1, 2)));

                Point newPoint = bullet.pic.Location;

                int dx = (int)((bullet.x2 - bullet.x1) / lenght * 5);
                int dy = (int)((bullet.y2 - bullet.y1) / lenght * 5);

                newPoint.Offset(dx, dy);

                bullet.pic.Location = newPoint;
            }
        }

        private void Rocket_move()
        {
            for (int i = 0; i < rocket_list.Count; i++)
            {
                rocket tempRocket = rocket_list[i];

                float lenght = (float)Math.Sqrt((Math.Pow(rocket_list[i].x2 - rocket_list[i].x1, 2)) + (Math.Pow(rocket_list[i].y2 - rocket_list[i].y1, 2)));

                int dx = (int)((rocket_list[i].x2 - rocket_list[i].x1) / lenght * 3);
                int dy = (int)((rocket_list[i].y2 - rocket_list[i].y1) / lenght * 3);

                Point newPoint = tempRocket.pic.Location;
                newPoint.Offset(dx, dy);
                tempRocket.pic.Location = newPoint;

                tempRocket.timer_life--;

                rocket_list[i] = tempRocket;
                if (tempRocket.timer_life <= 0)
                {
                    explosion_rocket.Location = rocket_list[i].pic.Location;
                    explosion_rocket.Visible = true;
                    rocket_explosion = true;
                    rocket_exp();
                    rocket_list[i].pic.Dispose();
                    rocket_list.Remove(rocket_list[i]);
                    break;
                }
            }
        }

        private void game_lev_1_MouseClick(object sender, MouseEventArgs e)
        {
            if (HERO.bullets_count != 0)
            {
                createAmmunition(HERO.pic.Location, "bullet");
            }

            //int n = Convert.ToInt32(test_lb.Text);
            //test_lb.Text = Convert.ToString(n + 1);
        }

        private void game_lev_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                move_up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                move_down = false;
            }
            if (e.KeyCode == Keys.D)
            {
                move_right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                move_left = false;
            }
        }


        //Враги
        private void enemy_moving()
        {
            foreach (var x in enemies)
            {
                if (enemy_col_enemy(x))
                {
                    if (x.pic.Left <= HERO.pic.Left && x.pic.Top <= HERO.pic.Top)
                    {
                        x.pic.Left += x.speed;
                        x.pic.Top += x.speed;
                    }
                    if (x.pic.Left >= HERO.pic.Left && x.pic.Top <= HERO.pic.Top)
                    {
                        x.pic.Left -= x.speed;
                        x.pic.Top += x.speed;
                    }
                    if (x.pic.Left <= HERO.pic.Left && x.pic.Top >= HERO.pic.Top)
                    {
                        x.pic.Left += x.speed;
                        x.pic.Top -= x.speed;
                    }
                    if (x.pic.Left >= HERO.pic.Left && x.pic.Top >= HERO.pic.Top)
                    {
                        x.pic.Left -= x.speed;
                        x.pic.Top -= x.speed;
                    }
                }
            }
        }



        private bool enemy_col_enemy(enemy currentEnemy)
        {
            foreach (var x in enemies)
            {
                if ((x.pic.Left <= currentEnemy.pic.Left && currentEnemy.pic.Left <= x.pic.Right) &&
                (currentEnemy.pic.Top >= x.pic.Top && currentEnemy.pic.Top <= x.pic.Bottom))
                {
                    return true;
                }
                if (currentEnemy.pic.Bounds.IntersectsWith(x.pic.Bounds))
                {
                    if (!Equals(x, currentEnemy))
                    {
                        currentEnemy.pic.Left -= 10;
                    }
                }
            }
            return false;
        }



        private void rocket_exp()
        {
            image_time++;
            switch (image_time)
            {
                case 15: explosion_rocket.Image = explosion_image[0]; break;
                case 30: explosion_rocket.Image = explosion_image[1]; break;
                case 45: explosion_rocket.Image = explosion_image[2]; break;
                case 60: image_time = 0; rocket_explosion = false; explosion_rocket.Visible = false; explosion_rocket.Image = explosion_image[0]; break;
            }
            for (int j = enemies.Count - 1; j >= 0; j--)
            {
                if (enemies[j].pic == null) continue;

                if (explosion_rocket.Bounds.IntersectsWith(enemies[j].pic.Bounds))
                {
                    count_kills++;
                    enemy_max--;
                    this.Controls.Remove(enemies[j].pic);
                    enemies[j].pic.Dispose();
                    enemies.RemoveAt(j);

                    break;
                }
            }

        }

        private void enemy_col_rocket()
        {
            for (int i = rocket_list.Count - 1; i >= 0; i--)
            {
                if (rocket_list[i].pic == null) continue;

                for (int j = enemies.Count - 1; j >= 0; j--)
                {
                    if (enemies[j].pic == null) continue;

                    if (rocket_list[i].pic.Bounds.IntersectsWith(enemies[j].pic.Bounds))
                    {
                        explosion_rocket.Location = rocket_list[i].pic.Location;
                        rocket_explosion = true;
                        explosion_rocket.Visible = true;
                        rocket_exp();
                        rocket_list[i].pic.Dispose();
                        rocket_list.Remove(rocket_list[i]);

                        break;
                    }
                }
            }
        }

        private void enemy_get_damage()
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                if (bullets[i].pic == null) continue;

                for (int j = enemies.Count - 1; j >= 0; j--)
                {
                    if (enemies[j].pic == null) continue;

                    if (bullets[i].pic.Bounds.IntersectsWith(enemies[j].pic.Bounds))
                    {
                        Debug.WriteLine(enemies[j].hp);
                        enemy enemy = enemies[j];
                        enemy.hp -= HERO.damage;
                        enemies[j] = enemy;

                        this.Controls.Remove(bullets[i].pic);
                        bullets[i].pic.Dispose();
                        bullets.RemoveAt(i);

                        if (enemies[j].hp <= 0)
                        {
                            count_kills++;
                            enemy_max--;
                            this.Controls.Remove(enemies[j].pic);
                            enemies[j].pic.Dispose();
                            enemies.RemoveAt(j);
                        }
                        break;
                    }
                }
            }
        }
    }
}

// Задумки

