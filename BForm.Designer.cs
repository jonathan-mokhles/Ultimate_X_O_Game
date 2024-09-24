namespace Ultimate_X_O_Game
{
    partial class BForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.Winnerlabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("SNOW BLUE", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Snow;
            this.Titlelabel.Location = new System.Drawing.Point(249, 9);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(276, 57);
            this.Titlelabel.TabIndex = 1;
            this.Titlelabel.Text = "Tic_Tac_Toe";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.winLabel.Location = new System.Drawing.Point(57, 219);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(138, 29);
            this.winLabel.TabIndex = 24;
            this.winLabel.Text = "no Winner";
            // 
            // Winnerlabel
            // 
            this.Winnerlabel.AutoSize = true;
            this.Winnerlabel.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winnerlabel.ForeColor = System.Drawing.Color.Coral;
            this.Winnerlabel.Location = new System.Drawing.Point(72, 174);
            this.Winnerlabel.Name = "Winnerlabel";
            this.Winnerlabel.Size = new System.Drawing.Size(108, 33);
            this.Winnerlabel.TabIndex = 23;
            this.Winnerlabel.Text = "Winner";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PlayerLabel.Location = new System.Drawing.Point(65, 114);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(122, 29);
            this.PlayerLabel.TabIndex = 22;
            this.PlayerLabel.Text = "player 1";
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLabel.ForeColor = System.Drawing.Color.Coral;
            this.TurnLabel.Location = new System.Drawing.Point(83, 77);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(87, 33);
            this.TurnLabel.TabIndex = 21;
            this.TurnLabel.Text = "Turn ";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(49, 297);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(155, 45);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(49, 373);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 45);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // BForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.Winnerlabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.label1);
            this.Name = "BForm";
            this.Text = "BForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label Winnerlabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnBack;
    }
}