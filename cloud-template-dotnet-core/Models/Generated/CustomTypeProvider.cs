using System;
using System.Collections.Generic;
using System.Linq;
using KenticoCloud.Delivery;

namespace KenticoCloud.Models
{
    public class CustomTypeProvider : ITypeProvider
    {
        private static readonly Dictionary<Type, string> _codenames = new Dictionary<Type, string>
        {
            {typeof(ApiCategory), "api_category"},
            {typeof(ApiContact), "api_contact"},
            {typeof(ApiDiscriminator), "api_discriminator"},
            {typeof(ApiDiscriminatorMapItem), "api_discriminator__map_item"},
            {typeof(ApiLicense), "api_license"},
            {typeof(ApiParameter), "api_parameter"},
            {typeof(ApiPath), "api_path"},
            {typeof(ApiPathOperation), "api_path_operation"},
            {typeof(ApiPropertyReferencingASchema), "api_property_referencing_a_schema"},
            {typeof(ApiRequestBody), "api_request_body"},
            {typeof(ApiResponse), "api_response"},
            {typeof(ApiResponseContainer), "api_response_container"},
            {typeof(ApiResponseContent), "api_response_content"},
            {typeof(ApiSchemaAllof), "api_schema__allof"},
            {typeof(ApiSchemaArray), "api_schema__array"},
            {typeof(ApiSchemaBoolean), "api_schema__boolean"},
            {typeof(ApiSchemaInteger), "api_schema__integer"},
            {typeof(ApiSchemaObject), "api_schema__object"},
            {typeof(ApiSchemaOneof), "api_schema__oneof"},
            {typeof(ApiSchemaString), "api_schema__string"},
            {typeof(ApiSecurityScheme), "api_security_scheme"},
            {typeof(ApiServer), "api_server"},
            {typeof(ApiSpecification), "api_specification"},
            {typeof(Callout), "callout"},
            {typeof(CodeSample), "code_sample"},
            {typeof(CodeSamples), "code_samples"},
            {typeof(Image), "image"}
        };

        public Type GetType(string contentType)
        {
            return _codenames.Keys.FirstOrDefault(type => GetCodename(type).Equals(contentType));
        }

        public string GetCodename(Type contentType)
        {
            return _codenames.TryGetValue(contentType, out var codename) ? codename : null;
        }
    }
}