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
    public partial class ApiDiscriminator
    {
        public const string Codename = "api_discriminator";
        public const string MappingCodename = "mapping";
        public const string PropertyNameCodename = "property_name";

        public IRichTextContent Mapping { get; set; }
        public string PropertyName { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}