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
    public partial class ApiSchemaInteger
    {
        public const string Codename = "api_schema__integer";
        public const string ReadonlyCodename = "readonly";
        public const string MinimumCodename = "minimum";
        public const string DescriptionCodename = "description";
        public const string FormatCodename = "format";
        public const string NullableCodename = "nullable";
        public const string NameCodename = "name";
        public const string WriteonlyCodename = "writeonly";
        public const string ExampleCodename = "example";
        public const string AcceptedValuesCodename = "accepted_values";
        public const string DefaultCodename = "default";
        public const string MaximumCodename = "maximum";

        public IEnumerable<MultipleChoiceOption> Readonly { get; set; }
        public decimal? Minimum { get; set; }
        public IRichTextContent Description { get; set; }
        public string Format { get; set; }
        public IEnumerable<MultipleChoiceOption> Nullable { get; set; }
        public string Name { get; set; }
        public IEnumerable<MultipleChoiceOption> Writeonly { get; set; }
        public string Example { get; set; }
        public string AcceptedValues { get; set; }
        public decimal? Default { get; set; }
        public decimal? Maximum { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}