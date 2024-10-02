using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lab3.Api.Attribute;

public class JsonPropertyNameSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        var jsonPropertyAttributes = context.Type.GetTypeInfo()
            .DeclaredProperties
            .Where(p => p.GetCustomAttribute<JsonPropertyNameAttribute>() != null);

        foreach (var prop in jsonPropertyAttributes)
        {
            var jsonPropertyName = ((JsonPropertyNameAttribute)prop
                .GetCustomAttributes(typeof(JsonPropertyNameAttribute), true)
                .First()).Name;

            if (schema.Properties.ContainsKey(prop.Name))
            {
                // Rename the Swagger schema property to the JSON property name
                var schemaProperty = schema.Properties[prop.Name];
                schema.Properties.Remove(prop.Name);
                schema.Properties.Add(jsonPropertyName, schemaProperty);
            }
        }
    }
}
