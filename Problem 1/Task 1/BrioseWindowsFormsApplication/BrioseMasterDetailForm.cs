using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BrioseWindowsFormsApplication
{
    public partial class BrioseMasterDetailForm : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=Problema1;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";
        DataSet ds = new DataSet();

        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();

        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public BrioseMasterDetailForm()
        {
            InitializeComponent();

            parentDataGridView.MultiSelect = false;
            childDataGridView.MultiSelect = false;

            parentDataGridView.EnableHeadersVisualStyles = false;
            //parentDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(parentDataGridView.Font, FontStyle.Bold);

            childDataGridView.EnableHeadersVisualStyles = false;
            //childDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(childDataGridView.Font, FontStyle.Bold);

            parentDataGridView.RowsDefaultCellStyle.BackColor = Color.DarkOrange;
            parentDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;

            childDataGridView.RowsDefaultCellStyle.BackColor = Color.PeachPuff;
            childDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;

            this.Text = "Magazin virtual de briose";
            this.Icon = new Icon("../../appIcon.ico");
            this.BackgroundImage = Image.FromFile("../../backgroundImage.jpg");
        }

        private void BrioseMasterDetailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema1].[dbo].[Cofetarii];", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema1].[dbo].[Briose];", conn);

                    parentAdapter.Fill(ds, "Cofetarii");
                    childAdapter.Fill(ds, "Briose");

                    DataColumn parentColumn = ds.Tables["Cofetarii"].Columns["cod_cofetarie"];
                    DataColumn childColumn = ds.Tables["Briose"].Columns["cod_cofetarie"];

                    DataRelation relation = new DataRelation("fk_cod_cofetarie", parentColumn, childColumn);
                    ds.Relations.Add(relation);

                    parentBS.DataSource = ds.Tables["Cofetarii"];
                    parentDataGridView.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "fk_cod_cofetarie";
                    childDataGridView.DataSource = childBS;

                    codCofetarieComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    SqlCommand selectCodCofetarieCommand = new SqlCommand("SELECT [cod_cofetarie] FROM [Problema1].[dbo].[Cofetarii];", conn);
                    SqlDataReader reader = selectCodCofetarieCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            codCofetarieComboBox.Items.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();

                    codCofetarieComboBox.SelectedIndex = 0;

                    childDataGridView.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adaugareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO [Problema1].[dbo].[Briose] " +
                        "([nume_briosa], [descriere], [pret], [cod_cofetarie]) " +
                        "VALUES (@nume_briosa, @descriere, @pret, @cod_cofetarie);", conn);
                    insertCommand.Parameters.AddWithValue("@nume_briosa", numeInput.Text);
                    insertCommand.Parameters.AddWithValue("@descriere", descriereInput.Text);
                    insertCommand.Parameters.AddWithValue("@pret", pretNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@cod_cofetarie", codCofetarieComboBox.Text);

                    int insertRowCount = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Insert Row Count: {0}", insertRowCount);

                    if (insertRowCount != 0)
                    {
                        MessageBox.Show("[+]Adaugare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Adaugarea nu s-a putut realiza!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand updateCommand = new SqlCommand("UPDATE [Problema1].[dbo].[Briose] SET [nume_briosa]=@nume_briosa, [descriere]=@descriere, [pret]=@pret, [cod_cofetarie]=@cod_cofetarie WHERE " +
                        "[cod_briosa]=@cod_briosa;", conn);
                    updateCommand.Parameters.AddWithValue("@nume_briosa", numeInput.Text);
                    updateCommand.Parameters.AddWithValue("@descriere", descriereInput.Text);
                    updateCommand.Parameters.AddWithValue("@pret", pretNumericUpDown.Value);
                    updateCommand.Parameters.AddWithValue("@cod_cofetarie", codCofetarieComboBox.Text);
                    updateCommand.Parameters.AddWithValue("@cod_briosa", codBriosaNumericUpDown.Value);

                    int updateRowCount = updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Update Row Count: {0}", updateRowCount);

                    if (updateRowCount != 0)
                    {
                        MessageBox.Show("[&]Modificare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Modificarea nu s-a putut realiza (nu exista o briosa cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stergereBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti briosa cu id-ul #" + codBriosaNumericUpDown.Value + "?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM [Problema1].[dbo].[Briose] WHERE [cod_briosa]=@cod_briosa;", conn);
                        deleteCommand.Parameters.AddWithValue("@cod_briosa", codBriosaNumericUpDown.Value);

                        int deleteRowCount = deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Delete Row Count: {0}", deleteRowCount);

                        if (deleteRowCount != 0)
                        {
                            MessageBox.Show("[-]Stergere realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshBtn.Focus();
                        }
                        else
                        {
                            MessageBox.Show("[!]Stergerea nu s-a putut realiza (nu exista o briosa cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearControls()
        {
            codBriosaNumericUpDown.Value = 0;
            numeInput.Text = "";
            descriereInput.Text = "";
            pretNumericUpDown.Value = 0;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            clearControls();
            codCofetarieComboBox.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                ds = new DataSet();

                parentAdapter = new SqlDataAdapter();
                childAdapter = new SqlDataAdapter();

                parentBS = new BindingSource();
                childBS = new BindingSource();

                parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema1].[dbo].[Cofetarii];", conn);
                childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema1].[dbo].[Briose];", conn);

                parentAdapter.Fill(ds, "Cofetarii");
                childAdapter.Fill(ds, "Briose");

                DataColumn parentColumn = ds.Tables["Cofetarii"].Columns["cod_cofetarie"];
                DataColumn childColumn = ds.Tables["Briose"].Columns["cod_cofetarie"];

                DataRelation relation = new DataRelation("fk_cod_cofetarie", parentColumn, childColumn);
                ds.Relations.Add(relation);

                parentBS.DataSource = ds.Tables["Cofetarii"];
                parentDataGridView.DataSource = parentBS;
                childBS.DataSource = parentBS;
                childBS.DataMember = "fk_cod_cofetarie";
                childDataGridView.DataSource = childBS;

                childDataGridView.ClearSelection();
            }
        }

        private void parentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                childDataGridView.ClearSelection();

                clearControls();

                int index = codCofetarieComboBox.FindString(parentDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                codCofetarieComboBox.SelectedIndex = index;
            }
        }

        private void childDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codBriosa;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out codBriosa);
                codBriosaNumericUpDown.Value = codBriosa;
                
                numeInput.Text = childDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                
                descriereInput.Text = childDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                
                decimal pretBriosa;
                decimal.TryParse(childDataGridView.SelectedRows[0].Cells[3].Value.ToString(), out pretBriosa);
                pretNumericUpDown.Value = pretBriosa;
            }
        }

        private void MasterDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a confirmation prompt to the user
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }
    }
}