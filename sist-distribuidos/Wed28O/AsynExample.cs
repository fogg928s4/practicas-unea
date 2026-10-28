using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        HttpClient _httpClient;
        public Form1()
        {
            InitializeComponent();
            this._httpClient = new HttpClient();
        }

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            Task<string> promise = this._httpClient.GetStringAsync(tb_url.Text);
            // awaits the result from the promise task
            string result = await promise;
            tb_result.Text = result;

        }

    }
}