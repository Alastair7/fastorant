using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.RegularExpressions;

namespace Fastorant.Host.Configuration.Swagger
{
    public class CamelCasePathDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var paths = swaggerDoc.Paths.ToDictionary(
                entry => ToCamelCasePath(entry.Key),
                entry => entry.Value);

            swaggerDoc.Paths = new OpenApiPaths();
            foreach (var path in paths) 
            {
                swaggerDoc.Paths[path.Key] = path.Value;
            }
        }

        private static string ToCamelCasePath(string path) 
        {
            return Regex
                .Replace(path, @"\/([A-Z])", 
                match => "/" + char.ToLowerInvariant(
                    match.Groups[1].Value[0]) + match.Value.Substring(2));
        }
    }
}
