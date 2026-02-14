namespace Intrusion
{
    partial class GameOver
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
            this.lblCause = new System.Windows.Forms.Label();
            this.lblTryAgain = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.pbCreature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreature)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCause
            // 
            this.lblCause.BackColor = System.Drawing.Color.Transparent;
            this.lblCause.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCause.ForeColor = System.Drawing.Color.Red;
            this.lblCause.Location = new System.Drawing.Point(12, 20);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(287, 201);
            this.lblCause.TabIndex = 1;
            // 
            // lblTryAgain
            // 
            this.lblTryAgain.AutoSize = true;
            this.lblTryAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblTryAgain.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTryAgain.ForeColor = System.Drawing.Color.Red;
            this.lblTryAgain.Location = new System.Drawing.Point(604, 37);
            this.lblTryAgain.Name = "lblTryAgain";
            this.lblTryAgain.Size = new System.Drawing.Size(144, 26);
            this.lblTryAgain.TabIndex = 2;
            this.lblTryAgain.Text = "Try Again";
            this.lblTryAgain.Click += new System.EventHandler(this.lblTryAgain_Click);
            // 
            // lblReturn
            // 
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.Red;
            this.lblReturn.Location = new System.Drawing.Point(593, 154);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(172, 53);
            this.lblReturn.TabIndex = 3;
            this.lblReturn.Text = "Return To Menu";
            this.lblReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // pbCreature
            // 
            this.pbCreature.BackColor = System.Drawing.Color.Transparent;
            this.pbCreature.Image = global::Intrusion.Properties.Resources.OldMan;
            this.pbCreature.Location = new System.Drawing.Point(124, 132);
            this.pbCreature.Name = "pbCreature";
            this.pbCreature.Size = new System.Drawing.Size(592, 439);
            this.pbCreature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCreature.TabIndex = 4;
            this.pbCreature.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Intrusion.Properties.Resources.GameOverRoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCreature);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblTryAgain);
            this.Controls.Add(this.lblCause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pbCreature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCause;
        private System.Windows.Forms.Label lblTryAgain;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.PictureBox pbCreature;
    }
}