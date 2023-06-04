namespace MelodiiWindowsFormsApplication
{
    partial class MelodiiMasterDetailForm
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
            this.durataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anLansareNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codMelodieNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codMelodieLbl = new System.Windows.Forms.Label();
            this.codArtistComboBox = new System.Windows.Forms.ComboBox();
            this.titluInput = new System.Windows.Forms.TextBox();
            this.codArtistLbl = new System.Windows.Forms.Label();
            this.durataLbl = new System.Windows.Forms.Label();
            this.anLansareLbl = new System.Windows.Forms.Label();
            this.titluLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.modificareBtn = new System.Windows.Forms.Button();
            this.adaugareBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anLansareNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codMelodieNumericUpDown)).BeginInit();
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
            this.mainPanel.Controls.Add(this.durataTimePicker);
            this.mainPanel.Controls.Add(this.anLansareNumericUpDown);
            this.mainPanel.Controls.Add(this.codMelodieNumericUpDown);
            this.mainPanel.Controls.Add(this.codMelodieLbl);
            this.mainPanel.Controls.Add(this.codArtistComboBox);
            this.mainPanel.Controls.Add(this.titluInput);
            this.mainPanel.Controls.Add(this.codArtistLbl);
            this.mainPanel.Controls.Add(this.durataLbl);
            this.mainPanel.Controls.Add(this.anLansareLbl);
            this.mainPanel.Controls.Add(this.titluLbl);
            this.mainPanel.Controls.Add(this.refreshBtn);
            this.mainPanel.Controls.Add(this.stergereBtn);
            this.mainPanel.Controls.Add(this.modificareBtn);
            this.mainPanel.Controls.Add(this.adaugareBtn);
            this.mainPanel.Location = new System.Drawing.Point(736, 314);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(630, 368);
            this.mainPanel.TabIndex = 2;
            // 
            // durataTimePicker
            // 
            this.durataTimePicker.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.durataTimePicker.Location = new System.Drawing.Point(352, 201);
            this.durataTimePicker.Name = "durataTimePicker";
            this.durataTimePicker.Size = new System.Drawing.Size(264, 38);
            this.durataTimePicker.TabIndex = 15;
            // 
            // anLansareNumericUpDown
            // 
            this.anLansareNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.anLansareNumericUpDown.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anLansareNumericUpDown.Location = new System.Drawing.Point(352, 141);
            this.anLansareNumericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.anLansareNumericUpDown.Name = "anLansareNumericUpDown";
            this.anLansareNumericUpDown.Size = new System.Drawing.Size(264, 38);
            this.anLansareNumericUpDown.TabIndex = 14;
            // 
            // codMelodieNumericUpDown
            // 
            this.codMelodieNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codMelodieNumericUpDown.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codMelodieNumericUpDown.Location = new System.Drawing.Point(352, 23);
            this.codMelodieNumericUpDown.Name = "codMelodieNumericUpDown";
            this.codMelodieNumericUpDown.Size = new System.Drawing.Size(264, 38);
            this.codMelodieNumericUpDown.TabIndex = 13;
            // 
            // codMelodieLbl
            // 
            this.codMelodieLbl.AutoSize = true;
            this.codMelodieLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codMelodieLbl.Location = new System.Drawing.Point(9, 23);
            this.codMelodieLbl.Name = "codMelodieLbl";
            this.codMelodieLbl.Size = new System.Drawing.Size(175, 30);
            this.codMelodieLbl.TabIndex = 12;
            this.codMelodieLbl.Text = "Cod melodie";
            // 
            // codArtistComboBox
            // 
            this.codArtistComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.codArtistComboBox.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codArtistComboBox.FormattingEnabled = true;
            this.codArtistComboBox.Location = new System.Drawing.Point(352, 261);
            this.codArtistComboBox.Name = "codArtistComboBox";
            this.codArtistComboBox.Size = new System.Drawing.Size(264, 38);
            this.codArtistComboBox.TabIndex = 10;
            // 
            // titluInput
            // 
            this.titluInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titluInput.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluInput.Location = new System.Drawing.Point(352, 81);
            this.titluInput.Name = "titluInput";
            this.titluInput.Size = new System.Drawing.Size(264, 38);
            this.titluInput.TabIndex = 8;
            // 
            // codArtistLbl
            // 
            this.codArtistLbl.AutoSize = true;
            this.codArtistLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codArtistLbl.Location = new System.Drawing.Point(9, 261);
            this.codArtistLbl.Name = "codArtistLbl";
            this.codArtistLbl.Size = new System.Drawing.Size(147, 30);
            this.codArtistLbl.TabIndex = 7;
            this.codArtistLbl.Text = "Cod artist";
            // 
            // durataLbl
            // 
            this.durataLbl.AutoSize = true;
            this.durataLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durataLbl.Location = new System.Drawing.Point(9, 201);
            this.durataLbl.Name = "durataLbl";
            this.durataLbl.Size = new System.Drawing.Size(109, 30);
            this.durataLbl.TabIndex = 6;
            this.durataLbl.Text = "Durata";
            // 
            // anLansareLbl
            // 
            this.anLansareLbl.AutoSize = true;
            this.anLansareLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anLansareLbl.Location = new System.Drawing.Point(9, 141);
            this.anLansareLbl.Name = "anLansareLbl";
            this.anLansareLbl.Size = new System.Drawing.Size(162, 30);
            this.anLansareLbl.TabIndex = 5;
            this.anLansareLbl.Text = "An lansare";
            // 
            // titluLbl
            // 
            this.titluLbl.AutoSize = true;
            this.titluLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluLbl.Location = new System.Drawing.Point(9, 81);
            this.titluLbl.Name = "titluLbl";
            this.titluLbl.Size = new System.Drawing.Size(72, 30);
            this.titluLbl.TabIndex = 4;
            this.titluLbl.Text = "Titlu";
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
            // MelodiiMasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.childDataGridView);
            this.Controls.Add(this.parentDataGridView);
            this.Name = "MelodiiMasterDetailForm";
            this.Text = "ArtistiMelodiiForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.MelodiiMasterDetailWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anLansareNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codMelodieNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label codArtistLbl;
        private System.Windows.Forms.Label durataLbl;
        private System.Windows.Forms.Label anLansareLbl;
        private System.Windows.Forms.Label titluLbl;
        private System.Windows.Forms.ComboBox codArtistComboBox;
        private System.Windows.Forms.TextBox titluInput;
        private System.Windows.Forms.NumericUpDown codMelodieNumericUpDown;
        private System.Windows.Forms.Label codMelodieLbl;
        private System.Windows.Forms.NumericUpDown anLansareNumericUpDown;
        private System.Windows.Forms.DateTimePicker durataTimePicker;
    }
}

