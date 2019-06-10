using KenticoCloud.Delivery;

namespace cloud_template_dotnet_core.ViewModels
{
    public class CategoryViewModel
    {
        public string Name { get; internal set; }
        public IRichTextContent Description { get; internal set; }

        public string HeadingId => $"{Name.ToLower().Replace(" ", "-")}-heading";
        public string ContentId => $"{Name.ToLower().Replace(" ", "-")}-content";
    }
}