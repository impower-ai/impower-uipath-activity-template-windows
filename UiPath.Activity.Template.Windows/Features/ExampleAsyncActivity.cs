using System;
using System.Activities;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace UiPath.Activity.Template.Windows.Features;

// This Display name is what you use to search for the activity within UiPath Studio
[DisplayName("Impower Async Example Activity")]
public class ExampleAsyncActivity : AsyncTaskCodeActivity<string>
{
	// This is how the arguments name is shown to the consumer in UiPath Studio
	[DisplayName("String Argument")]
	// Description that can be hovered in UiPath Studio to explain what this does.
	[Description("This is an example string argument. This is shown as a tooltip and can be viewed in UiPath Studio.")]
	// Optional attribute that mandates that a value must be given or else the project will not compile in UiPath Studio.
	[RequiredArgument]
	// In Argument meaning its a value we are taking in. Of type string. 
	public InArgument<string> InputExampleArgument { get; set; }

	// In this example, we use the async logic to await a task. Then we return the output.
	// For the inheriting class, w e did not need to provide a string. We could just impl AsyncTaskCodeActivity and return Task.CompletedTask.. 
	protected override async Task<string> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
	{
		await Task.Delay(1000, cancellationToken);
		var inputValue = InputExampleArgument.Get(context);
		Console.WriteLine($"Input successfully processed: {inputValue}");
		return inputValue;
	}
}
