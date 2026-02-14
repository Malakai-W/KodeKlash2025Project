namespace Intrusion
{
    partial class Ending1
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
            this.pbUpArrow = new System.Windows.Forms.PictureBox();
            this.pbLeftArrow = new System.Windows.Forms.PictureBox();
            this.timerShake = new System.Windows.Forms.Timer(this.components);
            this.pbRightArrow = new System.Windows.Forms.PictureBox();
            this.pbDownArrow = new System.Windows.Forms.PictureBox();
            this.lblTheEnd = new System.Windows.Forms.Label();
            this.lblReturnToMenu = new System.Windows.Forms.Label();
            this.pbTheWarped = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTheWarped)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUpArrow
            // 
            this.pbUpArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbUpArrow.Image = global::Intrusion.Properties.Resources.RedArrowUp;
            this.pbUpArrow.Location = new System.Drawing.Point(355, 12);
            this.pbUpArrow.Name = "pbUpArrow";
            this.pbUpArrow.Size = new System.Drawing.Size(100, 106);
            this.pbUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpArrow.TabIndex = 0;
            this.pbUpArrow.TabStop = false;
            this.pbUpArrow.Click += new System.EventHandler(this.pbUpArrow_Click);
            // 
            // pbLeftArrow
            // 
            this.pbLeftArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbLeftArrow.Enabled = false;
            this.pbLeftArrow.Image = global::Intrusion.Properties.Resources.RedArrowLeft;
            this.pbLeftArrow.Location = new System.Drawing.Point(12, 211);
            this.pbLeftArrow.Name = "pbLeftArrow";
            this.pbLeftArrow.Size = new System.Drawing.Size(129, 83);
            this.pbLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftArrow.TabIndex = 1;
            this.pbLeftArrow.TabStop = false;
            this.pbLeftArrow.Visible = false;
            this.pbLeftArrow.Click += new System.EventHandler(this.pbLeftArrow_Click);
            // 
            // timerShake
            // 
            this.timerShake.Interval = 1000;
            this.timerShake.Tick += new System.EventHandler(this.timerShake_Tick);
            // 
            // pbRightArrow
            // 
            this.pbRightArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbRightArrow.Enabled = false;
            this.pbRightArrow.Image = global::Intrusion.Properties.Resources.RedArrowRight;
            this.pbRightArrow.Location = new System.Drawing.Point(674, 211);
            this.pbRightArrow.Name = "pbRightArrow";
            this.pbRightArrow.Size = new System.Drawing.Size(129, 83);
            this.pbRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightArrow.TabIndex = 2;
            this.pbRightArrow.TabStop = false;
            this.pbRightArrow.Visible = false;
            this.pbRightArrow.Click += new System.EventHandler(this.pbRightArrow_Click);
            // 
            // pbDownArrow
            // 
            this.pbDownArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbDownArrow.Enabled = false;
            this.pbDownArrow.Image = global::Intrusion.Properties.Resources.RedArrowDown;
            this.pbDownArrow.Location = new System.Drawing.Point(366, 398);
            this.pbDownArrow.Name = "pbDownArrow";
            this.pbDownArrow.Size = new System.Drawing.Size(100, 106);
            this.pbDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDownArrow.TabIndex = 3;
            this.pbDownArrow.TabStop = false;
            this.pbDownArrow.Visible = false;
            this.pbDownArrow.Click += new System.EventHandler(this.pbDownArrow_Click);
            // 
            // lblTheEnd
            // 
            this.lblTheEnd.AutoSize = true;
            this.lblTheEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblTheEnd.Enabled = false;
            this.lblTheEnd.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheEnd.ForeColor = System.Drawing.Color.Red;
            this.lblTheEnd.Location = new System.Drawing.Point(339, 158);
            this.lblTheEnd.Name = "lblTheEnd";
            this.lblTheEnd.Size = new System.Drawing.Size(143, 32);
            this.lblTheEnd.TabIndex = 4;
            this.lblTheEnd.Text = "THE END";
            this.lblTheEnd.Visible = false;
            // 
            // lblReturnToMenu
            // 
            this.lblReturnToMenu.AutoSize = true;
            this.lblReturnToMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnToMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReturnToMenu.Enabled = false;
            this.lblReturnToMenu.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnToMenu.ForeColor = System.Drawing.Color.Red;
            this.lblReturnToMenu.Location = new System.Drawing.Point(304, 237);
            this.lblReturnToMenu.Name = "lblReturnToMenu";
            this.lblReturnToMenu.Size = new System.Drawing.Size(224, 28);
            this.lblReturnToMenu.TabIndex = 5;
            this.lblReturnToMenu.Text = "Return To Menu";
            this.lblReturnToMenu.Visible = false;
            this.lblReturnToMenu.Click += new System.EventHandler(this.lblReturnToMenu_Click);
            // 
            // pbTheWarped
            // 
            this.pbTheWarped.BackColor = System.Drawing.Color.Transparent;
            this.pbTheWarped.BackgroundImage = global::Intrusion.Properties.Resources.TheWarped;
            this.pbTheWarped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTheWarped.Location = new System.Drawing.Point(213, 30);
            this.pbTheWarped.Name = "pbTheWarped";
            this.pbTheWarped.Size = new System.Drawing.Size(408, 491);
            this.pbTheWarped.TabIndex = 6;
            this.pbTheWarped.TabStop = false;
            this.pbTheWarped.Visible = false;
            // 
            // Ending1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Intrusion.Properties.Resources.SafeRoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 516);
            this.Controls.Add(this.pbTheWarped);
            this.Controls.Add(this.lblReturnToMenu);
            this.Controls.Add(this.lblTheEnd);
            this.Controls.Add(this.pbDownArrow);
            this.Controls.Add(this.pbRightArrow);
            this.Controls.Add(this.pbLeftArrow);
            this.Controls.Add(this.pbUpArrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ending1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ending1";
            ((System.ComponentModel.ISupportInitialize)(this.pbUpArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTheWarped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUpArrow;
        private System.Windows.Forms.PictureBox pbLeftArrow;
        private System.Windows.Forms.Timer timerShake;
        private System.Windows.Forms.PictureBox pbRightArrow;
        private System.Windows.Forms.PictureBox pbDownArrow;
        private System.Windows.Forms.Label lblTheEnd;
        private System.Windows.Forms.Label lblReturnToMenu;
        private System.Windows.Forms.PictureBox pbTheWarped;
    }
}