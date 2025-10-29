using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddEditTaskForm : Form
    {
        public string TaskTitle => txtTitle.Text.Trim();
        public DateTime DueDate => dtpDueDate.Value;
        public bool IsCompleted => chkCompleted.Checked;

        public AddEditTaskForm()
        {
            InitializeComponent();
            chkCompleted.Visible = false; // при добавлении задача не выполнена
        }

        public AddEditTaskForm(TaskItem task) : this()
        {
            Text = "Редактировать задачу";
            txtTitle.Text = task.Title;
            dtpDueDate.Value = task.DueDate;
            chkCompleted.Checked = task.IsCompleted;
            chkCompleted.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskTitle))
            {
                MessageBox.Show("Введите название задачи.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}