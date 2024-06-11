using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_system0100.view
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            DateTime nd = DateTime.Now;
            lblDate.Text = nd.ToString("yyyy , MM , dd"); 
            
            MainClass.con.Open();

            string qry1 = "Select Count(*) From vehical Where status = 'Avialable'";
            SqlCommand cmd1 = new SqlCommand(qry1,MainClass.con);
            lblvcount.Text = (cmd1.ExecuteScalar()).ToString();
            

            string qry2 = "Select Count(*) From cdrivers Where status = 'Avialable'";
            SqlCommand cmd2 = new SqlCommand(qry2,MainClass.con);
            lbldcount.Text = (cmd2.ExecuteScalar()).ToString();
            

            MainClass.con.Close();
        }
    }
}
