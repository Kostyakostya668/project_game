namespace project_game
{
    partial class game_lev_1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_bt1 = new System.Windows.Forms.Button();
            this.exit_bt2 = new System.Windows.Forms.Button();
            this.pers_bt3 = new System.Windows.Forms.Button();
            this.hpBar_lb1 = new System.Windows.Forms.Label();
            this.test_lb = new System.Windows.Forms.Label();
            this.lab2_kills = new System.Windows.Forms.Label();
            this.lab3_bullets_count = new System.Windows.Forms.Label();
            this.test_lb2 = new System.Windows.Forms.Label();
            this.lab4_info = new System.Windows.Forms.Label();
            this.slo_1 = new System.Windows.Forms.Button();
            this.slo_2 = new System.Windows.Forms.Button();
            this.slo_3 = new System.Windows.Forms.Button();
            this.hp_bar = new System.Windows.Forms.ProgressBar();
            this.test_mod = new System.Windows.Forms.Button();
            this.lab_4_rocketcount = new System.Windows.Forms.Label();
            this.rocket_bar = new System.Windows.Forms.ProgressBar();
            this.explosion_rocket = new System.Windows.Forms.PictureBox();
            this.wave_lab = new System.Windows.Forms.Label();
            this.next_wave_bt4 = new System.Windows.Forms.Button();
            this.main_menu_bt5 = new System.Windows.Forms.Button();
            this.dom = new System.Windows.Forms.PictureBox();
            this.main_menu_bt6 = new System.Windows.Forms.Button();
            this.bt7_continue = new System.Windows.Forms.Button();
            this.main_menu_bt8 = new System.Windows.Forms.Button();
            this.lab_itogi = new System.Windows.Forms.Label();
            this.main_menu_bt9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.explosion_rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_bt1
            // 
            this.start_bt1.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_bt1.Location = new System.Drawing.Point(185, 157);
            this.start_bt1.Name = "start_bt1";
            this.start_bt1.Size = new System.Drawing.Size(123, 43);
            this.start_bt1.TabIndex = 0;
            this.start_bt1.Text = "Старт";
            this.start_bt1.UseVisualStyleBackColor = true;
            this.start_bt1.Click += new System.EventHandler(this.start_bt1_Click);
            // 
            // exit_bt2
            // 
            this.exit_bt2.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_bt2.Location = new System.Drawing.Point(185, 270);
            this.exit_bt2.Name = "exit_bt2";
            this.exit_bt2.Size = new System.Drawing.Size(123, 41);
            this.exit_bt2.TabIndex = 0;
            this.exit_bt2.Text = "Выход";
            this.exit_bt2.UseVisualStyleBackColor = true;
            this.exit_bt2.Click += new System.EventHandler(this.exit_bt2_Click);
            // 
            // pers_bt3
            // 
            this.pers_bt3.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pers_bt3.Location = new System.Drawing.Point(185, 206);
            this.pers_bt3.Name = "pers_bt3";
            this.pers_bt3.Size = new System.Drawing.Size(121, 58);
            this.pers_bt3.TabIndex = 0;
            this.pers_bt3.Text = "Настройки персонажа";
            this.pers_bt3.UseVisualStyleBackColor = true;
            // 
            // hpBar_lb1
            // 
            this.hpBar_lb1.AutoSize = true;
            this.hpBar_lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hpBar_lb1.Location = new System.Drawing.Point(12, 9);
            this.hpBar_lb1.Name = "hpBar_lb1";
            this.hpBar_lb1.Size = new System.Drawing.Size(41, 24);
            this.hpBar_lb1.TabIndex = 1;
            this.hpBar_lb1.Text = "HP:";
            this.hpBar_lb1.Visible = false;
            // 
            // test_lb
            // 
            this.test_lb.AutoSize = true;
            this.test_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_lb.Location = new System.Drawing.Point(316, 9);
            this.test_lb.Name = "test_lb";
            this.test_lb.Size = new System.Drawing.Size(20, 24);
            this.test_lb.TabIndex = 1;
            this.test_lb.Text = "0";
            this.test_lb.Visible = false;
            // 
            // lab2_kills
            // 
            this.lab2_kills.AutoSize = true;
            this.lab2_kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab2_kills.Location = new System.Drawing.Point(12, 44);
            this.lab2_kills.Name = "lab2_kills";
            this.lab2_kills.Size = new System.Drawing.Size(40, 24);
            this.lab2_kills.TabIndex = 1;
            this.lab2_kills.Text = "kills";
            this.lab2_kills.Visible = false;
            // 
            // lab3_bullets_count
            // 
            this.lab3_bullets_count.AutoSize = true;
            this.lab3_bullets_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab3_bullets_count.Location = new System.Drawing.Point(12, 79);
            this.lab3_bullets_count.Name = "lab3_bullets_count";
            this.lab3_bullets_count.Size = new System.Drawing.Size(64, 24);
            this.lab3_bullets_count.TabIndex = 1;
            this.lab3_bullets_count.Text = "bullets";
            this.lab3_bullets_count.Visible = false;
            // 
            // test_lb2
            // 
            this.test_lb2.AutoSize = true;
            this.test_lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_lb2.Location = new System.Drawing.Point(316, 44);
            this.test_lb2.Name = "test_lb2";
            this.test_lb2.Size = new System.Drawing.Size(20, 24);
            this.test_lb2.TabIndex = 1;
            this.test_lb2.Text = "0";
            this.test_lb2.Visible = false;
            // 
            // lab4_info
            // 
            this.lab4_info.AutoSize = true;
            this.lab4_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab4_info.Location = new System.Drawing.Point(316, 79);
            this.lab4_info.Name = "lab4_info";
            this.lab4_info.Size = new System.Drawing.Size(20, 24);
            this.lab4_info.TabIndex = 1;
            this.lab4_info.Text = "0";
            this.lab4_info.Visible = false;
            // 
            // slo_1
            // 
            this.slo_1.Enabled = false;
            this.slo_1.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slo_1.Location = new System.Drawing.Point(320, 157);
            this.slo_1.Name = "slo_1";
            this.slo_1.Size = new System.Drawing.Size(121, 43);
            this.slo_1.TabIndex = 0;
            this.slo_1.Tag = "easy";
            this.slo_1.Text = "Легко";
            this.slo_1.UseVisualStyleBackColor = true;
            this.slo_1.Visible = false;
            this.slo_1.Click += new System.EventHandler(this.slo_1_Click);
            // 
            // slo_2
            // 
            this.slo_2.Enabled = false;
            this.slo_2.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slo_2.Location = new System.Drawing.Point(320, 212);
            this.slo_2.Name = "slo_2";
            this.slo_2.Size = new System.Drawing.Size(121, 47);
            this.slo_2.TabIndex = 0;
            this.slo_2.Tag = "mid";
            this.slo_2.Text = "Средне";
            this.slo_2.UseVisualStyleBackColor = true;
            this.slo_2.Visible = false;
            this.slo_2.Click += new System.EventHandler(this.slo_1_Click);
            // 
            // slo_3
            // 
            this.slo_3.Enabled = false;
            this.slo_3.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slo_3.Location = new System.Drawing.Point(320, 270);
            this.slo_3.Name = "slo_3";
            this.slo_3.Size = new System.Drawing.Size(121, 41);
            this.slo_3.TabIndex = 0;
            this.slo_3.Tag = "dif";
            this.slo_3.Text = "Сложно";
            this.slo_3.UseVisualStyleBackColor = true;
            this.slo_3.Visible = false;
            this.slo_3.Click += new System.EventHandler(this.slo_1_Click);
            // 
            // hp_bar
            // 
            this.hp_bar.BackColor = System.Drawing.Color.Red;
            this.hp_bar.ForeColor = System.Drawing.Color.Red;
            this.hp_bar.Location = new System.Drawing.Point(49, 10);
            this.hp_bar.Name = "hp_bar";
            this.hp_bar.Size = new System.Drawing.Size(100, 23);
            this.hp_bar.TabIndex = 3;
            this.hp_bar.Visible = false;
            // 
            // test_mod
            // 
            this.test_mod.Enabled = false;
            this.test_mod.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_mod.Location = new System.Drawing.Point(320, 92);
            this.test_mod.Name = "test_mod";
            this.test_mod.Size = new System.Drawing.Size(121, 59);
            this.test_mod.TabIndex = 0;
            this.test_mod.Tag = "test";
            this.test_mod.Text = "Без врагов (тест)";
            this.test_mod.UseVisualStyleBackColor = true;
            this.test_mod.Visible = false;
            this.test_mod.Click += new System.EventHandler(this.slo_1_Click);
            // 
            // lab_4_rocketcount
            // 
            this.lab_4_rocketcount.AutoSize = true;
            this.lab_4_rocketcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_4_rocketcount.Location = new System.Drawing.Point(12, 109);
            this.lab_4_rocketcount.Name = "lab_4_rocketcount";
            this.lab_4_rocketcount.Size = new System.Drawing.Size(75, 24);
            this.lab_4_rocketcount.TabIndex = 1;
            this.lab_4_rocketcount.Text = "Ракеты";
            this.lab_4_rocketcount.Visible = false;
            // 
            // rocket_bar
            // 
            this.rocket_bar.BackColor = System.Drawing.Color.Red;
            this.rocket_bar.ForeColor = System.Drawing.Color.Red;
            this.rocket_bar.Location = new System.Drawing.Point(16, 136);
            this.rocket_bar.Name = "rocket_bar";
            this.rocket_bar.Size = new System.Drawing.Size(71, 15);
            this.rocket_bar.Step = 1;
            this.rocket_bar.TabIndex = 3;
            this.rocket_bar.Visible = false;
            // 
            // explosion_rocket
            // 
            this.explosion_rocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.explosion_rocket.Location = new System.Drawing.Point(49, 193);
            this.explosion_rocket.Name = "explosion_rocket";
            this.explosion_rocket.Size = new System.Drawing.Size(76, 66);
            this.explosion_rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion_rocket.TabIndex = 4;
            this.explosion_rocket.TabStop = false;
            this.explosion_rocket.Visible = false;
            // 
            // wave_lab
            // 
            this.wave_lab.AutoSize = true;
            this.wave_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wave_lab.Location = new System.Drawing.Point(170, 136);
            this.wave_lab.Name = "wave_lab";
            this.wave_lab.Size = new System.Drawing.Size(58, 24);
            this.wave_lab.TabIndex = 1;
            this.wave_lab.Text = "Wave";
            this.wave_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wave_lab.Visible = false;
            // 
            // next_wave_bt4
            // 
            this.next_wave_bt4.Enabled = false;
            this.next_wave_bt4.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_wave_bt4.Location = new System.Drawing.Point(320, 324);
            this.next_wave_bt4.Name = "next_wave_bt4";
            this.next_wave_bt4.Size = new System.Drawing.Size(121, 43);
            this.next_wave_bt4.TabIndex = 0;
            this.next_wave_bt4.Tag = "easy";
            this.next_wave_bt4.Text = "Далее";
            this.next_wave_bt4.UseVisualStyleBackColor = true;
            this.next_wave_bt4.Visible = false;
            this.next_wave_bt4.Click += new System.EventHandler(this.next_wave_bt4_Click);
            // 
            // main_menu_bt5
            // 
            this.main_menu_bt5.Enabled = false;
            this.main_menu_bt5.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_bt5.Location = new System.Drawing.Point(320, 373);
            this.main_menu_bt5.Name = "main_menu_bt5";
            this.main_menu_bt5.Size = new System.Drawing.Size(121, 59);
            this.main_menu_bt5.TabIndex = 0;
            this.main_menu_bt5.Tag = "easy";
            this.main_menu_bt5.Text = "Главное меню";
            this.main_menu_bt5.UseVisualStyleBackColor = true;
            this.main_menu_bt5.Visible = false;
            this.main_menu_bt5.Click += new System.EventHandler(this.main_menu_bt5_Click);
            // 
            // dom
            // 
            this.dom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dom.Location = new System.Drawing.Point(63, 291);
            this.dom.Name = "dom";
            this.dom.Size = new System.Drawing.Size(100, 50);
            this.dom.TabIndex = 2;
            this.dom.TabStop = false;
            // 
            // main_menu_bt6
            // 
            this.main_menu_bt6.Enabled = false;
            this.main_menu_bt6.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_bt6.Location = new System.Drawing.Point(185, 317);
            this.main_menu_bt6.Name = "main_menu_bt6";
            this.main_menu_bt6.Size = new System.Drawing.Size(121, 59);
            this.main_menu_bt6.TabIndex = 0;
            this.main_menu_bt6.Tag = "easy";
            this.main_menu_bt6.Text = "Главное меню";
            this.main_menu_bt6.UseVisualStyleBackColor = true;
            this.main_menu_bt6.Visible = false;
            this.main_menu_bt6.Click += new System.EventHandler(this.main_menu_bt5_Click);
            // 
            // bt7_continue
            // 
            this.bt7_continue.Enabled = false;
            this.bt7_continue.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7_continue.Location = new System.Drawing.Point(176, 382);
            this.bt7_continue.Name = "bt7_continue";
            this.bt7_continue.Size = new System.Drawing.Size(138, 59);
            this.bt7_continue.TabIndex = 0;
            this.bt7_continue.Tag = "easy";
            this.bt7_continue.Text = "Продолжить";
            this.bt7_continue.UseVisualStyleBackColor = true;
            this.bt7_continue.Visible = false;
            this.bt7_continue.Click += new System.EventHandler(this.bt7_continue_Click);
            // 
            // main_menu_bt8
            // 
            this.main_menu_bt8.Enabled = false;
            this.main_menu_bt8.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_bt8.Location = new System.Drawing.Point(185, 447);
            this.main_menu_bt8.Name = "main_menu_bt8";
            this.main_menu_bt8.Size = new System.Drawing.Size(121, 59);
            this.main_menu_bt8.TabIndex = 0;
            this.main_menu_bt8.Tag = "easy";
            this.main_menu_bt8.Text = "Главное меню";
            this.main_menu_bt8.UseVisualStyleBackColor = true;
            this.main_menu_bt8.Visible = false;
            this.main_menu_bt8.Click += new System.EventHandler(this.main_menu_bt5_Click);
            // 
            // lab_itogi
            // 
            this.lab_itogi.AutoSize = true;
            this.lab_itogi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_itogi.Location = new System.Drawing.Point(170, 92);
            this.lab_itogi.Name = "lab_itogi";
            this.lab_itogi.Size = new System.Drawing.Size(64, 24);
            this.lab_itogi.TabIndex = 1;
            this.lab_itogi.Text = "Итоги";
            this.lab_itogi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_itogi.Visible = false;
            // 
            // main_menu_bt9
            // 
            this.main_menu_bt9.Enabled = false;
            this.main_menu_bt9.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_bt9.Location = new System.Drawing.Point(42, 382);
            this.main_menu_bt9.Name = "main_menu_bt9";
            this.main_menu_bt9.Size = new System.Drawing.Size(121, 59);
            this.main_menu_bt9.TabIndex = 0;
            this.main_menu_bt9.Tag = "easy";
            this.main_menu_bt9.Text = "Главное меню";
            this.main_menu_bt9.UseVisualStyleBackColor = true;
            this.main_menu_bt9.Visible = false;
            this.main_menu_bt9.Click += new System.EventHandler(this.main_menu_bt5_Click);
            // 
            // game_lev_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_game.Properties.Resources.white_fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 531);
            this.Controls.Add(this.explosion_rocket);
            this.Controls.Add(this.rocket_bar);
            this.Controls.Add(this.hp_bar);
            this.Controls.Add(this.dom);
            this.Controls.Add(this.lab_4_rocketcount);
            this.Controls.Add(this.lab3_bullets_count);
            this.Controls.Add(this.lab2_kills);
            this.Controls.Add(this.lab_itogi);
            this.Controls.Add(this.wave_lab);
            this.Controls.Add(this.lab4_info);
            this.Controls.Add(this.test_lb2);
            this.Controls.Add(this.test_lb);
            this.Controls.Add(this.hpBar_lb1);
            this.Controls.Add(this.pers_bt3);
            this.Controls.Add(this.exit_bt2);
            this.Controls.Add(this.slo_3);
            this.Controls.Add(this.slo_2);
            this.Controls.Add(this.test_mod);
            this.Controls.Add(this.bt7_continue);
            this.Controls.Add(this.main_menu_bt6);
            this.Controls.Add(this.main_menu_bt9);
            this.Controls.Add(this.main_menu_bt8);
            this.Controls.Add(this.main_menu_bt5);
            this.Controls.Add(this.next_wave_bt4);
            this.Controls.Add(this.slo_1);
            this.Controls.Add(this.start_bt1);
            this.DoubleBuffered = true;
            this.Name = "game_lev_1";
            this.Text = "игра";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_lev_1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_lev_1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_lev_1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.explosion_rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_bt1;
        private System.Windows.Forms.Button exit_bt2;
        private System.Windows.Forms.Button pers_bt3;
        private System.Windows.Forms.Label hpBar_lb1;
        private System.Windows.Forms.Label test_lb;
        private System.Windows.Forms.Label lab2_kills;
        private System.Windows.Forms.Label lab3_bullets_count;
        private System.Windows.Forms.Label test_lb2;
        private System.Windows.Forms.Label lab4_info;
        private System.Windows.Forms.Button slo_1;
        private System.Windows.Forms.Button slo_2;
        private System.Windows.Forms.Button slo_3;
        private System.Windows.Forms.ProgressBar hp_bar;
        private System.Windows.Forms.Button test_mod;
        private System.Windows.Forms.Label lab_4_rocketcount;
        private System.Windows.Forms.ProgressBar rocket_bar;
        private System.Windows.Forms.PictureBox explosion_rocket;
        private System.Windows.Forms.Label wave_lab;
        private System.Windows.Forms.Button next_wave_bt4;
        private System.Windows.Forms.Button main_menu_bt5;
        private System.Windows.Forms.PictureBox dom;
        private System.Windows.Forms.Button main_menu_bt6;
        private System.Windows.Forms.Button bt7_continue;
        private System.Windows.Forms.Button main_menu_bt8;
        private System.Windows.Forms.Label Itogi;
        private System.Windows.Forms.Label lab_itogi;
        private System.Windows.Forms.Button main_menu_bt9;
    }
}

