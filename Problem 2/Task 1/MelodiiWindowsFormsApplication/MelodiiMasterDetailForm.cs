using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MelodiiWindowsFormsApplication
{
    public partial class MelodiiMasterDetailForm : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=Problema2;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";
        DataSet ds = new DataSet();

        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();

        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public MelodiiMasterDetailForm()
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

            durataTimePicker.Format = DateTimePickerFormat.Custom;
            durataTimePicker.CustomFormat = "mm:ss";
            durataTimePicker.Text = "00:00";

            this.Text = "Magazin virtual de melodii";
            this.Icon = new Icon("../../appIcon.ico");
            this.BackgroundImage = Image.FromFile("../../backgroundImage.jpg");
        }

        private void MelodiiMasterDetailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema2].[dbo].[Artisti];", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema2].[dbo].[Melodii];", conn);

                    parentAdapter.Fill(ds, "Artisti");
                    childAdapter.Fill(ds, "Melodii");

                    DataColumn parentColumn = ds.Tables["Artisti"].Columns["cod_artist"];
                    DataColumn childColumn = ds.Tables["Melodii"].Columns["cod_artist"];

                    DataRelation relation = new DataRelation("fk_cod_artist", parentColumn, childColumn);
                    ds.Relations.Add(relation);

                    parentBS.DataSource = ds.Tables["Artisti"];
                    parentDataGridView.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "fk_cod_artist";
                    childDataGridView.DataSource = childBS;

                    codArtistComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    SqlCommand selectCodArtistCommand = new SqlCommand("SELECT [cod_artist] FROM [Problema2].[dbo].[Artisti];", conn);
                    SqlDataReader reader = selectCodArtistCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            codArtistComboBox.Items.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();

                    codArtistComboBox.SelectedIndex = 0;

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

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO [Problema2].[dbo].[Melodii] " +
                        "([titlu], [an_lansare], [durata], [cod_artist]) " +
                        "VALUES (@titlu, @an_lansare, @durata, @cod_artist);", conn);
                    insertCommand.Parameters.AddWithValue("@titlu", titluInput.Text);
                    insertCommand.Parameters.AddWithValue("@an_lansare", anLansareNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@durata", durataTimePicker.Value);
                    insertCommand.Parameters.AddWithValue("@cod_artist", codArtistComboBox.Text);

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

                    SqlCommand updateCommand = new SqlCommand("UPDATE [Problema2].[dbo].[Melodii] SET [titlu]=@titlu, [an_lansare]=@an_lansare, [durata]=@durata, [cod_artist]=@cod_artist WHERE " +
                        "[cod_melodie]=@cod_melodie;", conn);
                    updateCommand.Parameters.AddWithValue("@titlu", titluInput.Text);
                    updateCommand.Parameters.AddWithValue("@an_lansare", anLansareNumericUpDown.Value);
                    updateCommand.Parameters.AddWithValue("@durata", durataTimePicker.Value);
                    updateCommand.Parameters.AddWithValue("@cod_artist", codArtistComboBox.Text);
                    updateCommand.Parameters.AddWithValue("@cod_melodie", codMelodieNumericUpDown.Value);

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
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti melodia cu id-ul #" + codMelodieNumericUpDown.Value + "?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM [Problema2].[dbo].[Melodii] WHERE [cod_melodie]=@cod_melodie;", conn);
                        deleteCommand.Parameters.AddWithValue("@cod_melodie", codMelodieNumericUpDown.Value);

                        int deleteRowCount = deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Delete Row Count: {0}", deleteRowCount);

                        if (deleteRowCount != 0)
                        {
                            MessageBox.Show("[-]Stergere realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshBtn.Focus();
                        }
                        else
                        {
                            MessageBox.Show("[!]Stergerea nu s-a putut realiza (nu exista o melodie cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            codMelodieNumericUpDown.Value = 0;
            titluInput.Text = "";
            anLansareNumericUpDown.Value = 0;
            durataTimePicker.Text = "00:00";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            clearControls();
            codArtistComboBox.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                ds = new DataSet();

                parentAdapter = new SqlDataAdapter();
                childAdapter = new SqlDataAdapter();

                parentBS = new BindingSource();
                childBS = new BindingSource();

                parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema2].[dbo].[Artisti];", conn);
                childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [Problema2].[dbo].[Melodii];", conn);

                parentAdapter.Fill(ds, "Artisti");
                childAdapter.Fill(ds, "Melodii");

                DataColumn parentColumn = ds.Tables["Artisti"].Columns["cod_artist"];
                DataColumn childColumn = ds.Tables["Melodii"].Columns["cod_artist"];

                DataRelation relation = new DataRelation("fk_cod_artist", parentColumn, childColumn);
                ds.Relations.Add(relation);

                parentBS.DataSource = ds.Tables["Artisti"];
                parentDataGridView.DataSource = parentBS;
                childBS.DataSource = parentBS;
                childBS.DataMember = "fk_cod_artist";
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

                int index = codArtistComboBox.FindString(parentDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                codArtistComboBox.SelectedIndex = index;
            }
        }

        private void childDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codMelodie;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out codMelodie);
                codMelodieNumericUpDown.Value = codMelodie;
                
                titluInput.Text = childDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                int anLansare;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[2].Value.ToString(), out anLansare);
                anLansareNumericUpDown.Value = anLansare;

                DateTime durata;
                DateTime.TryParse(childDataGridView.SelectedRows[0].Cells[3].Value.ToString(), out durata);
                durataTimePicker.Value = durata;
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