using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace cloud_template_dotnet_core.ViewModels
{
    public class PathOperationViewModel
    {
        public IEnumerable<ApiParameterViewModel> Parameters { get; internal set; }
        public IEnumerable<TaxonomyTerm> Operation { get; internal set; }
        public string Summary { get; internal set; }
        public IRichTextContent Description { get; internal set; }
    }
}