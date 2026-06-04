namespace Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            sendMessageButton = new Button();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            sortButton = new Button();
            addNewFriendButton = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            enableDarkThemeButton = new Button();
            removeAllFriendsButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            tableLayoutPanel3.SetColumnSpan(listBox1, 2);
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(464, 750);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(727, 23);
            textBox1.TabIndex = 1;
            // 
            // sendMessageButton
            // 
            sendMessageButton.Dock = DockStyle.Fill;
            sendMessageButton.Location = new Point(736, 3);
            sendMessageButton.Name = "sendMessageButton";
            sendMessageButton.Size = new Size(94, 28);
            sendMessageButton.TabIndex = 3;
            sendMessageButton.Text = "Отправить";
            sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1327, 814);
            splitContainer1.SplitterDistance = 484;
            splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(484, 814);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(476, 786);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сообщения";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(sortButton, 0, 0);
            tableLayoutPanel3.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(addNewFriendButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(470, 780);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // sortButton
            // 
            sortButton.Dock = DockStyle.Fill;
            sortButton.Location = new Point(0, 0);
            sortButton.Margin = new Padding(0);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(235, 24);
            sortButton.TabIndex = 1;
            sortButton.Text = "▼▲";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // addNewFriendButton
            // 
            addNewFriendButton.Dock = DockStyle.Fill;
            addNewFriendButton.Location = new Point(235, 0);
            addNewFriendButton.Margin = new Padding(0);
            addNewFriendButton.Name = "addNewFriendButton";
            addNewFriendButton.Size = new Size(235, 24);
            addNewFriendButton.TabIndex = 2;
            addNewFriendButton.Text = "☺ Добавить контакт";
            addNewFriendButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(476, 786);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Группы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(enableDarkThemeButton);
            tabPage3.Controls.Add(removeAllFriendsButton);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(476, 786);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Настройки";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // enableDarkThemeButton
            // 
            enableDarkThemeButton.Location = new Point(19, 54);
            enableDarkThemeButton.Name = "enableDarkThemeButton";
            enableDarkThemeButton.Size = new Size(169, 23);
            enableDarkThemeButton.TabIndex = 1;
            enableDarkThemeButton.Text = "Тёмная тема";
            enableDarkThemeButton.UseVisualStyleBackColor = true;
            enableDarkThemeButton.Click += enableDarkThemeButton_Click;
            // 
            // removeAllFriendsButton
            // 
            removeAllFriendsButton.Location = new Point(19, 15);
            removeAllFriendsButton.Name = "removeAllFriendsButton";
            removeAllFriendsButton.Size = new Size(169, 23);
            removeAllFriendsButton.TabIndex = 0;
            removeAllFriendsButton.Text = "Удалить всех друзей";
            removeAllFriendsButton.UseVisualStyleBackColor = true;
            removeAllFriendsButton.Click += removeAllFriendsButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(839, 814);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(sendMessageButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 777);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(833, 34);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(833, 768);
            textBox2.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 814);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Топ-Мессенджер";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button sendMessageButton;
        private SplitContainer splitContainer1;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button sortButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage tabPage3;
        private Button addNewFriendButton;
        private Button removeAllFriendsButton;
        private Button enableDarkThemeButton;
    }
}
