# Dynamic Form Generator

1. Render Forms: Dynamically generate and display a form defned by the provided JSON structure.
2. Data Collection: Collect user input values entered into the form felds.
3. Validation: Apply basic and custom validation rules to the input felds, such as required felds, email formatting, and number range checks.
4. Generate Response: Return the collected form data as a JSON object upon submission.

### Steps to run the application.
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Ensure dependencies are installed.
	- asp .Net Core WebAssembly 8.0.12
	- MudBlazor 8.3.0
	- Blazored Local Storage 4.5.0
4. Run the application.

### Design considerations and architecture decisions

* The application is built using Blazor WebAssembly.
* The application is built using MudBlazor components.
* The application uses Blazored Local Storage to store the form data.
* The application uses a JSON file to define the form structure.
* The application uses a JSON file to define the validation rules.
* Several test forms are defined for demonstration purposes.
* To facilitate clean deserilization of the JSON files, the application uses a custom deserilizer model.
* Form and FormField models are used to define the form structure and provide for extensibility in the future.
* A FormValue model is used to store the form data and make working with MudBlazor components easier.

## Assumptions Made During Development

* **JSON Configuration:** The application relies on a correctly formatted JSON configuration file to define form fields.
* **Data Types:** Data types specified in the JSON are assumed to be compatible with MudBlazor input components.
* **Unique Labels:** Form field labels are assumed to be unique, as they are used as keys in the `formData` dictionary.
* **Client-Side Validation:** The application uses MudBlazor's built-in validation, assuming users will provide valid input.
* **MudBlazor Library:** The application depends on the correct installation and functionality of the MudBlazor library.
* **Browser Compatibility:** The application is designed to run in modern web browsers with JavaScript enabled.
* **Date Handling:** Date fields are handled in the client's local time.

Deployed to http://morphiforms.bremmer.ca/
