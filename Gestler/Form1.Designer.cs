namespace Gestler
{
    partial class Gestler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestler));
            this.GestlerBox = new Emgu.CV.UI.ImageBox();
            this.GestlerButton = new System.Windows.Forms.Button();
            this.FingerCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GestlerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GestlerBox
            // 
            this.GestlerBox.Location = new System.Drawing.Point(12, 12);
            this.GestlerBox.Name = "GestlerBox";
            this.GestlerBox.Size = new System.Drawing.Size(650, 495);
            this.GestlerBox.TabIndex = 2;
            this.GestlerBox.TabStop = false;
            // 
            // GestlerButton
            // 
            this.GestlerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.GestlerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestlerButton.ForeColor = System.Drawing.Color.Snow;
            this.GestlerButton.Location = new System.Drawing.Point(289, 525);
            this.GestlerButton.Name = "GestlerButton";
            this.GestlerButton.Size = new System.Drawing.Size(147, 49);
            this.GestlerButton.TabIndex = 3;
            this.GestlerButton.Text = "Turn On";
            this.GestlerButton.UseVisualStyleBackColor = false;
            this.GestlerButton.Click += new System.EventHandler(this.GButtonPauseorResume);
            // 
            // FingerCount
            // 
            this.FingerCount.AutoSize = true;
            this.FingerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FingerCount.ForeColor = System.Drawing.Color.SkyBlue;
            this.FingerCount.Location = new System.Drawing.Point(615, 537);
            this.FingerCount.Name = "FingerCount";
            this.FingerCount.Size = new System.Drawing.Size(0, 25);
            this.FingerCount.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(550, 518);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 67);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Gestler
            // 
            this.ClientSize = new System.Drawing.Size(677, 598);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FingerCount);
            this.Controls.Add(this.GestlerButton);
            this.Controls.Add(this.GestlerBox);
            this.Name = "Gestler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gestler_Closed);
            this.Load += new System.EventHandler(this.Gestler_load);
            ((System.ComponentModel.ISupportInitialize)(this.GestlerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
        
        private Emgu.CV.UI.ImageBox GestlerBox;
        private System.Windows.Forms.Button GestlerButton;
        private System.Windows.Forms.Label FingerCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

