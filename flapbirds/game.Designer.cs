namespace flapbirds
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.borualt = new System.Windows.Forms.PictureBox();
            this.boruust = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.skortext = new System.Windows.Forms.Label();
            this.timergame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.borualt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            this.SuspendLayout();
            // 
            // borualt
            // 
            this.borualt.Image = ((System.Drawing.Image)(resources.GetObject("borualt.Image")));
            this.borualt.Location = new System.Drawing.Point(337, 258);
            this.borualt.Name = "borualt";
            this.borualt.Size = new System.Drawing.Size(86, 94);
            this.borualt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borualt.TabIndex = 0;
            this.borualt.TabStop = false;
            // 
            // boruust
            // 
            this.boruust.Image = ((System.Drawing.Image)(resources.GetObject("boruust.Image")));
            this.boruust.Location = new System.Drawing.Point(460, -1);
            this.boruust.Name = "boruust";
            this.boruust.Size = new System.Drawing.Size(90, 97);
            this.boruust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruust.TabIndex = 1;
            this.boruust.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 352);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(564, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // flappy
            // 
            this.flappy.Image = ((System.Drawing.Image)(resources.GetObject("flappy.Image")));
            this.flappy.Location = new System.Drawing.Point(53, 124);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(83, 48);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 3;
            this.flappy.TabStop = false;
            // 
            // skortext
            // 
            this.skortext.AutoSize = true;
            this.skortext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skortext.Location = new System.Drawing.Point(82, 410);
            this.skortext.Name = "skortext";
            this.skortext.Size = new System.Drawing.Size(115, 31);
            this.skortext.TabIndex = 4;
            this.skortext.Text = "Score:0";
            // 
            // timergame
            // 
            this.timergame.Enabled = true;
            this.timergame.Interval = 20;
            this.timergame.Tick += new System.EventHandler(this.timergameEvent);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(564, 460);
            this.Controls.Add(this.skortext);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.boruust);
            this.Controls.Add(this.borualt);
            this.Name = "game";
            this.Text = "Flappy Birds";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.borualt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox borualt;
        private System.Windows.Forms.PictureBox boruust;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.Label skortext;
        private System.Windows.Forms.Timer timergame;
    }
}

