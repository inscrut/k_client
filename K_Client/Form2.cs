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


            string[] substr = null; //10,718,user1,ru-RU, Hello, i am user1 in 718

            foreach (string str in _msgs)
            {
                substr = str.Split(',');
                textBox_messages.Text += substr[3] + " (" + substr[2] + ") >> ";
                
                if(substr.Length > 5)
                {
                    for(int i=4; i<substr.Length; i++)
                    {
                        if (i + 1 == substr.Length) textBox_messages.Text += substr[i];
                        else textBox_messages.Text += substr[i] + ",";
                    }
                    textBox_messages.Text += "\r\n";
                }
                else
                {
                    textBox_messages.Text += substr[4] + "\r\n";
                }                
            }
        }
    }
}
