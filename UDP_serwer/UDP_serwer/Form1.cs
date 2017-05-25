using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace UDP_serwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            int port = Convert.ToUInt16(my_port.Value);

            IPEndPoint zdalnyIP = new IPEndPoint(IPAddress.Any, 0); //akceptowanie dowolnego ip, 0 = brak filtrów

            try
            {
                UdpClient serwer = new UdpClient(port);
                Byte[] odczyt = serwer.Receive(ref zdalnyIP);
                string dane = Encoding.ASCII.GetString(odczyt);
                wiadomosc.Items.Add(dane);
                serwer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Błąd ");
            }
        }
    }
}
