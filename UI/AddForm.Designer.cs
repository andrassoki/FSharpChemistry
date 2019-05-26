namespace UI
{
    partial class AddForm
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
            this.lblAtomicNumber = new System.Windows.Forms.Label();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.lblShortName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAtomicWeight = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.lblDensity = new System.Windows.Forms.Label();
            this.txtMolarMass = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.addFormTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormulaMod = new System.Windows.Forms.TextBox();
            this.txtNameMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDensityMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMolarMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.gbData.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.addFormTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAtomicNumber
            // 
            this.lblAtomicNumber.AutoSize = true;
            this.lblAtomicNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtomicNumber.Location = new System.Drawing.Point(23, 16);
            this.lblAtomicNumber.Name = "lblAtomicNumber";
            this.lblAtomicNumber.Size = new System.Drawing.Size(30, 20);
            this.lblAtomicNumber.TabIndex = 25;
            this.lblAtomicNumber.Text = "ID:";
            // 
            // txtFormula
            // 
            this.txtFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(158, 78);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(160, 22);
            this.txtFormula.TabIndex = 15;
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortName.Location = new System.Drawing.Point(23, 47);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(55, 20);
            this.lblShortName.TabIndex = 26;
            this.lblShortName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(158, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 34;
            // 
            // lblAtomicWeight
            // 
            this.lblAtomicWeight.AutoSize = true;
            this.lblAtomicWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtomicWeight.Location = new System.Drawing.Point(23, 78);
            this.lblAtomicWeight.Name = "lblAtomicWeight";
            this.lblAtomicWeight.Size = new System.Drawing.Size(71, 20);
            this.lblAtomicWeight.TabIndex = 27;
            this.lblAtomicWeight.Text = "Formula:";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.addFormTabControl);
            this.pnlMain.Controls.Add(this.lstBox);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 59);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(587, 317);
            this.pnlMain.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(34, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 32);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(197, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 32);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(34, 16);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(135, 32);
            this.btnModify.TabIndex = 29;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(197, 16);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(135, 32);
            this.btnCommit.TabIndex = 28;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.Transparent;
            this.gbData.Controls.Add(this.lblAtomicNumber);
            this.gbData.Controls.Add(this.txtFormula);
            this.gbData.Controls.Add(this.txtName);
            this.gbData.Controls.Add(this.lblShortName);
            this.gbData.Controls.Add(this.lblAtomicWeight);
            this.gbData.Controls.Add(this.txtDensity);
            this.gbData.Controls.Add(this.lblDensity);
            this.gbData.Controls.Add(this.txtMolarMass);
            this.gbData.Controls.Add(this.lblGroup);
            this.gbData.Controls.Add(this.txtID);
            this.gbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbData.Location = new System.Drawing.Point(3, 3);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(351, 285);
            this.gbData.TabIndex = 9;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // txtDensity
            // 
            this.txtDensity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDensity.Location = new System.Drawing.Point(158, 140);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(160, 22);
            this.txtDensity.TabIndex = 36;
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensity.Location = new System.Drawing.Point(23, 109);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(94, 20);
            this.lblDensity.TabIndex = 28;
            this.lblDensity.Text = "Molar mass:";
            // 
            // txtMolarMass
            // 
            this.txtMolarMass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMolarMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMolarMass.Location = new System.Drawing.Point(158, 109);
            this.txtMolarMass.Name = "txtMolarMass";
            this.txtMolarMass.Size = new System.Drawing.Size(160, 22);
            this.txtMolarMass.TabIndex = 35;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(23, 140);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(66, 20);
            this.lblGroup.TabIndex = 29;
            this.lblGroup.Text = "Density:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(158, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 22);
            this.txtID.TabIndex = 33;
            // 
            // lstBox
            // 
            this.lstBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 20;
            this.lstBox.Location = new System.Drawing.Point(0, 0);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(222, 317);
            this.lstBox.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(186)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(587, 59);
            this.pnlTop.TabIndex = 9;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Location = new System.Drawing.Point(469, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(59, 59);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(528, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 59);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // addFormTabControl
            // 
            this.addFormTabControl.Controls.Add(this.tabPage1);
            this.addFormTabControl.Controls.Add(this.tabPage2);
            this.addFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFormTabControl.Location = new System.Drawing.Point(222, 0);
            this.addFormTabControl.Name = "addFormTabControl";
            this.addFormTabControl.SelectedIndex = 0;
            this.addFormTabControl.Size = new System.Drawing.Size(365, 317);
            this.addFormTabControl.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.gbData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Record";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify Record";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(222, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 100);
            this.panel1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFormulaMod);
            this.groupBox1.Controls.Add(this.txtNameMod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDensityMod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMolarMod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIdMod);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 285);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            // 
            // txtFormulaMod
            // 
            this.txtFormulaMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormulaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormulaMod.Location = new System.Drawing.Point(158, 78);
            this.txtFormulaMod.Name = "txtFormulaMod";
            this.txtFormulaMod.Size = new System.Drawing.Size(160, 22);
            this.txtFormulaMod.TabIndex = 15;
            // 
            // txtNameMod
            // 
            this.txtNameMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameMod.Location = new System.Drawing.Point(158, 47);
            this.txtNameMod.Name = "txtNameMod";
            this.txtNameMod.Size = new System.Drawing.Size(160, 22);
            this.txtNameMod.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Formula:";
            // 
            // txtDensityMod
            // 
            this.txtDensityMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDensityMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDensityMod.Location = new System.Drawing.Point(158, 140);
            this.txtDensityMod.Name = "txtDensityMod";
            this.txtDensityMod.Size = new System.Drawing.Size(160, 22);
            this.txtDensityMod.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Molar mass:";
            // 
            // txtMolarMod
            // 
            this.txtMolarMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMolarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMolarMod.Location = new System.Drawing.Point(158, 109);
            this.txtMolarMod.Name = "txtMolarMod";
            this.txtMolarMod.Size = new System.Drawing.Size(160, 22);
            this.txtMolarMod.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Density:";
            // 
            // txtIdMod
            // 
            this.txtIdMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdMod.Enabled = false;
            this.txtIdMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMod.Location = new System.Drawing.Point(158, 16);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(160, 22);
            this.txtIdMod.TabIndex = 33;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 376);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.pnlMain.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.addFormTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblAtomicNumber;
        public System.Windows.Forms.TextBox txtFormula;
        public System.Windows.Forms.Label lblShortName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblAtomicWeight;
        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.Button btnCommit;
        public System.Windows.Forms.GroupBox gbData;
        public System.Windows.Forms.TextBox txtDensity;
        public System.Windows.Forms.Label lblDensity;
        public System.Windows.Forms.TextBox txtMolarMass;
        public System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.ListBox lstBox;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Button btnMinimize;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabControl addFormTabControl;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFormulaMod;
        public System.Windows.Forms.TextBox txtNameMod;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDensityMod;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMolarMod;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtIdMod;
    }
}