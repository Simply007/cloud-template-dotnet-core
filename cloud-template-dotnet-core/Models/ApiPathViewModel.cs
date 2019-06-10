using System.Collections.Generic;

namespace cloud_template_dotnet_core.ViewModels
{
    public class ApiPathViewModel
    {
        public IEnumerable<PathOperationViewModel> PathOperations { get; internal set; }
        public string Path { get; internal set; }
    }
}