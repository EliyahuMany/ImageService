using ImageCommunication.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ImageCommunication.Handler {
    interface IClientHandler {
        event EventHandler<DataRecievedEventsArgs> DataRecieved;
        void Start();
        void Close();
        void Send(object sender, DataRecievedEventsArgs e);
    }
}
