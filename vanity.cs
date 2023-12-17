using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_page
{
    public partial class vanity : Form
    {
        public vanity()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            closet form = new closet();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Homepage form= new Homepage();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("item added to cart");
        }
    }
}
