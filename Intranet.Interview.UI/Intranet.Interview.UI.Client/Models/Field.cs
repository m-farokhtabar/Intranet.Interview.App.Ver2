namespace Intranet.Interview.UI.Client.Model;
/// <summary>
/// Field meta data and display description
/// </summary>
public class Field
{
    /// <summary>
    /// type of input like text,email,dropdown,number,checkbox,multidropdown
    /// </summary>
    public string Type { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    /// <summary>
    /// Custom regex pattern for text input
    /// </summary>
    public string Pattern { get; set; } = string.Empty;
    /// <summary>
    /// A placeholder is a short hint inside an input field that shows the expected value or format before the user enters data.
    /// </summary>
    public string PlaceHolder { get; set; } = string.Empty;
    /// <summary>
    /// Provide additional explanations below the input fields to guide users on how to enter data.
    /// </summary>
    public string HelperText { get; set; } = string.Empty;
    public bool? Required { get; set; }
    public int? Min { get; set; }
    /// <summary>
    /// Max Value and also using for maxlength for Text and email
    /// </summary>
    public int? Max { get; set; }
    /// <summary>
    /// Display the inputs in descending order, with the highest number first.
    /// </summary>
    public int Order { get; set; } = 0;
    /// <summary>
    /// Display Value Items for list
    /// //TODO: it is better to use display:value structure
    /// </summary>
    public List<string>? Values { get; set; }
    
    #region Data received by users
    /// <summary>
    /// Text, email, dropdown input
    /// </summary>
    public string? StringValue { get; set; }
    /// <summary>
    /// Multi dropdown input
    /// </summary>
    public IEnumerable<string?> SelectedValues { get; set; } = new HashSet<string?>();
    /// <summary>
    /// Numeric input
    /// </summary>
    public int? IntValue { get; set; }
    /// <summary>
    /// checkbox input
    /// </summary>
    public bool BoolValue { get; set; }
    #endregion
}
