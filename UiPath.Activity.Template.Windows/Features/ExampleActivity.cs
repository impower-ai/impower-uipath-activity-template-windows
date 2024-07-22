using System;
using System.Activities;
using System.ComponentModel;

namespace UiPath.Activity.Template.Windows.Features;

// This Display name is what you use to search for the activity within UiPath Studio
[DisplayName("Impower Example Activity")]
public class ExampleActivity : CodeActivity
{
	// This is how the arguments name is shown to the consumer in UiPath Studio
	[DisplayName("String Argument")]
	// Description that can be hovered in UiPath Studio to explain what this does.
	[Description("This is an example string argument. This is shown as a tooltip and can be viewed in UiPath Studio.")]
	// Optional attribute that mandates that a value must be given or else the project will not compile in UiPath Studio.
	[RequiredArgument]
	// In Argument meaning its a value we are taking in. Of type string. 
	public InArgument<string> InputExampleArgument { get; set; }

	// Example Output Argument
	[DisplayName("String Output Argument")]
	[Description("This is an example string argument. This is shown as a tooltip and can be viewed in UiPath Studio.")]
	[RequiredArgument]
	public OutArgument<string> OutputArgument { get; set; }

	protected override void Execute(CodeActivityContext context)
	{
		// When you want to retrieve the value that the consumer has specified for the activity.
		// You must call .Get on the property that has the argument, and give it a context.
		// For example. InputExampleArgument.Get(context); 
		// This will access the value provided in UiPath Studio ^
		var inputValue = InputExampleArgument.Get(context);
		Console.WriteLine($"Custom Activity Output: {inputValue}");
		// Set output argument to string appended with itself. 
		OutputArgument.Set(context, $"{inputValue} - {inputValue}");
	}
}
