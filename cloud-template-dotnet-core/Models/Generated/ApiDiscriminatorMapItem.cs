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
    public partial class ApiDiscriminatorMapItem
    {
        public const string Codename = "api_discriminator__map_item";
        public const string DiscriminatorValueCodename = "discriminator_value";
        public const string SchemaCodename = "schema";

        public string DiscriminatorValue { get; set; }
        public IEnumerable<object> Schema { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}