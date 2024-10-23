namespace TestDb
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            enterButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(78, 30);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(100, 23);
            loginBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(78, 59);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(enterButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passwordBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(loginBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 155);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Авторизация";
            // 
            // button1
            // 
            button1.Location = new Point(77, 120);
            button1.Name = "button1";
            button1.Size = new Size(101, 26);
            button1.TabIndex = 9;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(77, 88);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(101, 26);
            enterButton.TabIndex = 8;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 177);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Авторизация";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox loginBox;
        private TextBox passwordBox;
        private GroupBox groupBox1;
        private Button enterButton;
        private Button button1;
    }
}