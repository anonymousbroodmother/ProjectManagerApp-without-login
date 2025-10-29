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
    public partial class AddEditProjectForm : Form
    {
        public string ProjectName => txtName.Text.Trim();
        public string Description => txtDescription.Text.Trim();

        public AddEditProjectForm()
        {
            InitializeComponent();
        }

        // Конструктор для редактирования
        public AddEditProjectForm(Project project) : this()
        {
            Text = "Редактировать проект";
            txtName.Text = project.Name;
            txtDescription.Text = project.Description;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectName))
            {
                MessageBox.Show("Введите название проекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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