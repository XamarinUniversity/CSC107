using System.Collections.Generic;
using Xamarin.Forms;

namespace ListOfEmployees
{
	public class MainPage : ContentPage 
	{
		public MainPage () 
		{
			// TODO: define a List of employee objects
			List<Employee> employeeList = new List<Employee> ();

			// TODO: populate some employees into your list
			employeeList.Add( new Employee { FirstName = "Jesse",  LastName = "Liberty"    } );
			employeeList.Add( new Employee { FirstName = "George", LastName = "Washington" } );
			employeeList.Add( new Employee { FirstName = "Mark",   LastName = "Smith"      } );

			Content = new StackLayout
			{
				Children =
				{
					// TODO: display the list
					new ListView() { ItemsSource = employeeList }
				}
			};
		}
	}
}