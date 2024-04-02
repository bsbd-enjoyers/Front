
namespace Freelance_IT
{
    partial class AboutMeClientForm
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
            this.fillfieldsLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.fullnameLlabel = new System.Windows.Forms.Label();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fillfieldsLabel
            // 
            this.fillfieldsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillfieldsLabel.AutoSize = true;
            this.fillfieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillfieldsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fillfieldsLabel.Location = new System.Drawing.Point(38, 59);
            this.fillfieldsLabel.Name = "fillfieldsLabel";
            this.fillfieldsLabel.Size = new System.Drawing.Size(415, 40);
            this.fillfieldsLabel.TabIndex = 0;
            this.fillfieldsLabel.Text = "Информация о клиенте";
            this.fillfieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.acceptButton.Location = new System.Drawing.Point(78, 464);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(322, 72);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(86, 268);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(308, 54);
            this.emailBox.TabIndex = 2;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBox.Location = new System.Drawing.Point(86, 375);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(308, 54);
            this.phoneBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.emailLabel.Location = new System.Drawing.Point(81, 236);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(125, 29);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Эл. почта";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.phoneLabel.Location = new System.Drawing.Point(81, 343);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(119, 29);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Телефон";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameLlabel
            // 
            this.fullnameLlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameLlabel.AutoSize = true;
            this.fullnameLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fullnameLlabel.Location = new System.Drawing.Point(81, 124);
            this.fullnameLlabel.Name = "fullnameLlabel";
            this.fullnameLlabel.Size = new System.Drawing.Size(70, 29);
            this.fullnameLlabel.TabIndex = 0;
            this.fullnameLlabel.Text = "ФИО";
            this.fullnameLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fullnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameTextBox.Location = new System.Drawing.Point(86, 156);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(308, 54);
            this.fullnameTextBox.TabIndex = 2;
            // 
            // AboutMeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 576);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.fullnameLlabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fillfieldsLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutMeClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fillfieldsLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label fullnameLlabel;
        private System.Windows.Forms.TextBox fullnameTextBox;
    }
}