using CSharpFunctionalExtensions;
using ProductivityServices.Foundation.Models;
using System;

namespace ProductivityServices.Factory.Factory
{
    public class FactoryService : IFactoryService
    {
        IFileSystemService _fileSystemService;
        IModelsService _modelsService;


        public FactoryService(IFileSystemService fileSystemService, IModelsService modelsService)
        {
            _fileSystemService = fileSystemService ?? throw new ArgumentNullException(nameof(fileSystemService));
            _modelsService = modelsService ?? throw new ArgumentNullException(nameof(modelsService));
        }

        public Result Load()
        {
            return _fileSystemService.Load().Check(_modelsService.Load);
        }

        public Result Save()
        {
            return _fileSystemService.Save(_modelsService.Project);
        }
    }
}

