using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flapbirds
{
    public partial class gamestart : Form
    {
        public gamestart()
        {
            InitializeComponent();
        }
        private void btnbasla_Click_1(object sender, EventArgs e)
        {
            game frmoyun = new game(this);
            frmoyun.Show();
        }
    }
}
