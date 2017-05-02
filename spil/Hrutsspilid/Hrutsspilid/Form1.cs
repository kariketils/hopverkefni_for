using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hrutsspilid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSyna_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = imageList1[1];
            panel2.BackgroundImage = imageList1;
        }
    }
}
