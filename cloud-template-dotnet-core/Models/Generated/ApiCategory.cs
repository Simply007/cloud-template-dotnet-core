// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace KenticoCloud.Models
{
    public partial class ApiCategory
    {
        public const string Codename = "api_category";
        public const string UrlCodename = "url";
        public const string DescriptionCodename = "description";
        public const string ApiReferenceCodename = "api_reference";
        public const string NameCodename = "name";

        public string Url { get; set; }
        public IRichTextContent Description { get; set; }
        public IEnumerable<TaxonomyTerm> ApiReference { get; set; }
        public string Name { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}