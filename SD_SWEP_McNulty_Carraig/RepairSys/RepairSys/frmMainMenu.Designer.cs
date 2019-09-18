namespace RepairSys
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnusMain = new System.Windows.Forms.MenuStrip();
            this.partsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estimateCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviseRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRepairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsSoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusMain
            // 
            this.mnusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partsToolStripMenuItem,
            this.reapairsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnusMain.Location = new System.Drawing.Point(0, 0);
            this.mnusMain.Name = "mnusMain";
            this.mnusMain.Size = new System.Drawing.Size(800, 24);
            this.mnusMain.TabIndex = 0;
            this.mnusMain.Text = "menuStrip1";
            // 
            // partsToolStripMenuItem
            // 
            this.partsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartToolStripMenuItem,
            this.updatePartsToolStripMenuItem,
            this.listPartsToolStripMenuItem});
            this.partsToolStripMenuItem.Name = "partsToolStripMenuItem";
            this.partsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.partsToolStripMenuItem.Text = "Parts";
            this.partsToolStripMenuItem.Click += new System.EventHandler(this.partsToolStripMenuItem_Click);
            // 
            // addPartToolStripMenuItem
            // 
            this.addPartToolStripMenuItem.Name = "addPartToolStripMenuItem";
            this.addPartToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addPartToolStripMenuItem.Text = "Add Part";
            this.addPartToolStripMenuItem.Click += new System.EventHandler(this.addPartToolStripMenuItem_Click);
            // 
            // updatePartsToolStripMenuItem
            // 
            this.updatePartsToolStripMenuItem.Name = "updatePartsToolStripMenuItem";
            this.updatePartsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.updatePartsToolStripMenuItem.Text = "Update Part";
            this.updatePartsToolStripMenuItem.Click += new System.EventHandler(this.updatePartsToolStripMenuItem_Click);
            // 
            // listPartsToolStripMenuItem
            // 
            this.listPartsToolStripMenuItem.Name = "listPartsToolStripMenuItem";
            this.listPartsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.listPartsToolStripMenuItem.Text = "List Parts";
            this.listPartsToolStripMenuItem.Click += new System.EventHandler(this.listPartsToolStripMenuItem_Click);
            // 
            // reapairsToolStripMenuItem
            // 
            this.reapairsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logRepairToolStripMenuItem,
            this.estimateCostToolStripMenuItem,
            this.commenceRepairToolStripMenuItem,
            this.completeRepairToolStripMenuItem,
            this.reviseRepairToolStripMenuItem,
            this.listRepairsToolStripMenuItem});
            this.reapairsToolStripMenuItem.Name = "reapairsToolStripMenuItem";
            this.reapairsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reapairsToolStripMenuItem.Text = "Repairs";
            // 
            // logRepairToolStripMenuItem
            // 
            this.logRepairToolStripMenuItem.Name = "logRepairToolStripMenuItem";
            this.logRepairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logRepairToolStripMenuItem.Text = "Log Repair";
            this.logRepairToolStripMenuItem.Click += new System.EventHandler(this.logRepairToolStripMenuItem_Click);
            // 
            // estimateCostToolStripMenuItem
            // 
            this.estimateCostToolStripMenuItem.Name = "estimateCostToolStripMenuItem";
            this.estimateCostToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.estimateCostToolStripMenuItem.Text = "Estimate Cost";
            this.estimateCostToolStripMenuItem.Click += new System.EventHandler(this.estimateCostToolStripMenuItem_Click);
            // 
            // commenceRepairToolStripMenuItem
            // 
            this.commenceRepairToolStripMenuItem.Name = "commenceRepairToolStripMenuItem";
            this.commenceRepairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.commenceRepairToolStripMenuItem.Text = "Commence Repair";
            this.commenceRepairToolStripMenuItem.Click += new System.EventHandler(this.commenceRepairToolStripMenuItem_Click);
            // 
            // completeRepairToolStripMenuItem
            // 
            this.completeRepairToolStripMenuItem.Name = "completeRepairToolStripMenuItem";
            this.completeRepairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.completeRepairToolStripMenuItem.Text = "Complete Repair";
            this.completeRepairToolStripMenuItem.Click += new System.EventHandler(this.completeRepairToolStripMenuItem_Click);
            // 
            // reviseRepairToolStripMenuItem
            // 
            this.reviseRepairToolStripMenuItem.Name = "reviseRepairToolStripMenuItem";
            this.reviseRepairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reviseRepairToolStripMenuItem.Text = "Revise Repair";
            this.reviseRepairToolStripMenuItem.Click += new System.EventHandler(this.reviseRepairToolStripMenuItem_Click);
            // 
            // listRepairsToolStripMenuItem
            // 
            this.listRepairsToolStripMenuItem.Name = "listRepairsToolStripMenuItem";
            this.listRepairsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listRepairsToolStripMenuItem.Text = "List Repairs";
            this.listRepairsToolStripMenuItem.Click += new System.EventHandler(this.listRepairsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyseToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // analyseToolStripMenuItem
            // 
            this.analyseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueToolStripMenuItem,
            this.partsSoldToolStripMenuItem});
            this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
            this.analyseToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.analyseToolStripMenuItem.Text = "Analyse";
            // 
            // yearlyRevenueToolStripMenuItem
            // 
            this.yearlyRevenueToolStripMenuItem.Name = "yearlyRevenueToolStripMenuItem";
            this.yearlyRevenueToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.yearlyRevenueToolStripMenuItem.Text = "Yearly Revenue";
            this.yearlyRevenueToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueToolStripMenuItem_Click);
            // 
            // partsSoldToolStripMenuItem
            // 
            this.partsSoldToolStripMenuItem.Name = "partsSoldToolStripMenuItem";
            this.partsSoldToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.partsSoldToolStripMenuItem.Text = "Parts Sold";
            this.partsSoldToolStripMenuItem.Click += new System.EventHandler(this.partsSoldToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnusMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnusMain;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnusMain.ResumeLayout(false);
            this.mnusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusMain;
        private System.Windows.Forms.ToolStripMenuItem partsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reapairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estimateCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviseRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRepairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partsSoldToolStripMenuItem;
    }
}