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
    public partial class TaskViewForm : Form
    {
        private readonly AppDbContext _context;
        private readonly Project _project;

        public TaskViewForm(Project project)
        {
            InitializeComponent();
            _project = project;
            _context = new AppDbContext();
            lblTitle.Text = $"Задачи проекта: {_project.Name}";
            LoadTasks();
        }

        private void LoadTasks()
        {
            var tasks = _context.Tasks
                .Where(t => t.ProjectId == _project.Id)
                .ToList();

            dataGridViewTasks.DataSource = tasks.Select(t => new
            {
                t.Id,
                t.Title,
                Выполнено = t.IsCompleted ? "Да" : "Нет",
                Срок = t.DueDate.ToShortDateString()
            }).ToList();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var form = new AddEditTaskForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var task = new TaskItem
                {
                    Title = form.TaskTitle,
                    IsCompleted = false,
                    DueDate = form.DueDate,
                    ProjectId = _project.Id
                };
                _context.Tasks.Add(task);
                _context.SaveChanges();
                LoadTasks();
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для редактирования.");
                return;
            }

            var id = (int)dataGridViewTasks.SelectedRows[0].Cells["Id"].Value;
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return;

            var form = new AddEditTaskForm(task);
            if (form.ShowDialog() == DialogResult.OK)
            {
                task.Title = form.TaskTitle;
                task.DueDate = form.DueDate;
                task.IsCompleted = form.IsCompleted;
                _context.SaveChanges();
                LoadTasks();
            }
        }


        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для удаления.");
                return;
            }

            var id = (int)dataGridViewTasks.SelectedRows[0].Cells["Id"].Value;

            if (MessageBox.Show("Удалить выбранную задачу?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
                if (task != null)
                {
                    _context.Tasks.Remove(task);
                    _context.SaveChanges();
                    LoadTasks();
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}