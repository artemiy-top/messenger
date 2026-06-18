namespace Client
{
    partial class RegisterForm
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
            registerButton = new Button();
            loginLinkLabel = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            repeatPasswordMaskedTextBox = new MaskedTextBox();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            passwordMaskedTextBox.TextChanged += passwordMaskedTextBox_TextChanged;
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
            // registerButton
            // 
            registerButton.Enabled = false;
            registerButton.Location = new Point(68, 231);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(97, 23);
            registerButton.TabIndex = 3;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.Enabled = false;
            loginLinkLabel.Location = new Point(75, 274);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(78, 28);
            loginLinkLabel.TabIndex = 8;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Войти";
            loginLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Location = new Point(12, 150);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(205, 23);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(15, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 2;
            label3.Text = "Повторите пароль";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // repeatPasswordMaskedTextBox
            // 
            repeatPasswordMaskedTextBox.Font = new Font("Segoe UI", 14F);
            repeatPasswordMaskedTextBox.Location = new Point(12, 179);
            repeatPasswordMaskedTextBox.Name = "repeatPasswordMaskedTextBox";
            repeatPasswordMaskedTextBox.PasswordChar = '*';
            repeatPasswordMaskedTextBox.Size = new Size(205, 32);
            repeatPasswordMaskedTextBox.TabIndex = 9;
            repeatPasswordMaskedTextBox.TextChanged += passwordMaskedTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 263);
            label4.Name = "label4";
            label4.Size = new Size(158, 15);
            label4.TabIndex = 11;
            label4.Text = "Вы уже зарегистрированы?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 311);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(repeatPasswordMaskedTextBox);
            Controls.Add(loginLinkLabel);
            Controls.Add(registerButton);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(loginTextBox);
            Controls.Add(passwordMaskedTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация в Messenger";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private Button registerButton;
        private LinkLabel loginLinkLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private MaskedTextBox repeatPasswordMaskedTextBox;
        private Label label4;
    }
}