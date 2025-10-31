using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class TaskViewForm : Form
    {
        private readonly AppDbContext _context = new();
        private readonly Project _project;

        public TaskViewForm(Project project)
        {
            InitializeComponent();
            _project = project;
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

        // Разрешаем отмечать задачи как выполненные
        private void dataGridViewTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = (int)dataGridViewTasks.Rows[e.RowIndex].Cells["Id"].Value;
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return;

            // Переключаем статус
            task.IsCompleted = !task.IsCompleted;
            _context.SaveChanges();
            LoadTasks(); // обновляем таблицу
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу.");
                return;
            }

            try
            {
                var id = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["Id"].Value);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}