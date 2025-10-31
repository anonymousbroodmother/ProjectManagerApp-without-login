using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context = new();

        public Form1()
        {
            InitializeComponent();
            _context.Database.EnsureCreated();
            LoadProjects();
        }

        private void LoadProjects()
        {
            listBoxProjects.Items.Clear();
            var projects = _context.Projects.ToList();
            foreach (var p in projects)
            {
                listBoxProjects.Items.Add($"{p.Id}: {p.Name}");
            }
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem == null) return;

            var id = int.Parse(listBoxProjects.SelectedItem.ToString().Split(':')[0]);
            var project = _context.Projects.Include(p => p.Tasks).FirstOrDefault(p => p.Id == id);
            if (project == null) return;

            var taskForm = new TaskViewForm(project);
            taskForm.ShowDialog();
        }
    }
}