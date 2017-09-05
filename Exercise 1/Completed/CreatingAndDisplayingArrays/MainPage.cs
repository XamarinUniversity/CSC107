using Xamarin.Forms;

namespace CreatingAndDisplayingArrays
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{
			// TODO: Create the array named "intArray"
			int[] intArray = new int[5];

			// TODO: Fill in the array with data
			for (int i = 0; i < 5; i++)
			{
				intArray[i] = i * 20;
			}

			Content = new StackLayout
				{
					// TODO: Display the array, uncomment the next line
					Children = { new ListView() { ItemsSource = intArray } }
				};
		}
	}
}