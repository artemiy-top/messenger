using Message = Shared.Message;
using Shared;
using ServiceStack;

namespace Client
{
    public partial class MainForm : Form
    {
        public string SessionId;

        public MainForm(string sessionId)
        {
            InitializeComponent();
            this.SessionId = sessionId;

            ClientChat[] chats = "http://localhost:5000/get-chats"
                .GetJsonFromUrl((HttpRequestMessage request) =>
                {
                    request.AddBearerToken(this.SessionId);
                })
                .FromJson<ClientChat[]>();

            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(chats.Select((chat) => $"{chat.Title} ({chat.LastMessage})").ToArray());
        }

        bool buttonClicked = false;

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
            {
                string[] users = this.listBox1.Items
                   .Cast<string>()
                   .Order()
                   .ToArray();
                this.listBox1.Items.Clear();
                this.listBox1.Items.AddRange(users);
                this.buttonClicked = true;
                this.sortButton.Text = "▼";
            }
            else
            {
                string[] users = this.listBox1.Items
                    .Cast<string>()
                    .OrderDescending()
                    .ToArray();
                this.listBox1.Items.Clear();
                this.listBox1.Items.AddRange(users);
                this.buttonClicked = false;
                this.sortButton.Text = "▲";
            }
        }

        private void removeAllFriendsButton_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void enableDarkThemeButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;

            this.listBox1.BackColor = Color.Black;
            this.listBox1.ForeColor = Color.White;

            this.sortButton.BackColor = Color.Black;
            this.sortButton.ForeColor = Color.White;

            this.sendMessageButton.BackColor = Color.Black;
            this.sendMessageButton.ForeColor = Color.White;
        }
    }
}
