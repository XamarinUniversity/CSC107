using System.Collections.Generic;
using Xamarin.Forms;

namespace ListOfEmployees
{
    public class MainPage : ContentPage 
    {
        public MainPage () 
        {
            // TODO: define a List of employee objects

            // TODO: populate some employees into your list

            Content = new StackLayout
			{
                Children =
				{
                    // TODO: display the list
                    // new ListView() { ItemsSource = employeeList }
                }
            };
        }
    }
}