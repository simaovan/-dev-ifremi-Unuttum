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
    public partial class resetPassword : Form
    {
        string username = sendCode.to;

        public resetPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text==txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V6EK0QP\\SQLEXPRESS;Initial Catalog=SifremiUnuttum1;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[SifremiUnuttum] SET,> ,[password] = '"+txtResetPassVer.Text+"' WHERE username= '"+username+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarlıyla değiştirildi.");
            }
            else
            {
                MessageBox.Show("Yeni şifre ile yeni şifre tekrar aynı değil.");
            }
        }
    }
}
