using System.Collections.Generic;
using Xamarin.Forms;

namespace DictionaryOfEmployees
{
	public class MainPage : ContentPage 
	{
		public MainPage ()
		{
			var EmployeeDictionary = new Dictionary<int, Employee> ( );

			EmployeeDictionary.Add( 101, new Employee {
				Id        = 101,
				FirstName = "Jesse",
				LastName  = "Liberty"
			} );

			EmployeeDictionary.Add( 102, new Employee {
				Id        = 102,
				FirstName = "George",
				LastName  = "Washington"
			} );

			EmployeeDictionary.Add( 103, new Employee {
				Id        = 103,
				FirstName = "Mark",
				LastName  = "Smith"
			} );

			var Employee101 = new Label ( );
			var Employee102 = new Label ( );
			var Employee103 = new Label ( );

			Employee101.Text = EmployeeDictionary[ 101 ].ToString( );
			Employee103.Text = EmployeeDictionary[ 103 ].ToString( );
			Employee102.Text = EmployeeDictionary[ 102 ].ToString( );

			Content = new StackLayout
			{
				Padding = 50,
				Children =
				{
					Employee101,
					Employee102,
					Employee103
				}
			};
		}
	}
}