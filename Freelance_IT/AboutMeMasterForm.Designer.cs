
namespace Freelance_IT
{
    partial class AboutMeMasterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.aboutMeTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.fillfieldsLabel = new System.Windows.Forms.Label();
            this.createSkillButton = new System.Windows.Forms.Button();
            this.editSkillButton = new System.Windows.Forms.Button();
            this.deleteSkillButton = new System.Windows.Forms.Button();
            this.moreLabel = new System.Windows.Forms.Label();
            this.skilltypeBox = new System.Windows.Forms.TextBox();
            this.skilltypeLabel = new System.Windows.Forms.Label();
            this.moreBox = new System.Windows.Forms.TextBox();
            this.skillsDataGridView = new System.Windows.Forms.DataGridView();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.fullnameLlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skillsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(53, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Обо мне";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutMeTextBox
            // 
            this.aboutMeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutMeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.aboutMeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutMeTextBox.Location = new System.Drawing.Point(58, 412);
            this.aboutMeTextBox.Multiline = true;
            this.aboutMeTextBox.Name = "aboutMeTextBox";
            this.aboutMeTextBox.Size = new System.Drawing.Size(470, 232);
            this.aboutMeTextBox.TabIndex = 6;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.acceptButton.Location = new System.Drawing.Point(58, 662);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(322, 72);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.phoneLabel.Location = new System.Drawing.Point(53, 269);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(119, 29);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Телефон";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(58, 205);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(308, 54);
            this.emailBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.emailLabel.Location = new System.Drawing.Point(53, 173);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(125, 29);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Эл. почта";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBox.Location = new System.Drawing.Point(58, 301);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(308, 54);
            this.phoneBox.TabIndex = 3;
            // 
            // fillfieldsLabel
            // 
            this.fillfieldsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillfieldsLabel.AutoSize = true;
            this.fillfieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillfieldsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fillfieldsLabel.Location = new System.Drawing.Point(51, 28);
            this.fillfieldsLabel.Name = "fillfieldsLabel";
            this.fillfieldsLabel.Size = new System.Drawing.Size(517, 40);
            this.fillfieldsLabel.TabIndex = 0;
            this.fillfieldsLabel.Text = "Информация об исполнителе";
            this.fillfieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createSkillButton
            // 
            this.createSkillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.createSkillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSkillButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.createSkillButton.Location = new System.Drawing.Point(554, 662);
            this.createSkillButton.Name = "createSkillButton";
            this.createSkillButton.Size = new System.Drawing.Size(141, 64);
            this.createSkillButton.TabIndex = 7;
            this.createSkillButton.Text = "Создать";
            this.createSkillButton.UseVisualStyleBackColor = false;
            this.createSkillButton.Click += new System.EventHandler(this.createSkillButton_Click);
            // 
            // editSkillButton
            // 
            this.editSkillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.editSkillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSkillButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.editSkillButton.Location = new System.Drawing.Point(721, 662);
            this.editSkillButton.Name = "editSkillButton";
            this.editSkillButton.Size = new System.Drawing.Size(141, 64);
            this.editSkillButton.TabIndex = 7;
            this.editSkillButton.Text = "Внести изменения";
            this.editSkillButton.UseVisualStyleBackColor = false;
            this.editSkillButton.Click += new System.EventHandler(this.editSkillButton_Click);
            // 
            // deleteSkillButton
            // 
            this.deleteSkillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.deleteSkillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSkillButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.deleteSkillButton.Location = new System.Drawing.Point(890, 662);
            this.deleteSkillButton.Name = "deleteSkillButton";
            this.deleteSkillButton.Size = new System.Drawing.Size(141, 64);
            this.deleteSkillButton.TabIndex = 7;
            this.deleteSkillButton.Text = "Удалить";
            this.deleteSkillButton.UseVisualStyleBackColor = false;
            this.deleteSkillButton.Click += new System.EventHandler(this.deleteSkillButton_Click);
            // 
            // moreLabel
            // 
            this.moreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moreLabel.AutoSize = true;
            this.moreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.moreLabel.Location = new System.Drawing.Point(549, 183);
            this.moreLabel.Name = "moreLabel";
            this.moreLabel.Size = new System.Drawing.Size(143, 29);
            this.moreLabel.TabIndex = 0;
            this.moreLabel.Text = "Подробнее";
            this.moreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skilltypeBox
            // 
            this.skilltypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skilltypeBox.BackColor = System.Drawing.SystemColors.Window;
            this.skilltypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skilltypeBox.Location = new System.Drawing.Point(554, 116);
            this.skilltypeBox.Multiline = true;
            this.skilltypeBox.Name = "skilltypeBox";
            this.skilltypeBox.Size = new System.Drawing.Size(308, 54);
            this.skilltypeBox.TabIndex = 2;
            // 
            // skilltypeLabel
            // 
            this.skilltypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skilltypeLabel.AutoSize = true;
            this.skilltypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skilltypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.skilltypeLabel.Location = new System.Drawing.Point(549, 84);
            this.skilltypeLabel.Name = "skilltypeLabel";
            this.skilltypeLabel.Size = new System.Drawing.Size(85, 29);
            this.skilltypeLabel.TabIndex = 0;
            this.skilltypeLabel.Text = "Навык";
            this.skilltypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moreBox
            // 
            this.moreBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreBox.Location = new System.Drawing.Point(554, 215);
            this.moreBox.Multiline = true;
            this.moreBox.Name = "moreBox";
            this.moreBox.Size = new System.Drawing.Size(534, 164);
            this.moreBox.TabIndex = 3;
            // 
            // skillsDataGridView
            // 
            this.skillsDataGridView.AllowUserToAddRows = false;
            this.skillsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillsDataGridView.Location = new System.Drawing.Point(554, 406);
            this.skillsDataGridView.Name = "skillsDataGridView";
            this.skillsDataGridView.RowHeadersWidth = 62;
            this.skillsDataGridView.RowTemplate.Height = 28;
            this.skillsDataGridView.Size = new System.Drawing.Size(534, 238);
            this.skillsDataGridView.TabIndex = 8;
            this.skillsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skillsDataGridView_CellClick);
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fullnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameTextBox.Location = new System.Drawing.Point(58, 116);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(308, 54);
            this.fullnameTextBox.TabIndex = 10;
            // 
            // fullnameLlabel
            // 
            this.fullnameLlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullnameLlabel.AutoSize = true;
            this.fullnameLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fullnameLlabel.Location = new System.Drawing.Point(53, 84);
            this.fullnameLlabel.Name = "fullnameLlabel";
            this.fullnameLlabel.Size = new System.Drawing.Size(70, 29);
            this.fullnameLlabel.TabIndex = 9;
            this.fullnameLlabel.Text = "ФИО";
            this.fullnameLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutMeMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 743);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.fullnameLlabel);
            this.Controls.Add(this.skillsDataGridView);
            this.Controls.Add(this.deleteSkillButton);
            this.Controls.Add(this.editSkillButton);
            this.Controls.Add(this.createSkillButton);
            this.Controls.Add(this.fillfieldsLabel);
            this.Controls.Add(this.moreBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skilltypeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.aboutMeTextBox);
            this.Controls.Add(this.skilltypeBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.moreLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.acceptButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutMeMasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.skillsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aboutMeTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label fillfieldsLabel;
        private System.Windows.Forms.Button createSkillButton;
        private System.Windows.Forms.Button editSkillButton;
        private System.Windows.Forms.Button deleteSkillButton;
        private System.Windows.Forms.Label moreLabel;
        private System.Windows.Forms.TextBox skilltypeBox;
        private System.Windows.Forms.Label skilltypeLabel;
        private System.Windows.Forms.TextBox moreBox;
        private System.Windows.Forms.DataGridView skillsDataGridView;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Label fullnameLlabel;
    }
}