using System.Activities;

namespace UiPath.Activity.Template.Windows;

// Common best practice to create a base class for your activities. 
// This can be used to provide default arguments that all your activities may use.
// Or it can provide default logic. 
public abstract class BaseTemplateActivity : CodeActivity
{
	protected override void Execute(CodeActivityContext context) { }
}
