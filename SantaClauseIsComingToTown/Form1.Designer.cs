namespace SantaClauseIsComingToTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grounds = new System.Windows.Forms.PictureBox();
            this.santaHouse = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.sun = new System.Windows.Forms.PictureBox();
            this.snowFlake = new System.Windows.Forms.PictureBox();
            this.christmasTree = new System.Windows.Forms.PictureBox();
            this.scorelable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.christmasTree)).BeginInit();
            this.SuspendLayout();
            // 
            // grounds
            // 
            this.grounds.Image = ((System.Drawing.Image)(resources.GetObject("grounds.Image")));
            this.grounds.Location = new System.Drawing.Point(-7, 411);
            this.grounds.Name = "grounds";
            this.grounds.Size = new System.Drawing.Size(1232, 103);
            this.grounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grounds.TabIndex = 0;
            this.grounds.TabStop = false;
            // 
            // santaHouse
            // 
            this.santaHouse.Image = ((System.Drawing.Image)(resources.GetObject("santaHouse.Image")));
            this.santaHouse.Location = new System.Drawing.Point(-7, 221);
            this.santaHouse.Name = "santaHouse";
            this.santaHouse.Size = new System.Drawing.Size(176, 218);
            this.santaHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santaHouse.TabIndex = 1;
            this.santaHouse.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(998, 195);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(181, 141);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 2;
            this.santa.TabStop = false;
            // 
            // sun
            // 
            this.sun.Image = ((System.Drawing.Image)(resources.GetObject("sun.Image")));
            this.sun.Location = new System.Drawing.Point(216, 0);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(148, 125);
            this.sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sun.TabIndex = 3;
            this.sun.TabStop = false;
            // 
            // snowFlake
            // 
            this.snowFlake.Image = ((System.Drawing.Image)(resources.GetObject("snowFlake.Image")));
            this.snowFlake.Location = new System.Drawing.Point(746, 46);
            this.snowFlake.Name = "snowFlake";
            this.snowFlake.Size = new System.Drawing.Size(100, 91);
            this.snowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowFlake.TabIndex = 4;
            this.snowFlake.TabStop = false;
            // 
            // christmasTree
            // 
            this.christmasTree.Image = ((System.Drawing.Image)(resources.GetObject("christmasTree.Image")));
            this.christmasTree.Location = new System.Drawing.Point(448, 232);
            this.christmasTree.Name = "christmasTree";
            this.christmasTree.Size = new System.Drawing.Size(100, 207);
            this.christmasTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.christmasTree.TabIndex = 5;
            this.christmasTree.TabStop = false;
            // 
            // scorelable
            // 
            this.scorelable.AutoSize = true;
            this.scorelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.scorelable.Location = new System.Drawing.Point(-5, 46);
            this.scorelable.Name = "scorelable";
            this.scorelable.Size = new System.Drawing.Size(163, 44);
            this.scorelable.TabIndex = 6;
            this.scorelable.Text = "score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // playagain
            // 
            this.playagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.playagain.Location = new System.Drawing.Point(3, 93);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(131, 86);
            this.playagain.TabIndex = 7;
            this.playagain.Text = "Play Again";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Visible = false;
            this.playagain.Click += new System.EventHandler(this.Playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1204, 506);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.scorelable);
            this.Controls.Add(this.christmasTree);
            this.Controls.Add(this.snowFlake);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.santaHouse);
            this.Controls.Add(this.grounds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.christmasTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grounds;
        private System.Windows.Forms.PictureBox santaHouse;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox sun;
        private System.Windows.Forms.PictureBox snowFlake;
        private System.Windows.Forms.PictureBox christmasTree;
        private System.Windows.Forms.Label scorelable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playagain;
    }
}

