using ServiceStack;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AddFriendForm : Form
    {
        string sessionId;
        public AddFriendForm(string sessionId)
        {
            InitializeComponent();

            ClientUser[] clientUsers = "http://localhost:5000/users".GetJsonFromUrl().FromJson<ClientUser[]>();
            this.friendsListBox.Items.AddRange(clientUsers);
            this.sessionId = sessionId;
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            ClientUser? selectedFriend = this.friendsListBox.SelectedItem as ClientUser;
            if (selectedFriend == null)
            {
                return;
            }

            "http://localhost:5000/add-friend".PostJsonToUrl(new AddFriendRequest
            {
                Id = selectedFriend.Id,
            }, (HttpRequestMessage request) =>
            {
                request.AddBearerToken(this.sessionId);
            });
            this.Close();
        }
    }
}
