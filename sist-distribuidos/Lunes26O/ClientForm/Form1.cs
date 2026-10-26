using System.Net.Sockets;
using System.Text;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            ConnectServer("127.0.0.1", text);
        }

        private void ConnectServer(string server, string msg)
        {
            int port = 8090;
            // Uses the public TcpClient(string hostname, int port) : this(AddressFamily.Unknown) constructor
            TcpClient tcpClient = new TcpClient(server, port);

            // Stream works with bytes moving
            // So we turn it into an aarray of bytes
            Byte[] dataMsg = Encoding.ASCII.GetBytes(msg);

            NetworkStream networkStream = tcpClient.GetStream();

            // SImilar to fwrite() in C
            // Offset: how it moved, and the length (how many byteS)
            networkStream.Write(dataMsg, 0, dataMsg.Length);
            ShowAMessageBox($"Sending message: {msg}");
            DateTime startTime = DateTime.Now;

            // The opposite, we turn a stream of bytes into a string
            Byte[] receivedData = new Byte[256];

            string receivedMsg = string.Empty;

            int numBytes = networkStream.Read(receivedData, 0, receivedData.Length);

            receivedMsg = Encoding.ASCII.GetString(receivedData, 0, receivedData.Length);

            ShowAMessageBox($"Received message: {receivedMsg}");

            // Do this to avoid leaking the connection
            networkStream.Close();
            tcpClient.Close();
        }

        private void ShowAMessageBox(string msg)
        {
            MessageBox.Show(msg, "Hey you!");
        }
    }
}