
namespace Freelance_IT.Forms
{
    partial class HandleOrderForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.clientDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.clientDescriptionLabel = new System.Windows.Forms.Label();
            this.clientEnterLabel = new System.Windows.Forms.Label();
            this.masterIDLabel = new System.Windows.Forms.Label();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.masterCostTextBox = new System.Windows.Forms.TextBox();
            this.masterDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productTypeBox = new System.Windows.Forms.TextBox();
            this.masterCostLabel = new System.Windows.Forms.Label();
            this.declineButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.masterDecriptionLabel = new System.Windows.Forms.Label();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.masterEnterLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clientIDLinkLabel = new System.Windows.Forms.LinkLabel();
            this.masterIDLinkLabel = new System.Windows.Forms.LinkLabel();
            this.statusLineLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 572);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTextBox);
            this.panel4.Controls.Add(this.fullnameTextBox);
            this.panel4.Controls.Add(this.dateLabel);
            this.panel4.Controls.Add(this.fullnameLabel);
            this.panel4.Controls.Add(this.clientDescriptionTextBox);
            this.panel4.Controls.Add(this.clientDescriptionLabel);
            this.panel4.Controls.Add(this.clientEnterLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1250, 572);
            this.panel4.TabIndex = 17;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.Location = new System.Drawing.Point(75, 301);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(308, 54);
            this.dateTextBox.TabIndex = 22;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fullnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameTextBox.Location = new System.Drawing.Point(75, 401);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.ReadOnly = true;
            this.fullnameTextBox.Size = new System.Drawing.Size(369, 143);
            this.fullnameTextBox.TabIndex = 23;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.dateLabel.Location = new System.Drawing.Point(70, 269);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(141, 29);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "Дата сдачи";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fullnameLabel.Location = new System.Drawing.Point(70, 369);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(282, 29);
            this.fullnameLabel.TabIndex = 21;
            this.fullnameLabel.Text = "Полное наименование";
            this.fullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientDescriptionTextBox
            // 
            this.clientDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.clientDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientDescriptionTextBox.Location = new System.Drawing.Point(470, 301);
            this.clientDescriptionTextBox.Multiline = true;
            this.clientDescriptionTextBox.Name = "clientDescriptionTextBox";
            this.clientDescriptionTextBox.ReadOnly = true;
            this.clientDescriptionTextBox.Size = new System.Drawing.Size(701, 243);
            this.clientDescriptionTextBox.TabIndex = 19;
            // 
            // clientDescriptionLabel
            // 
            this.clientDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientDescriptionLabel.AutoSize = true;
            this.clientDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.clientDescriptionLabel.Location = new System.Drawing.Point(465, 269);
            this.clientDescriptionLabel.Name = "clientDescriptionLabel";
            this.clientDescriptionLabel.Size = new System.Drawing.Size(219, 29);
            this.clientDescriptionLabel.TabIndex = 18;
            this.clientDescriptionLabel.Text = "Описание задачи";
            this.clientDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientEnterLabel
            // 
            this.clientEnterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientEnterLabel.AutoSize = true;
            this.clientEnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientEnterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.clientEnterLabel.Location = new System.Drawing.Point(68, 217);
            this.clientEnterLabel.Name = "clientEnterLabel";
            this.clientEnterLabel.Size = new System.Drawing.Size(332, 40);
            this.clientEnterLabel.TabIndex = 17;
            this.clientEnterLabel.Text = "Введено клиентом";
            this.clientEnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masterIDLabel
            // 
            this.masterIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterIDLabel.AutoSize = true;
            this.masterIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.masterIDLabel.Location = new System.Drawing.Point(70, 97);
            this.masterIDLabel.Name = "masterIDLabel";
            this.masterIDLabel.Size = new System.Drawing.Size(177, 26);
            this.masterIDLabel.TabIndex = 11;
            this.masterIDLabel.Text = "ID исполнителя:\r\n";
            this.masterIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.orderInfoLabel.Location = new System.Drawing.Point(64, 26);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(528, 55);
            this.orderInfoLabel.TabIndex = 0;
            this.orderInfoLabel.Text = "Информация о заказе";
            this.orderInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.masterCostTextBox);
            this.panel2.Controls.Add(this.masterDescriptionTextBox);
            this.panel2.Controls.Add(this.productTypeBox);
            this.panel2.Controls.Add(this.masterCostLabel);
            this.panel2.Controls.Add(this.declineButton);
            this.panel2.Controls.Add(this.orderButton);
            this.panel2.Controls.Add(this.masterDecriptionLabel);
            this.panel2.Controls.Add(this.productTypeLabel);
            this.panel2.Controls.Add(this.masterEnterLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 385);
            this.panel2.TabIndex = 10;
            // 
            // masterCostTextBox
            // 
            this.masterCostTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.masterCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterCostTextBox.Location = new System.Drawing.Point(74, 227);
            this.masterCostTextBox.Multiline = true;
            this.masterCostTextBox.Name = "masterCostTextBox";
            this.masterCostTextBox.ReadOnly = true;
            this.masterCostTextBox.Size = new System.Drawing.Size(308, 54);
            this.masterCostTextBox.TabIndex = 9;
            // 
            // masterDescriptionTextBox
            // 
            this.masterDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.masterDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterDescriptionTextBox.Location = new System.Drawing.Point(469, 104);
            this.masterDescriptionTextBox.Multiline = true;
            this.masterDescriptionTextBox.Name = "masterDescriptionTextBox";
            this.masterDescriptionTextBox.ReadOnly = true;
            this.masterDescriptionTextBox.Size = new System.Drawing.Size(714, 259);
            this.masterDescriptionTextBox.TabIndex = 10;
            // 
            // productTypeBox
            // 
            this.productTypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productTypeBox.BackColor = System.Drawing.SystemColors.Window;
            this.productTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeBox.Location = new System.Drawing.Point(74, 104);
            this.productTypeBox.Multiline = true;
            this.productTypeBox.Name = "productTypeBox";
            this.productTypeBox.ReadOnly = true;
            this.productTypeBox.Size = new System.Drawing.Size(308, 54);
            this.productTypeBox.TabIndex = 11;
            // 
            // masterCostLabel
            // 
            this.masterCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterCostLabel.AutoSize = true;
            this.masterCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.masterCostLabel.Location = new System.Drawing.Point(69, 195);
            this.masterCostLabel.Name = "masterCostLabel";
            this.masterCostLabel.Size = new System.Drawing.Size(280, 29);
            this.masterCostLabel.TabIndex = 3;
            this.masterCostLabel.Text = "Стоимость разработки";
            this.masterCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // declineButton
            // 
            this.declineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.declineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.declineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.declineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.declineButton.Location = new System.Drawing.Point(266, 315);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(186, 48);
            this.declineButton.TabIndex = 7;
            this.declineButton.Text = "Отклонить";
            this.declineButton.UseVisualStyleBackColor = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.orderButton.Location = new System.Drawing.Point(74, 315);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(186, 48);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // masterDecriptionLabel
            // 
            this.masterDecriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterDecriptionLabel.AutoSize = true;
            this.masterDecriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterDecriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.masterDecriptionLabel.Location = new System.Drawing.Point(464, 72);
            this.masterDecriptionLabel.Name = "masterDecriptionLabel";
            this.masterDecriptionLabel.Size = new System.Drawing.Size(743, 29);
            this.masterDecriptionLabel.TabIndex = 4;
            this.masterDecriptionLabel.Text = "Полное техническое описание продукта и детали реализации\r\n";
            this.masterDecriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.productTypeLabel.Location = new System.Drawing.Point(69, 72);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(170, 29);
            this.productTypeLabel.TabIndex = 5;
            this.productTypeLabel.Text = "Тип продукта";
            this.productTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masterEnterLabel
            // 
            this.masterEnterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterEnterLabel.AutoSize = true;
            this.masterEnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterEnterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.masterEnterLabel.Location = new System.Drawing.Point(67, 22);
            this.masterEnterLabel.Name = "masterEnterLabel";
            this.masterEnterLabel.Size = new System.Drawing.Size(413, 40);
            this.masterEnterLabel.TabIndex = 6;
            this.masterEnterLabel.Text = "Введено исполнителем";
            this.masterEnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clientIDLinkLabel);
            this.panel3.Controls.Add(this.masterIDLinkLabel);
            this.panel3.Controls.Add(this.statusLineLabel);
            this.panel3.Controls.Add(this.statusLabel);
            this.panel3.Controls.Add(this.orderInfoLabel);
            this.panel3.Controls.Add(this.clientIDLabel);
            this.panel3.Controls.Add(this.masterIDLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 191);
            this.panel3.TabIndex = 18;
            // 
            // clientIDLinkLabel
            // 
            this.clientIDLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientIDLinkLabel.AutoSize = true;
            this.clientIDLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIDLinkLabel.ForeColor = System.Drawing.Color.White;
            this.clientIDLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.clientIDLinkLabel.Location = new System.Drawing.Point(261, 144);
            this.clientIDLinkLabel.Name = "clientIDLinkLabel";
            this.clientIDLinkLabel.Size = new System.Drawing.Size(138, 29);
            this.clientIDLinkLabel.TabIndex = 12;
            this.clientIDLinkLabel.TabStop = true;
            this.clientIDLinkLabel.Text = "ID клиента";
            this.clientIDLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masterIDLinkLabel
            // 
            this.masterIDLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterIDLinkLabel.AutoSize = true;
            this.masterIDLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterIDLinkLabel.ForeColor = System.Drawing.Color.White;
            this.masterIDLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.masterIDLinkLabel.Location = new System.Drawing.Point(261, 97);
            this.masterIDLinkLabel.Name = "masterIDLinkLabel";
            this.masterIDLinkLabel.Size = new System.Drawing.Size(198, 29);
            this.masterIDLinkLabel.TabIndex = 12;
            this.masterIDLinkLabel.TabStop = true;
            this.masterIDLinkLabel.Text = "ID исполнителя";
            this.masterIDLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masterIDLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.masterIDLinkLabel_LinkClicked);
            // 
            // statusLineLabel
            // 
            this.statusLineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLineLabel.AutoSize = true;
            this.statusLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.statusLineLabel.Location = new System.Drawing.Point(863, 26);
            this.statusLineLabel.Name = "statusLineLabel";
            this.statusLineLabel.Size = new System.Drawing.Size(344, 55);
            this.statusLineLabel.TabIndex = 0;
            this.statusLineLabel.Text = "Статус заказа";
            this.statusLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.statusLabel.Location = new System.Drawing.Point(868, 94);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(236, 29);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Тут какой-то статус";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.clientIDLabel.Location = new System.Drawing.Point(70, 144);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(128, 26);
            this.clientIDLabel.TabIndex = 11;
            this.clientIDLabel.Text = "ID клиента:";
            this.clientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HandleOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 957);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HandleOrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label masterIDLabel;
        private System.Windows.Forms.Label orderInfoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox masterCostTextBox;
        private System.Windows.Forms.TextBox masterDescriptionTextBox;
        private System.Windows.Forms.TextBox productTypeBox;
        private System.Windows.Forms.Label masterCostLabel;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label masterDecriptionLabel;
        private System.Windows.Forms.Label productTypeLabel;
        private System.Windows.Forms.Label masterEnterLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel masterIDLinkLabel;
        private System.Windows.Forms.Label statusLineLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.LinkLabel clientIDLinkLabel;
        private System.Windows.Forms.Label clientIDLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox clientDescriptionTextBox;
        private System.Windows.Forms.Label clientDescriptionLabel;
        private System.Windows.Forms.Label clientEnterLabel;
    }
}