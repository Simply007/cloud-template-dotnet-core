using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace cloud_template_dotnet_core.ViewModels
{
    public class DeliveryApiSpecificationViewModel
    {
        public string Title { get; internal set; }
        public IRichTextContent Description { get; internal set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IRichTextContent EndPoints { get; set; }
        public IEnumerable<ApiPathViewModel> Paths { get; set; }
        public string Version { get; internal set; }
    }
}