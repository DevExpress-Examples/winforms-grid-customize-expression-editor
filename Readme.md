<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620455/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T501883)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
<!-- default file list end -->
# How to customize the Expression Editor


This example illustrates the API available for customizing the new <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument6212">Expression Editor</a> version. In this demo application, the following changes are made to the Expression Editor.<br><br>1. The "<strong>Now</strong>" function is removed from the list of date-time functions and is not allowed for use in expressions (a custom validator displays an error on an attempt to use this function).<br>2. Capitalization of function names is disabled.<br>3. A custom color provider is implemented to use a custom palette for syntax highlighting.<br>4. The "<strong>Columns</strong>" category is renamed to "<strong>Fields</strong>".<br>5. A custom Expression Editor view is implemented (to display only specific parts of the editor).<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-expression-editor-t501883/17.1.3+/media/0d5733f1-1de3-11e7-80bf-00155d62480c.png"><br><br>To invoke the Expression Editor, right-click the custom column in the grid control and select the corresponding command in the context menu.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-expression-editor-t501883/17.1.3+/media/3883389e-1ddd-11e7-80bf-00155d62480c.png">

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-expression-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-expression-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
