using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using PacketDotNet;
using SharpPcap;
using SharpPcap.WinPcap;
using System.Threading;
using System.Windows.Forms;
delegate void pysäytä_uudelleen_ohjaus();
namespace ARP_spoofer_with_port_forwarding
{
    public partial class Form1 : Form
    {
        Thread packet_listener;

        PhysicalAddress ohjattava_mac;
        IPAddress ohjattava_ip;
        PhysicalAddress kuunneltatava_mac;
        IPAddress kuunneltava_ip;
        bool mode = false;

        port_forwarder forwarder;
        WinPcapDeviceList laitelista = WinPcapDeviceList.Instance;
        
        public Form1()
        {
            InitializeComponent();

           
        }


        


        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach(WinPcapDevice laite in laitelista)
            {

                kuuntelu_laitteet.Items.Add(laite.Name);



            }
           

            
        }

        public  void add_text(string text)
        {
            Received_and_forwarded.Items.Add(text);
            
            if(autoscroll.Checked == true)
            {
                Received_and_forwarded.TopIndex = Received_and_forwarded.Items.Count - 1;
            }

        }







        private void Kuuntelu_laitteet_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            laitelista[kuuntelu_laitteet.SelectedIndex].Open();
            Received_and_forwarded.Items.Add(laitelista[kuuntelu_laitteet.SelectedIndex].Interface);
            if (mode==true)
            {
                forwarder.Capture_stop();
                button1.Text = "start";
                mode = false;
                packet_listener = null;
                forwarder = null;

            }

            laitelista[kuuntelu_laitteet.SelectedIndex].Close();

        }







        private void button1_Click(object sender, EventArgs e)
        {

            

            if (mode==true)
            {
                
                button1.Text = "start";
                mode = false;
                forwarder.Capture_stop();
                packet_listener = null;
                forwarder = null;



            }
            else
            {
                if(check_addresses(ohjattava_mac_text.Text,ohjattava_ip_text.Text,kuunneltava_mac_text.Text)==true)
                {


                    forwarder = new port_forwarder(ohjattava_mac,ohjattava_ip,kuunneltatava_mac,laitelista[kuuntelu_laitteet.SelectedIndex],Received_and_forwarded);
                    packet_listener = new Thread(forwarder.Capture_start);
                    packet_listener.Start();
                    
                    button1.Text = "stop";
                    mode = true;

                }
               

            }
        }



        bool check_addresses(string ohjattava_mac,string ohjattava_ip, string kuunneltatava_mac )
        {
           

            if (IPAddress.TryParse(ohjattava_ip,out this.ohjattava_ip))
            {


                if (kuunneltatava_mac.Length == 12 && ohjattava_mac.Length == 12)
                {

                    this.ohjattava_mac = PhysicalAddress.Parse(ohjattava_mac.ToUpper());
                    this.kuunneltatava_mac = PhysicalAddress.Parse(kuunneltatava_mac.ToUpper());
                    return true;
                }else
                {
                    MessageBox.Show("väärät mac osoitteet!");
                    return false;
                }





            }else
            {

                MessageBox.Show("väärät ip osoitteet!");
                return false;
            }



        }





    }
   
}
