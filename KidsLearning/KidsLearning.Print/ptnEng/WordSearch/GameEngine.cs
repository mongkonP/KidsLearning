using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Configuration;

namespace WordSearch.Classes
{
    public class GameEngine
    {
       // CheatCode CheatCodeObj;
        public const int REMAINING_TIME_BONUS_FACTOR = 10;
        private const int PENALTY_SCORE = 50;
        private const int NUM_ORIENTATIONS = 4;                     // Orientations - we have four as listed below in the enum.
        private int MAX_WORDS = Convert.ToInt16(ConfigurationManager.AppSettings["MAX_WORDS"]);
    
        public List<string> WORDS_FOUND = new List<string>();      // These arrays are needed to store all the words that the player found.
        public List<WordPosition> WordPositions = new List<WordPosition>();
        private Random Rnd;
      //  private string CurrentCategory;
        private int GridSize;

        public string[] WORD_ARRAY { get; set; } // These arrays are needed to store all the available words.
        public char[,] WORDS_IN_BOARD;           // This is a word matrix to mimic the board.
        public enum Direction { Down = 1, Right, DownLeft, DownRight, Up, Left, UpLeft, UpRight, None };
        List<Direction> ChosenDirections = new List<Direction>();
        public int CurrentScore { get; set; }
        public string StatusForDisplay { get; set; }
        public List<Point> ColouredRectangles = new List<Point>();
        public int RemainingTime;

        public GameEngine(string[] Words,  int GridSizeParam, int MAX_SECONDS_PARAM)
        {

            WORD_ARRAY = Words;
            GridSize = GridSizeParam;
        

            foreach (var lst in (GameEngine.Direction[])Enum.GetValues(typeof(GameEngine.Direction)))
                ChosenDirections.Add(lst);
        }

        public void InitializeBoard(int GridSize)
        {
            try
            {
                WORDS_IN_BOARD = new char[GridSize, GridSize];
                Rnd = new Random(DateTime.Now.Millisecond);
                Direction OrientationDecision;
                int PlacementIndex_X, PlacementIndex_Y;
                bool PlacementSuccessful;

                for (int i = 0; i <= WORD_ARRAY.GetUpperBound(0); i++)   // For all the words in the list, try to place them on the board.
                {
                    PlacementSuccessful = false;
                    do
                    {
                        // Total number of elements in an enum: http://stackoverflow.com/questions/856154/total-number-of-items-defined-in-an-enum
                        OrientationDecision = GetOrientation(Rnd, Enum.GetNames(typeof(Direction)).Length);   // From randomizer, orientation of the string to put should be either of the eight orientations.
                        PlacementIndex_X = GetRandomNumber(Rnd, GridSize);    // Get the X-coordinate for the string to place.
                        PlacementIndex_Y = GetRandomNumber(Rnd, GridSize);    // Get the Y-coordinate for the string to place.
                        PlacementSuccessful = PlaceTheWords(OrientationDecision, PlacementIndex_X, PlacementIndex_Y, WORD_ARRAY[i]);
                    }
                    while (!PlacementSuccessful);
                }
                // Fill the empty squares with random letters.

                try
                {
                    for (int i = 0; i < GridSize; i++)
                        for (int j = 0; j < GridSize; j++)
                            if (WORDS_IN_BOARD[i, j] == '\0')
                                WORDS_IN_BOARD[i, j] = (char)(65 + GetRandomNumber(Rnd, 26));
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occurred in 'FillInTheGaps' method of the 'GameEngine' class. Error msg: " + Ex.Message);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'InitializeBoard' method of the 'GameEngine' class. Error msg: " + Ex.Message);
            }
        }

        private Direction GetOrientation(Random Rnd, int Max)
        {
            switch (Rnd.Next(1, Max))   // Generate a random number between 1 and Max - 1; So if Max = 9, it will generate a random direction between 1 and 8.
            {
                case 1: if (ChosenDirections.Find(p => p.Equals(Direction.Down)) == Direction.Down) return Direction.Down; break;
                case 2: if (ChosenDirections.Find(p => p.Equals(Direction.Right)) == Direction.Right) return Direction.Right; break;
                case 3: if (ChosenDirections.Find(p => p.Equals(Direction.DownLeft)) == Direction.DownLeft) return Direction.DownLeft; break;
                case 4: if (ChosenDirections.Find(p => p.Equals(Direction.DownRight)) == Direction.DownRight) return Direction.DownRight; break;
                case 5: if (ChosenDirections.Find(p => p.Equals(Direction.Up)) == Direction.Up) return Direction.Up; break;
                case 6: if (ChosenDirections.Find(p => p.Equals(Direction.Left)) == Direction.Left) return Direction.Left; break;
                case 7: if (ChosenDirections.Find(p => p.Equals(Direction.UpLeft)) == Direction.UpLeft) return Direction.UpLeft; break;
                case 8: if (ChosenDirections.Find(p => p.Equals(Direction.UpRight)) == Direction.UpRight) return Direction.UpRight; break;
                default: return Direction.None;
            }
            return Direction.None;
        }

        private int GetRandomNumber(Random Rnd, int Max)
        {
            return Rnd.Next(Max);   // Generates a number from 0 up to the grid size.
        }

        private bool PlaceTheWords(Direction OrientationDecision, int PlacementIndex_X, int PlacementIndex_Y, string Word)
        {
            try
            {
                bool PlaceAvailable = true;

                switch (OrientationDecision)
                {
                    case Direction.Down:
                        for (int i = 0, j = PlacementIndex_Y; i < Word.Length; i++, j++)               // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j >= GridSize) return false; // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[PlacementIndex_X, j] != '\0')
                                if (WORDS_IN_BOARD[PlacementIndex_X, j] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, or a non-conflicting overlap is available, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_Y; i < Word.Length; i++, j++)
                                WORDS_IN_BOARD[PlacementIndex_X, j] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.Up:
                        for (int i = 0, j = PlacementIndex_Y; i < Word.Length; i++, j--)               // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j < 0) return false; // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[PlacementIndex_X, j] != '\0')
                                if (WORDS_IN_BOARD[PlacementIndex_X, j] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, or a non-conflicting overlap is available, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_Y; i < Word.Length; i++, j--)
                                WORDS_IN_BOARD[PlacementIndex_X, j] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.Right:
                        for (int i = 0, j = PlacementIndex_X; i < Word.Length; i++, j++)               // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j >= GridSize) return false; // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[j, PlacementIndex_Y] != '\0')
                                if (WORDS_IN_BOARD[j, PlacementIndex_Y] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, or a non-conflicting overlap is available, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_X; i < Word.Length; i++, j++)
                                WORDS_IN_BOARD[j, PlacementIndex_Y] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.Left:
                        for (int i = 0, j = PlacementIndex_X; i < Word.Length; i++, j--)               // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j < 0) return false; // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[j, PlacementIndex_Y] != '\0')
                                if (WORDS_IN_BOARD[j, PlacementIndex_Y] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, or a non-conflicting overlap is available, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_X; i < Word.Length; i++, j--)
                                WORDS_IN_BOARD[j, PlacementIndex_Y] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.DownLeft:
                        for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j++, k--)  // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j >= GridSize || k < 0) return false;   // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[k, j] != '\0')
                                if (WORDS_IN_BOARD[k, j] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j++, k--)
                                WORDS_IN_BOARD[k, j] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.UpLeft:
                        for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j--, k--)  // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j < 0 || k < 0) return false;   // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[k, j] != '\0')
                                if (WORDS_IN_BOARD[k, j] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j--, k--)
                                WORDS_IN_BOARD[k, j] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.DownRight:
                        for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j++, k++)  // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j >= GridSize || k >= GridSize) return false;   // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[j, k] != '\0')
                                if (WORDS_IN_BOARD[j, k] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j++, k++)
                                WORDS_IN_BOARD[j, k] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                    case Direction.UpRight:
                        for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j++, k--)  // First we check if the word can be placed in the array. For this it needs blanks there.
                        {
                            if (j >= GridSize || k < 0) return false;   // Falling outside the grid. Hence placement unavailable.
                            if (WORDS_IN_BOARD[j, k] != '\0')
                                if (WORDS_IN_BOARD[j, k] != Word[i])   // If there is an overlap, then we see if the characters match. If matches, then it can still go there.
                                {
                                    PlaceAvailable = false;
                                    break;
                                }
                        }
                        if (PlaceAvailable)
                        {   // If all the cells are blank, then this word can be placed there. So place it.
                            for (int i = 0, j = PlacementIndex_X, k = PlacementIndex_Y; i < Word.Length; i++, j++, k--)
                                WORDS_IN_BOARD[j, k] = Word[i];
                            StoreWordPosition(Word, PlacementIndex_X, PlacementIndex_Y, OrientationDecision);
                            return true;
                        }
                        break;
                }
                return false;   // Otherwise continue with a different place and index.
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'PlaceTheWords' method of the 'GameEngine' class. Error msg: " + Ex.Message);
                return false;   // Otherwise continue with a different place and index.
            }
        }

 

        private void StoreWordPosition(string Word, int PlacementIndex_X, int PlacementIndex_Y, Direction OrientationDecision)
        {
            WordPosition Pos = new WordPosition();
            Pos.Word = Word;
            Pos.PlacementIndex_X = PlacementIndex_X;
            Pos.PlacementIndex_Y = PlacementIndex_Y;
            Pos.Direction = OrientationDecision;

            switch (OrientationDecision)
            {
                case Direction.Down: Pos.ScoreAugmenter = 10; break;
                case Direction.Up: Pos.ScoreAugmenter = 20; break;
                case Direction.Right: Pos.ScoreAugmenter = 10; break;
                case Direction.Left: Pos.ScoreAugmenter = 20; break;
                case Direction.DownLeft: Pos.ScoreAugmenter = 20; break;
                case Direction.DownRight: Pos.ScoreAugmenter = 20; break;
                case Direction.UpLeft: Pos.ScoreAugmenter = 30; break;
                case Direction.UpRight: Pos.ScoreAugmenter = 30; break;
                case Direction.None: Pos.ScoreAugmenter = 0; break;
            }
            WordPositions.Add(Pos);
        }



     

       
    }
}
