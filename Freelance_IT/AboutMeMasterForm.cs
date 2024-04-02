using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_IT
{
    public partial class AboutMeMasterForm : Form
    {
        // private
        private Master _master;

        private DataTable skillDataTable = new DataTable();
        private int selectedRow = -1;

        private AboutMeMasterForm()
        {
            InitializeComponent();

            // Инициализируем таблицу с навыками
            skillDataTable.Columns.Clear();
            skillDataTable.Columns.Add("Тип навыка", typeof(string));
            skillDataTable.Columns.Add("Подробное описание", typeof(string));
        }

        private void addSkillTableRow(string skill_type, string description)
        {
            skilltypeBox.Text = skill_type;
            moreBox.Text = description;
        }


        private void createSkillButton_Click(object sender, EventArgs e)
        {
            skillDataTable.Rows.Add(skilltypeBox.Text, moreBox.Text);
            addSkillTableRow("", "");
        }

        private void skillsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow == -1)
            {
                return;
            }
            skilltypeBox.Text = skillsDataGridView.Rows[selectedRow].Cells[0].Value.ToString();
            moreBox.Text = skillsDataGridView.Rows[selectedRow].Cells[1].Value.ToString();
        }

        private void editSkillButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                return;
            }
            skillsDataGridView.Rows[selectedRow].Cells[0].Value = skilltypeBox.Text;
            skillsDataGridView.Rows[selectedRow].Cells[1].Value = moreBox.Text;
            selectedRow = -1;
        }

        private void deleteSkillButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                return;
            }
            skillsDataGridView.Rows.RemoveAt(selectedRow);
            selectedRow = -1;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _master.fullname = fullnameTextBox.Text;
            _master.phone = phoneBox.Text;
            _master.email = emailBox.Text;
            _master.about_me = aboutMeTextBox.Text;

            foreach (DataRow skill_row in skillDataTable.Rows)
            {
                _master.skills[skill_row["Тип навыка"].ToString()] = skill_row["Подробное описание"].ToString();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // public
        public static Master getDetailedInfo(Master master)
        {
            AboutMeMasterForm aboutMasterWindow = new AboutMeMasterForm();

            if (master != null)
            {
                aboutMasterWindow._master = master;
                aboutMasterWindow.fullnameTextBox.Text = master.fullname;
                aboutMasterWindow.phoneBox.Text = master.phone;
                aboutMasterWindow.emailBox.Text = master.email;
                aboutMasterWindow.aboutMeTextBox.Text = master.about_me;
                foreach(KeyValuePair<string, string> skill in master.skills)
                {
                    aboutMasterWindow.addSkillTableRow(skill.Key, skill.Value);
                }
            }
            else
            {
                aboutMasterWindow._master = new Master();
            }

            if (aboutMasterWindow.ShowDialog() == DialogResult.OK)
            {
                return aboutMasterWindow._master;
            }

            return null;
        }

    }
}
