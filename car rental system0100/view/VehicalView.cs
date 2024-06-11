using car_rental_system0100.Insert;
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
    public partial class VehicalView : Form
    {
        public VehicalView()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new VehicalAdd());
            GetData();
            /*VehicalAdd va = new VehicalAdd();
            va.Show();*/
        }
        public void GetData()
        {
            string qry = "Select * From vehical where name like '%" + txtSearch.Text + "%'    ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvvehicalnum);
            lb.Items.Add(dgvpic);
            lb.Items.Add(dgvBrand);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvstatus);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void VehicalView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdelete")//Delete
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    String id1 = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete From vehical where id = '" + id1 + "' ";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;

                    guna2MessageDialog1.Show("Detete Successfull");
                    GetData();
                }
            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VehicalAdd va = new VehicalAdd();

            String id1 = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);

            va.txtvehicalno.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvvehicalnum"].Value);
            va.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
            va.txtPrice.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value);
            va.cmbBrand.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvBrand"].Value);
            va.cmbType.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvtype"].Value);

            Byte[] img = (Byte[])guna2DataGridView1.CurrentRow.Cells["dgvpic"].Value;

            MemoryStream ms = new MemoryStream(img);
            va.txtImage.Image = Image.FromStream(ms);

            string qry = "Delete From vehical where id = '" + id1 + "' ";
            Hashtable ht = new Hashtable();
            MainClass.SQl(qry, ht);
            MainClass.BlurBackground(va);
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
