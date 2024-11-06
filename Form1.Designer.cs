namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWord = new Label();
            lblGuesses = new Label();
            lblStreak = new Label();
            pnlLetters = new Panel();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Location = new Point(544, 224);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(36, 15);
            lblWord.TabIndex = 0;
            lblWord.Text = "Word";
            // 
            // lblGuesses
            // 
            lblGuesses.AutoSize = true;
            lblGuesses.Location = new Point(544, 199);
            lblGuesses.Name = "lblGuesses";
            lblGuesses.Size = new Size(109, 15);
            lblGuesses.TabIndex = 1;
            lblGuesses.Text = "Guesses Remaining";
            // 
            // lblStreak
            // 
            lblStreak.AutoSize = true;
            lblStreak.Location = new Point(544, 249);
            lblStreak.Name = "lblStreak";
            lblStreak.Size = new Size(39, 15);
            lblStreak.TabIndex = 2;
            lblStreak.Text = "Streak";
            // 
            // pnlLetters
            // 
            pnlLetters.Location = new Point(94, 124);
            pnlLetters.Name = "pnlLetters";
            pnlLetters.Size = new Size(418, 324);
            pnlLetters.TabIndex = 3;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(578, 282);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(75, 23);
            btnNewGame.TabIndex = 3;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 573);
            Controls.Add(btnNewGame);
            Controls.Add(pnlLetters);
            Controls.Add(lblStreak);
            Controls.Add(lblWord);
            Controls.Add(lblGuesses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private Label lblGuesses;
        private Label lblStreak;
        private Panel pnlLetters;
        private Button btnNewGame;
    }
}
