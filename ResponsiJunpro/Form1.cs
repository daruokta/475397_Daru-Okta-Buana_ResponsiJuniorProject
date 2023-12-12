using Npgsql;
using System.Data;
using System.Windows.Forms;
namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port5432;Username=postgres;Password=informatika;Database=ResponsiJunpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void Form1_load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}