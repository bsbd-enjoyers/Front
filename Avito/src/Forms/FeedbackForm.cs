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
using Avito.Network;

namespace Avito.Forms
{
    public partial class FeedbackForm : Form
    {
        // private
        private FeedbackForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        // public
        public static int getFeedback()
        {
            FeedbackForm feedbackForm = new FeedbackForm();

            if (feedbackForm.ShowDialog() == DialogResult.OK)
            {
                return (int)feedbackForm.scoreNumericUpDown.Value;
            }
            return -1;
        }
    }
}
