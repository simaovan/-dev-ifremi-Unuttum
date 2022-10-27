using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SifremiUnuttum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6EK0QP\\SQLEXPRESS;Initial Catalog=SifremiUnuttum1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from SifremiUnuttum1 where username='" + txtUser.Text + "' and password '" + txtPassword.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Başarıyla giriş yapıldı.");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sendCode sc = new sendCode();
            this.Hide();
            sc.Show();

        }
    }
}
