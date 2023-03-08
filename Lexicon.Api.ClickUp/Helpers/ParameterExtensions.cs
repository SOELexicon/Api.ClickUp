using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Parameter Extensions By Craig Wright
/// Used to get the parameters from a Params object and return them as RestSharp Parameters
/// </summary>
namespace Api.ClickUp.Helpers
{
    public static class ParamsExtensions
    {
        public static List<Parameter> GetParametersFromParamsObject<T>(this T paramsObject)
        {
            List<Parameter> parameters = new List<Parameter>();

            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(paramsObject);

                if (value != null)
                {
                    string name = property.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? property.Name;
                    Parameter parameter = new Parameter(name, value.ToString(), ParameterType.QueryString);
                    parameters.Add(parameter);
                }
            }

            return parameters;
        }
    }
}