namespace ProjectTemplate.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectTemplate.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjectTemplate.Data.DataContext";
        }

        protected override void Seed(ProjectTemplate.Data.DataContext context)
        {
            for (int i = 0; i <= 10; i++)
            {
                context.Samples.Add(new Core.DomainModel.Sample() {
                    Name = $"Name{i.ToString()}"
                });
            }
            context.SaveChanges();
        }
    }
}
