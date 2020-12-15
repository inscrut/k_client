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
            button_send.Click += Button_send_Click;
        }

        private void Button_send_Click(object sender, EventArgs e)
        {
            if(textBox_msg.TextLength <= 0)
            {
                MessageBox.Show("Необходимо ввести текст сообщения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TCP_Client_K.Send("SEND CHAT " + listBox_groups.SelectedItem.ToString() + " " + textBox_msg.Text + "\r\n\r\n");
            var res = TCP_Client_K.Read();
            if (res.Contains("OK"))
            {
                textBox_msg.Text = "";
                update_msgs();
            }
            else
            {
                MessageBox.Show("Произошла ошибка отправки сообщения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ListBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_msgs();
        }

        private void update_msgs()
        {
            textBox_messages.Text = "";
            TCP_Client_K.Send("GET MSG " + listBox_groups.SelectedItem.ToString() + "\r\n\r\n");
            var res = TCP_Client_K.Read();
            _msgs = res.Split(';').ToList();
            _msgs.Remove(""); //fix last empty obj

            foreach (var str in _msgs)
            {
                textBox_messages.Text += str + "\r\n";
            }
        }
    }
}
