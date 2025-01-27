namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_groun = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_control = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_groun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_groun
            // 
            this.pictureBox_groun.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_groun.Image")));
            this.pictureBox_groun.Location = new System.Drawing.Point(1, 706);
            this.pictureBox_groun.Name = "pictureBox_groun";
            this.pictureBox_groun.Size = new System.Drawing.Size(903, 100);
            this.pictureBox_groun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_groun.TabIndex = 0;
            this.pictureBox_groun.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Bottom.Image")));
            this.pictureBox_Bottom.Location = new System.Drawing.Point(562, 465);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(112, 245);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 1;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bird.Image")));
            this.pictureBox_bird.Location = new System.Drawing.Point(66, 277);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(101, 77);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 2;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_top.Image")));
            this.pictureBox_top.Location = new System.Drawing.Point(701, 0);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(100, 182);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 3;
            this.pictureBox_top.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // timer_control
            // 
            this.timer_control.Enabled = true;
            this.timer_control.Interval = 50;
            this.timer_control.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(904, 807);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_top);
            this.Controls.Add(this.pictureBox_bird);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Controls.Add(this.pictureBox_groun);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_groun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_groun;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_control;
    }
}

