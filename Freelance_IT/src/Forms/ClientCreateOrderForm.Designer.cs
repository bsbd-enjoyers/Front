
namespace Freelance_IT.Forms
{
    partial class ClientCreateOrderForm
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
            this.createOrderLabel = new System.Windows.Forms.Label();
            this.publishButton = new System.Windows.Forms.Button();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // createOrderLabel
            // 
            this.createOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createOrderLabel.AutoSize = true;
            this.createOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.createOrderLabel.Location = new System.Drawing.Point(49, 52);
            this.createOrderLabel.Name = "createOrderLabel";
            this.createOrderLabel.Size = new System.Drawing.Size(412, 55);
            this.createOrderLabel.TabIndex = 0;
            this.createOrderLabel.Text = "Создание заказа";
            this.createOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publishButton
            // 
            this.publishButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.publishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.publishButton.Location = new System.Drawing.Point(59, 645);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(308, 72);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "Опубликовать";
            this.publishButton.UseVisualStyleBackColor = false;
            this.publishButton.Click += new System.EventHandler(this.enter_Click);
            // 
            // fullNameBox
            // 
            this.fullNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.fullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameBox.Location = new System.Drawing.Point(59, 157);
            this.fullNameBox.Multiline = true;
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(308, 54);
            this.fullNameBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fullNameLabel.Location = new System.Drawing.Point(54, 125);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(282, 29);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Полное наименование";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.descriptionLabel.Location = new System.Drawing.Point(460, 125);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(410, 29);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Опишите, что вы хотите получить";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(465, 157);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(579, 560);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // costLabel
            // 
            this.costLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.costLabel.Location = new System.Drawing.Point(54, 221);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(104, 29);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "Бюджет";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(59, 262);
            this.costTextBox.Multiline = true;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(308, 54);
            this.costTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.dateLabel.Location = new System.Drawing.Point(54, 334);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(141, 29);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата сдачи";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(59, 372);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2024, 5, 7, 17, 23, 42, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // ClientCreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 785);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.createOrderLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientCreateOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createOrderLabel;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}