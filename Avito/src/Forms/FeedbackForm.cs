using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Avito.Classes;

namespace Avito.Forms
{
    public partial class FeedbackForm : Form
    {
        // private
        /*private Feedback _feedback;

        private FeedbackForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _feedback.score = (uint)scoreNumericUpDown.Value;
            _feedback.comment = commentBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        // public
        public static Feedback getFeedback(Feedback feedback)
        {
            FeedbackForm feedbackForm = new FeedbackForm();

            if (feedback == null)
            {
                MessageBox.Show("Невозможно оставить отзыв(");
                return null;              
            }

            if (feedback.score != 0)
            {
                feedbackForm.scoreNumericUpDown.Value = feedback.score;
            }

            feedbackForm.commentBox.Text = feedback.comment;
            feedbackForm.orderIDLinkLabel.Text = feedback.id_order.ToString();

            feedbackForm._feedback = feedback;

            if (feedbackForm.ShowDialog() == DialogResult.OK)
            {
                return feedbackForm._feedback;
            }

            return null;
        }*/
    }
}
