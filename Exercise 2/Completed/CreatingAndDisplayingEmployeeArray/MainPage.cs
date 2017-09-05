using Xamarin.Forms;

namespace CreatingAndDisplayingEmployeeArray
{
	public class MainPage : ContentPage 
	{
		public MainPage () 
		{
			// TODO: Create employeeArray
			Employee[] employeeArray = new Employee[3];

			// TODO: Populate employeeArray with some data
			employeeArray[ 0 ] = new Employee { FirstName = "Jesse",  LastName = "Liberty"    };
			employeeArray[ 1 ] = new Employee { FirstName = "George", LastName = "Washington" };
			employeeArray[ 2 ] = new Employee { FirstName = "Mark",   LastName = "Smith"      };

			Content = new StackLayout
			{
				Children =
				{
					// TODO: Display employeeArray
					new ListView() { ItemsSource = employeeArray }
				}
			};
		}
	}
}