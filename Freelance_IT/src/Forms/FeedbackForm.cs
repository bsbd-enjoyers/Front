using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Freelance_IT.Classes;

namespace Freelance_IT.Forms
{
    public partial class FeedbackForm : Form
    {
        // private
        private Feedback _feedback;

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
        public static Feedback getFeedback(Feedback feedback = null)
        {
            FeedbackForm feedbackForm = new FeedbackForm();

            if (feedback != null)
            {
                feedbackForm.scoreNumericUpDown.Value = feedback.score;
                feedbackForm.commentBox.Text = feedback.comment;
                feedbackForm.orderIDLinkLabel.Text = feedback.id_order.ToString();
            }
            else
            {
                feedbackForm._feedback = new Feedback();
            }

            if (feedbackForm.ShowDialog() == DialogResult.OK)
            {
                return feedbackForm._feedback;
            }

            return null;
        }
    }
}
