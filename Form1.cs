using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Project> projects = new List<Project>();
        private int nextProjectId = 1;
        private readonly AppDbContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            LoadProjects();
        }

        private void UpdateProjectList()
        {
            listBoxProjects.Items.Clear();
            foreach (var proj in projects)
            {
                listBoxProjects.Items.Add($"{proj.Id}: {proj.Name}");
            }
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

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            var form = new AddProjectForm(); // создадим отдельную форму для ввода
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newProject = new Project
                {
                    Id = nextProjectId++,
                    Name = form.ProjectName,
                    Description = form.Description,
                    StartDate = DateTime.Now
                };
                projects.Add(newProject);
                UpdateProjectList();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditProjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var project = new Project
                {
                    Name = form.ProjectName,
                    Description = form.Description,
                    StartDate = DateTime.Now
                };
                _context.Projects.Add(project);
                _context.SaveChanges();
                LoadProjects();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem == null) return;

            var selectedText = listBoxProjects.SelectedItem.ToString();
            var id = int.Parse(selectedText.Split(':')[0]);

            var project = _context.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return;

            var form = new AddEditProjectForm(project);
            if (form.ShowDialog() == DialogResult.OK)
            {
                project.Name = form.ProjectName;
                project.Description = form.Description;
                _context.SaveChanges();
                LoadProjects();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem == null) return;

            var selectedText = listBoxProjects.SelectedItem.ToString();
            var id = int.Parse(selectedText.Split(':')[0]);

            var project = _context.Projects.Include(p => p.Tasks).FirstOrDefault(p => p.Id == id);
            if (project == null) return;

            if (MessageBox.Show($"Удалить проект '{project.Name}' и все его задачи?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
                LoadProjects();
            }
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem == null) return;

            var selectedText = listBoxProjects.SelectedItem.ToString();
            var id = int.Parse(selectedText.Split(':')[0]);

            var project = _context.Projects.Include(p => p.Tasks).FirstOrDefault(p => p.Id == id);
            if (project == null) return;

            var taskForm = new TaskViewForm(project);
            taskForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}