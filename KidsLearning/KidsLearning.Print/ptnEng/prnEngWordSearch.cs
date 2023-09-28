using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TORServices.Maths;
using static TORServices.Maths.extMath;
using TORServices.Drawings;
using static WordSearch.Classes.GameEngine;
using WordSearch.Classes;
using OfficeOpenXml;
using System.IO;

namespace KidsLearning.Print.ptnEng
{
  public partial  class prnEngWordSearch : prnControl
    {
        public prnEngWordSearch()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        string[] Words ;
        char[,] WORDS_IN_BOARD = new char[10, 10];
        Random Rnd = new Random(DateTime.Now.Millisecond);
        int GridSize = 10;
        List<WordPosition> WordPositions = new List<WordPosition>();
        List<Direction> ChosenDirections = new List<Direction>();
        List<Point> ColouredRectangles = new List<Point>();
        List<Point> FailedRectangles = new List<Point>();
        Responsive ResponsiveObj;

        List<string> WordAll;
        int SizeFactor;
        int CalibrationFactor;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {

            ReportHeader =  "การทดสอบ เกี่ยวกับ การสะกดอ่านภาษาอังกฤษเบื้องต้น ";
            ReportToppic = "Eng  WordSearch";
            iPage = 1;
            iPageAll = 1;

            this.printDocument1.DefaultPageSettings.Landscape = true;

            foreach (var lst in (Direction[])Enum.GetValues(typeof(Direction)))
                ChosenDirections.Add(lst);


        


            ResponsiveObj = new Responsive(Screen.PrimaryScreen.Bounds);
            ResponsiveObj.SetMultiplicationFactor();

            SizeFactor = ResponsiveObj.GetMetrics(60);
            CalibrationFactor = ResponsiveObj.GetMetrics(400);

            WordAll = new List<string>();
            FileInfo existingFile = new FileInfo(@System.Windows.Forms.Application.StartupPath + @"\File\Book\Eng Sentences_1.xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {



                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];//EAT
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {

                    //  MessageBox.Show(worksheet.Cells[row, 1].Value.ToString() + "\n" + worksheet.Cells[row, 3].Value.ToString());

                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim() + "" + worksheet.Cells[row, 3].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            if(worksheet.Cells[row, 1].Value?.ToString().Trim().Length<=10)
                            WordAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim().ToUpper());
                            

                        }


                    }


                }
                worksheet = package.Workbook.Worksheets[1];//ห้องต่างๆ ในโรงเรียน
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            if (worksheet.Cells[row, 1].Value?.ToString().Trim().Length <= 10)
                                WordAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim().ToUpper());


                        }

                    }

                }

                worksheet = package.Workbook.Worksheets[2];//อาชีพ
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            if (worksheet.Cells[row, 1].Value?.ToString().Trim().Length <= 10)
                                WordAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim().ToUpper());


                        }

                    }

                }

                worksheet = package.Workbook.Worksheets[3];//สัตว์
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            if (worksheet.Cells[row, 1].Value?.ToString().Trim().Length <= 10)
                                WordAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim().ToUpper());


                        }

                    }

                }

                worksheet = package.Workbook.Worksheets[4];//กีฬา
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                    {
                        if (worksheet.Cells[row, 1].Value?.ToString().Trim().Length <= 10)
                            WordAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim().ToUpper());


                    }


                }

                worksheet = package.Workbook.Worksheets[5];//สี
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                    {
                        if (worksheet.Cells[row, 1].Value?.ToString().Trim().Length <= 10)
                            WordAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim().ToUpper());


                    }

                }

            };




            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 593);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1218, 593);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1212, 571);
            // 
            // prnEngWordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnEngWordSearch";
            this.Size = new System.Drawing.Size(1468, 593);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        void InitializeBoard()
        {
            try
            {
                Direction OrientationDecision;
                int PlacementIndex_X, PlacementIndex_Y;
                bool PlacementSuccessful;

                for (int i = 0; i <= Words.GetUpperBound(0); i++)   // For all the words in the list, try to place them on the board.
                {
                    PlacementSuccessful = false;
                    do
                    {
                        // Total number of elements in an enum: http://stackoverflow.com/questions/856154/total-number-of-items-defined-in-an-enum
                        OrientationDecision = GetOrientation(Rnd, Enum.GetNames(typeof(Direction)).Length);   // From randomizer, orientation of the string to put should be either of the eight orientations.
                        PlacementIndex_X = GetRandomNumber(Rnd, GridSize);    // Get the X-coordinate for the string to place.
                        PlacementIndex_Y = GetRandomNumber(Rnd, GridSize);    // Get the Y-coordinate for the string to place.
                        PlacementSuccessful = PlaceTheWords(OrientationDecision, PlacementIndex_X, PlacementIndex_Y, Words[i]);
                    }
                    while (!PlacementSuccessful);
                }
                // Fill the empty squares with random letters.

                try
                {
                    for (int i = 0; i < GridSize; i++)
                    {
                        for (int j = 0; j < GridSize; j++)
                        {
                            if (WORDS_IN_BOARD[i, j] == '\0')
                            {
                                WORDS_IN_BOARD[i, j] = (char)(65 + GetRandomNumber(Rnd, 26));
                                //MessageBox.Show(WORDS_IN_BOARD[i, j].ToString());
                            }
                        }
                    }
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

        Direction GetOrientation(Random Rnd, int Max)
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

        int GetRandomNumber(Random Rnd, int Max)
        {
            return Rnd.Next(Max);   // Generates a number from 0 up to the grid size.
        }
        // https://msdn.microsoft.com/en-us/library/ztxk24yx(v=vs.110).aspx
        private void ColourCells(List<Point> Rect, Color RectColor)
        {
            try
            {
                SolidBrush myBrush = new SolidBrush(RectColor);
                Graphics formGraphics;
                formGraphics = CreateGraphics();

                for (int i = 0; i < Rect.Count; i++)
                    formGraphics.FillRectangle(myBrush, new Rectangle(Rect[i], new Size(SizeFactor, SizeFactor)));

                myBrush.Dispose();
                formGraphics.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'ColourCells' method of 'GameBoard' form. Error msg: " + Ex.Message);
            }
        }

        private void MapArrayToGameBoard(Graphics g)
        {
            // https://msdn.microsoft.com/en-us/library/9why95hd%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
           // Graphics formGraphics = CreateGraphics();
            Font drawFont = new Font("Arial", ResponsiveObj.GetMetrics(16));
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            string CharacterToMap;

            try
            {
                for (int i = 0; i < GridSize; i++)
                    for (int j = 0; j < GridSize; j++)
                    {
                         // MessageBox.Show("" + WORDS_IN_BOARD[i, j]);
                        if (WORDS_IN_BOARD[i, j] != '\0')
                        {

                            CharacterToMap = "" + WORDS_IN_BOARD[i, j]; // "" is needed as a means for conversion of character to string.
                            g.DrawString(CharacterToMap, drawFont, drawBrush, (i + 1) * SizeFactor + 112 ,
                                (j + 1) * SizeFactor + 212);
                        }
                    }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'MapArrayToGameBoard' method of 'GameBoard' form. Error msg: " + Ex.Message);
            }
            finally
            {
                drawFont.Dispose();
                drawBrush.Dispose();
               // formGraphics.Dispose();
            }
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
        void StoreWordPosition(string Word, int PlacementIndex_X, int PlacementIndex_Y, Direction OrientationDecision)
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

      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            string _word = "";
            int c = RandomNumber.Randomnumber(5, 10);
            for (int i = 0; i < c; i++)
                _word += WordAll[RandomNumber.Randomnumber(0, WordAll.Count )] + "|";

            _word += WordAll[RandomNumber.Randomnumber(0, WordAll.Count )];
            Words = _word.Split('|');


            InitializeBoard();
            int yC = 100;
            int xC = 100;
            try
            {
                Font headFont = new Font("Arial", ResponsiveObj.GetMetrics(20));
                Font drawFont = new Font("Arial", ResponsiveObj.GetMetrics(16));
                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                e.Graphics.DrawString("Words List:", headFont, drawBrush, 700, 150);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), 650, 180, 300, 500);
                int y = 200;
                foreach (string Str in Words)
                {
                    e.Graphics.DrawString(Str, drawFont, drawBrush, 690, y);
                    y += 40;
                }

                ColourCells(ColouredRectangles, Color.LightBlue);
                if (FailedRectangles.Count > 0) ColourCells(FailedRectangles, Color.ForestGreen);

                // Draw horizontal lines.
                for (int i = 0; i <= GridSize; i++)
                    e.Graphics.DrawLine(pen, SizeFactor +100, (i + 1) * SizeFactor + 200, GridSize * SizeFactor + SizeFactor + 100, (i + 1) * SizeFactor + 200);

                // Draw vertical lines.
                for (int i = 0; i <= GridSize; i++)
                    e.Graphics.DrawLine(pen, (i + 1) * SizeFactor + 100, SizeFactor + 200, (i + 1) * SizeFactor + 100, GridSize * SizeFactor + SizeFactor + 200);

                MapArrayToGameBoard(e.Graphics);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'GameBoard_Paint' method of 'GameBoard' form. Error msg: " + Ex.Message);
            }



            #endregion



            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

    }
}
