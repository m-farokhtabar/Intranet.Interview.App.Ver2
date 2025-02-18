namespace Intranet.Interview.UI.Client.Services.FormSrv;

/// <summary>
/// <see cref="IFilePath"/>
/// </summary>
public class FilePath : IFilePath
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    public FilePath(string path)
    {
        Path = path;
    }
    /// <summary>
    /// <see cref="IFilePath.Path"/>
    /// </summary>
    public string Path { get; set; } = string.Empty;
}
