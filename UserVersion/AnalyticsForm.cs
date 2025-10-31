using Microsoft.EntityFrameworkCore;
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
    public partial class AnalyticsForm : Form
    {
        private readonly AppDbContext _context;
        public AnalyticsForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadAnalytics();

        }

        private void LoadAnalytics()
        {
            var sb = new StringBuilder();
            sb.AppendLine("📊 Аналитика проектов и задач");
            sb.AppendLine(new string('=', 50));

            // 1. Общая статистика
            var totalProjects = _context.Projects.Count();
            var totalTasks = _context.Tasks.Count();
            var completedTasks = _context.Tasks.Count(t => t.IsCompleted);
            var overdueTasks = _context.Tasks.Count(t => !t.IsCompleted && t.DueDate < DateTime.Today);

            sb.AppendLine($"Всего проектов: {totalProjects}");
            sb.AppendLine($"Всего задач: {totalTasks}");
            sb.AppendLine($"Завершено задач: {completedTasks} ({(totalTasks > 0 ? (double)completedTasks / totalTasks * 100 : 0):F1}%)");
            sb.AppendLine($"Просрочено задач: {overdueTasks}");
            sb.AppendLine();

            // 2. Топ-3 самых загруженных проекта
            sb.AppendLine("🔥 Топ-3 проекта по количеству задач:");
            var topProjects = _context.Projects
                .Select(p => new
                {
                    p.Name,
                    TaskCount = p.Tasks.Count
                })
                .OrderByDescending(x => x.TaskCount)
                .Take(3)
                .ToList();

            foreach (var proj in topProjects)
            {
                sb.AppendLine($"- {proj.Name}: {proj.TaskCount} задач");
            }
            sb.AppendLine();

            // 3. Просроченные задачи
            sb.AppendLine("⏰ Просроченные задачи (не завершены):");
            var overdueList = _context.Tasks
                .Where(t => !t.IsCompleted && t.DueDate < DateTime.Today)
                .Include(t => t.Project)
                .OrderBy(t => t.DueDate)
                .ToList();

            if (overdueList.Any())
            {
                foreach (var task in overdueList)
                {
                    sb.AppendLine($"- [{task.Project.Name}] {task.Title} (срок: {task.DueDate:dd.MM.yyyy})");
                }
            }
            else
            {
                sb.AppendLine("Нет просроченных задач.");
            }
            sb.AppendLine();

            // 4. Проекты без задач
            var emptyProjects = _context.Projects
                .Where(p => p.Tasks.Count == 0)
                .ToList();

            if (emptyProjects.Any())
            {
                sb.AppendLine("📂 Проекты без задач:");
                foreach (var p in emptyProjects)
                {
                    sb.AppendLine($"- {p.Name}");
                }
            }

            txtResults.Text = sb.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAnalytics();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}