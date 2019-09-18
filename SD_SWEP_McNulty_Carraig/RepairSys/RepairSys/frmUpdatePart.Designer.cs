namespace RepairSys
{
    partial class frmUpdatePart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePart));
            this.grdUpdatePart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectPart = new System.Windows.Forms.ComboBox();
            this.txtupdateModelNo = new System.Windows.Forms.TextBox();
            this.txtUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUpdatePart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpUpdatePartDetails = new System.Windows.Forms.GroupBox();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdatePart)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpUpdatePartDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdUpdatePart
            // 
            this.grdUpdatePart.AllowUserToAddRows = false;
            this.grdUpdatePart.AllowUserToDeleteRows = false;
            this.grdUpdatePart.AllowUserToResizeColumns = false;
            this.grdUpdatePart.AllowUserToResizeRows = false;
            this.grdUpdatePart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUpdatePart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdUpdatePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdatePart.Location = new System.Drawing.Point(0, 116);
            this.grdUpdatePart.Name = "grdUpdatePart";
            this.grdUpdatePart.ReadOnly = true;
            this.grdUpdatePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdatePart.Size = new System.Drawing.Size(572, 181);
            this.grdUpdatePart.TabIndex = 0;
            this.grdUpdatePart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdatePart_CellClick);
           
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboSelectPart);
            this.panel1.Controls.Add(this.grdUpdatePart);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 460);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Part to be updated:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Part Type";
            // 
            // cboSelectPart
            // 
            this.cboSelectPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectPart.FormattingEnabled = true;
            this.cboSelectPart.Location = new System.Drawing.Point(112, 32);
            this.cboSelectPart.Name = "cboSelectPart";
            this.cboSelectPart.Size = new System.Drawing.Size(121, 21);
            this.cboSelectPart.TabIndex = 1;
            this.cboSelectPart.SelectedIndexChanged += new System.EventHandler(this.cboSelectPart_SelectedIndexChanged);
            // 
            // txtupdateModelNo
            // 
            this.txtupdateModelNo.Location = new System.Drawing.Point(99, 24);
            this.txtupdateModelNo.Name = "txtupdateModelNo";
            this.txtupdateModelNo.Size = new System.Drawing.Size(134, 20);
            this.txtupdateModelNo.TabIndex = 9;
            // 
            // txtUpdateUnitPrice
            // 
            this.txtUpdateUnitPrice.Location = new System.Drawing.Point(99, 56);
            this.txtUpdateUnitPrice.MaxLength = 6;
            this.txtUpdateUnitPrice.Name = "txtUpdateUnitPrice";
            this.txtUpdateUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateUnitPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Part_Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Model Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit Price";
            // 
            // cboUpdatePart
            // 
            this.cboUpdatePart.FormattingEnabled = true;
            this.cboUpdatePart.Location = new System.Drawing.Point(99, 89);
            this.cboUpdatePart.Name = "cboUpdatePart";
            this.cboUpdatePart.Size = new System.Drawing.Size(121, 21);
            this.cboUpdatePart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Part";
            // 
            // btnUpdatePart
            // 
            this.btnUpdatePart.Location = new System.Drawing.Point(512, 536);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePart.TabIndex = 6;
            this.btnUpdatePart.Text = "Submit";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 536);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpUpdatePartDetails
            // 
            this.grpUpdatePartDetails.BackColor = System.Drawing.Color.White;
            this.grpUpdatePartDetails.Controls.Add(this.txtPartId);
            this.grpUpdatePartDetails.Controls.Add(this.label7);
            this.grpUpdatePartDetails.Controls.Add(this.txtUpdateUnitPrice);
            this.grpUpdatePartDetails.Controls.Add(this.txtupdateModelNo);
            this.grpUpdatePartDetails.Controls.Add(this.cboUpdatePart);
            this.grpUpdatePartDetails.Controls.Add(this.label3);
            this.grpUpdatePartDetails.Controls.Add(this.label4);
            this.grpUpdatePartDetails.Controls.Add(this.label5);
            this.grpUpdatePartDetails.Location = new System.Drawing.Point(12, 355);
            this.grpUpdatePartDetails.Name = "grpUpdatePartDetails";
            this.grpUpdatePartDetails.Size = new System.Drawing.Size(572, 139);
            this.grpUpdatePartDetails.TabIndex = 10;
            this.grpUpdatePartDetails.TabStop = false;
            this.grpUpdatePartDetails.Text = "Part Details";
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(329, 24);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.ReadOnly = true;
            this.txtPartId.Size = new System.Drawing.Size(42, 20);
            this.txtPartId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(283, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Part ID";
            // 
            // frmUpdatePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 571);
            this.Controls.Add(this.grpUpdatePartDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdatePart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdatePart";
            this.Text = "Update Part";
            this.Load += new System.EventHandler(this.frmUpdatePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdatePart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpUpdatePartDetails.ResumeLayout(false);
            this.grpUpdatePartDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUpdatePart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSelectPart;
        private System.Windows.Forms.ComboBox cboUpdatePart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.TextBox txtupdateModelNo;
        private System.Windows.Forms.TextBox txtUpdateUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpUpdatePartDetails;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.Label label7;
    }
}