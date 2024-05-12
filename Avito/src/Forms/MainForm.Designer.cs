
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
            this.userPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.logutLabel = new System.Windows.Forms.LinkLabel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.clientButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.masterButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
            // userPanel
            // 
            this.userPanel.Controls.Add(this.loginLabel);
            this.userPanel.Controls.Add(this.avatarPictureBox);
            this.userPanel.Controls.Add(this.logutLabel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(858, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(260, 208);
            this.userPanel.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(56, 146);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(157, 29);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Нажми сюда";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPictureBox.Location = new System.Drawing.Point(71, 23);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(120, 120);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 3;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.avatarPictureBox_Click);
            // 
            // logutLabel
            // 
            this.logutLabel.AutoSize = true;
            this.logutLabel.Location = new System.Drawing.Point(100, 175);
            this.logutLabel.Name = "logutLabel";
            this.logutLabel.Size = new System.Drawing.Size(58, 20);
            this.logutLabel.TabIndex = 2;
            this.logutLabel.TabStop = true;
            this.logutLabel.Text = "Выйти";
            this.logutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logutLabel_LinkClicked);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.clientButton);
            this.headerPanel.Controls.Add(this.searchTextBox);
            this.headerPanel.Controls.Add(this.searchButton);
            this.headerPanel.Controls.Add(this.masterButton);
            this.headerPanel.Controls.Add(this.orderButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(858, 208);
            this.headerPanel.TabIndex = 1;
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(311, 23);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(138, 71);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Клиенты";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
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
            // masterButton
            // 
            this.masterButton.Location = new System.Drawing.Point(167, 23);
            this.masterButton.Name = "masterButton";
            this.masterButton.Size = new System.Drawing.Size(138, 71);
            this.masterButton.TabIndex = 0;
            this.masterButton.Text = "Исполнители";
            this.masterButton.UseVisualStyleBackColor = true;
            this.masterButton.Click += new System.EventHandler(this.masterButton_Click);
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
            this.deleteButton.Location = new System.Drawing.Point(953, 365);
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
            this.checkButton.Location = new System.Drawing.Point(953, 295);
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
            this.createButton.Location = new System.Drawing.Point(953, 435);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(141, 64);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.feedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.feedbackButton.Location = new System.Drawing.Point(953, 225);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(141, 64);
            this.feedbackButton.TabIndex = 10;
            this.feedbackButton.Text = "Оставить отзыв";
            this.feedbackButton.UseVisualStyleBackColor = false;
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 550);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button masterButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.LinkLabel logutLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button feedbackButton;
    }
}