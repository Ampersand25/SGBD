namespace BrioseWindowsFormsApplication
{
    partial class BrioseMasterDetailForm
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
            this.codBriosaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codBriosaLbl = new System.Windows.Forms.Label();
            this.pretNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codCofetarieComboBox = new System.Windows.Forms.ComboBox();
            this.descriereInput = new System.Windows.Forms.TextBox();
            this.numeInput = new System.Windows.Forms.TextBox();
            this.codCofetarieLbl = new System.Windows.Forms.Label();
            this.pretLbl = new System.Windows.Forms.Label();
            this.descriereLbl = new System.Windows.Forms.Label();
            this.numeLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.modificareBtn = new System.Windows.Forms.Button();
            this.adaugareBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codBriosaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretNumericUpDown)).BeginInit();
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
            this.mainPanel.Controls.Add(this.codBriosaNumericUpDown);
            this.mainPanel.Controls.Add(this.codBriosaLbl);
            this.mainPanel.Controls.Add(this.pretNumericUpDown);
            this.mainPanel.Controls.Add(this.codCofetarieComboBox);
            this.mainPanel.Controls.Add(this.descriereInput);
            this.mainPanel.Controls.Add(this.numeInput);
            this.mainPanel.Controls.Add(this.codCofetarieLbl);
            this.mainPanel.Controls.Add(this.pretLbl);
            this.mainPanel.Controls.Add(this.descriereLbl);
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
            // codBriosaNumericUpDown
            // 
            this.codBriosaNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codBriosaNumericUpDown.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codBriosaNumericUpDown.Location = new System.Drawing.Point(352, 23);
            this.codBriosaNumericUpDown.Name = "codBriosaNumericUpDown";
            this.codBriosaNumericUpDown.Size = new System.Drawing.Size(264, 38);
            this.codBriosaNumericUpDown.TabIndex = 13;
            // 
            // codBriosaLbl
            // 
            this.codBriosaLbl.AutoSize = true;
            this.codBriosaLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codBriosaLbl.Location = new System.Drawing.Point(9, 23);
            this.codBriosaLbl.Name = "codBriosaLbl";
            this.codBriosaLbl.Size = new System.Drawing.Size(157, 30);
            this.codBriosaLbl.TabIndex = 12;
            this.codBriosaLbl.Text = "Cod briosa";
            // 
            // pretNumericUpDown
            // 
            this.pretNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pretNumericUpDown.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretNumericUpDown.Location = new System.Drawing.Point(352, 200);
            this.pretNumericUpDown.Name = "pretNumericUpDown";
            this.pretNumericUpDown.Size = new System.Drawing.Size(264, 38);
            this.pretNumericUpDown.TabIndex = 11;
            // 
            // codCofetarieComboBox
            // 
            this.codCofetarieComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codCofetarieComboBox.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codCofetarieComboBox.FormattingEnabled = true;
            this.codCofetarieComboBox.Location = new System.Drawing.Point(352, 257);
            this.codCofetarieComboBox.Name = "codCofetarieComboBox";
            this.codCofetarieComboBox.Size = new System.Drawing.Size(264, 38);
            this.codCofetarieComboBox.TabIndex = 10;
            // 
            // descriereInput
            // 
            this.descriereInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.descriereInput.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriereInput.Location = new System.Drawing.Point(352, 141);
            this.descriereInput.Name = "descriereInput";
            this.descriereInput.Size = new System.Drawing.Size(264, 38);
            this.descriereInput.TabIndex = 9;
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
            // codCofetarieLbl
            // 
            this.codCofetarieLbl.AutoSize = true;
            this.codCofetarieLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codCofetarieLbl.Location = new System.Drawing.Point(9, 261);
            this.codCofetarieLbl.Name = "codCofetarieLbl";
            this.codCofetarieLbl.Size = new System.Drawing.Size(198, 30);
            this.codCofetarieLbl.TabIndex = 7;
            this.codCofetarieLbl.Text = "Cod cofetarie";
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
            // descriereLbl
            // 
            this.descriereLbl.AutoSize = true;
            this.descriereLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriereLbl.Location = new System.Drawing.Point(9, 141);
            this.descriereLbl.Name = "descriereLbl";
            this.descriereLbl.Size = new System.Drawing.Size(148, 30);
            this.descriereLbl.TabIndex = 5;
            this.descriereLbl.Text = "Descriere";
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
            // BrioseMasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.childDataGridView);
            this.Controls.Add(this.parentDataGridView);
            this.Name = "BrioseMasterDetailForm";
            this.Text = "CofetariiBrioseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.BrioseMasterDetailWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codBriosaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label codCofetarieLbl;
        private System.Windows.Forms.Label pretLbl;
        private System.Windows.Forms.Label descriereLbl;
        private System.Windows.Forms.Label numeLbl;
        private System.Windows.Forms.ComboBox codCofetarieComboBox;
        private System.Windows.Forms.TextBox descriereInput;
        private System.Windows.Forms.TextBox numeInput;
        private System.Windows.Forms.NumericUpDown pretNumericUpDown;
        private System.Windows.Forms.NumericUpDown codBriosaNumericUpDown;
        private System.Windows.Forms.Label codBriosaLbl;
    }
}

