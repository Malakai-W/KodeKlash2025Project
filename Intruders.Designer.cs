namespace Intrusion
{
    partial class Intruders
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
            this.pbArrowRight = new System.Windows.Forms.PictureBox();
            this.pbArrowLeft = new System.Windows.Forms.PictureBox();
            this.pbArrowDown = new System.Windows.Forms.PictureBox();
            this.pbArrowUp = new System.Windows.Forms.PictureBox();
            this.timerOldMan = new System.Windows.Forms.Timer(this.components);
            this.pbCloseDoor = new System.Windows.Forms.PictureBox();
            this.timerFrontDoor = new System.Windows.Forms.Timer(this.components);
            this.pbFlashlight = new System.Windows.Forms.PictureBox();
            this.timerGremlin = new System.Windows.Forms.Timer(this.components);
            this.timerGameEnds = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashlight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArrowRight
            // 
            this.pbArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.pbArrowRight.Enabled = false;
            this.pbArrowRight.Image = global::Intrusion.Properties.Resources.RedArrowRight;
            this.pbArrowRight.Location = new System.Drawing.Point(720, 214);
            this.pbArrowRight.Name = "pbArrowRight";
            this.pbArrowRight.Size = new System.Drawing.Size(140, 72);
            this.pbArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrowRight.TabIndex = 3;
            this.pbArrowRight.TabStop = false;
            this.pbArrowRight.Visible = false;
            this.pbArrowRight.Click += new System.EventHandler(this.pbArrowRight_Click);
            // 
            // pbArrowLeft
            // 
            this.pbArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbArrowLeft.Enabled = false;
            this.pbArrowLeft.Image = global::Intrusion.Properties.Resources.RedArrowLeft;
            this.pbArrowLeft.Location = new System.Drawing.Point(12, 214);
            this.pbArrowLeft.Name = "pbArrowLeft";
            this.pbArrowLeft.Size = new System.Drawing.Size(140, 72);
            this.pbArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrowLeft.TabIndex = 2;
            this.pbArrowLeft.TabStop = false;
            this.pbArrowLeft.Visible = false;
            this.pbArrowLeft.Click += new System.EventHandler(this.pbArrowLeft_Click);
            // 
            // pbArrowDown
            // 
            this.pbArrowDown.BackColor = System.Drawing.Color.Transparent;
            this.pbArrowDown.Enabled = false;
            this.pbArrowDown.Image = global::Intrusion.Properties.Resources.RedArrowDown;
            this.pbArrowDown.Location = new System.Drawing.Point(397, 399);
            this.pbArrowDown.Name = "pbArrowDown";
            this.pbArrowDown.Size = new System.Drawing.Size(104, 103);
            this.pbArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrowDown.TabIndex = 1;
            this.pbArrowDown.TabStop = false;
            this.pbArrowDown.Visible = false;
            this.pbArrowDown.Click += new System.EventHandler(this.pbArrowDown_Click);
            // 
            // pbArrowUp
            // 
            this.pbArrowUp.BackColor = System.Drawing.Color.Transparent;
            this.pbArrowUp.Image = global::Intrusion.Properties.Resources.RedArrowUp;
            this.pbArrowUp.Location = new System.Drawing.Point(397, 12);
            this.pbArrowUp.Name = "pbArrowUp";
            this.pbArrowUp.Size = new System.Drawing.Size(104, 103);
            this.pbArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrowUp.TabIndex = 0;
            this.pbArrowUp.TabStop = false;
            this.pbArrowUp.Click += new System.EventHandler(this.pbArrowUp_Click);
            // 
            // timerOldMan
            // 
            this.timerOldMan.Interval = 1000;
            this.timerOldMan.Tick += new System.EventHandler(this.timerOldMan_Tick);
            // 
            // pbCloseDoor
            // 
            this.pbCloseDoor.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseDoor.Enabled = false;
            this.pbCloseDoor.Location = new System.Drawing.Point(373, 187);
            this.pbCloseDoor.Name = "pbCloseDoor";
            this.pbCloseDoor.Size = new System.Drawing.Size(145, 170);
            this.pbCloseDoor.TabIndex = 4;
            this.pbCloseDoor.TabStop = false;
            this.pbCloseDoor.Click += new System.EventHandler(this.pbCloseDoor_Click);
            // 
            // timerFrontDoor
            // 
            this.timerFrontDoor.Enabled = true;
            this.timerFrontDoor.Interval = 1000;
            this.timerFrontDoor.Tick += new System.EventHandler(this.timerFrontDoor_Tick);
            // 
            // pbFlashlight
            // 
            this.pbFlashlight.BackColor = System.Drawing.Color.Transparent;
            this.pbFlashlight.Enabled = false;
            this.pbFlashlight.Image = global::Intrusion.Properties.Resources.flashlight;
            this.pbFlashlight.Location = new System.Drawing.Point(757, 12);
            this.pbFlashlight.Name = "pbFlashlight";
            this.pbFlashlight.Size = new System.Drawing.Size(103, 103);
            this.pbFlashlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlashlight.TabIndex = 5;
            this.pbFlashlight.TabStop = false;
            this.pbFlashlight.Visible = false;
            this.pbFlashlight.Click += new System.EventHandler(this.pbFlashlight_Click);
            // 
            // timerGremlin
            // 
            this.timerGremlin.Enabled = true;
            this.timerGremlin.Interval = 1000;
            this.timerGremlin.Tick += new System.EventHandler(this.timerGremlin_Tick);
            // 
            // timerGameEnds
            // 
            this.timerGameEnds.Enabled = true;
            this.timerGameEnds.Interval = 1000;
            this.timerGameEnds.Tick += new System.EventHandler(this.timerGameEnds_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.Red;
            this.lblSeconds.Location = new System.Drawing.Point(772, 482);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(88, 23);
            this.lblSeconds.TabIndex = 6;
            // 
            // Intruders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Intrusion.Properties.Resources.SafeRoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 514);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.pbFlashlight);
            this.Controls.Add(this.pbCloseDoor);
            this.Controls.Add(this.pbArrowRight);
            this.Controls.Add(this.pbArrowLeft);
            this.Controls.Add(this.pbArrowDown);
            this.Controls.Add(this.pbArrowUp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intruders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intruders";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Intruders_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArrowUp;
        private System.Windows.Forms.PictureBox pbArrowDown;
        private System.Windows.Forms.PictureBox pbArrowLeft;
        private System.Windows.Forms.PictureBox pbArrowRight;
        private System.Windows.Forms.Timer timerOldMan;
        private System.Windows.Forms.PictureBox pbCloseDoor;
        private System.Windows.Forms.Timer timerFrontDoor;
        private System.Windows.Forms.PictureBox pbFlashlight;
        private System.Windows.Forms.Timer timerGremlin;
        private System.Windows.Forms.Timer timerGameEnds;
        private System.Windows.Forms.Label lblSeconds;
    }
}