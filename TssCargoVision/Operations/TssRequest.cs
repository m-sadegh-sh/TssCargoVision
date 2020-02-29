using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TssCargoVision.Operations
{
    public sealed class TssRequest
    {
        public string Method { get; set; }

        public IDictionary<string, object> Params { get; set; }

        public static TssRequest Create(string method, object instance)
        {
            var @params = instance.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .OfType<PropertyInfo>()
                .ToDictionary(p => p.Name, p => p.GetValue(instance));

            return new TssRequest
            {
                Method = method,
                Params = @params
            };
        }
    }
}
