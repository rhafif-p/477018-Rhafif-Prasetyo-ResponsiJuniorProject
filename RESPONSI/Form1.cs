using Microsoft.VisualBasic;
using Npgsql;
using System.Data;

namespace RESPONSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        string connstring = "Host=localhost;Port =5432;Username =postgres;Password=informatika;Database=responsi";
        public DataTable dt;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            load_data();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM insert_karyawan(:_name,:_dept_id)";
            int depart_id = dropdown_handle();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_name", txtName.Text);
            cmd.Parameters.AddWithValue("_dept_id", depart_id);
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data berhasil Ditambah", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load_data();
                r = null;
            }
            else
            {
                MessageBox.Show("Data Gagal di proses");
                conn.Close();
                load_data();
                r = null;

            }
        }

        private void load_data()
        {
            conn.Open();
            string sql = "select * FROM select_karyawan()";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgvData.DataSource = dt;
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM update_karyawan(:_id_k,:_name,:_id_dept)";
            int depart_id = dropdown_handle();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id_k", r.Cells["id"].Value);
            cmd.Parameters.AddWithValue("_name", txtName.Text);
            cmd.Parameters.AddWithValue("_id_dept", depart_id);
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data berhasil di edit", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load_data();
                r = null;
            }
            else
            {
                MessageBox.Show("Data Gagal di proses");
                conn.Close();
                load_data();
                r = null;

            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgvData.Rows[e.RowIndex];
            txtName.Text = r.Cells["name"].Value.ToString();
            deptCombo.Text = r.Cells["dept_name"].Value.ToString();



        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //MISSCLICK
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "Select * FROM delete_karyawan(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["id"].Value);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil Dihapus", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    load_data();
                    r = null;
                }
                else
                {
                    MessageBox.Show("Data Gagal di proses");
                    conn.Close();
                    load_data();
                    r = null;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Fail to Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sadada" + dropdown_handle());
        }

        private int dropdown_handle()
        {
            if (deptCombo.Text == "HR")
                return 1;
            if (deptCombo.Text == "Engineer")
                return 2;
            if (deptCombo.Text == "Developer")
                return 3;
            if (deptCombo.Text == "Product_M")
                return 4;
            if (deptCombo.Text == "Finance")
                return 5;
            else
                return 0;
        }
    }
}