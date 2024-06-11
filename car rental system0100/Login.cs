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

namespace car_rental_system0100
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand cmd;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MainClass.con.Open();
                cmd = new SqlCommand("SELECT * FROM users WHERE uid = '" + txtUID.Text + "' AND password = '" + txtPassword.Text + "'", MainClass.con);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MainClass.con.Close();
                    Main fmain = new Main();
                    fmain.Show();
                    this.Hide();
                }
                else
                {
                    guna2MessageDialog1.Show("Invalid Username or Password");
                    return;
                }
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show("Error in ligin process" + ex);
                return;
            }
            finally
            {
                MainClass.con.Close();
            }
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUID.Clear();
            //Application.Exit();
        }
    }
}
