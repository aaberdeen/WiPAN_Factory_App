using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiPANFactory
{
    public partial class DataBaseSetup : Form
    {
        public DataBaseSetup()
        {
            InitializeComponent();

            textBoxServer.Text = Properties.Settings.Default.Server;
            textBoxPort.Text = Properties.Settings.Default.Port;
            textBoxDataBase.Text = Properties.Settings.Default.Database;
            textBoxUID.Text = Properties.Settings.Default.UID;
            textBoxPassword.Text = Properties.Settings.Default.Password;
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.Server = textBoxServer.Text;
           
            Properties.Settings.Default.Port = textBoxPort.Text;
           
            Properties.Settings.Default.Database = textBoxDataBase.Text;
            
            Properties.Settings.Default.UID = textBoxUID.Text;
            string password;

            if (textBoxPassword.Text == "")
            {
                password = null;
            }
            else
            {
                password = textBoxPassword.Text;
            }

            Properties.Settings.Default.Password = password;

            Properties.Settings.Default.Save();
            this.Hide();
        }
    }
}
