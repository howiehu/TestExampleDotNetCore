namespace ExpenseService.Models.Project
{
    public class Project
    {
        public Project(ProjectType type, string name)
        {
            Type = type;
            Name = name;
        }

        public ProjectType Type { get; }

        public string Name { get; }
    }
}
