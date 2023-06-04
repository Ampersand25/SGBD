using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BiscuitiWindowsFormsApplication
{
    public partial class BiscuitiMasterDetailForm : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=Problema3;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";
        DataSet ds = new DataSet();

        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();

        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public BiscuitiMasterDetailForm()
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

            pretInput.Text = "0.00";

            this.Text = "Magazin virtual de biscuiti";
            this.Icon = new Icon("../../appIcon.ico");
            this.BackgroundImage = Image.FromFile("../../backgroundImage.jpg");
        }

        private void BiscuitiMasterDetailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema3].[dbo].[Producatori];", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema3].[dbo].[Biscuiti];", conn);

                    parentAdapter.Fill(ds, "Producatori");
                    childAdapter.Fill(ds, "Biscuiti");

                    DataColumn parentColumn = ds.Tables["Producatori"].Columns["cod_p"];
                    DataColumn childColumn = ds.Tables["Biscuiti"].Columns["cod_p"];

                    DataRelation relation = new DataRelation("fk_cod_p", parentColumn, childColumn);
                    ds.Relations.Add(relation);

                    parentBS.DataSource = ds.Tables["Producatori"];
                    parentDataGridView.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "fk_cod_p";
                    childDataGridView.DataSource = childBS;

                    codProducatorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    SqlCommand selectCodArtistCommand = new SqlCommand("SELECT [cod_p] FROM [Problema3].[dbo].[Producatori];", conn);
                    SqlDataReader reader = selectCodArtistCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            codProducatorComboBox.Items.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();

                    codProducatorComboBox.SelectedIndex = 0;

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

                    double pret;
                    double.TryParse(pretInput.Text, out pret);

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO [Problema3].[dbo].[Biscuiti] " +
                        "([nume_b], [nr_calorii], [pret], [cod_p]) " +
                        "VALUES (@nume_b, @nr_calorii, @pret, @cod_p);", conn);
                    insertCommand.Parameters.AddWithValue("@nume_b", numeInput.Text);
                    insertCommand.Parameters.AddWithValue("@nr_calorii", numarCaloriiNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@pret", pret);
                    insertCommand.Parameters.AddWithValue("@cod_p", codProducatorComboBox.Text);

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

                    double pret;
                    double.TryParse(pretInput.Text, out pret);

                    SqlCommand updateCommand = new SqlCommand("UPDATE [Problema3].[dbo].[Biscuiti] SET [nume_b]=@nume_b, [nr_calorii]=@nr_calorii, [pret]=@pret, [cod_p]=@cod_p WHERE " +
                        "[cod_b]=@cod_b;", conn);
                    updateCommand.Parameters.AddWithValue("@nume_b", numeInput.Text);
                    updateCommand.Parameters.AddWithValue("@nr_calorii", numarCaloriiNumericUpDown.Value);
                    updateCommand.Parameters.AddWithValue("@pret", pret);
                    updateCommand.Parameters.AddWithValue("@cod_p", codProducatorComboBox.Text);
                    updateCommand.Parameters.AddWithValue("@cod_b", codBiscuiteNumericUpDown.Value);

                    int updateRowCount = updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Update Row Count: {0}", updateRowCount);

                    if (updateRowCount != 0)
                    {
                        MessageBox.Show("[&]Modificare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Modificarea nu s-a putut realiza (nu exista o melodie cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti biscuitele cu id-ul #" + codBiscuiteNumericUpDown.Value + "?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM [Problema3].[dbo].[Biscuiti] WHERE [cod_b]=@cod_b;", conn);
                        deleteCommand.Parameters.AddWithValue("@cod_b", codBiscuiteNumericUpDown.Value);

                        int deleteRowCount = deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Delete Row Count: {0}", deleteRowCount);

                        if (deleteRowCount != 0)
                        {
                            MessageBox.Show("[-]Stergere realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshBtn.Focus();
                        }
                        else
                        {
                            MessageBox.Show("[!]Stergerea nu s-a putut realiza (nu exista un biscuite cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            codBiscuiteNumericUpDown.Value = 0;
            numeInput.Text = "";
            numarCaloriiNumericUpDown.Value = 0;
            pretInput.Text = "0.00";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            clearControls();
            codProducatorComboBox.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                ds = new DataSet();

                parentAdapter = new SqlDataAdapter();
                childAdapter = new SqlDataAdapter();

                parentBS = new BindingSource();
                childBS = new BindingSource();

                parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema3].[dbo].[Producatori];", conn);
                childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema3].[dbo].[Biscuiti];", conn);

                parentAdapter.Fill(ds, "Producatori");
                childAdapter.Fill(ds, "Biscuiti");

                DataColumn parentColumn = ds.Tables["Producatori"].Columns["cod_p"];
                DataColumn childColumn = ds.Tables["Biscuiti"].Columns["cod_p"];

                DataRelation relation = new DataRelation("fk_cod_p", parentColumn, childColumn);
                ds.Relations.Add(relation);

                parentBS.DataSource = ds.Tables["Producatori"];
                parentDataGridView.DataSource = parentBS;
                childBS.DataSource = parentBS;
                childBS.DataMember = "fk_cod_p";
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

                int index = codProducatorComboBox.FindString(parentDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                codProducatorComboBox.SelectedIndex = index;
            }
        }

        private void childDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codBiscuite;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out codBiscuite);
                codBiscuiteNumericUpDown.Value = codBiscuite;
                
                numeInput.Text = childDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                int nrCalorii;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[2].Value.ToString(), out nrCalorii);
                numarCaloriiNumericUpDown.Value = nrCalorii;

                double pret;
                double.TryParse(childDataGridView.SelectedRows[0].Cells[3].Value.ToString(), out pret);
                pretInput.Text = pret.ToString();
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