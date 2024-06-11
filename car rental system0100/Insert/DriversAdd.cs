using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_system0100.Insert
{
    public partial class DriversAdd : Form
    {
        public DriversAdd()
        {
            InitializeComponent();
        }
        string sta = "Avialable";
        public int id = 0;

        private void DriversAdd_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)//Insert
            {

                qry = "INSERT INTO cdrivers  Values (@lino , @name , @tel , @email , @status)";

            }
            else//Update
            {
                qry = "Update cdrivers Set (lino = @lino , name = @name, tel = @tel , email = @email , status = @status  where id = @id)";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@lino", txtlino.Text);
            ht.Add("@name", txtName.Text);
            ht.Add("@tel", txtTel.Text);
            ht.Add("@email", txtEmail.Text);
            ht.Add("@status", sta);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Driver Details Saved Successfully...");
                id = 0;
                txtlino.Text = "";
                txtName.Text = "";
                txtTel.Text = "";
                txtEmail.Text = "";
                txtName.PlaceholderText = "Name";
                txtlino.PlaceholderText = "Licens NO";
                txtTel.PlaceholderText = "Tel  Ex- 07xxxxxxxx";
                txtEmail.PlaceholderText = "email Ex- xxx@gmail.com";
                txtName.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtlino.Text = "";
            txtName.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtName.PlaceholderText = "Name";
            txtlino.PlaceholderText = "Licens NO";
            txtTel.PlaceholderText = "Tel  Ex- 07xxxxxxxx";
            txtEmail.PlaceholderText = "email Ex- xxx@gmail.com";
        }

        private void txtlino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
