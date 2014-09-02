using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;
using ComPort;
using MySql.Data.MySqlClient;

namespace WiPANFactory
{
    public partial class WiPANfactory : Form
    {
        /* NetworkStream that will be used */
        private static NetworkStream myStream;
        /* TcpClient that will connect for us */
        private static TcpClient myClient;
        /* Storage space */
        private static byte[] myBuffer;
        /* Application running flag */
        DBConnect dbConnect;

        public WiPANfactory()
        {
            InitializeComponent();
            //dbConnect = new DBConnect("127.0.0.1", "3306", "mac_address_db", "root", null);

            string password = null;
            if (Properties.Settings.Default.Password == "")
            {
                password = null;

            }
            else
            {
                password = Properties.Settings.Default.Password;
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button_Connect.Select();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            
            string password = null;
            if (Properties.Settings.Default.Password == "")
            {
                password = null;

            }
            else
            {
                password = Properties.Settings.Default.Password;
            }
            dbConnect = new DBConnect(Properties.Settings.Default.Server, Properties.Settings.Default.Port, Properties.Settings.Default.Database, Properties.Settings.Default.UID, password); //initialises new db connection


            String strServer = textBox_IP.Text;  //Console.ReadLine();
            String strPort = textBox_Port.Text;  //Console.ReadLine();

            /* Connecting to server (will crash if address/name is incorrect) */

            try
            {
                string checkResult = null;
                if (comboBox_product.Text == "WiPAN Coord")
                {
                    textBox_Inv.Text = "";

                    myClient = new TcpClient(strServer, Int32.Parse(strPort));


                    textBox3.Text = "connected"; //Console.WriteLine("Connected...");
                    /* Store the NetworkStream */
                    myStream = myClient.GetStream();
                    /* Create data buffer */
                    myBuffer = new byte[myClient.ReceiveBufferSize];

                    getINV();
                    checkResult = checkDBforUID();
                }
                checkMACstock();

                
                if (checkResult == null)
                {
                    getNewMac();
                }
                else
                {
                    textBox_MAC.Text = checkResult.ToUpper();
                }

                textBox_MacArp.Text = arpIP(textBox_IP.Text).ToUpper();

                if (textBox_MAC.Text != textBox_MacArp.Text)
                {
                    textBox_MacArp.BackColor = Color.Red;
                }
                else
                {
                    textBox_MacArp.BackColor = Color.White;
                }


            }
            catch (System.Net.Sockets.SocketException se)
            {
                richTextBox1.AppendText("connection failed");
                richTextBox1.AppendText("\n");
            }
            catch
            {
                richTextBox1.AppendText("connection failed");
                richTextBox1.AppendText("\n");
            }



        }
        private void sendMac_Click(object sender, EventArgs e)
        {


            updateDB();
            if (comboBox_product.Text == "WiPAN Coord")
            {

                sendMAC();
            }
        }
        private void disConnect_Click(object sender, EventArgs e)
        {
            //myStream.Flush();

            // myStream.Close(1000);
            //  myStream.Read(myBuffer, 0, myClient.ReceiveBufferSize);

            myStream.Dispose();
            myClient.Close();



            textBox3.Text = "disconnected";



        }
        private void resetBoard_Click(object sender, EventArgs e)
        {
            //tidListen.Abort();
            resetBoard();
            myStream.Close();
            myClient.Close();


            textBox3.Text = "disconnected";
        }
        private void sendStatIP_Click(object sender, EventArgs e)
        {
            sendIP();
        }
        private void sendDHCP_Click(object sender, EventArgs e)
        {
            sendDHCP();
        }
        private void readDB_Click(object sender, EventArgs e)
        {
            DBView dbView = new DBView();
            dbView.Show();
        }
        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseSetup dbSetup = new DataBaseSetup();
            dbSetup.Show();

        }
        private void sendSubnet_Click(object sender, EventArgs e)
        {
            sendSubnetMask();
        }
        private void sendGateway_Click(object sender, EventArgs e)
        {
            sendGateWay();
        }
        private void sendPassword_Click(object sender, EventArgs e)
        {
            sendPassword();
        }

        public void resetBoard()
        {
            byte[] data2 = WipanCmd.resetBoard();
            /* Sending the data */
            try
            {
                myStream.Write(data2, 0, data2.Length);
            }
            catch
            {
                richTextBox1.AppendText("/n exception data not sent");
            }
        }

        public void sendMAC()
        {
            byte[] data2 = WipanCmd.sendMAC(textBox_MAC.Text);
            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
            richTextBox1.AppendText("mac sent");
        }

        public void sendIP()
        {
            byte[] data2 = WipanCmd.sendIP(textBox7.Text);
            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
            richTextBox1.AppendText("ip sent");
        }

        public void sendDHCP()
        {
            byte[] data2 = WipanCmd.sendDHCP(textBox8.Text);
            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
            richTextBox1.AppendText("DHCP sent");
        }

        public void sendSubnetMask()
        {
            byte[] data2 = WipanCmd.sendSubnetMask(textBox_Mask.Text);
            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
            richTextBox1.AppendText("sub Mask sent");
        }

        public void sendGateWay()
        {
            richTextBox1.AppendText("gateway sent");
            byte[] data2 = WipanCmd.sendGateway(textBox_Mask.Text);
            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
        }

        public void sendPassword()
        {
            byte[] data2 = WipanCmd.sendPassword(textBox_Password.Text);
            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
            richTextBox1.AppendText("Password sent");
        }

        public void openUDP()
        {
             byte[] data2 = WipanCmd.openUDP();

             myStream.Write(data2, 0, data2.Length);
        }

        public void closeUDP()
        {
            byte[] data2 = WipanCmd.closeUDP();
            myStream.Write(data2, 0, data2.Length);
        }

        public void sendTime()
        {
        }

        public void senddate()
        {
        }

        public void getINV()
        {
            byte[] data2 = WipanCmd.getINV();

            /* Sending the data */
            myStream.Write(data2, 0, data2.Length);
            richTextBox1.AppendText("get INV sent");

            //wait for reply with time out
            myStream.ReadTimeout = 1000;
            int lData = myStream.Read(myBuffer, 0, myClient.ReceiveBufferSize);
            textBox_Inv.Text = string.Format("{0:x}{1:x}{2:x}{3:x}{4:x}{5:x}{6:x}{7:x}{8:x}{9:x}{10:x}{11:x}", myBuffer[0], myBuffer[1], myBuffer[2], myBuffer[3], myBuffer[4], myBuffer[5], myBuffer[6], myBuffer[7], myBuffer[8], myBuffer[9], myBuffer[10], myBuffer[11]);

        }

        private string arpIP(string IP)
        {
            return GetMac.GetMacAddress(IP);
        }

        private void checkMACstock()
        {
            DataTable table = new DataTable();

            if (dbConnect.OpenConnection() == true)
            {
                string sql = string.Format("SELECT * FROM factory_setup.mac_table where Allocated = false");
                MySqlCommand command = new MySqlCommand(sql, dbConnect.connection);

                MySqlDataReader dataReader = command.ExecuteReader();
                // table.Load(command.ExecuteReader(), LoadOption.OverwriteChanges);
                table.Load(dataReader, LoadOption.OverwriteChanges);
                dbConnect.CloseConnection();

                int unallocated = table.Rows.Count;
                label11.Text = string.Format("Unallocated MACS = {0}", unallocated);
            }
            else // datbase connection not open
            {
                MessageBox.Show("Error , no database connection!");
            }
        }

        private void getNewMac()
        {

            //initialises new db connection


            DataTable table = new DataTable();

            if (dbConnect.OpenConnection() == true)
            {
                string sql = string.Format("select * from mac_table where Allocated = '0' limit 1"); // TagAdd);
                MySqlCommand command = new MySqlCommand(sql, dbConnect.connection);

                MySqlDataReader dataReader = command.ExecuteReader();
                // table.Load(command.ExecuteReader(), LoadOption.OverwriteChanges);
                table.Load(dataReader, LoadOption.OverwriteChanges);
                dbConnect.CloseConnection();

                foreach (DataRow i in table.Rows)
                {
                    //string macAddr = (string)i.ItemArray[0];

                    var macAddr = i.ItemArray[0];
                    textBox_MAC.Text = string.Format("{0:x}", macAddr).ToUpper();
                }

            }
            else // datbase connection not open
            {
                MessageBox.Show("Error , no database connection!");
            }
        }

        private string checkDBforUID()
        {
            DataTable table = new DataTable();

            if (dbConnect.OpenConnection() == true)
            {
                string sql = string.Format("select * from mac_table where STM32_UID = '{0}'", textBox_Inv.Text); // TagAdd);
                MySqlCommand command = new MySqlCommand(sql, dbConnect.connection);

                MySqlDataReader dataReader = command.ExecuteReader();
                // table.Load(command.ExecuteReader(), LoadOption.OverwriteChanges);
                table.Load(dataReader, LoadOption.OverwriteChanges);

                dbConnect.CloseConnection();

                if (table.Rows.Count > 0)
                { // in database

                    foreach (DataRow i in table.Rows)
                    {
                        //string macAddr = (string)i.ItemArray[0];

                        var macAddr = i.ItemArray[0];
                        return string.Format("{0:x}", macAddr);
                    }
                }
                else
                {
                    return null;
                }

                return null;

            }
            else // datbase connection not open
            {
                MessageBox.Show("Error , no database connection!");
                return null;
            }
        }

        private void updateDB()
        {
            DataTable table = new DataTable();
            Int64 intMac = Convert.ToInt64(textBox_MAC.Text, 16);

            if (dbConnect.OpenConnection() == true)
            {
                string sql = string.Format("UPDATE mac_table SET Allocated=true, STM32_UID = '{0}', use_devOrProduction = '{1}', Product_type = '{2}', Product_SN = '{3}', Date = (@value) WHERE MAC = {4}",
                                                                                    textBox_Inv.Text, comboBox_use.Text, comboBox_product.Text, textBox_SN.Text, intMac); // TagAdd);
                MySqlCommand command = new MySqlCommand(sql, dbConnect.connection);
                command.Parameters.AddWithValue("@value", DateTime.Now);
                command.ExecuteNonQuery();
                dbConnect.CloseConnection();

                //MySqlDataReader dataReader = command.ExecuteReader();
                // table.Load(command.ExecuteReader(), LoadOption.OverwriteChanges);
                // table.Load(dataReader, LoadOption.OverwriteChanges);



            }
            else // datbase connection not open
            {
                MessageBox.Show("Error , no database connection!");

            }

        }


        private void textBox_IP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Connect.Select();
            }
        }

        private void button_justGet_Click(object sender, EventArgs e)
        {
            textBox_Inv.Text = "";
            string password = null;
            if (Properties.Settings.Default.Password == "")
            {
                password = null;

            }
            else
            {
                password = Properties.Settings.Default.Password;
            }
            dbConnect = new DBConnect(Properties.Settings.Default.Server, Properties.Settings.Default.Port, Properties.Settings.Default.Database, Properties.Settings.Default.UID, password); //initialises new db connection


            String strServer = textBox_IP.Text;  //Console.ReadLine();
            String strPort = textBox_Port.Text;  //Console.ReadLine();

            /* Connecting to server (will crash if address/name is incorrect) */

            try
            {
                //myClient = new TcpClient(strServer, Int32.Parse(strPort));


                //textBox3.Text = "connected"; //Console.WriteLine("Connected...");
                ///* Store the NetworkStream */
                //myStream = myClient.GetStream();
                ///* Create data buffer */
                //myBuffer = new byte[myClient.ReceiveBufferSize];

                //getINV();

                checkMACstock();

                string checkResult = checkDBforUID();
                if (checkResult == null)
                {
                    getNewMac();
                }
                else
                {
                    textBox_MAC.Text = checkResult.ToUpper();
                }

                textBox_MacArp.Text = arpIP(textBox_IP.Text).ToUpper();

                if (textBox_MAC.Text != textBox_MacArp.Text)
                {
                    textBox_MacArp.BackColor = Color.Red;
                }
                else
                {
                    textBox_MacArp.BackColor = Color.White;
                }


            }
            catch (System.Net.Sockets.SocketException se)
            {
                richTextBox1.AppendText("connection failed");
                richTextBox1.AppendText("\n");
            }
            catch
            {
                richTextBox1.AppendText("connection failed");
                richTextBox1.AppendText("\n");
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            closeUDP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openUDP();
        }



    }
}
