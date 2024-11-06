namespace Hangman

{
    public partial class Form1 : Form
    {
        private string secretWord;
        private int wrongGuesses;
        private int maxGuesses = 6;
        private List<char> guessedLetters;
        private int streak;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        // Initializes or resets the game state
        private void InitializeGame()
        {
            string[] wordList = { "programming", "hangman", "developer", "application", "csharp", "computer", "technology" };
            Random random = new Random();
            secretWord = wordList[random.Next(wordList.Length)];

            wrongGuesses = 0;
            guessedLetters = new List<char>();
            streak = 0;

            // Update UI
            lblWord.Text = new string('_', secretWord.Length);  // Display the word as underscores
            lblGuesses.Text = $"Guesses Remaining: {maxGuesses}";
            lblStreak.Text = $"Streak: {streak}";

            // Reset all letter buttons
            foreach (Control control in pnlLetters.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;  // Enable all letter buttons
                }
            }
        }

        // Called when a letter button is clicked
        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            char guessedLetter = clickedButton.Text[0];

            // Disable the button after clicking
            clickedButton.Enabled = false;

            // Check if the letter has been guessed already
            if (guessedLetters.Contains(guessedLetter))
            {
                MessageBox.Show("You already guessed that letter.");
                return;
            }

            guessedLetters.Add(guessedLetter);

            // Check if the letter is in the secret word
            bool correctGuess = false;
            char[] wordDisplay = lblWord.Text.ToCharArray();
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guessedLetter)
                {
                    wordDisplay[i] = guessedLetter;
                    correctGuess = true;
                }
            }

            // Update the displayed word
            lblWord.Text = new string(wordDisplay);

            // If incorrect guess, increase wrong guesses
            if (!correctGuess)
            {
                wrongGuesses++;
                lblGuesses.Text = $"Guesses Remaining: {maxGuesses - wrongGuesses}";
            }

            // Check if player has won or lost
            CheckGameStatus();
        }

        // Checks if the game is won or lost
        private void CheckGameStatus()
        {
            // If the word is fully guessed
            if (!lblWord.Text.Contains("_"))
            {
                MessageBox.Show("Congratulations! You've guessed the word!");
                streak++;
                InitializeGame();
            }
            // If the player loses (wrong guesses exceeded max guesses)
            else if (wrongGuesses >= maxGuesses)
            {
                MessageBox.Show($"You lost! The word was: {secretWord}");
                streak = 0;  // Reset streak on loss
                InitializeGame();
            }
        }

        // Button to reset the game after a loss or win
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int buttonWidth = 30, buttonHeight = 30, margin = 5;
            int x = 10, y = 10;

            // Loop through alphabet and create buttons
            foreach (char letter in alphabet)
            {
                Button letterButton = new Button();
                letterButton.Text = letter.ToString();
                letterButton.Width = buttonWidth;
                letterButton.Height = buttonHeight;
                letterButton.Left = x;
                letterButton.Top = y;
                letterButton.Click += LetterButton_Click;

                pnlLetters.Controls.Add(letterButton);

                // Update x and y for positioning next button
                x += buttonWidth + margin;
                if (x + buttonWidth > pnlLetters.Width)
                {
                    x = 10;
                    y += buttonHeight + margin;
                }
            }
        }
    }
}
