using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_system0100.Insert
{
    public partial class VehicalAdd : Form
    {
        public VehicalAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        string filepath;
        Byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtImage.Image = new Bitmap(filepath);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        string sta = "Avialable";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)//Insert
            {
                
                qry = "INSERT INTO vehical  Values (@vahicalno , @pic , @brand , @name , @type , @price, @status)";

            }
            else//Update
            {
                qry = "Update vehical Set (vahicalno = @vahicalno , pic = @pic, brand = @brand , name = @name , type = @type , price = @price ,status = @status  where id = @id)";
            }

            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();


            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@vahicalno", txtvehicalno.Text);
            ht.Add("@pic", imageByteArray);
            ht.Add("@brand", cmbBrand.Text);
            ht.Add("@name", txtName.Text);
            ht.Add("@type", cmbType.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@status", sta);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully...");
                id = 0;
                txtvehicalno.Text = "";
                txtPrice.Text = "";
                txtName.Text = "";
                txtName.PlaceholderText = "Name";
                txtPrice.PlaceholderText = "Price";
                txtvehicalno.PlaceholderText = "Vehical Number";
                txtImage.Image = car_rental_system0100.Properties.Resources.vehical_search;
                txtName.Focus();
            }
        }
    }
}
