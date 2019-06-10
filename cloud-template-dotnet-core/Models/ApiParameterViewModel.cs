using KenticoCloud.Delivery;

namespace cloud_template_dotnet_core.ViewModels
{
    public class ApiParameterViewModel
    {
        public string Schema { get; internal set; }
        public string Location { get; internal set; }
        public IRichTextContent Description { get; internal set; }
        public string Name { get; internal set; }
    }
}