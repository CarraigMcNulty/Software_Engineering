namespace RepairSys
{
    partial class frmCommenceRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommenceRepair));
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.grdListRepairs = new System.Windows.Forms.DataGridView();
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblExistingPayment = new System.Windows.Forms.Label();
            this.lblPaymenTitle = new System.Windows.Forms.Label();
            this.grdRepairParts = new System.Windows.Forms.DataGridView();
            this.pnlExistingPayment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepairs)).BeginInit();
            this.pnlConfirmation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepairParts)).BeginInit();
            this.pnlExistingPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(119, 40);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 0;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Location = new System.Drawing.Point(168, 40);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 1;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // grdListRepairs
            // 
            this.grdListRepairs.AllowUserToAddRows = false;
            this.grdListRepairs.AllowUserToDeleteRows = false;
            this.grdListRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListRepairs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdListRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListRepairs.Location = new System.Drawing.Point(18, 64);
            this.grdListRepairs.MultiSelect = false;
            this.grdListRepairs.Name = "grdListRepairs";
            this.grdListRepairs.ReadOnly = true;
            this.grdListRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListRepairs.Size = new System.Drawing.Size(758, 281);
            this.grdListRepairs.TabIndex = 2;
            this.grdListRepairs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListRepairs_CellClick);
            this.grdListRepairs.SelectionChanged += new System.EventHandler(this.grdListRepairs_SelectionChanged);
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.Controls.Add(this.label1);
            this.pnlConfirmation.Controls.Add(this.radYes);
            this.pnlConfirmation.Controls.Add(this.radNo);
            this.pnlConfirmation.Location = new System.Drawing.Point(12, 593);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(225, 60);
            this.pnlConfirmation.TabIndex = 3;
            this.pnlConfirmation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Has the full cost of this repair been paid? :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commence Repair";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(82, 459);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(264, 96);
            this.txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repair Desc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 736);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 713);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Commence Repair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCustEmail.Location = new System.Drawing.Point(69, 405);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(84, 17);
            this.lblCustEmail.TabIndex = 10;
            this.lblCustEmail.Text = "lblCustEmail";
            this.lblCustEmail.Visible = false;
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEmailTitle.Location = new System.Drawing.Point(17, 405);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(46, 17);
            this.lblEmailTitle.TabIndex = 9;
            this.lblEmailTitle.Text = "Email:";
            this.lblEmailTitle.Visible = false;
            // 
            // lblExistingPayment
            // 
            this.lblExistingPayment.AutoSize = true;
            this.lblExistingPayment.BackColor = System.Drawing.SystemColors.Control;
            this.lblExistingPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblExistingPayment.Location = new System.Drawing.Point(265, 56);
            this.lblExistingPayment.Name = "lblExistingPayment";
            this.lblExistingPayment.Size = new System.Drawing.Size(16, 17);
            this.lblExistingPayment.TabIndex = 12;
            this.lblExistingPayment.Text = "0";
            // 
            // lblPaymenTitle
            // 
            this.lblPaymenTitle.AutoSize = true;
            this.lblPaymenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPaymenTitle.Location = new System.Drawing.Point(3, 56);
            this.lblPaymenTitle.Name = "lblPaymenTitle";
            this.lblPaymenTitle.Size = new System.Drawing.Size(256, 17);
            this.lblPaymenTitle.TabIndex = 11;
            this.lblPaymenTitle.Text = "Payment found the customer will owe: €";
            // 
            // grdRepairParts
            // 
            this.grdRepairParts.AllowUserToAddRows = false;
            this.grdRepairParts.AllowUserToDeleteRows = false;
            this.grdRepairParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdRepairParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdRepairParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepairParts.Location = new System.Drawing.Point(382, 405);
            this.grdRepairParts.Name = "grdRepairParts";
            this.grdRepairParts.ReadOnly = true;
            this.grdRepairParts.RowHeadersVisible = false;
            this.grdRepairParts.Size = new System.Drawing.Size(389, 150);
            this.grdRepairParts.TabIndex = 13;
            // 
            // pnlExistingPayment
            // 
            this.pnlExistingPayment.Controls.Add(this.label6);
            this.pnlExistingPayment.Controls.Add(this.lblAmountPaid);
            this.pnlExistingPayment.Controls.Add(this.label5);
            this.pnlExistingPayment.Controls.Add(this.label4);
            this.pnlExistingPayment.Controls.Add(this.lblPaymenTitle);
            this.pnlExistingPayment.Controls.Add(this.lblExistingPayment);
            this.pnlExistingPayment.Location = new System.Drawing.Point(382, 581);
            this.pnlExistingPayment.Name = "pnlExistingPayment";
            this.pnlExistingPayment.Size = new System.Drawing.Size(332, 81);
            this.pnlExistingPayment.TabIndex = 14;
            this.pnlExistingPayment.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "The customer has paid: €";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAmountPaid.Location = new System.Drawing.Point(178, 33);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(16, 17);
            this.lblAmountPaid.TabIndex = 17;
            this.lblAmountPaid.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "This Repair Has Been Revised";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(379, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parts in this Repair:";
            // 
            // frmCommenceRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(783, 770);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlExistingPayment);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.grdRepairParts);
            this.Controls.Add(this.lblEmailTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlConfirmation);
            this.Controls.Add(this.grdListRepairs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCommenceRepair";
            this.Text = "Commence Repair";
            this.Load += new System.EventHandler(this.frmCommenceRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepairs)).EndInit();
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlConfirmation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepairParts)).EndInit();
            this.pnlExistingPayment.ResumeLayout(false);
            this.pnlExistingPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.DataGridView grdListRepairs;
        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblExistingPayment;
        private System.Windows.Forms.Label lblPaymenTitle;
        private System.Windows.Forms.DataGridView grdRepairParts;
        private System.Windows.Forms.Panel pnlExistingPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label label7;
    }
}