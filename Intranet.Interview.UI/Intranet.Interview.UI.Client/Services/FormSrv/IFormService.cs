using Intranet.Interview.UI.Client.Model;

namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    public interface IFormService
    {
        Task<FormMetadata> GetFormMeta();
        string PostFormData(List<Field> fields);
    }
}