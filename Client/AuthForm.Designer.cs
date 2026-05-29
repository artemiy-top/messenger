namespace Client
{
    partial class AuthForm
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
            passwordMaskedTextBox = new MaskedTextBox();
            loginTextBox = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            loginButton = new Button();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // passwordMaskedTextBox
            // 
            passwordMaskedTextBox.Font = new Font("Segoe UI", 14F);
            passwordMaskedTextBox.Location = new Point(12, 112);
            passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            passwordMaskedTextBox.PasswordChar = '*';
            passwordMaskedTextBox.Size = new Size(205, 32);
            passwordMaskedTextBox.TabIndex = 2;
            passwordMaskedTextBox.Text = "12345";
            passwordMaskedTextBox.KeyPress += passwordMaskedTextBox_KeyPress;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Segoe UI", 14F);
            loginTextBox.Location = new Point(12, 41);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(205, 32);
            loginTextBox.TabIndex = 1;
            loginTextBox.Text = "John";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(70, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(205, 23);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(205, 23);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(63, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(75, 161);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(78, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Enabled = false;
            linkLabel1.Location = new Point(75, 187);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 23);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Регистрация";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 221);
            Controls.Add(linkLabel1);
            Controls.Add(loginButton);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(loginTextBox);
            Controls.Add(passwordMaskedTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в Messenger";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox passwordMaskedTextBox;
        private TextBox loginTextBox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Button loginButton;
        private LinkLabel linkLabel1;
    }
}