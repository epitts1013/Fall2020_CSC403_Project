namespace Fall2020_CSC403_Project
{
    partial class FrmInteract
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInteract = new System.Windows.Forms.Button();
            this.lblInteract = new System.Windows.Forms.Label();
            this.btnInteract2 = new System.Windows.Forms.Button();
            this.btnLeaveInteraction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(84, 86);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(105, 228);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.powerup_babypeanut;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(587, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 132);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnInteract
            // 
            this.btnInteract.Location = new System.Drawing.Point(285, 118);
            this.btnInteract.Name = "btnInteract";
            this.btnInteract.Size = new System.Drawing.Size(95, 35);
            this.btnInteract.TabIndex = 2;
            this.btnInteract.Text = "Collect Child";
            this.btnInteract.UseVisualStyleBackColor = true;
            this.btnInteract.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInteract
            // 
            this.lblInteract.AutoSize = true;
            this.lblInteract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteract.Location = new System.Drawing.Point(238, 68);
            this.lblInteract.Name = "lblInteract";
            this.lblInteract.Size = new System.Drawing.Size(532, 25);
            this.lblInteract.TabIndex = 3;
            this.lblInteract.Text = "You have found your lost son, what shall you do?";
            // 
            // btnInteract2
            // 
            this.btnInteract2.Location = new System.Drawing.Point(458, 118);
            this.btnInteract2.Name = "btnInteract2";
            this.btnInteract2.Size = new System.Drawing.Size(95, 35);
            this.btnInteract2.TabIndex = 4;
            this.btnInteract2.Text = "BANISH HIM!";
            this.btnInteract2.UseVisualStyleBackColor = true;
            this.btnInteract2.Click += new System.EventHandler(this.btnInteract2_Click);
            // 
            // btnLeaveInteraction
            // 
            this.btnLeaveInteraction.Location = new System.Drawing.Point(414, 423);
            this.btnLeaveInteraction.Name = "btnLeaveInteraction";
            this.btnLeaveInteraction.Size = new System.Drawing.Size(111, 40);
            this.btnLeaveInteraction.TabIndex = 5;
            this.btnLeaveInteraction.Text = "Leave interaction";
            this.btnLeaveInteraction.UseVisualStyleBackColor = true;
            this.btnLeaveInteraction.Click += new System.EventHandler(this.btnLeaveInteraction_Click);
            // 
            // FrmInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(878, 504);
            this.Controls.Add(this.btnLeaveInteraction);
            this.Controls.Add(this.btnInteract2);
            this.Controls.Add(this.lblInteract);
            this.Controls.Add(this.btnInteract);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picPlayer);
            this.Name = "FrmInteract";
            this.Text = "FrmInteract";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInteract;
        private System.Windows.Forms.Label lblInteract;
        private System.Windows.Forms.Button btnInteract2;
        private System.Windows.Forms.Button btnLeaveInteraction;
    }
}