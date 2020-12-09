using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace K_Client
{
    public partial class Form_Auth : Form
    {
        private static string e_mail = "";
        private static string _pass = "";

        private SHA256 mySHA256;

        public Form_Auth()
        {
            InitializeComponent();

            mySHA256 = SHA256.Create();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if(textBox_email.TextLength <= 0 || textBox_pass.TextLength <= 0)
            {
                //empty check
                MessageBox.Show("Введите e-mail и пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _pass = textBox_pass.Text;
            e_mail = textBox_email.Text;

            byte[] pass_sha = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(_pass));

            string sha = Convert.ToBase64String(pass_sha);

            //MessageBox.Show(sha, e_mail, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(TCP_Client_K.Conn("127.0.0.1", 80) != 0x00)
            {
                MessageBox.Show("Не удалось подключиться к серверу", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Connected...

            TCP_Client_K.Send("LOGIN\r\n\r\n");

            if (TCP_Client_K.Read() != "OK\r\n\r\n")
            {
                MessageBox.Show("Неверный ответ сервера!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TCP_Client_K.Send(e_mail + "\r\n\r\n");
            TCP_Client_K.Send(sha + "\r\n\r\n");

            if (TCP_Client_K.Read() != "ACCEPT\r\n\r\n")
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
