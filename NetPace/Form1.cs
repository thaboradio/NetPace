using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetPace
{
    public partial class NetPaceMain : Form
    {
        private NetworkInterface nic = null;
        public NetPaceMain()
        {
            InitializeComponent();

            GetAllInterfaces();
        }

        public void GetAllInterfaces()
        {
            IEnumerable<NetworkInterface> adapters = NetworkInterface.GetAllNetworkInterfaces()
                .Where(nicType => nicType.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);
            lstAdapters.DisplayMember = "Description";
            lstAdapters.ValueMember = "Id";
            foreach (var item in adapters)
            {
                //IPInterfaceProperties props = item.GetIPProperties();
                //IPv4InterfaceStatistics stats = item.GetIPv4Statistics();
                lstAdapters.Items.Add(item);

            }
            if (lstAdapters.Items.Count > 0)
                lstAdapters.SelectedIndex = 0;
        }

        private void lstAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstAdapters.SelectedItem is NetworkInterface)
                {

                    nic = lstAdapters.SelectedItem as NetworkInterface;
                    if (nic.Name.Contains("Local Area Connection"))
                    {
                        AdapterName.Text = "LAN";
                        AdapterStatus.Text = nic.OperationalStatus.ToString();
                        AdapterSpeed.Text = (nic.Speed / 1048576).ToString();
                    }
                    else
                    {
                        AdapterName.Text = nic.Name;
                        AdapterStatus.Text = nic.OperationalStatus.ToString();
                        AdapterSpeed.Text = (nic.Speed / 1048576).ToString() + " Mbps";
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
