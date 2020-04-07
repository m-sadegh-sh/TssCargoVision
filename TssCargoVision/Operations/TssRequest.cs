using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TssCargoVision.Operations
{
    public sealed class TssRequest
    {
        public IDictionary<string, string> Params { get; set; }

        public static TssRequest Create(string method, object instance)
        {
            var @params = instance.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .OfType<PropertyInfo>()
                .ToDictionary(p => $"params[{p.Name}]", p => p.GetValue(instance)?.ToString());

            @params.Add("method", method);

            return new TssRequest
            {
                Params = @params
            };
        }
    }
}
