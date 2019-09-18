namespace RepairSys
{
    partial class frmReviseRepair
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviseRepair));
            this.grpSelectRepair = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoEstimated = new System.Windows.Forms.RadioButton();
            this.rdoProcessing = new System.Windows.Forms.RadioButton();
            this.grdListRepair = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlRepDesc = new System.Windows.Forms.Panel();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRepairDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectRepair = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpSelectParts = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdShowParts = new System.Windows.Forms.DataGridView();
            this.lblEstimateTitle = new System.Windows.Forms.Label();
            this.cboListParts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddtoRepair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlAddedParts = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCostNum = new System.Windows.Forms.Label();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grdAddedParts = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReviseRepair = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSelectRepair.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepair)).BeginInit();
            this.pnlRepDesc.SuspendLayout();
            this.grpSelectParts.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowParts)).BeginInit();
            this.pnlQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlAddedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelectRepair
            // 
            this.grpSelectRepair.BackColor = System.Drawing.Color.Transparent;
            this.grpSelectRepair.Controls.Add(this.panel2);
            this.grpSelectRepair.Controls.Add(this.grdListRepair);
            this.grpSelectRepair.Controls.Add(this.label9);
            this.grpSelectRepair.Controls.Add(this.label8);
            this.grpSelectRepair.Controls.Add(this.pnlRepDesc);
            this.grpSelectRepair.Controls.Add(this.btnSelectRepair);
            this.grpSelectRepair.Controls.Add(this.btnBack);
            this.grpSelectRepair.Location = new System.Drawing.Point(10, 36);
            this.grpSelectRepair.Name = "grpSelectRepair";
            this.grpSelectRepair.Size = new System.Drawing.Size(619, 665);
            this.grpSelectRepair.TabIndex = 3;
            this.grpSelectRepair.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoEstimated);
            this.panel2.Controls.Add(this.rdoProcessing);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 29);
            this.panel2.TabIndex = 18;
            // 
            // rdoEstimated
            // 
            this.rdoEstimated.AutoSize = true;
            this.rdoEstimated.BackColor = System.Drawing.SystemColors.Control;
            this.rdoEstimated.Location = new System.Drawing.Point(98, 9);
            this.rdoEstimated.Name = "rdoEstimated";
            this.rdoEstimated.Size = new System.Drawing.Size(71, 17);
            this.rdoEstimated.TabIndex = 17;
            this.rdoEstimated.TabStop = true;
            this.rdoEstimated.Text = "Estimated";
            this.rdoEstimated.UseVisualStyleBackColor = false;
            this.rdoEstimated.Click += new System.EventHandler(this.rdoEstimated_Click);
            // 
            // rdoProcessing
            // 
            this.rdoProcessing.AutoSize = true;
            this.rdoProcessing.BackColor = System.Drawing.SystemColors.Control;
            this.rdoProcessing.Location = new System.Drawing.Point(7, 9);
            this.rdoProcessing.Name = "rdoProcessing";
            this.rdoProcessing.Size = new System.Drawing.Size(77, 17);
            this.rdoProcessing.TabIndex = 16;
            this.rdoProcessing.TabStop = true;
            this.rdoProcessing.Text = "Processing";
            this.rdoProcessing.UseVisualStyleBackColor = false;
            this.rdoProcessing.Click += new System.EventHandler(this.rdoProcessing_Click);
            // 
            // grdListRepair
            // 
            this.grdListRepair.AllowUserToAddRows = false;
            this.grdListRepair.AllowUserToDeleteRows = false;
            this.grdListRepair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListRepair.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdListRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListRepair.GridColor = System.Drawing.Color.White;
            this.grdListRepair.Location = new System.Drawing.Point(0, 89);
            this.grdListRepair.MultiSelect = false;
            this.grdListRepair.Name = "grdListRepair";
            this.grdListRepair.ReadOnly = true;
            this.grdListRepair.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdListRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListRepair.Size = new System.Drawing.Size(619, 348);
            this.grdListRepair.TabIndex = 0;
            this.grdListRepair.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListRepair_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Select Repair";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "NO LOGGED REPAIRS TO DISPLAY";
            // 
            // pnlRepDesc
            // 
            this.pnlRepDesc.Controls.Add(this.lblCustEmail);
            this.pnlRepDesc.Controls.Add(this.label12);
            this.pnlRepDesc.Controls.Add(this.txtRepairDesc);
            this.pnlRepDesc.Controls.Add(this.label2);
            this.pnlRepDesc.Location = new System.Drawing.Point(6, 458);
            this.pnlRepDesc.Name = "pnlRepDesc";
            this.pnlRepDesc.Size = new System.Drawing.Size(433, 156);
            this.pnlRepDesc.TabIndex = 5;
            this.pnlRepDesc.Visible = false;
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCustEmail.Location = new System.Drawing.Point(55, 122);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(84, 17);
            this.lblCustEmail.TabIndex = 18;
            this.lblCustEmail.Text = "lblCustEmail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(3, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Email:";
            // 
            // txtRepairDesc
            // 
            this.txtRepairDesc.BackColor = System.Drawing.SystemColors.Control;
            this.txtRepairDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepairDesc.Location = new System.Drawing.Point(121, 13);
            this.txtRepairDesc.Multiline = true;
            this.txtRepairDesc.Name = "txtRepairDesc";
            this.txtRepairDesc.ReadOnly = true;
            this.txtRepairDesc.Size = new System.Drawing.Size(256, 80);
            this.txtRepairDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repair Description";
            // 
            // btnSelectRepair
            // 
            this.btnSelectRepair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSelectRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSelectRepair.Location = new System.Drawing.Point(511, 620);
            this.btnSelectRepair.Name = "btnSelectRepair";
            this.btnSelectRepair.Size = new System.Drawing.Size(102, 39);
            this.btnSelectRepair.TabIndex = 3;
            this.btnSelectRepair.Text = "Next";
            this.btnSelectRepair.UseVisualStyleBackColor = true;
            this.btnSelectRepair.Visible = false;
            this.btnSelectRepair.Click += new System.EventHandler(this.btnSelectRepair_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnBack.Location = new System.Drawing.Point(9, 620);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // grpSelectParts
            // 
            this.grpSelectParts.BackColor = System.Drawing.Color.Transparent;
            this.grpSelectParts.Controls.Add(this.panel1);
            this.grpSelectParts.Controls.Add(this.pnlAddedParts);
            this.grpSelectParts.Controls.Add(this.label10);
            this.grpSelectParts.Controls.Add(this.btnReviseRepair);
            this.grpSelectParts.Controls.Add(this.btnReturn);
            this.grpSelectParts.Enabled = false;
            this.grpSelectParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectParts.Location = new System.Drawing.Point(637, 36);
            this.grpSelectParts.Name = "grpSelectParts";
            this.grpSelectParts.Size = new System.Drawing.Size(619, 665);
            this.grpSelectParts.TabIndex = 4;
            this.grpSelectParts.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdShowParts);
            this.panel1.Controls.Add(this.lblEstimateTitle);
            this.panel1.Controls.Add(this.cboListParts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRepID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pnlQuantity);
            this.panel1.Location = new System.Drawing.Point(4, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 299);
            this.panel1.TabIndex = 16;
  
            // 
            // grdShowParts
            // 
            this.grdShowParts.AllowUserToAddRows = false;
            this.grdShowParts.AllowUserToDeleteRows = false;
            this.grdShowParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdShowParts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShowParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdShowParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdShowParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdShowParts.Location = new System.Drawing.Point(0, 65);
            this.grdShowParts.Name = "grdShowParts";
            this.grdShowParts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShowParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdShowParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdShowParts.Size = new System.Drawing.Size(402, 212);
            this.grdShowParts.TabIndex = 0;
            this.grdShowParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShowParts_CellClick);
            // 
            // lblEstimateTitle
            // 
            this.lblEstimateTitle.AutoSize = true;
            this.lblEstimateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblEstimateTitle.Location = new System.Drawing.Point(7, 9);
            this.lblEstimateTitle.Name = "lblEstimateTitle";
            this.lblEstimateTitle.Size = new System.Drawing.Size(320, 20);
            this.lblEstimateTitle.TabIndex = 14;
            this.lblEstimateTitle.Text = "Select The Parts Below For Repair : ";
            this.lblEstimateTitle.Visible = false;
            // 
            // cboListParts
            // 
            this.cboListParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListParts.FormattingEnabled = true;
            this.cboListParts.Location = new System.Drawing.Point(281, 36);
            this.cboListParts.Name = "cboListParts";
            this.cboListParts.Size = new System.Drawing.Size(121, 21);
            this.cboListParts.TabIndex = 5;
            this.cboListParts.SelectedIndexChanged += new System.EventHandler(this.cboListParts_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(189, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Part Type";
            // 
            // txtRepID
            // 
            this.txtRepID.Location = new System.Drawing.Point(480, 37);
            this.txtRepID.Name = "txtRepID";
            this.txtRepID.ReadOnly = true;
            this.txtRepID.Size = new System.Drawing.Size(27, 20);
            this.txtRepID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(424, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Repair ID";
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.label11);
            this.pnlQuantity.Controls.Add(this.btnAddtoRepair);
            this.pnlQuantity.Controls.Add(this.label4);
            this.pnlQuantity.Controls.Add(this.numQuantity);
            this.pnlQuantity.Location = new System.Drawing.Point(406, 88);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(197, 117);
            this.pnlQuantity.TabIndex = 7;
            this.pnlQuantity.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Select Quantity : ";
            this.label11.Visible = false;
            // 
            // btnAddtoRepair
            // 
            this.btnAddtoRepair.Location = new System.Drawing.Point(97, 87);
            this.btnAddtoRepair.Name = "btnAddtoRepair";
            this.btnAddtoRepair.Size = new System.Drawing.Size(87, 23);
            this.btnAddtoRepair.TabIndex = 9;
            this.btnAddtoRepair.Text = "Add To Repair";
            this.btnAddtoRepair.UseVisualStyleBackColor = true;
            this.btnAddtoRepair.Click += new System.EventHandler(this.btnAddtoRepair_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(2, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Quantity (Max 5) :";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(126, 61);
            this.numQuantity.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(48, 20);
            this.numQuantity.TabIndex = 0;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlAddedParts
            // 
            this.pnlAddedParts.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddedParts.Controls.Add(this.label6);
            this.pnlAddedParts.Controls.Add(this.lblCostNum);
            this.pnlAddedParts.Controls.Add(this.btnRemovePart);
            this.pnlAddedParts.Controls.Add(this.label7);
            this.pnlAddedParts.Controls.Add(this.grdAddedParts);
            this.pnlAddedParts.Location = new System.Drawing.Point(6, 339);
            this.pnlAddedParts.Name = "pnlAddedParts";
            this.pnlAddedParts.Size = new System.Drawing.Size(613, 236);
            this.pnlAddedParts.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Parts Added to this repair:";
            // 
            // lblCostNum
            // 
            this.lblCostNum.AutoSize = true;
            this.lblCostNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblCostNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostNum.Location = new System.Drawing.Point(533, 104);
            this.lblCostNum.Name = "lblCostNum";
            this.lblCostNum.Size = new System.Drawing.Size(0, 13);
            this.lblCostNum.TabIndex = 13;
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(413, 65);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(87, 23);
            this.btnRemovePart.TabIndex = 11;
            this.btnRemovePart.Text = "Remove Part ";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Repair Cost : €";
            // 
            // grdAddedParts
            // 
            this.grdAddedParts.AllowUserToAddRows = false;
            this.grdAddedParts.AllowUserToDeleteRows = false;
            this.grdAddedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAddedParts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAddedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAddedParts.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdAddedParts.Location = new System.Drawing.Point(5, 43);
            this.grdAddedParts.Name = "grdAddedParts";
            this.grdAddedParts.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddedParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAddedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAddedParts.Size = new System.Drawing.Size(400, 179);
            this.grdAddedParts.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "NO PARTS ADDED";
            // 
            // btnReviseRepair
            // 
            this.btnReviseRepair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnReviseRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnReviseRepair.Location = new System.Drawing.Point(516, 619);
            this.btnReviseRepair.Name = "btnReviseRepair";
            this.btnReviseRepair.Size = new System.Drawing.Size(97, 40);
            this.btnReviseRepair.TabIndex = 3;
            this.btnReviseRepair.Text = "Revise Cost";
            this.btnReviseRepair.UseVisualStyleBackColor = true;
            this.btnReviseRepair.Visible = false;
            this.btnReviseRepair.Click += new System.EventHandler(this.btnEstimateCost_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnReturn.Location = new System.Drawing.Point(15, 619);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Select Repair";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.825F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Revise Repair";
            // 
            // frmReviseRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1268, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSelectRepair);
            this.Controls.Add(this.grpSelectParts);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReviseRepair";
            this.Text = "Revise Repair";
            this.Load += new System.EventHandler(this.frmReviseRepair_Load);
            this.grpSelectRepair.ResumeLayout(false);
            this.grpSelectRepair.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRepair)).EndInit();
            this.pnlRepDesc.ResumeLayout(false);
            this.pnlRepDesc.PerformLayout();
            this.grpSelectParts.ResumeLayout(false);
            this.grpSelectParts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowParts)).EndInit();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlAddedParts.ResumeLayout(false);
            this.pnlAddedParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectRepair;
        private System.Windows.Forms.DataGridView grdListRepair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlRepDesc;
        private System.Windows.Forms.TextBox txtRepairDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectRepair;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpSelectParts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView grdShowParts;
        private System.Windows.Forms.Label lblEstimateTitle;
        private System.Windows.Forms.ComboBox cboListParts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.Button btnAddtoRepair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtRepID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAddedParts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCostNum;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdAddedParts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReviseRepair;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoEstimated;
        private System.Windows.Forms.RadioButton rdoProcessing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label label12;
    }
}