using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; 

namespace SecureCommunicationComponent
{
    public class Communicator 
    {
        public string SendAlert(string Addressee, string Message)
        {
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            return v.ToString() + " Received : " + Message; 

        } 
    }
}
