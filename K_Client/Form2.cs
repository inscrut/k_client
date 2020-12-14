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
        private List<string> _chts = null;

        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form2()
        {
            InitializeComponent();

            //get chats
            TCP_Client_K.Send("GET CHATS\r\n\r\n");
            var res = TCP_Client_K.Read();
            _chts = res.Split(';').ToList();
            _chts.Remove("");

        }
    }
}
