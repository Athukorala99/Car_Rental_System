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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = MainClass.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            lblPrice.Text = "Price";
            try
            {
                MainClass.con.Open();
                String qry = "Select * From vehical where vahicalno = '" + lblvnum.Text + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, MainClass.con);
                da.Fill(dt);
                da.SelectCommand.ExecuteNonQuery();

                foreach (DataRow dr in dt.Rows)
                {
                    lblPrice.Text = dr["price"].ToString();
                }
                return;
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show("Error insert data" + ex);
            }
            finally
            {
                MainClass.con.Close();
            }

            DateTime rd = Convert.ToDateTime(lblrentdate.Text);
            DateTime nd = DateTime.Now;

            TimeSpan duration = nd - rd;
            double dif = duration.TotalDays;
            int dif1 = Convert.ToInt32(dif) + 2;
            int cal = (((Convert.ToInt32(lblPrice.Text))*dif1) -(Convert.ToInt32(lbladvanced.Text)) );
            lblAmount.Text = cal.ToString();
        }

        private void lblvnum_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {
            DateTime rd = Convert.ToDateTime(lblrentdate.Text);
            DateTime nd = DateTime.Now;

            TimeSpan duration = nd - rd;
            double dif = duration.TotalDays;
            int dif1 = Convert.ToInt32(dif) +1;
           // guna2MessageDialog1.Show(dif1.ToString());
            int cal = (((Convert.ToInt32(lblPrice.Text)) * dif1) - (Convert.ToInt32(lbladvanced.Text)));
            lblAmount.Text = cal.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string stat = "Avialable";

            string qry = "Delete From rents where vnum = '" + lblvnum.Text + "'";
            Hashtable ht = new Hashtable();
            MainClass.SQl(qry,ht);

            string qry1 = "Update cdrivers set status = '"+stat+"' Where lino = '"+lbldlino.Text+"'";
            Hashtable ht1 = new Hashtable(); 
            MainClass.SQl(qry1, ht1); 
            
            string qry2 = "Update vehical set status = '"+stat+"' Where vahicalno = '"+lblvnum.Text+"'";
            Hashtable ht2 = new Hashtable();
            MainClass.SQl(qry2, ht2);

            this.Hide();
        }
    }
}
