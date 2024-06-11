using car_rental_system0100.insert;
using car_rental_system0100.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_system0100
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        static Main _obj;
        public static Main Instance
        {
            get { if (_obj == null) { _obj = new Main(); } return _obj; }
        }
        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new Dash());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AddControls(new DriverView());
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddControls(new VehicalView()); 
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddControls(new RentView());

        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddControls(new Dash());
        }
    }
}
