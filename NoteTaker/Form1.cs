using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class formJegyzet : Form
    {
        public formJegyzet()
        {
            InitializeComponent();
            tbDesign();
        }

        private void formJegyzet_Load(object sender, EventArgs e)
        {
            tbCim.Select();
            ListaF(sender, e);
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            SqlCommand parancs = new SqlCommand();

            parancs.Connection = kapcsolat;
            parancs.CommandText = @"INSERT INTO jegyzet VALUES (@Cím, @Jegyzet)";
            parancs.Parameters.AddWithValue("@Cím", tbCim.Text);
            parancs.Parameters.AddWithValue("@Jegyzet", tbJegyzet.Text);

            parancs.ExecuteNonQuery();
            kapcsolat.Close();

            tbCim.Text = "";
            tbJegyzet.Text = "";
            tbCim.Select();
            ListaF(sender, e);
            btnUjJegyzet.Enabled = true;
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            const string message = "Biztos törölni szeretnéd a jegyzeteket? A törlés után nincs lehetőség azok visszaállítására!";
            const string caption = "Figyelem!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string conn = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
                SqlConnection kapcsolat = new SqlConnection(conn);
                kapcsolat.Open();
                SqlCommand parancs = new SqlCommand();

                parancs.Connection = kapcsolat;
                parancs.CommandText = @"DELETE FROM jegyzet";
                parancs.ExecuteNonQuery();
                kapcsolat.Close();

                ListaF(sender, e);
                JegyzetekIndexTorles(sender, e);
                tbCim.Text = "";
                tbJegyzet.Text = "";
                tbCim.Select();
                btnUjJegyzet.Enabled = true;
            }
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            if (dgvAdatok != null && dgvAdatok.SelectedRows.Count > 0)
            {
                if (dgvAdatok.SelectedRows[0] != null)
                {
                    tbCim.Text = dgvAdatok.SelectedRows[0].Cells[1].Value.ToString();
                    tbJegyzet.Text = dgvAdatok.SelectedRows[0].Cells[2].Value.ToString();

                    string actCim = tbCim.Text;
                    string actJegyzet = tbJegyzet.Text;

                    string connT = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
                    SqlConnection kapcsolatT = new SqlConnection(connT);
                    kapcsolatT.Open();
                    SqlCommand parancsT = new SqlCommand();

                    parancsT.Connection = kapcsolatT;
                    parancsT.CommandText = @"DELETE FROM jegyzet WHERE Cím = @Cím AND Jegyzet = @Jegyzet";
                    parancsT.Parameters.AddWithValue("@Cím", actCim);
                    parancsT.Parameters.AddWithValue("@Jegyzet", actJegyzet);

                    parancsT.ExecuteNonQuery();
                    kapcsolatT.Close();

                    btnUjJegyzet.Enabled = false;
                }
            }
        }

        private void btnUjJegyzet_Click(object sender, EventArgs e)
        {
            tbCim.Text = "";
            tbJegyzet.Text = "";
            tbCim.Select();
        }

        private void dgvAdatok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    DataGridViewRow sor = dgvAdatok.Rows[e.RowIndex];
                    if (MessageBox.Show("Biztos törölni akarod ezt a jegyzetet?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string conn = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
                        SqlConnection kapcsolat = new SqlConnection(conn);
                        kapcsolat.Open();
                        string sql = @"DELETE FROM jegyzet WHERE ID=@ID";
                        SqlCommand parancs = new SqlCommand(sql, kapcsolat);

                        parancs.Parameters.AddWithValue("ID", sor.Cells["ID"].Value);
                        parancs.ExecuteReader();
                        kapcsolat.Close();
                        ListaF(sender, e);
                        tbCim.Text = "";
                        tbJegyzet.Text = "";
                    }
                }
            }
            catch (Exception adat)
            {
                MessageBox.Show(adat.Message);
            }
        }

        private void dgvAdatok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdatok != null && dgvAdatok.SelectedRows.Count > 0)
            {
                if (dgvAdatok.SelectedRows[0] != null)
                {
                    tbCim.Text = dgvAdatok.SelectedRows[0].Cells[1].Value.ToString();
                    tbJegyzet.Text = dgvAdatok.SelectedRows[0].Cells[2].Value.ToString();

                    string actCim = tbCim.Text;
                    string actJegyzet = tbJegyzet.Text;

                    string connT = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
                    SqlConnection kapcsolatT = new SqlConnection(connT);
                    kapcsolatT.Open();
                    SqlCommand parancsT = new SqlCommand();

                    parancsT.Connection = kapcsolatT;
                    parancsT.CommandText = @"DELETE FROM jegyzet WHERE Cím = @Cím AND Jegyzet = @Jegyzet";
                    parancsT.Parameters.AddWithValue("@Cím", actCim);
                    parancsT.Parameters.AddWithValue("@Jegyzet", actJegyzet);

                    parancsT.ExecuteNonQuery();
                    kapcsolatT.Close();

                    btnUjJegyzet.Enabled = false;
                }
            }
        }

        private void JegyzetekIndexTorles(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            SqlCommand parancs = new SqlCommand();

            parancs.Connection = kapcsolat;
            parancs.CommandText = @"DBCC CHECKIDENT('jegyzet',RESEED,0);";

            parancs.ExecuteNonQuery();
            kapcsolat.Close();
        }

        private void ListaF(object sender, EventArgs e)
        {
            dgvAdatok.Rows.Clear();
            try
            {
                string conn = @"Server=(localdb)\MSSQLLocalDB;Database=jegyzetek";
                SqlConnection kapcsolat = new SqlConnection(conn);
                kapcsolat.Open();
                string sql = @"SELECT ID, Cím, Jegyzet FROM jegyzet";
                SqlCommand parancs = new SqlCommand(sql, kapcsolat);
                SqlDataReader lekerdez = parancs.ExecuteReader();

                while (lekerdez.Read())
                {
                    dgvAdatok.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2], "Törlés");
                }
                kapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbDesign()
        {
            tbJegyzet.ForeColor = Color.Black;
            tbJegyzet.Font = new Font("Segoe UI", 11, FontStyle.Italic);
            tbCim.ForeColor = Color.Black;
            tbCim.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        }
    }
}
