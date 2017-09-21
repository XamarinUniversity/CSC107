namespace Hangman
{
    public class HangmanManager
    {
        private string hiddenString;

        public string DisplayString
        {
            get; private set;
        }

        public bool IsGameOver
        {
            get
            {
                return DisplayString == hiddenString;
            }
        }

        public HangmanManager(string hiddenWord)
        {
            hiddenString = hiddenWord;
            CreateDisplayString();
        }

        public bool Guess(char guess)
        {
            bool foundALetter = false;
            for (int i = 0; i < hiddenString.Length; i++)
            {
                if (hiddenString[i] == guess)
                {
                    DisplayString = DisplayString.Remove(i, 1);
                    DisplayString = DisplayString.Insert(i, guess.ToString());
                    foundALetter = true;
                }
            }
            return foundALetter;
        }

        private void CreateDisplayString()
        {
            for (int i = 0; i < hiddenString.Length; i++)
            {
                DisplayString += "*";
            }
        }
    }
}
