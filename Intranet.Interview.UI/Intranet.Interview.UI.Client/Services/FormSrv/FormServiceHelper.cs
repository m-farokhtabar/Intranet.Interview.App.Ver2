using Intranet.Interview.UI.Client.Model;
using System.Text.Json;

namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    public static class FormServiceHelper
    {
        /// <summary>
        /// Convert dynamic data value of the form To raw json
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static string FieldsToJson(List<Field> fields)
        {
            if (fields?.Count > 0)
            {
                var formData = new Dictionary<string, object?>();
                foreach (var field in fields)
                {
                    formData[field.Label] = field.Type switch
                    {
                        "text" or "email" or "dropdown" => field.StringValue,
                        "multidropdown" => field.SelectedValues is not null && field.SelectedValues.Count()>0 ?  field.SelectedValues : null,
                        "number" => field.IntValue,
                        "checkbox" => field.BoolValue,
                        _ => null
                    };
                }
                return JsonSerializer.Serialize(formData);
            }
            else
                return string.Empty;
        }
    }
}
