using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SendARPRequest
{
    class Program
    {

        [System.Runtime.InteropServices.DllImport("Iphlpapi.dll", EntryPoint = "SendARP")]
        internal extern static Int32 SendArp(Int32 destIpAddress, Int32 srcIpAddress,
                     byte[] macAddress, ref Int32 macAddressLength);



        /*
         * 
         * 
         */
        static void Main(string[] pArgs)
        {
            Console.Clear();

            if (pArgs.Length != 1)
            {
                Console.WriteLine("Usage : {0} IP-Address", Application.ProductName);
                return;
            }


            try
            {
                String lClientMAC = GetMACFromNetworkComputer(IPAddress.Parse(pArgs[0]));
                Console.WriteLine("Client system with IP {0} has MAC {1}", pArgs[0], lClientMAC);
            }
            catch (Exception lEx)
            {
                Console.WriteLine("Error occurred : {0}", lEx.Message);
            }

        }



        /*
         * 
         * 
         */
        private static String GetMACFromNetworkComputer(IPAddress pIPAddress)
        {
            String lRetVal = String.Empty;
            Int32 lConvertedIPAddr = 0;
            byte[] lMACArray;
            int lByteArrayLen = 0;
            int lARPReply = 0;

            if (pIPAddress.AddressFamily != AddressFamily.InterNetwork)
                throw new ArgumentException("The remote system only supports IPv4 addresses");

            lConvertedIPAddr = ConvertIPToInt32(pIPAddress);
            lMACArray = new byte[6]; // 48 bit
            lByteArrayLen = lMACArray.Length;

            if ((lARPReply = SendArp(lConvertedIPAddr, 0, lMACArray, ref lByteArrayLen)) != 0)
                throw new Exception(String.Format("Error no. {0} occured while resolving MAC " +
                                                  " address of system {1}", lARPReply,
                                                  pIPAddress.ToString()));


            //return the MAC address in a PhysicalAddress format
            for (int i = 0; i < lMACArray.Length; i++)
            {
                lRetVal += String.Format("{0}", lMACArray[i].ToString("X2"));
                lRetVal += (i != lMACArray.Length - 1) ? "-" : "";
            } // for (in...

            return (lRetVal);
        }


        /*
         * 
         * 
         */
        private static Int32 ConvertIPToInt32(IPAddress pIPAddr)
        {
            byte[] lByteAddress = pIPAddr.GetAddressBytes();
            return BitConverter.ToInt32(lByteAddress, 0);
        }

    }
}
