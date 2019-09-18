namespace RepairSys
{
    partial class frmListParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListParts));
            this.grdListParts = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prntListParts = new System.Windows.Forms.PrintDialog();
            this.prntDocListParts = new System.Drawing.Printing.PrintDocument();
            this.grpPartTypeSearch = new System.Windows.Forms.Panel();
            this.btnprint = new System.Windows.Forms.Button();
            this.cboListParts = new System.Windows.Forms.ComboBox();
            this.lblListParts = new System.Windows.Forms.Label();
            this.btnShowParts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListParts)).BeginInit();
            this.grpPartTypeSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdListParts
            // 
            this.grdListParts.AllowUserToAddRows = false;
            this.grdListParts.AllowUserToDeleteRows = false;
            this.grdListParts.AllowUserToResizeColumns = false;
            this.grdListParts.AllowUserToResizeRows = false;
            this.grdListParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListParts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdListParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListParts.Location = new System.Drawing.Point(11, 112);
            this.grdListParts.Name = "grdListParts";
            this.grdListParts.ReadOnly = true;
            this.grdListParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdListParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListParts.Size = new System.Drawing.Size(486, 534);
            this.grdListParts.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBack.Location = new System.Drawing.Point(409, 652);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 28);
            this.btnBack.TabIndex = 13;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Close";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Available Parts";
            // 
            // prntListParts
            // 
            this.prntListParts.UseEXDialog = true;
            // 
            // prntDocListParts
            // 
            this.prntDocListParts.DocumentName = "List Parts";
            this.prntDocListParts.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prntListParts_PrintPage);
            // 
            // grpPartTypeSearch
            // 
            this.grpPartTypeSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpPartTypeSearch.Controls.Add(this.btnShowParts);
            this.grpPartTypeSearch.Controls.Add(this.btnprint);
            this.grpPartTypeSearch.Controls.Add(this.cboListParts);
            this.grpPartTypeSearch.Controls.Add(this.lblListParts);
            this.grpPartTypeSearch.Location = new System.Drawing.Point(12, 39);
            this.grpPartTypeSearch.Name = "grpPartTypeSearch";
            this.grpPartTypeSearch.Size = new System.Drawing.Size(486, 67);
            this.grpPartTypeSearch.TabIndex = 11;
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnprint.Location = new System.Drawing.Point(281, 27);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(88, 28);
            this.btnprint.TabIndex = 15;
            this.btnprint.TabStop = false;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // cboListParts
            // 
            this.cboListParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListParts.FormattingEnabled = true;
            this.cboListParts.Location = new System.Drawing.Point(95, 19);
            this.cboListParts.Name = "cboListParts";
            this.cboListParts.Size = new System.Drawing.Size(121, 21);
            this.cboListParts.TabIndex = 2;
            this.cboListParts.SelectedIndexChanged += new System.EventHandler(this.cboListParts_SelectedIndexChanged);
            // 
            // lblListParts
            // 
            this.lblListParts.AutoSize = true;
            this.lblListParts.Location = new System.Drawing.Point(3, 27);
            this.lblListParts.Name = "lblListParts";
            this.lblListParts.Size = new System.Drawing.Size(86, 13);
            this.lblListParts.TabIndex = 3;
            this.lblListParts.Text = "Select Part Type";
            // 
            // btnShowParts
            // 
            this.btnShowParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnShowParts.Location = new System.Drawing.Point(375, 8);
            this.btnShowParts.Name = "btnShowParts";
            this.btnShowParts.Size = new System.Drawing.Size(99, 49);
            this.btnShowParts.TabIndex = 16;
            this.btnShowParts.TabStop = false;
            this.btnShowParts.Text = "Show All Parts";
            this.btnShowParts.UseVisualStyleBackColor = true;
            this.btnShowParts.Click += new System.EventHandler(this.btnShowParts_Click);
            // 
            // frmListParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpPartTypeSearch);
            this.Controls.Add(this.grdListParts);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListParts";
            this.Text = "List Available Parts";
            this.Load += new System.EventHandler(this.frmListPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListParts)).EndInit();
            this.grpPartTypeSearch.ResumeLayout(false);
            this.grpPartTypeSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListParts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintDialog prntListParts;
        private System.Drawing.Printing.PrintDocument prntDocListParts;
        private System.Windows.Forms.Panel grpPartTypeSearch;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.ComboBox cboListParts;
        private System.Windows.Forms.Label lblListParts;
        private System.Windows.Forms.Button btnShowParts;
    }
}