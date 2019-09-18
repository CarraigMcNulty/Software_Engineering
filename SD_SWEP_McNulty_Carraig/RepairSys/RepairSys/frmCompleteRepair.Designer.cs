namespace RepairSys
{
    partial class frmCompleteRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompleteRepair));
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.grdListRepairs = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepairs)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repair Desc";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(80, 383);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(264, 96);
            this.txtDesc.TabIndex = 9;
            // 
            // grdListRepairs
            // 
            this.grdListRepairs.AllowUserToAddRows = false;
            this.grdListRepairs.AllowUserToDeleteRows = false;
            this.grdListRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListRepairs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdListRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListRepairs.Location = new System.Drawing.Point(12, 88);
            this.grdListRepairs.MultiSelect = false;
            this.grdListRepairs.Name = "grdListRepairs";
            this.grdListRepairs.ReadOnly = true;
            this.grdListRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListRepairs.Size = new System.Drawing.Size(771, 272);
            this.grdListRepairs.TabIndex = 7;
            this.grdListRepairs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListRepairs_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Complete Repair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Complete Repair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Select a repair to Complete:";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCustEmail.Location = new System.Drawing.Point(533, 386);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(84, 17);
            this.lblCustEmail.TabIndex = 16;
            this.lblCustEmail.Text = "lblCustEmail";
            this.lblCustEmail.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(481, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Email:";
            // 
            // frmCompleteRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 557);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.grdListRepairs);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompleteRepair";
            this.Text = "Complete Repair";
            this.Load += new System.EventHandler(this.frmCompleteRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DataGridView grdListRepairs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label label12;
    }
}