namespace TestDb
{
    partial class Form1
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
            connectionStatusLabel = new Label();
            usersGrid = new DataGridView();
            groupBox1 = new GroupBox();
            addButton = new Button();
            listBox1 = new ListBox();
            minPriceBox = new TextBox();
            numberBox = new TextBox();
            nameBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usersGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // connectionStatusLabel
            // 
            connectionStatusLabel.AutoSize = true;
            connectionStatusLabel.Location = new Point(1551, 837);
            connectionStatusLabel.Margin = new Padding(2, 0, 2, 0);
            connectionStatusLabel.Name = "connectionStatusLabel";
            connectionStatusLabel.Size = new Size(88, 15);
            connectionStatusLabel.TabIndex = 0;
            connectionStatusLabel.Text = "Not Connected";
            // 
            // usersGrid
            // 
            usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGrid.Location = new Point(12, 12);
            usersGrid.Name = "usersGrid";
            usersGrid.Size = new Size(1626, 468);
            usersGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(minPriceBox);
            groupBox1.Controls.Add(numberBox);
            groupBox1.Controls.Add(nameBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(138, 555);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 139);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // addButton
            // 
            addButton.Location = new Point(478, 70);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Тестовый тип №1", "Тестовый тип №2" });
            listBox1.Location = new Point(20, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 34);
            listBox1.TabIndex = 7;
            // 
            // minPriceBox
            // 
            minPriceBox.Location = new Point(358, 70);
            minPriceBox.Name = "minPriceBox";
            minPriceBox.Size = new Size(100, 23);
            minPriceBox.TabIndex = 6;
            // 
            // numberBox
            // 
            numberBox.Location = new Point(252, 70);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(100, 23);
            numberBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(146, 70);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 36);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Мин. цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 36);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Артикул";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 36);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Наименование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Тип";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 861);
            Controls.Add(groupBox1);
            Controls.Add(usersGrid);
            Controls.Add(connectionStatusLabel);
            Margin = new Padding(2);
            Name = "Form1";
            Opacity = 0.95D;
            Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)usersGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label connectionStatusLabel;
        private DataGridView usersGrid;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox minPriceBox;
        private TextBox numberBox;
        private TextBox nameBox;
        private Label label4;
        private Label label3;
        private ListBox listBox1;
        private Button addButton;
    }
}
