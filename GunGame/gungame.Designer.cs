namespace GunGame
{
    partial class gungame
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
            this.videoplayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonload = new System.Windows.Forms.Button();
            this.buttonspin = new System.Windows.Forms.Button();
            this.buttonshoot = new System.Windows.Forms.Button();
            this.buttonshootaway = new System.Windows.Forms.Button();
            this.buttonnextgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoplayer
            // 
            this.videoplayer.Location = new System.Drawing.Point(247, 131);
            this.videoplayer.Name = "videoplayer";
            this.videoplayer.Size = new System.Drawing.Size(338, 370);
            this.videoplayer.TabIndex = 0;
            this.videoplayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(144, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Russian Roullete";
            // 
            // buttonload
            // 
            this.buttonload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonload.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonload.ForeColor = System.Drawing.Color.Gold;
            this.buttonload.Location = new System.Drawing.Point(46, 174);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(131, 77);
            this.buttonload.TabIndex = 2;
            this.buttonload.Text = "Load";
            this.buttonload.UseVisualStyleBackColor = false;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // buttonspin
            // 
            this.buttonspin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonspin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonspin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonspin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonspin.ForeColor = System.Drawing.Color.Gold;
            this.buttonspin.Location = new System.Drawing.Point(46, 342);
            this.buttonspin.Name = "buttonspin";
            this.buttonspin.Size = new System.Drawing.Size(131, 87);
            this.buttonspin.TabIndex = 3;
            this.buttonspin.Text = "Spin";
            this.buttonspin.UseVisualStyleBackColor = false;
            this.buttonspin.Click += new System.EventHandler(this.buttonspin_Click);
            // 
            // buttonshoot
            // 
            this.buttonshoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonshoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonshoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonshoot.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshoot.ForeColor = System.Drawing.Color.Gold;
            this.buttonshoot.Location = new System.Drawing.Point(673, 131);
            this.buttonshoot.Name = "buttonshoot";
            this.buttonshoot.Size = new System.Drawing.Size(117, 58);
            this.buttonshoot.TabIndex = 4;
            this.buttonshoot.Text = "Shoot";
            this.buttonshoot.UseVisualStyleBackColor = false;
            this.buttonshoot.Click += new System.EventHandler(this.buttonshoot_Click);
            // 
            // buttonshootaway
            // 
            this.buttonshootaway.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonshootaway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonshootaway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonshootaway.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshootaway.ForeColor = System.Drawing.Color.Gold;
            this.buttonshootaway.Location = new System.Drawing.Point(659, 254);
            this.buttonshootaway.Name = "buttonshootaway";
            this.buttonshootaway.Size = new System.Drawing.Size(143, 58);
            this.buttonshootaway.TabIndex = 5;
            this.buttonshootaway.Text = "ShootAway";
            this.buttonshootaway.UseVisualStyleBackColor = false;
            this.buttonshootaway.Click += new System.EventHandler(this.buttonshootaway_Click);
            // 
            // buttonnextgame
            // 
            this.buttonnextgame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonnextgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonnextgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonnextgame.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnextgame.ForeColor = System.Drawing.Color.Gold;
            this.buttonnextgame.Location = new System.Drawing.Point(673, 371);
            this.buttonnextgame.Name = "buttonnextgame";
            this.buttonnextgame.Size = new System.Drawing.Size(117, 130);
            this.buttonnextgame.TabIndex = 6;
            this.buttonnextgame.Text = "Next Game";
            this.buttonnextgame.UseVisualStyleBackColor = false;
            this.buttonnextgame.Click += new System.EventHandler(this.buttonnextgame_Click);
            // 
            // gungame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GunGame.Properties.Resources.getty_ar_15_and_pistol;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 531);
            this.Controls.Add(this.buttonnextgame);
            this.Controls.Add(this.buttonshootaway);
            this.Controls.Add(this.buttonshoot);
            this.Controls.Add(this.buttonspin);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoplayer);
            this.Name = "gungame";
            this.Text = "gungame";
            this.Load += new System.EventHandler(this.gungame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox videoplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.Button buttonspin;
        private System.Windows.Forms.Button buttonshoot;
        private System.Windows.Forms.Button buttonshootaway;
        private System.Windows.Forms.Button buttonnextgame;
    }
}