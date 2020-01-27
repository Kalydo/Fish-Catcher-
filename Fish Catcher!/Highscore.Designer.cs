namespace Fish_Catcher_
{
    partial class Highscore
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
            this.txtHighscore = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnZuruck = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHighscore
            // 
            this.txtHighscore.Location = new System.Drawing.Point(12, 114);
            this.txtHighscore.Name = "txtHighscore";
            this.txtHighscore.ReadOnly = true;
            this.txtHighscore.Size = new System.Drawing.Size(333, 282);
            this.txtHighscore.TabIndex = 0;
            this.txtHighscore.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(15, 72);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(42, 22);
            this.txtScore.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(122, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Game Over !!!!";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 17);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // btnZuruck
            // 
            this.btnZuruck.Location = new System.Drawing.Point(12, 411);
            this.btnZuruck.Name = "btnZuruck";
            this.btnZuruck.Size = new System.Drawing.Size(147, 44);
            this.btnZuruck.TabIndex = 6;
            this.btnZuruck.Text = "Zurück zum Titelbildschirm";
            this.btnZuruck.UseVisualStyleBackColor = true;
            this.btnZuruck.Click += new System.EventHandler(this.btnZuruck_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(185, 411);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(160, 44);
            this.btnBeenden.TabIndex = 7;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(209, 72);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(99, 23);
            this.btnSpeichern.TabIndex = 8;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 467);
            this.ControlBox = false;
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnZuruck);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHighscore);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 512);
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHighscore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnZuruck;
        private System.Windows.Forms.Button btnBeenden;
        public System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnSpeichern;
    }
}