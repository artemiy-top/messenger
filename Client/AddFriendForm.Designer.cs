namespace Client
{
    partial class AddFriendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            friendsListBox = new ListBox();
            addFriendButton = new Button();
            SuspendLayout();
            // 
            // friendsListBox
            // 
            friendsListBox.FormattingEnabled = true;
            friendsListBox.Location = new Point(12, 12);
            friendsListBox.Name = "friendsListBox";
            friendsListBox.Size = new Size(165, 169);
            friendsListBox.TabIndex = 0;
            // 
            // addFriendButton
            // 
            addFriendButton.Location = new Point(35, 187);
            addFriendButton.Name = "addFriendButton";
            addFriendButton.Size = new Size(120, 23);
            addFriendButton.TabIndex = 1;
            addFriendButton.Text = "Добавить друга";
            addFriendButton.UseVisualStyleBackColor = true;
            addFriendButton.Click += addFriendButton_Click;
            // 
            // AddFriendForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 217);
            Controls.Add(addFriendButton);
            Controls.Add(friendsListBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AddFriendForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить друга";
            ResumeLayout(false);
        }

        #endregion

        private ListBox friendsListBox;
        private Button addFriendButton;
    }
}