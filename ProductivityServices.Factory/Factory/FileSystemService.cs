using CSharpFunctionalExtensions;
using Microsoft.Win32;
using System.Text.Json;

namespace ProductivityServices.Factory.Factory
{
    public class FileSystemService : IFileSystemService
    {
        public Result<Factory> Load()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var reuslt = openFileDialog.ShowDialog();

            if (reuslt == true)
            {
                var content = System.IO.File.ReadAllText(openFileDialog.FileName);

                return JsonSerializer.Deserialize<Factory>(content);
            }

            return Result.Failure<Factory>("FAiL");
        }

        public Result Save(Factory factory)
        {
            var content = JsonSerializer.Serialize(factory);

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
