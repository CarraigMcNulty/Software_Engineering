namespace RepairSys
{
    partial class frmupRepDesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmupRepDesc));
            this.pnlRepDesc = new System.Windows.Forms.Panel();
            this.txtRepId = new System.Windows.Forms.TextBox();
            this.btnUpdateDesc = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtRepairDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRepDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRepDesc
            // 
            this.pnlRepDesc.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRepDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRepDesc.BackgroundImage")));
            this.pnlRepDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRepDesc.Controls.Add(this.txtRepId);
            this.pnlRepDesc.Controls.Add(this.btnUpdateDesc);
            this.pnlRepDesc.Controls.Add(this.btnCancel);
            this.pnlRepDesc.Controls.Add(this.lbltitle);
            this.pnlRepDesc.Controls.Add(this.txtRepairDesc);
            this.pnlRepDesc.Controls.Add(this.label2);
            this.pnlRepDesc.Location = new System.Drawing.Point(11, 12);
            this.pnlRepDesc.Name = "pnlRepDesc";
            this.pnlRepDesc.Size = new System.Drawing.Size(513, 219);
            this.pnlRepDesc.TabIndex = 6;
            // 
            // txtRepId
            // 
            this.txtRepId.Location = new System.Drawing.Point(121, 146);
            this.txtRepId.Name = "txtRepId";
            this.txtRepId.Size = new System.Drawing.Size(29, 20);
            this.txtRepId.TabIndex = 7;
            this.txtRepId.Visible = false;
            // 
            // btnUpdateDesc
            // 
            this.btnUpdateDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUpdateDesc.Location = new System.Drawing.Point(423, 176);
            this.btnUpdateDesc.Name = "btnUpdateDesc";
            this.btnUpdateDesc.Size = new System.Drawing.Size(87, 43);
            this.btnUpdateDesc.TabIndex = 6;
            this.btnUpdateDesc.Text = "Update Description";
            this.btnUpdateDesc.UseVisualStyleBackColor = true;
            this.btnUpdateDesc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCancel.Location = new System.Drawing.Point(7, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbltitle.Location = new System.Drawing.Point(3, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(232, 20);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Update Repair Description";
            // 
            // txtRepairDesc
            // 
            this.txtRepairDesc.AcceptsReturn = true;
            this.txtRepairDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtRepairDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepairDesc.Location = new System.Drawing.Point(121, 60);
            this.txtRepairDesc.Multiline = true;
            this.txtRepairDesc.Name = "txtRepairDesc";
            this.txtRepairDesc.Size = new System.Drawing.Size(364, 80);
            this.txtRepairDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repair Description";
            // 
            // frmupRepDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 243);
            this.Controls.Add(this.pnlRepDesc);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmupRepDesc";
            this.Text = "Repair Description";
         
            this.pnlRepDesc.ResumeLayout(false);
            this.pnlRepDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRepDesc;
        private System.Windows.Forms.TextBox txtRepairDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnUpdateDesc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRepId;
    }
}