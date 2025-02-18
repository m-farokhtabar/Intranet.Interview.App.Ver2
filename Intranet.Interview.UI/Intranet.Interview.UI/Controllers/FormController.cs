using Intranet.Interview.UI.Client.Services.FormSrv;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Interview.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly string path = "";
        public FormController(IFilePath filePath)
        {
            this.path = filePath.Path;
        }
        [HttpGet("MetaData")]
        public async Task<IActionResult> GetFormMeta()
        {            
            if (!System.IO.File.Exists(path))
                throw new Exception("File not found.");            
            return Ok(await System.IO.File.ReadAllTextAsync(path).ConfigureAwait(false));
        }
    }
}
