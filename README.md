# Intranet.Interview.App_Ver2
# Dynamic Form Generator

## Overview
The Dynamic Form Generator is a web application that dynamically renders forms based on a JSON configuration. It allows users to input data, validates the entries, and generates a JSON object upon form submission.

The application uses Blazor WebAssembly for the front-end and .NET 8 for the development environment. The form rendering is flexible and can be modified by simply editing a JSON file.

## Features

- **Dynamic Form Rendering:** Renders forms based on a JSON configuration.
- **Data Collection:** Collects user input and outputs it as a JSON object.
- **Validation:** Applies validation rules such as required fields, email format, and number ranges.
- **Immediate Validation:** With the `Immediate="true"` property, validation occurs instantly as users fill out the form, enhancing the user experience.

### New Features:
- **PlaceHolder:** A hint within the input fields that shows the expected data format.
- **HelperText:** Provides additional instructions beneath input fields to guide users.
- **Pattern:** Allows custom regex patterns for text inputs.
- **Multi-dropdown:** Supports selecting multiple values from a dropdown.
- **Order:** Fields are displayed in descending order.
- **Max Length:** Defines the maximum character length for text fields.

## Setup Instructions

1. **Clone the Repository:** Clone this repository to your local machine:

    ```bash
    git clone <repository_url>
    ```

2. **Visual Studio Setup:** Open the project in Visual Studio and ensure the `Intranet.Interview.UI` project is set as the startup project.

3. **Form JSON Configuration:** The form configuration is stored in the `DynamicForm.json` file, located at:

    ```
    Intranet.Interview.UI/wwwroot/DynamicForm.json
    ```

    Modify the JSON content to change the form fields as needed.

4. **Running the Project:**
   - Set `Intranet.Interview.UI` as the startup project.
   - Press F5 or click **Run** to start the application.
   - Once running, navigate to the Dynamic Form menu on the left.

### Sample DynamicForm.json:
```json
{
  "title": "Sample Form",
  "fields": [
    {
      "type": "text",
      "label": "Name",
      "required": true,
      "PlaceHolder": "Please input your fullname",
      "max": 15,
      "order": 9
    },
    {
      "type": "text",
      "label": "Phone",
      "required": true,
      "placeHolder": "Phone number e.g. 123-456-7890",
      "pattern": "^(\\d{3})[- ]?(\\d{3})[- ]?(\\d{4})$",
      "order": 8
    },
    {
      "type": "email",
      "label": "Email",
      "placeHolder": "Please input your email",
      "required": true,
      "order": 10
    },
    {
      "type": "number",
      "label": "Age",
      "placeHolder": "Please input your age",
      "min": 18,
      "max": 100,
      "HelperText": "Age must be between 18 - 100"
    },
    {
      "type": "dropdown",
      "label": "Industry",
      "placeHolder": "Please input the Industry",
      "values": [ "Tech", "Production", "Health" ],
      "required": true
    },
    {
      "type": "multidropdown",
      "label": "Preferred Work Options",
      "values": [ "Tech", "Production", "Health" ],
      "placeHolder": "Please input the Work Options",
      "required": true,
      "HelperText": "You can choose more than one"
    },
    {
      "type": "checkbox",
      "label": "Subscribe to Newsletter",
      "required": false
    }
  ]
}
