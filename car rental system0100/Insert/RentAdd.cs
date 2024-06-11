using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_system0100.Insert
{
    public partial class RentAdd : Form
    {
        public RentAdd()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtImg_Click(object sender, EventArgs e)
        {

        }
        public int dID = 0;

        private void RentAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select lino 'name' from cdrivers where status = 'Avialable'";

            MainClass.CBFill(qry, cmbDriver);

            if (dID > 0)
            {
                cmbDriver.SelectedValue = dID;
            }

            DateTime dt = DateTime.Now;
            txtDate.Text = dt.ToString("yyyy , MM ,, dd");

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime rd = Convert.ToDateTime(txtDate.Text);

            TimeSpan duration = rd - dt;
            double dif = duration.TotalDays;
            int dif1 = Convert.ToInt32(dif) + 1;
            //guna2MessageDialog1.Show(dif1.ToString());
            int cal = dif1 * Convert.ToInt32(lblPrice.Text);
            lblTotal.Text = cal.ToString();
        }
        public int id = 0;
        Byte[] imageByteArray;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string stat = "Not Avialable";
            
            string qry1 = "UPDATE cdrivers set status = '" + stat + "' WHERE lino = '" + cmbDriver.Text + "' ";
            Hashtable ht1 = new Hashtable();
            MainClass.SQl(qry1,ht1);
            
            
            string qry2 = "UPDATE vehical set status = '" + stat + "' WHERE vahicalno = '" + lblveno.Text + "' ";
            Hashtable ht2 = new Hashtable();
            MainClass.SQl(qry2,ht2);
           


            string qry = "";
            DateTime nd = DateTime.Now;
            string dat = nd.ToString("yyyy , MM , dd");

            if (id == 0)//Insert
            {
                qry = "INSERT INTO rents  Values (@pic , @vnum , @vtype , @vbrand , @vname , @cname, @cnum , @rentdate , @redate , @dname , @dnum , @advanced , @total)";
            }
            else//Update
            {
                qry = "Update rents Set ( pic = @pic , vnum= @vnum , vtype = @vtype , vbrand = @vbrand , vname = @vname , cname = @cname , cnum = @cnum , rentdate = @rentdate , redate = @redate , dname = @dname , dnum = @dnum , advanced = @advanced , total = @total  where id = @id)";
            }

            Image temp = new Bitmap(txtImg.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();
           

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@pic", imageByteArray);
            ht.Add("@vnum", lblveno.Text);
            ht.Add("@vtype", lblType.Text);
            ht.Add("@vbrand", lblBrand.Text);
            ht.Add("@vname", lblName.Text);
            ht.Add("@cname", txtCName.Text);
            ht.Add("@cnum", txtCNumber.Text);
            ht.Add("@rentdate", dat);
            ht.Add("@redate", txtDate.Text);
            ht.Add("@dname", cmbDriver.Text);
            ht.Add("@dnum", lblTel.Text);
            ht.Add("@advanced", txtAdvanced.Text);
            ht.Add("@total", lblTotal.Text);

            
            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully...");
                id = 0;
                lblveno.Focus();
            }

            this.Hide();

        }


        private void cmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = MainClass.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            lblTel.Text = "Tel";
            try
            {
                MainClass.con.Open();
                String qry = "Select * From cdrivers where lino = '" + cmbDriver.Text + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, MainClass.con);
                da.Fill(dt);
                da.SelectCommand.ExecuteNonQuery();

                foreach (DataRow dr in dt.Rows)
                {
                    lblTel.Text = dr["tel"].ToString();
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
        }
    }
}
