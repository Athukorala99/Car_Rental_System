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

namespace car_rental_system0100.view
{
    public partial class RentList : Form
    {
        public RentList()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void GetData()
        {
            string qry = "Select * From rents where vnum like '%" + txtSearch.Text + "%'    ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvpic);
            lb.Items.Add(dgvvnum);
            lb.Items.Add(dgvvtype);
            lb.Items.Add(dgvvbrand);
            lb.Items.Add(dgvvname);
            lb.Items.Add(dgvcname);
            lb.Items.Add(dgvcnum);
            lb.Items.Add(dgvrentdate);
            lb.Items.Add(dgvredate);
            lb.Items.Add(dgvdlino);
            lb.Items.Add(dgvdnum);
            lb.Items.Add(dgvadvanced);
            lb.Items.Add(dgvtotal);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvreturn")//Return
            {
                Return rdv = new Return();

                String id1 = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                rdv.lblvnum.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvvnum"].Value);
                rdv.lblvname.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvvname"].Value);
                rdv.lblcname.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvcname"].Value);
                rdv.lblcnum.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvcnum"].Value);
                rdv.lblrentdate.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvrentdate"].Value);
                rdv.lbladvanced.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvadvanced"].Value);
                rdv.lbldlino.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvdlino"].Value);

                Byte[] img = (Byte[])guna2DataGridView1.CurrentRow.Cells["dgvpic"].Value;

                MemoryStream ms = new MemoryStream(img);
                rdv.imgpic.Image = Image.FromStream(ms);

                MainClass.BlurBackground(rdv);

            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RentList_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
