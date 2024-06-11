using car_rental_system0100.Insert;
using System;
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

namespace car_rental_system0100.view
{
    public partial class RentView : Form
    {
        public RentView()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new RentList());
            /*RentList rl = new RentList();
            rl.Show();*/
            loadProductsFromDatabase();
        }

        private void RentView_Load(object sender, EventArgs e)
        {
            loadProductsFromDatabase();
        }
        private void loadProductsFromDatabase()
        {
            string qry = @"Select * From vehical where status = 'Avialable'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Byte[] imageArray = (byte[])row["pic"];
                    byte[] imageByteArray = imageArray;

                    
                    AddItems("0", row["vahicalno"].ToString(), Image.FromStream(new MemoryStream(imageArray)), row["brand"].ToString(), row["name"].ToString(), row["type"].ToString(), row["price"].ToString());
                }

            }
        }
        public void AddItems(string id, String vehicalno, Image pic, string Brand, string name, string type, string price)
        {
            var w = new ucProduct()
            {
                CName = name,
                Cno = vehicalno,
                CPrice = price,
                CBrand = Brand,
                CImage = pic,
                CType = type,
                id = Convert.ToInt32(id),

            };
            flowLayoutPanel1.Controls.Add(w);


            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                //MessageBox.Show(wdg.id.ToString()+ wdg.CName + wdg.Cno);
                //MainClass.nm = wdg.CName;
                RentAdd rd = new RentAdd();
                rd.lblName.Text = wdg.CName;
                rd.lblPrice.Text =wdg.CPrice;
                rd.lblType.Text = wdg.CType;
                rd.lblveno.Text = wdg.Cno;
                rd.lblBrand.Text = wdg.CBrand;
                rd.txtImg.Image = wdg.CImage;
                MainClass.BlurBackground(rd);


                //rd.Show();
                

                /*foreach (DataGridViewRow item in )
                {
                    if (Convert.ToInt32(item.Cells["dgvproid"].Value) == wdg.id)
                    {
                        item.Cells["dgvqty"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) * int.Parse(item.Cells["dgvPrice"].Value.ToString());

                        GrandTotal();
                        return;
                    }
                }
                guna2DataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GrandTotal();*/

            };
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.CName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }
    }
}
