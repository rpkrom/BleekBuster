namespace MeramecNetFlixProject.UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.browseInventoryToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            this.manageAccountToolStripMenuItem.Click += new System.EventHandler(this.manageAccountToolStripMenuItem_Click);
            // 
            // browseInventoryToolStripMenuItem
            // 
            this.browseInventoryToolStripMenuItem.Name = "browseInventoryToolStripMenuItem";
            this.browseInventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.browseInventoryToolStripMenuItem.Text = "Browse";
            this.browseInventoryToolStripMenuItem.Click += new System.EventHandler(this.browseInventoryToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreFormToolStripMenuItem,
            this.vendorFormToolStripMenuItem,
            this.movieFormToolStripMenuItem,
            this.inventoryReportToolStripMenuItem,
            this.memberReportToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // genreFormToolStripMenuItem
            // 
            this.genreFormToolStripMenuItem.Name = "genreFormToolStripMenuItem";
            this.genreFormToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.genreFormToolStripMenuItem.Text = "Genre Form";
            this.genreFormToolStripMenuItem.Click += new System.EventHandler(this.genreFormToolStripMenuItem_Click);
            // 
            // vendorFormToolStripMenuItem
            // 
            this.vendorFormToolStripMenuItem.Name = "vendorFormToolStripMenuItem";
            this.vendorFormToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.vendorFormToolStripMenuItem.Text = "Vendor Form";
            this.vendorFormToolStripMenuItem.Click += new System.EventHandler(this.vendorFormToolStripMenuItem_Click);
            // 
            // movieFormToolStripMenuItem
            // 
            this.movieFormToolStripMenuItem.Name = "movieFormToolStripMenuItem";
            this.movieFormToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.movieFormToolStripMenuItem.Text = "Movie Form";
            this.movieFormToolStripMenuItem.Click += new System.EventHandler(this.movieFormToolStripMenuItem_Click);
            // 
            // inventoryReportToolStripMenuItem
            // 
            this.inventoryReportToolStripMenuItem.Name = "inventoryReportToolStripMenuItem";
            this.inventoryReportToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.inventoryReportToolStripMenuItem.Text = "Inventory Report";
            this.inventoryReportToolStripMenuItem.Click += new System.EventHandler(this.inventoryReportToolStripMenuItem_Click);
            // 
            // loginbutton1
            // 
            this.loginbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton1.Location = new System.Drawing.Point(179, 488);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(305, 60);
            this.loginbutton1.TabIndex = 1;
            this.loginbutton1.Text = "LOGIN";
            this.loginbutton1.UseVisualStyleBackColor = true;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // memberReportToolStripMenuItem
            // 
            this.memberReportToolStripMenuItem.Name = "memberReportToolStripMenuItem";
            this.memberReportToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.memberReportToolStripMenuItem.Text = "Member Report";
            this.memberReportToolStripMenuItem.Click += new System.EventHandler(this.memberReportToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(702, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbutton1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseInventoryToolStripMenuItem;
        private System.Windows.Forms.Button loginbutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberReportToolStripMenuItem;
    }
}

