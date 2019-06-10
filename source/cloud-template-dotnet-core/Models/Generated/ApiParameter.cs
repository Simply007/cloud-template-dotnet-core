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
    public partial class ApiParameter
    {
        public const string Codename = "api_parameter";
        public const string SchemaCodename = "schema";
        public const string ExplodeCodename = "explode";
        public const string ApiReferenceCodename = "api_reference";
        public const string DescriptionCodename = "description";
        public const string NameCodename = "name";
        public const string DeprecatedCodename = "deprecated";
        public const string StyleCodename = "style";
        public const string ExampleCodename = "example";
        public const string RequiredCodename = "required";
        public const string InCodename = "in";

        public IEnumerable<object> Schema { get; set; }
        public IEnumerable<MultipleChoiceOption> Explode { get; set; }
        public IEnumerable<TaxonomyTerm> ApiReference { get; set; }
        public IRichTextContent Description { get; set; }
        public string Name { get; set; }
        public IEnumerable<MultipleChoiceOption> Deprecated { get; set; }
        public IEnumerable<MultipleChoiceOption> Style { get; set; }
        public string Example { get; set; }
        public IEnumerable<MultipleChoiceOption> Required { get; set; }
        public IEnumerable<MultipleChoiceOption> In { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}