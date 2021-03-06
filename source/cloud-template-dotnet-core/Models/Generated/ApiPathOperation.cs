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
    public partial class ApiPathOperation
    {
        public const string Codename = "api_path_operation";
        public const string RequestBodyCodename = "request_body";
        public const string SummaryCodename = "summary";
        public const string DeprecatedCodename = "deprecated";
        public const string CodeSamplesCodename = "code_samples";
        public const string ApiReferenceCodename = "api_reference";
        public const string ParametersCodename = "parameters";
        public const string DescriptionCodename = "description";
        public const string PathOperationCodename = "path_operation";
        public const string UrlCodename = "url";
        public const string CategoryCodename = "category";
        public const string ResponsesCodename = "responses";

        public IRichTextContent RequestBody { get; set; }
        public string Summary { get; set; }
        public IEnumerable<MultipleChoiceOption> Deprecated { get; set; }
        public IEnumerable<object> CodeSamples { get; set; }
        public IEnumerable<TaxonomyTerm> ApiReference { get; set; }
        public IEnumerable<object> Parameters { get; set; }
        public IRichTextContent Description { get; set; }
        public IEnumerable<TaxonomyTerm> PathOperation { get; set; }
        public string Url { get; set; }
        public IEnumerable<object> Category { get; set; }
        public IRichTextContent Responses { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}