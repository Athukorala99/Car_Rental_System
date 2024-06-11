using car_rental_system0100.Insert;
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

namespace car_rental_system0100.insert
{
    public partial class DriverView : Form
    {
        public DriverView()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new DriversAdd());
            /*DriversAdd da = new DriversAdd();
            da.Show();*/
            GetData();
        }
        public void GetData()
        {
            string qry = "Select * From cdrivers where lino like '%" + txtSearch.Text + "%'    ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvlno);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvtel);
            lb.Items.Add(dgvmail);
            lb.Items.Add(dgvstatus);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void DriverView_Load(object sender, EventArgs e)
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
                    string qry = "Delete From cdrivers where id = '" + id1 + "' ";
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
            DriversAdd da = new DriversAdd();

            String id1 = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);

            da.txtlino.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvlno"].Value);
            da.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
            da.txtTel.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvtel"].Value);
            da.txtEmail.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvmail"].Value); 


            string qry = "Delete From cdrivers where id = '" + id1 + "' ";
            Hashtable ht = new Hashtable();
            MainClass.SQl(qry, ht);
            MainClass.BlurBackground(da);
            GetData();
        }
    }
}
