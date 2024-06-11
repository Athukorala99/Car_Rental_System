using System;
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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        public int id { get; set; }
        public string Cno { get; set; }

        public string CName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string CType
        {
            get { return lblType.Text; }
            set { lblType.Text = value; }
        }
        public string CPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public string CBrand
        {
            get { return lblBrand.Text; }
            set { lblBrand.Text = value; }
        }
        public Image CImage
        {
            get { return txtPic.Image; }
            set { txtPic.Image = value; }
        }
        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void txtPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }

        private void lblPName_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
