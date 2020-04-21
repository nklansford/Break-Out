namespace BreakOut
{
    partial class BreakOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paddle = new Paddle();
            this.losingWall = new System.Windows.Forms.PictureBox();
            this.topWall = new System.Windows.Forms.PictureBox();
            this.rightWall = new System.Windows.Forms.PictureBox();
            this.bottomWall = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.brick1 = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            this.brick3 = new System.Windows.Forms.PictureBox();
            this.brick4 = new System.Windows.Forms.PictureBox();
            this.brick5 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.losingWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.paddle.Location = new System.Drawing.Point(81, 310);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(21, 193);
            this.paddle.TabIndex = 0;
            this.paddle.TabStop = false;
            this.paddle.Tag = "player";
            // 
            // losingWall
            // 
            this.losingWall.BackColor = System.Drawing.Color.LightCyan;
            this.losingWall.Location = new System.Drawing.Point(26, 21);
            this.losingWall.Name = "losingWall";
            this.losingWall.Size = new System.Drawing.Size(10, 665);
            this.losingWall.TabIndex = 1;
            this.losingWall.TabStop = false;
            this.losingWall.Tag = "wall";
            // 
            // topWall
            // 
            this.topWall.BackColor = System.Drawing.Color.LightCyan;
            this.topWall.Location = new System.Drawing.Point(26, 21);
            this.topWall.Name = "topWall";
            this.topWall.Size = new System.Drawing.Size(1179, 10);
            this.topWall.TabIndex = 2;
            this.topWall.TabStop = false;
            this.topWall.Tag = "wall";
            // 
            // rightWall
            // 
            this.rightWall.BackColor = System.Drawing.Color.LightCyan;
            this.rightWall.Location = new System.Drawing.Point(1195, 21);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(10, 665);
            this.rightWall.TabIndex = 3;
            this.rightWall.TabStop = false;
            this.rightWall.Tag = "wall";
            // 
            // bottomWall
            // 
            this.bottomWall.BackColor = System.Drawing.Color.LightCyan;
            this.bottomWall.Location = new System.Drawing.Point(26, 676);
            this.bottomWall.Name = "bottomWall";
            this.bottomWall.Size = new System.Drawing.Size(1179, 10);
            this.bottomWall.TabIndex = 4;
            this.bottomWall.TabStop = false;
            this.bottomWall.Tag = "wall";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Coral;
            this.ball.Location = new System.Drawing.Point(226, 340);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(24, 23);
            this.ball.TabIndex = 5;
            this.ball.TabStop = false;
            this.ball.Tag = "ball";
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.Azure;
            this.brick1.Location = new System.Drawing.Point(964, 56);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(22, 96);
            this.brick1.TabIndex = 6;
            this.brick1.TabStop = false;
            this.brick1.Tag = "points10";
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.brick2.Location = new System.Drawing.Point(1012, 56);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(22, 96);
            this.brick2.TabIndex = 7;
            this.brick2.TabStop = false;
            this.brick2.Tag = "points20";
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.brick3.Location = new System.Drawing.Point(1056, 56);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(22, 96);
            this.brick3.TabIndex = 8;
            this.brick3.TabStop = false;
            this.brick3.Tag = "points30";
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Teal;
            this.brick4.Location = new System.Drawing.Point(1101, 56);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(22, 96);
            this.brick4.TabIndex = 9;
            this.brick4.TabStop = false;
            this.brick4.Tag = "points40";
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.brick5.Location = new System.Drawing.Point(1148, 56);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(22, 96);
            this.brick5.TabIndex = 10;
            this.brick5.TabStop = false;
            this.brick5.Tag = "points50";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.LightCyan;
            this.score.Location = new System.Drawing.Point(28, 702);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(85, 34);
            this.score.TabIndex = 11;
            this.score.Text = "Score:";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BreakOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 767);
            this.Controls.Add(this.score);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.bottomWall);
            this.Controls.Add(this.rightWall);
            this.Controls.Add(this.topWall);
            this.Controls.Add(this.losingWall);
            this.Controls.Add(this.paddle);
            this.Name = "BreakOut";
            this.Text = "BreakOut";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.losingWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Paddle paddle;
        private System.Windows.Forms.PictureBox losingWall;
        private System.Windows.Forms.PictureBox topWall;
        private System.Windows.Forms.PictureBox rightWall;
        private System.Windows.Forms.PictureBox bottomWall;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox brick1;
        private System.Windows.Forms.PictureBox brick2;
        private System.Windows.Forms.PictureBox brick3;
        private System.Windows.Forms.PictureBox brick4;
        private System.Windows.Forms.PictureBox brick5;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timer;
    }
}

