namespace BiscuitiWindowsFormsApplication
{
    partial class BiscuitiMasterDetailForm
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
            this.parentDataGridView = new System.Windows.Forms.DataGridView();
            this.childDataGridView = new System.Windows.Forms.DataGridView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.numarCaloriiNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codBiscuiteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codBiscuiteLbl = new System.Windows.Forms.Label();
            this.codProducatorComboBox = new System.Windows.Forms.ComboBox();
            this.numeInput = new System.Windows.Forms.TextBox();
            this.codProducatorLbl = new System.Windows.Forms.Label();
            this.pretLbl = new System.Windows.Forms.Label();
            this.numarCaloriiLbl = new System.Windows.Forms.Label();
            this.numeLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.modificareBtn = new System.Windows.Forms.Button();
            this.adaugareBtn = new System.Windows.Forms.Button();
            this.pretInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numarCaloriiNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codBiscuiteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // parentDataGridView
            // 
            this.parentDataGridView.AllowUserToAddRows = false;
            this.parentDataGridView.AllowUserToDeleteRows = false;
            this.parentDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.parentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Orbitron ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.parentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.parentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.parentDataGridView.GridColor = System.Drawing.Color.DarkOrange;
            this.parentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.parentDataGridView.Name = "parentDataGridView";
            this.parentDataGridView.ReadOnly = true;
            this.parentDataGridView.RowHeadersWidth = 62;
            this.parentDataGridView.RowTemplate.Height = 28;
            this.parentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parentDataGridView.Size = new System.Drawing.Size(1354, 269);
            this.parentDataGridView.TabIndex = 0;
            this.parentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentDataGridView_CellClick);
            // 
            // childDataGridView
            // 
            this.childDataGridView.AllowUserToAddRows = false;
            this.childDataGridView.AllowUserToDeleteRows = false;
            this.childDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.childDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.childDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Orbitron ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.childDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.childDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.childDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.childDataGridView.GridColor = System.Drawing.Color.DarkOrange;
            this.childDataGridView.Location = new System.Drawing.Point(12, 314);
            this.childDataGridView.Name = "childDataGridView";
            this.childDataGridView.ReadOnly = true;
            this.childDataGridView.RowHeadersWidth = 62;
            this.childDataGridView.RowTemplate.Height = 28;
            this.childDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.childDataGridView.Size = new System.Drawing.Size(684, 368);
            this.childDataGridView.TabIndex = 1;
            this.childDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childDataGridView_CellClick);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.mainPanel.Controls.Add(this.pretInput);
            this.mainPanel.Controls.Add(this.numarCaloriiNumericUpDown);
            this.mainPanel.Controls.Add(this.codBiscuiteNumericUpDown);
            this.mainPanel.Controls.Add(this.codBiscuiteLbl);
            this.mainPanel.Controls.Add(this.codProducatorComboBox);
            this.mainPanel.Controls.Add(this.numeInput);
            this.mainPanel.Controls.Add(this.codProducatorLbl);
            this.mainPanel.Controls.Add(this.pretLbl);
            this.mainPanel.Controls.Add(this.numarCaloriiLbl);
            this.mainPanel.Controls.Add(this.numeLbl);
            this.mainPanel.Controls.Add(this.refreshBtn);
            this.mainPanel.Controls.Add(this.stergereBtn);
            this.mainPanel.Controls.Add(this.modificareBtn);
            this.mainPanel.Controls.Add(this.adaugareBtn);
            this.mainPanel.Location = new System.Drawing.Point(736, 314);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(630, 368);
            this.mainPanel.TabIndex = 2;
            // 
            // numarCaloriiNumericUpDown
            // 
            this.numarCaloriiNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numarCaloriiNumericUpDown.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarCaloriiNumericUpDown.Location = new System.Drawing.Point(352, 141);
            this.numarCaloriiNumericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numarCaloriiNumericUpDown.Name = "numarCaloriiNumericUpDown";
            this.numarCaloriiNumericUpDown.Size = new System.Drawing.Size(264, 38);
            this.numarCaloriiNumericUpDown.TabIndex = 14;
            // 
            // codBiscuiteNumericUpDown
            // 
            this.codBiscuiteNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codBiscuiteNumericUpDown.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codBiscuiteNumericUpDown.Location = new System.Drawing.Point(352, 23);
            this.codBiscuiteNumericUpDown.Name = "codBiscuiteNumericUpDown";
            this.codBiscuiteNumericUpDown.Size = new System.Drawing.Size(264, 38);
            this.codBiscuiteNumericUpDown.TabIndex = 13;
            // 
            // codBiscuiteLbl
            // 
            this.codBiscuiteLbl.AutoSize = true;
            this.codBiscuiteLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codBiscuiteLbl.Location = new System.Drawing.Point(9, 23);
            this.codBiscuiteLbl.Name = "codBiscuiteLbl";
            this.codBiscuiteLbl.Size = new System.Drawing.Size(178, 30);
            this.codBiscuiteLbl.TabIndex = 12;
            this.codBiscuiteLbl.Text = "Cod biscuite";
            // 
            // codProducatorComboBox
            // 
            this.codProducatorComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codProducatorComboBox.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProducatorComboBox.FormattingEnabled = true;
            this.codProducatorComboBox.Location = new System.Drawing.Point(352, 261);
            this.codProducatorComboBox.Name = "codProducatorComboBox";
            this.codProducatorComboBox.Size = new System.Drawing.Size(264, 38);
            this.codProducatorComboBox.TabIndex = 10;
            // 
            // numeInput
            // 
            this.numeInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numeInput.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeInput.Location = new System.Drawing.Point(352, 81);
            this.numeInput.Name = "numeInput";
            this.numeInput.Size = new System.Drawing.Size(264, 38);
            this.numeInput.TabIndex = 8;
            // 
            // codProducatorLbl
            // 
            this.codProducatorLbl.AutoSize = true;
            this.codProducatorLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProducatorLbl.Location = new System.Drawing.Point(9, 261);
            this.codProducatorLbl.Name = "codProducatorLbl";
            this.codProducatorLbl.Size = new System.Drawing.Size(226, 30);
            this.codProducatorLbl.TabIndex = 7;
            this.codProducatorLbl.Text = "Cod producator";
            // 
            // pretLbl
            // 
            this.pretLbl.AutoSize = true;
            this.pretLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretLbl.Location = new System.Drawing.Point(9, 201);
            this.pretLbl.Name = "pretLbl";
            this.pretLbl.Size = new System.Drawing.Size(73, 30);
            this.pretLbl.TabIndex = 6;
            this.pretLbl.Text = "Pret";
            // 
            // numarCaloriiLbl
            // 
            this.numarCaloriiLbl.AutoSize = true;
            this.numarCaloriiLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarCaloriiLbl.Location = new System.Drawing.Point(9, 141);
            this.numarCaloriiLbl.Name = "numarCaloriiLbl";
            this.numarCaloriiLbl.Size = new System.Drawing.Size(140, 30);
            this.numarCaloriiLbl.TabIndex = 5;
            this.numarCaloriiLbl.Text = "Nr. calorii";
            // 
            // numeLbl
            // 
            this.numeLbl.AutoSize = true;
            this.numeLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLbl.Location = new System.Drawing.Point(9, 81);
            this.numeLbl.Name = "numeLbl";
            this.numeLbl.Size = new System.Drawing.Size(89, 30);
            this.numeLbl.TabIndex = 4;
            this.numeLbl.Text = "Nume";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(489, 311);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(138, 54);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stergereBtn
            // 
            this.stergereBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.stergereBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stergereBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergereBtn.Location = new System.Drawing.Point(319, 311);
            this.stergereBtn.Name = "stergereBtn";
            this.stergereBtn.Size = new System.Drawing.Size(164, 54);
            this.stergereBtn.TabIndex = 2;
            this.stergereBtn.Text = "Stergere";
            this.stergereBtn.UseVisualStyleBackColor = false;
            this.stergereBtn.Click += new System.EventHandler(this.stergereBtn_Click);
            // 
            // modificareBtn
            // 
            this.modificareBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.modificareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificareBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificareBtn.Location = new System.Drawing.Point(163, 311);
            this.modificareBtn.Name = "modificareBtn";
            this.modificareBtn.Size = new System.Drawing.Size(150, 54);
            this.modificareBtn.TabIndex = 1;
            this.modificareBtn.Text = "Modificare";
            this.modificareBtn.UseVisualStyleBackColor = false;
            this.modificareBtn.Click += new System.EventHandler(this.modificareBtn_Click);
            // 
            // adaugareBtn
            // 
            this.adaugareBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.adaugareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adaugareBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugareBtn.Location = new System.Drawing.Point(6, 311);
            this.adaugareBtn.Name = "adaugareBtn";
            this.adaugareBtn.Size = new System.Drawing.Size(151, 54);
            this.adaugareBtn.TabIndex = 0;
            this.adaugareBtn.Text = "Adaugare";
            this.adaugareBtn.UseVisualStyleBackColor = false;
            this.adaugareBtn.Click += new System.EventHandler(this.adaugareBtn_Click);
            // 
            // pretInput
            // 
            this.pretInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pretInput.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretInput.Location = new System.Drawing.Point(352, 201);
            this.pretInput.Name = "pretInput";
            this.pretInput.Size = new System.Drawing.Size(264, 38);
            this.pretInput.TabIndex = 15;
            // 
            // BiscuitiMasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.childDataGridView);
            this.Controls.Add(this.parentDataGridView);
            this.Name = "BiscuitiMasterDetailForm";
            this.Text = "ProducatoriBiscuitiForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.BiscuitiMasterDetailWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numarCaloriiNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codBiscuiteNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentDataGridView;
        private System.Windows.Forms.DataGridView childDataGridView;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button stergereBtn;
        private System.Windows.Forms.Button modificareBtn;
        private System.Windows.Forms.Button adaugareBtn;
        private System.Windows.Forms.Label codProducatorLbl;
        private System.Windows.Forms.Label pretLbl;
        private System.Windows.Forms.Label numarCaloriiLbl;
        private System.Windows.Forms.Label numeLbl;
        private System.Windows.Forms.ComboBox codProducatorComboBox;
        private System.Windows.Forms.TextBox numeInput;
        private System.Windows.Forms.NumericUpDown codBiscuiteNumericUpDown;
        private System.Windows.Forms.Label codBiscuiteLbl;
        private System.Windows.Forms.NumericUpDown numarCaloriiNumericUpDown;
        private System.Windows.Forms.TextBox pretInput;
    }
}

