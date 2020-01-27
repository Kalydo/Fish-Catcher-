namespace Fish_Catcher_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReadMe = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadMe
            // 
            this.btnReadMe.BackColor = System.Drawing.Color.Transparent;
            this.btnReadMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReadMe.Location = new System.Drawing.Point(365, 521);
            this.btnReadMe.Name = "btnReadMe";
            this.btnReadMe.Size = new System.Drawing.Size(301, 80);
            this.btnReadMe.TabIndex = 0;
            this.btnReadMe.Text = "Read Me";
            this.btnReadMe.UseVisualStyleBackColor = false;
            this.btnReadMe.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStart.Location = new System.Drawing.Point(365, 435);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(301, 80);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fish Catcher! developed by RSFS GmbH";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Fish_Catcher_.Properties.Resources.Logo_ausgeschnitten;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 705);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReadMe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Fish Catcher! v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadMe;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

