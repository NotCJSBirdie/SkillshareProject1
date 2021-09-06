
namespace FlappyBirdForSkillshare
{
    partial class Form1
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
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = global::FlappyBirdForSkillshare.Properties.Resources.flappybird;
            this.flappybird.Location = new System.Drawing.Point(73, 183);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(44, 36);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::FlappyBirdForSkillshare.Properties.Resources.pipebottom;
            this.pipebottom.Location = new System.Drawing.Point(389, -92);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(74, 233);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::FlappyBirdForSkillshare.Properties.Resources.pipetop;
            this.pipetop.Location = new System.Drawing.Point(313, 278);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(76, 217);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 2;
            this.pipetop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdForSkillshare.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-23, 382);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(842, 138);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(12, 23);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(77, 22);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score :";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 30;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.Color.Red;
            this.restart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(192, 265);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(100, 22);
            this.restart.TabIndex = 5;
            this.restart.Text = "RESTART";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(500, 486);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "FlappyBirdForSkillshare";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeysdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeysup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label restart;
    }
}

