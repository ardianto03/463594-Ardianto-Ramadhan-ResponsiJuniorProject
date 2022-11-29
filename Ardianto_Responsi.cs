using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace Ardianto_Responsi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "host=localhost;Port=2022;Username=ardianto;Password=123456;Database=Responsi 2";

        public DataTable tabel;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                
            }
            try
            {

            }
            catch
            {

            }


            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (r == null) {
                try
                {


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tbNamaKaryawan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDepKaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}