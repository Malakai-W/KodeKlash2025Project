namespace Intrusion
{
    partial class Ending2
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
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.lblOManSpeech = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArrow
            // 
            this.pbArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbArrow.Image = global::Intrusion.Properties.Resources.RedArrowRight;
            this.pbArrow.Location = new System.Drawing.Point(306, 12);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(100, 50);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 0;
            this.pbArrow.TabStop = false;
            this.pbArrow.Click += new System.EventHandler(this.pbArrow_Click);
            // 
            // lblOManSpeech
            // 
            this.lblOManSpeech.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOManSpeech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOManSpeech.Location = new System.Drawing.Point(12, 12);
            this.lblOManSpeech.Name = "lblOManSpeech";
            this.lblOManSpeech.Size = new System.Drawing.Size(188, 166);
            this.lblOManSpeech.TabIndex = 1;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Enabled = false;
            this.lblEnd.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.Red;
            this.lblEnd.Location = new System.Drawing.Point(45, 201);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(128, 29);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "The End";
            this.lblEnd.Visible = false;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReturn.Enabled = false;
            this.lblReturn.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.Red;
            this.lblReturn.Location = new System.Drawing.Point(12, 255);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(201, 25);
            this.lblReturn.TabIndex = 3;
            this.lblReturn.Text = "Return To Menu";
            this.lblReturn.Visible = false;
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // Ending2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Intrusion.Properties.Resources.sadOldMan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblOManSpeech);
            this.Controls.Add(this.pbArrow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ending2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ending2";
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Label lblOManSpeech;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblReturn;
    }
}