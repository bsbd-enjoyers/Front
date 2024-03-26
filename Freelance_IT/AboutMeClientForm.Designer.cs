
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.enterLabel.Location = new System.Drawing.Point(71, 76);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(355, 40);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Заполните все поля";
            this.enterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enter
            // 
            this.enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.enter.Location = new System.Drawing.Point(90, 390);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(322, 72);
            this.enter.TabIndex = 1;
            this.enter.Text = "Подтвердить";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBox.BackColor = System.Drawing.SystemColors.Window;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(90, 172);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(308, 54);
            this.loginBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(90, 297);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(308, 48);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.loginLabel.Location = new System.Drawing.Point(85, 140);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(125, 29);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Эл. почта";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.passwordLabel.Location = new System.Drawing.Point(85, 265);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(119, 29);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Телефон";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutMeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 510);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.enterLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutMeClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}