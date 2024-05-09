
namespace Freelance_IT.Forms
{
    partial class FeedbackForm
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
            this.commentBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.orderIDLinkLabel = new System.Windows.Forms.LinkLabel();
            this.scoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fillfieldsLabel
            // 
            this.fillfieldsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillfieldsLabel.AutoSize = true;
            this.fillfieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillfieldsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.fillfieldsLabel.Location = new System.Drawing.Point(20, 19);
            this.fillfieldsLabel.Name = "fillfieldsLabel";
            this.fillfieldsLabel.Size = new System.Drawing.Size(284, 40);
            this.fillfieldsLabel.TabIndex = 0;
            this.fillfieldsLabel.Text = "Отзыв к заказу:";
            this.fillfieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.acceptButton.Location = new System.Drawing.Point(27, 381);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(230, 48);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // commentBox
            // 
            this.commentBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commentBox.BackColor = System.Drawing.SystemColors.Window;
            this.commentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentBox.Location = new System.Drawing.Point(27, 199);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(540, 164);
            this.commentBox.TabIndex = 2;
            // 
            // commentLabel
            // 
            this.commentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.commentLabel.Location = new System.Drawing.Point(22, 167);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(177, 29);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Комментарий";
            this.commentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.scoreLabel.Location = new System.Drawing.Point(22, 83);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(101, 29);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Оценка";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderIDLinkLabel
            // 
            this.orderIDLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderIDLinkLabel.AutoSize = true;
            this.orderIDLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIDLinkLabel.ForeColor = System.Drawing.Color.White;
            this.orderIDLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(163)))), ((int)(((byte)(81)))));
            this.orderIDLinkLabel.Location = new System.Drawing.Point(310, 19);
            this.orderIDLinkLabel.Name = "orderIDLinkLabel";
            this.orderIDLinkLabel.Size = new System.Drawing.Size(176, 40);
            this.orderIDLinkLabel.TabIndex = 13;
            this.orderIDLinkLabel.TabStop = true;
            this.orderIDLinkLabel.Text = "ID заказа";
            this.orderIDLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreNumericUpDown
            // 
            this.scoreNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreNumericUpDown.Location = new System.Drawing.Point(27, 115);
            this.scoreNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scoreNumericUpDown.Name = "scoreNumericUpDown";
            this.scoreNumericUpDown.Size = new System.Drawing.Size(81, 44);
            this.scoreNumericUpDown.TabIndex = 15;
            this.scoreNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 449);
            this.Controls.Add(this.scoreNumericUpDown);
            this.Controls.Add(this.orderIDLinkLabel);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.fillfieldsLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fillfieldsLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.LinkLabel orderIDLinkLabel;
        private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
    }
}