namespace RepairSys
{
    partial class frmListRepairs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListRepairs));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseList = new System.Windows.Forms.Button();
            this.grpModelNoSearch = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.btnPendingFilter = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnEstimated = new System.Windows.Forms.Button();
            this.btnProcessing = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grdListRepairs = new System.Windows.Forms.DataGridView();
            this.txtRepairDesc = new System.Windows.Forms.TextBox();
            this.lblRepDesc = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.lblEmailtitle = new System.Windows.Forms.Label();
            this.prntListRep = new System.Windows.Forms.PrintDialog();
            this.prntDocListRepairs = new System.Drawing.Printing.PrintDocument();
            this.pnlRepDetails = new System.Windows.Forms.Panel();
            this.grpModelNoSearch.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepairs)).BeginInit();
            this.pnlRepDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Repair";
            // 
            // btnCloseList
            // 
            this.btnCloseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCloseList.Location = new System.Drawing.Point(12, 681);
            this.btnCloseList.Name = "btnCloseList";
            this.btnCloseList.Size = new System.Drawing.Size(91, 38);
            this.btnCloseList.TabIndex = 2;
            this.btnCloseList.Text = "Close";
            this.btnCloseList.UseVisualStyleBackColor = true;
            this.btnCloseList.Click += new System.EventHandler(this.btnCloseList_Click);
            // 
            // grpModelNoSearch
            // 
            this.grpModelNoSearch.BackColor = System.Drawing.SystemColors.Control;
            this.grpModelNoSearch.Controls.Add(this.pnlFilters);
            this.grpModelNoSearch.Location = new System.Drawing.Point(17, 36);
            this.grpModelNoSearch.Name = "grpModelNoSearch";
            this.grpModelNoSearch.Size = new System.Drawing.Size(452, 104);
            this.grpModelNoSearch.TabIndex = 13;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.lblFilter);
            this.pnlFilters.Controls.Add(this.Clear);
            this.pnlFilters.Controls.Add(this.btnPendingFilter);
            this.pnlFilters.Controls.Add(this.btnCompleted);
            this.pnlFilters.Controls.Add(this.btnEstimated);
            this.pnlFilters.Controls.Add(this.btnProcessing);
            this.pnlFilters.Location = new System.Drawing.Point(3, 33);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(449, 64);
            this.pnlFilters.TabIndex = 15;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(5, 3);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(50, 13);
            this.lblFilter.TabIndex = 15;
            this.lblFilter.Text = "Filter By :";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(332, 23);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnPendingFilter
            // 
            this.btnPendingFilter.Location = new System.Drawing.Point(8, 23);
            this.btnPendingFilter.Name = "btnPendingFilter";
            this.btnPendingFilter.Size = new System.Drawing.Size(75, 23);
            this.btnPendingFilter.TabIndex = 13;
            this.btnPendingFilter.Text = "Pending";
            this.btnPendingFilter.UseVisualStyleBackColor = true;
            this.btnPendingFilter.Click += new System.EventHandler(this.btnPendingFilter_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(251, 23);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(75, 23);
            this.btnCompleted.TabIndex = 14;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnEstimated
            // 
            this.btnEstimated.Location = new System.Drawing.Point(89, 23);
            this.btnEstimated.Name = "btnEstimated";
            this.btnEstimated.Size = new System.Drawing.Size(75, 23);
            this.btnEstimated.TabIndex = 12;
            this.btnEstimated.Text = "Estimated";
            this.btnEstimated.UseVisualStyleBackColor = true;
            this.btnEstimated.Click += new System.EventHandler(this.btnEstimated_Click);
            // 
            // btnProcessing
            // 
            this.btnProcessing.Location = new System.Drawing.Point(170, 23);
            this.btnProcessing.Name = "btnProcessing";
            this.btnProcessing.Size = new System.Drawing.Size(75, 23);
            this.btnProcessing.TabIndex = 11;
            this.btnProcessing.Text = "Processing";
            this.btnProcessing.UseVisualStyleBackColor = true;
            this.btnProcessing.Click += new System.EventHandler(this.btnProcessing_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrint.Location = new System.Drawing.Point(637, 113);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 28);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grdListRepairs
            // 
            this.grdListRepairs.AllowUserToAddRows = false;
            this.grdListRepairs.AllowUserToDeleteRows = false;
            this.grdListRepairs.AllowUserToResizeColumns = false;
            this.grdListRepairs.AllowUserToResizeRows = false;
            this.grdListRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListRepairs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListRepairs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdListRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListRepairs.Location = new System.Drawing.Point(12, 151);
            this.grdListRepairs.Name = "grdListRepairs";
            this.grdListRepairs.ReadOnly = true;
            this.grdListRepairs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdListRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListRepairs.Size = new System.Drawing.Size(1102, 510);
            this.grdListRepairs.TabIndex = 14;
            this.grdListRepairs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListParts_CellClick);
            this.grdListRepairs.SelectionChanged += new System.EventHandler(this.grdListRepairs_SelectionChanged);
            // 
            // txtRepairDesc
            // 
            this.txtRepairDesc.Location = new System.Drawing.Point(72, 3);
            this.txtRepairDesc.Multiline = true;
            this.txtRepairDesc.Name = "txtRepairDesc";
            this.txtRepairDesc.ReadOnly = true;
            this.txtRepairDesc.Size = new System.Drawing.Size(310, 76);
            this.txtRepairDesc.TabIndex = 15;
            this.txtRepairDesc.Visible = false;
            // 
            // lblRepDesc
            // 
            this.lblRepDesc.AutoSize = true;
            this.lblRepDesc.Location = new System.Drawing.Point(0, 3);
            this.lblRepDesc.Name = "lblRepDesc";
            this.lblRepDesc.Size = new System.Drawing.Size(66, 13);
            this.lblRepDesc.TabIndex = 16;
            this.lblRepDesc.Text = "Repair Desc";
            this.lblRepDesc.Visible = false;
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCustEmail.Location = new System.Drawing.Point(55, 104);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(84, 17);
            this.lblCustEmail.TabIndex = 18;
            this.lblCustEmail.Text = "lblCustEmail";
            this.lblCustEmail.Visible = false;
            // 
            // lblEmailtitle
            // 
            this.lblEmailtitle.AutoSize = true;
            this.lblEmailtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEmailtitle.Location = new System.Drawing.Point(3, 104);
            this.lblEmailtitle.Name = "lblEmailtitle";
            this.lblEmailtitle.Size = new System.Drawing.Size(46, 17);
            this.lblEmailtitle.TabIndex = 17;
            this.lblEmailtitle.Text = "Email:";
            this.lblEmailtitle.Visible = false;
            // 
            // prntListRep
            // 
            this.prntListRep.UseEXDialog = true;
            // 
            // prntDocListRepairs
            // 
            this.prntDocListRepairs.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prntListRepairs_PrintPage);
            // 
            // pnlRepDetails
            // 
            this.pnlRepDetails.Controls.Add(this.lblCustEmail);
            this.pnlRepDetails.Controls.Add(this.lblEmailtitle);
            this.pnlRepDetails.Controls.Add(this.lblRepDesc);
            this.pnlRepDetails.Controls.Add(this.txtRepairDesc);
            this.pnlRepDetails.Location = new System.Drawing.Point(729, 8);
            this.pnlRepDetails.Name = "pnlRepDetails";
            this.pnlRepDetails.Size = new System.Drawing.Size(385, 133);
            this.pnlRepDetails.TabIndex = 20;
            this.pnlRepDetails.Visible = false;
            // 
            // frmListRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 728);
            this.Controls.Add(this.pnlRepDetails);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdListRepairs);
            this.Controls.Add(this.grpModelNoSearch);
            this.Controls.Add(this.btnCloseList);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListRepairs";
            this.Text = "List Repair";
            this.Load += new System.EventHandler(this.frmListRepairs_Load);
            this.grpModelNoSearch.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepairs)).EndInit();
            this.pnlRepDetails.ResumeLayout(false);
            this.pnlRepDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseList;
        private System.Windows.Forms.Panel grpModelNoSearch;
        private System.Windows.Forms.DataGridView grdListRepairs;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnPendingFilter;
        private System.Windows.Forms.Button btnEstimated;
        private System.Windows.Forms.Button btnProcessing;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox txtRepairDesc;
        private System.Windows.Forms.Label lblRepDesc;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label lblEmailtitle;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog prntListRep;
        private System.Drawing.Printing.PrintDocument prntDocListRepairs;
        private System.Windows.Forms.Panel pnlRepDetails;
    }
}