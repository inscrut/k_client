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
        private List<string> _msgs = null;

        public void global_FormClosed(object sender, EventArgs e)
        {
            TCP_Client_K.Send("BYE\r\n\r\n");
            Application.Exit();
        }

        public Form2()
        {
            InitializeComponent();

            //get chats
            TCP_Client_K.Send("GET CHATS\r\n\r\n");
            var res = TCP_Client_K.Read();
            _chts = res.Split(';').ToList();
            _chts.Remove(""); //fix last empty obj

            listBox_groups.DataSource = _chts;

            listBox_groups.SelectedIndexChanged += ListBox_groups_SelectedIndexChanged;
        }

        private void ListBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_messages.Text = "";
            TCP_Client_K.Send("GET MSG " + listBox_groups.SelectedItem.ToString() + "\r\n\r\n");
            var res = TCP_Client_K.Read();
            _msgs = res.Split(';').ToList();
            _msgs.Remove(""); //fix last empty obj

            foreach(var str in _msgs)
            {
                textBox_messages.Text += str + "\r\n";
            }
        }
    }
}
