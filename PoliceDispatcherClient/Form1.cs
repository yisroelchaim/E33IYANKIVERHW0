using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureCommunicationComponent;

namespace PoliceDispatcherClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {

        }

        private void OfficerButton_Click(object sender, EventArgs e)
        {

        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            Communicator MyCommunicator = new Communicator();
            string message = MyCommunicator.SendAlert(OfficerTextBox.Text, "Hello, from Police Dispatcher");
            MessageBox.Show(message);

        }
    }
}
