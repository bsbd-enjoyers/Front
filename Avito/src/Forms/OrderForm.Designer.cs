
namespace Avito.Forms
{
    partial class OrderForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.sellerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.statusLineLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 569);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Controls.Add(this.actionButton);
            this.panel4.Controls.Add(this.dateTextBox);
            this.panel4.Controls.Add(this.fullnameTextBox);
            this.panel4.Controls.Add(this.dateLabel);
            this.panel4.Controls.Add(this.fullnameLabel);
            this.panel4.Controls.Add(this.costTextBox);
            this.panel4.Controls.Add(this.costLabel);
            this.panel4.Controls.Add(this.numberTextBox);
            this.panel4.Controls.Add(this.numberLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1054, 569);
            this.panel4.TabIndex = 17;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.cancelButton.Location = new System.Drawing.Point(309, 459);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(208, 84);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.actionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.actionButton.Location = new System.Drawing.Point(62, 459);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(223, 84);
            this.actionButton.TabIndex = 25;
            this.actionButton.Text = "Подтвердить";
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.Location = new System.Drawing.Point(510, 267);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(364, 54);
            this.dateTextBox.TabIndex = 22;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fullnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameTextBox.Location = new System.Drawing.Point(57, 267);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.ReadOnly = true;
            this.fullnameTextBox.Size = new System.Drawing.Size(369, 54);
            this.fullnameTextBox.TabIndex = 23;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.dateLabel.Location = new System.Drawing.Point(505, 235);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(178, 29);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "Дата доставки";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fullnameLabel.Location = new System.Drawing.Point(57, 235);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(189, 29);
            this.fullnameLabel.TabIndex = 21;
            this.fullnameLabel.Text = "Наименование";
            this.fullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(510, 369);
            this.costTextBox.Multiline = true;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(364, 54);
            this.costTextBox.TabIndex = 19;
            // 
            // costLabel
            // 
            this.costLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.costLabel.Location = new System.Drawing.Point(505, 337);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(312, 29);
            this.costLabel.TabIndex = 18;
            this.costLabel.Text = "Полная стоимость заказа";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(57, 369);
            this.numberTextBox.Multiline = true;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.ReadOnly = true;
            this.numberTextBox.Size = new System.Drawing.Size(369, 54);
            this.numberTextBox.TabIndex = 19;
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.numberLabel.Location = new System.Drawing.Point(57, 337);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(93, 29);
            this.numberLabel.TabIndex = 18;
            this.numberLabel.Text = "Кол-во";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.orderInfoLabel.Location = new System.Drawing.Point(52, 26);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(528, 55);
            this.orderInfoLabel.TabIndex = 0;
            this.orderInfoLabel.Text = "Информация о заказе";
            this.orderInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerLinkLabel);
            this.panel3.Controls.Add(this.sellerLinkLabel);
            this.panel3.Controls.Add(this.statusLineLabel);
            this.panel3.Controls.Add(this.statusLabel);
            this.panel3.Controls.Add(this.orderInfoLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 212);
            this.panel3.TabIndex = 18;
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLinkLabel.ForeColor = System.Drawing.Color.White;
            this.customerLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.customerLinkLabel.Location = new System.Drawing.Point(55, 146);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(371, 37);
            this.customerLinkLabel.TabIndex = 12;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Подробнее о покупателе";
            this.customerLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLinkLabel_LinkClicked);
            // 
            // sellerLinkLabel
            // 
            this.sellerLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellerLinkLabel.AutoSize = true;
            this.sellerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellerLinkLabel.ForeColor = System.Drawing.Color.White;
            this.sellerLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.sellerLinkLabel.Location = new System.Drawing.Point(55, 97);
            this.sellerLinkLabel.Name = "sellerLinkLabel";
            this.sellerLinkLabel.Size = new System.Drawing.Size(344, 37);
            this.sellerLinkLabel.TabIndex = 12;
            this.sellerLinkLabel.TabStop = true;
            this.sellerLinkLabel.Text = "Подробнее о продавце";
            this.sellerLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sellerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sellerLinkLabel_LinkClicked);
            // 
            // statusLineLabel
            // 
            this.statusLineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLineLabel.AutoSize = true;
            this.statusLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.statusLineLabel.Location = new System.Drawing.Point(669, 26);
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
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.statusLabel.Location = new System.Drawing.Point(672, 97);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(303, 37);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Тут какой-то статус";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderInfoLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label statusLineLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel sellerLinkLabel;
    }
}