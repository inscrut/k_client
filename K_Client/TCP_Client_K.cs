using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_Client
{
    public static class TCP_Client_K
    {
        private static TcpClient client = null;
        private static NetworkStream stream = null;
        

        public static byte Conn(string _server, int _port)
        {
            try
            {
                client = new TcpClient(_server, _port);
            }
            catch(SocketException e)
            {
                MessageBox.Show(e.Message, "Ошибка сокета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x01;
            }
            catch
            {
                MessageBox.Show("Непредвиденная ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x01;
            }

            try
            {
                stream = client.GetStream();
            }
            catch
            {
                MessageBox.Show("Ошибка создания потока!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x01;
            }

            return 0x00;
        }

        public static byte Send(string _msg)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(_msg);

            try
            {
                stream.Write(data, 0, data.Length);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка аргумента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x01;
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка ввода-вывода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x01;
            }
            catch
            {
                MessageBox.Show("Непредвиденная ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x01;
            }

            return 0x00;
        }

        public static string Read()
        {
            String responseData = String.Empty;
            Byte[] data = new Byte[512];


            try
            {
                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            return responseData;
        }

        public static void Close()
        {
            try
            {
                stream.Close();
                client.Close();
            }
            catch { }
        }
    }
}
