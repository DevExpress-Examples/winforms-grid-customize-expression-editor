<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620455/18.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T501883)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms Data Grid - Customize the Expression Editor

This example shows how to customize the [Expression Editor](https://docs.devexpress.com/WindowsForms/6212/common-features/expressions/expression-editor) as follows:

* Remove the **Now** function from the list of Date-Time functions and prevent users from using this function in expressions (display an error message).
* Disable capitalization of function names.
* Implement a color provider to use a custom palette for syntax highlighting.
* Rename the **Columns** category to **Fields**.
* Implement a custom Expression Editor view to display only specific UI elements of the Expression Editor.

![Customize WinForms Expression Editor](https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-expression-editor-t501883/17.1.3+/media/0d5733f1-1de3-11e7-80bf-00155d62480c.png)

Right-click the **Expression** column header and select the **Expression Editor...** command in the context menu to invoke the Expression Editor.

![Show Expression Editor](https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-expression-editor-t501883/17.1.3+/media/3883389e-1ddd-11e7-80bf-00155d62480c.png)

## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))

## Documentation

* [Expression Editor](https://docs.devexpress.com/WindowsForms/6212/common-features/expressions/expression-editor)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-expression-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-customize-expression-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
