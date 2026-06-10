using ServiceStack;
using ServiceStack.Model;
using Shared;
using Message = Shared.Message;

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
            this.listBox1
                .Items
                .AddRange(chats);
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

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ClientChat selectedChat = this.listBox1.SelectedItem as ClientChat;
            if (selectedChat == null)
            {
                this.messagesTextBox.Text = "";
                return;
            }

            int chatId = selectedChat.Id;

            ClientMessage[] messages = $"http://localhost:5000/get-chat/{chatId}"
                .GetJsonFromUrl((HttpRequestMessage request) =>
                {
                    request.AddBearerToken(this.SessionId);
                })
                .FromJson<ClientMessage[]>();

            this.messagesTextBox.Text = messages
                .Select((message) => $"{message.SenderName}: {message.Text}")
                .Join("\r\n\r\n");

            this.messagesTextBox.SelectionStart = this.messagesTextBox.Text.Length;
            this.messagesTextBox.ScrollToCaret();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            ClientChat selectedChat = this.listBox1.SelectedItem as ClientChat;
            if (selectedChat == null)
            {
                this.messagesTextBox.Text = "";
                return;
            }
            int chatId = selectedChat.Id;

            bool result = "http://localhost:5000/send-message"
                 .PostJsonToUrl(new SendMessageRequest
                 {
                     ChatId = chatId,
                     Message = this.newMessageTextBox.Text,
                 },
                 (HttpRequestMessage request) =>
                 {
                     request.AddBearerToken(this.SessionId);
                 })
                 .FromJson<bool>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.listBox1_SelectedValueChanged(sender, e);
        }

        private void newMessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.sendMessageButton_Click(sender, e);
            }
        }
    }
}
