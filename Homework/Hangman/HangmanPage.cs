using System;
using Xamarin.Forms;

namespace Hangman
{
    public class HangmanPage : ContentPage
    {
        private Label hiddenMessageLabel;
        private Entry guessEntry;

        private HangmanManager hangManager;

        public HangmanPage()
        {
            hangManager = new HangmanManager("xamarin");

            hiddenMessageLabel = new Label { FontSize = 36, HorizontalTextAlignment = TextAlignment.Center };
            guessEntry = new Entry { Placeholder = "Enter a single character" };
            Button guessButton = new Button { Text = "Guess" };

            guessButton.Clicked += GuessButton_Clicked;

            Content = new StackLayout
            {
                Padding = 20,
                Children = {
                    hiddenMessageLabel,
                    guessEntry,
                    guessButton
                }
            };
            UpdateUI();
        }

        private void GuessButton_Clicked(object sender, EventArgs e)
        {
            char guessedLetter;
            if (char.TryParse(guessEntry.Text, out guessedLetter))
            {
                // Always test lowercase.
                guessedLetter = Char.ToLower(guessedLetter);
                if (hangManager.Guess(guessedLetter))
                {
                    UpdateUI();
                }
                //after we guess lets clear the entry
                guessEntry.Text = "";
                //after we guess check to see if we have completed the puzzle
                if (hangManager.IsGameOver)
                {
                    DisplayAlert("You Win!", "Good Job! You have completed the puzzle.", "Okay");
                }
            }
            else
            {
                DisplayAlert("Not a Valid Guess", "Please enter a single character", "Okay");
            }
        }

        private void UpdateUI()
        {
            hiddenMessageLabel.Text = hangManager.DisplayString;
        }
    }
}
