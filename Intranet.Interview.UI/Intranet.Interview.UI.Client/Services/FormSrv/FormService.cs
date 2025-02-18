using Intranet.Interview.UI.Client.Model;
using System.Net.Http.Json;
using static Intranet.Interview.UI.Client.Services.FormSrv.FormServiceHelper;

namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    /// <summary>
    /// Manange Dynamic Forms
    /// <list type="bullet">
    /// <item>Read Form Meta</item>
    /// <item>Send data to the end point</item>
    /// </list>
    /// </summary>
    public class FormService : IFormService
    {        
        private readonly HttpClient http;
        /// <summary>
        /// Inject external Services to create FormService instance
        /// </summary>
        /// <param name="http"></param>
        public FormService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<FormMetadata> GetFormMeta()
        {
            var result = await http.GetFromJsonAsync<FormMetadata>($"api/Form/MetaData/");
            return result is null ? throw new Exception() : result;
        }
        /// <summary>
        /// Save Data Form
        /// </summary>
        /// <param name="fields"></param>
        /// <returns>Json string result</returns>
        public string PostFormData(List<Field> fields)
        {
            //data can be converted to proper JSON
            string jsonForm = FieldsToJson(fields);
            Console.WriteLine(jsonForm);

            //TODO: In this part, we can send data as an API request for registration.

            return jsonForm;
        }
    }
}
