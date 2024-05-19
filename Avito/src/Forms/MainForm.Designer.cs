
namespace Avito.Forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.customerButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.sellerButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.logutLabel = new System.Windows.Forms.LinkLabel();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.walletLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userPanel);
            this.panel1.Controls.Add(this.headerPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 208);
            this.panel1.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.customerButton);
            this.headerPanel.Controls.Add(this.searchTextBox);
            this.headerPanel.Controls.Add(this.searchButton);
            this.headerPanel.Controls.Add(this.sellerButton);
            this.headerPanel.Controls.Add(this.productButton);
            this.headerPanel.Controls.Add(this.orderButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(789, 208);
            this.headerPanel.TabIndex = 1;
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(455, 23);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(138, 71);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "Клиенты";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(23, 119);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(570, 62);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(611, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 62);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // sellerButton
            // 
            this.sellerButton.Location = new System.Drawing.Point(311, 23);
            this.sellerButton.Name = "sellerButton";
            this.sellerButton.Size = new System.Drawing.Size(138, 71);
            this.sellerButton.TabIndex = 0;
            this.sellerButton.Text = "Продавцы";
            this.sellerButton.UseVisualStyleBackColor = true;
            this.sellerButton.Click += new System.EventHandler(this.sellerButton_Click);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(167, 23);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(138, 71);
            this.productButton.TabIndex = 0;
            this.productButton.Text = "Продукты";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(23, 23);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(138, 71);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Заказы";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(23, 225);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(909, 299);
            this.DataGridView.TabIndex = 12;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.deleteButton.Location = new System.Drawing.Point(953, 435);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(141, 64);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.checkButton.Location = new System.Drawing.Point(953, 365);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(141, 64);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Просмотреть";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.createButton.Location = new System.Drawing.Point(953, 295);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(141, 64);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.buyButton.Location = new System.Drawing.Point(953, 225);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(141, 64);
            this.buyButton.TabIndex = 10;
            this.buyButton.Text = "Заказать";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // logutLabel
            // 
            this.logutLabel.AutoSize = true;
            this.logutLabel.Location = new System.Drawing.Point(53, 169);
            this.logutLabel.Name = "logutLabel";
            this.logutLabel.Size = new System.Drawing.Size(58, 20);
            this.logutLabel.TabIndex = 2;
            this.logutLabel.TabStop = true;
            this.logutLabel.Text = "Выйти";
            this.logutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logutLabel_LinkClicked);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPictureBox.Location = new System.Drawing.Point(24, 41);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(120, 120);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 3;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.avatarPictureBox_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(160, 65);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(157, 29);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Нажми сюда";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletLabel.Location = new System.Drawing.Point(193, 97);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(96, 29);
            this.walletLabel.TabIndex = 4;
            this.walletLabel.Text = "Баланс";
            this.walletLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.walletLabel);
            this.userPanel.Controls.Add(this.loginLabel);
            this.userPanel.Controls.Add(this.avatarPictureBox);
            this.userPanel.Controls.Add(this.logutLabel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(789, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(329, 208);
            this.userPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 550);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button sellerButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.LinkLabel logutLabel;
    }
}