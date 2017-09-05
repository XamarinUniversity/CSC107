using System.Collections.Generic;
using Xamarin.Forms;

namespace DictionaryOfEmployees
{
    public class MainPage : ContentPage 
    {
        public MainPage () 
        {
            // TODO: create a Dictionary from int to Employee

            // TODO: Add an employee with an id of 101 to the dictionary
            // TODO: Add an employee with an id of 102 to the dictionary
            // TODO: Add an employee with an id of 103 to the dictionary

            var Employee101 = new Label ( );
            var Employee102 = new Label ( );
            var Employee103 = new Label ( );

            // TODO: fill in the Text for each label
            // using the employees in the dictionary
            // Employee101.Text = 
            // Employee103.Text = 
            // Employee102.Text = 

            // Display the three employees
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