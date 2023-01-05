using CSharpFunctionalExtensions;
using Microsoft.Win32;
using ProductivityServices.Foundation.Models;
using System.Text.Json;

namespace ProductivityServices.Factory.Factory
{
    public class FileSystemService : IFileSystemService
    {
        public Result<Project> Load()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var reuslt = openFileDialog.ShowDialog();

            if (reuslt == true)
            {
                var content = System.IO.File.ReadAllText(openFileDialog.FileName);

                return JsonSerializer.Deserialize<Project>(content);
            }

            return Result.Failure<Project>("Fail");
        }

        public Result Save(Project project)
        {
            var content = JsonSerializer.Serialize(project);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            var reuslt = saveFileDialog.ShowDialog();

            if (reuslt == true)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, content);
            }

            return Result.Success();
        }
    }
}

