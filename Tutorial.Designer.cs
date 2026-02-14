namespace Intrusion
{
    partial class Tutorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExtraMechanic = new System.Windows.Forms.Label();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check the front door and keep it closed";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "When you see the old man, hide under a table until you hear him leave";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Find and scare off the gremlin with the flashlight when you hear the bell";
            // 
            // lblExtraMechanic
            // 
            this.lblExtraMechanic.BackColor = System.Drawing.Color.Transparent;
            this.lblExtraMechanic.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraMechanic.Location = new System.Drawing.Point(150, 230);
            this.lblExtraMechanic.Name = "lblExtraMechanic";
            this.lblExtraMechanic.Size = new System.Drawing.Size(554, 59);
            this.lblExtraMechanic.TabIndex = 3;
            this.lblExtraMechanic.Text = "If gremlin is not scared off, run to the safe spot (the first room you were in)";
            this.lblExtraMechanic.Visible = false;
            // 
            // pbArrow
            // 
            this.pbArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbArrow.Image = global::Intrusion.Properties.Resources.RedArrowRight;
            this.pbArrow.Location = new System.Drawing.Point(736, 422);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(100, 50);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 4;
            this.pbArrow.TabStop = false;
            this.pbArrow.Click += new System.EventHandler(this.pbArrow_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(140, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 92);
            this.label4.TabIndex = 5;
            this.label4.Text = "Press Q while holding shift to return to menu (once you click on the arrow to con" +
    "tinue); or if you have caplocks on, you can just press Q";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(178, 310);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(466, 46);
            this.lblTime.TabIndex = 6;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Intrusion.Properties.Resources.Paper;
            this.ClientSize = new System.Drawing.Size(848, 484);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.lblExtraMechanic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExtraMechanic;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
    }
}