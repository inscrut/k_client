using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_Client
{
    public partial class Form2 : Form
    {
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
