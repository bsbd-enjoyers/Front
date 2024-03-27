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
        DataTable skillDataTable = new DataTable();
        int selectedRow = -1;

        public AboutMeMasterForm()
        {
            InitializeComponent();

            // Инициализируем таблицу с навыками
            skillDataTable.Columns.Clear();
            skillDataTable.Columns.Add("Тип навыка", typeof(string));
            skillDataTable.Columns.Add("Подробное описание", typeof(string));
        }

        private void createSkillButton_Click(object sender, EventArgs e)
        {
            skillDataTable.Rows.Add(skilltypeBox.Text, moreBox.Text);
            skilltypeBox.Text = "";
            moreBox.Text = "";
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
    }
}
