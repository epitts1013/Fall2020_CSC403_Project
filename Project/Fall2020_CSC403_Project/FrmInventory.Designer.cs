namespace Fall2020_CSC403_Project
{
    partial class FrmInventory
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
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatBlock = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnUse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(196, 40);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(120, 95);
            this.lstInventory.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 248);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatBlock
            // 
            this.lblStatBlock.AutoSize = true;
            this.lblStatBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatBlock.Location = new System.Drawing.Point(8, 263);
            this.lblStatBlock.Name = "lblStatBlock";
            this.lblStatBlock.Size = new System.Drawing.Size(60, 24);
            this.lblStatBlock.TabIndex = 2;
            this.lblStatBlock.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Inventory";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(213, 13);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(86, 24);
            this.lblInventory.TabIndex = 4;
            this.lblInventory.Text = "Inventory";
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(196, 141);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(120, 23);
            this.btnUse.TabIndex = 5;
            this.btnUse.Text = "Use Item";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(328, 386);
            this.ControlBox = false;
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatBlock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstInventory);
            this.Name = "FrmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatBlock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnUse;
    }
}