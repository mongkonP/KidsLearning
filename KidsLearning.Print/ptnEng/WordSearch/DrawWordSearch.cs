using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WordSearch.Classes.GameEngine;

namespace WordSearch.Classes
{
   public static class ExtDrawWordSearch
    {
     //  private static char[,] WORDS_IN_BOARD = new char[10, 10];
        private static Random Rnd = new Random(DateTime.Now.Millisecond);
        private static int GridSize = 10;
        private static List<WordPosition> WordPositions = new List<WordPosition>();
        private static List<Direction> ChosenDirections = new List<Direction>();
        private static List<Point> ColouredRectangles = new List<Point>();
        private static List<Point> FailedRectangles = new List<Point>();


      private static  string[] Words;
        private static int SizeFactor = 40;
        private static int CalibrationFactor = 10;
        public static void DrawWordSearch(this Graphics g, string[] _Words, char[,] WORDS_IN_BOARD, int GridSize, int x,int y)
        {
            Words = _Words;
           // InitializeBoard();
            Font headFont = new Font("Arial", 20);
            Font drawFont = new Font("Arial", 16);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            g.DrawString("Words List:", headFont, drawBrush,x+ 550, y+10);
            g.DrawRectangle(new Pen(Color.Black, 3), x+500, y+50, 300, 400);
            int _y =  y+70,_x = x;
            foreach (string Str in Words)
            {
               g.DrawString(Str, drawFont, drawBrush, x+ 550, _y);
                _y += 30;
            }
            ColourCells( g,ColouredRectangles, Color.LightBlue);
            if (FailedRectangles.Count > 0) ColourCells(g, FailedRectangles, Color.ForestGreen);


            _y = y;
            for (int i = 0; i <= GridSize; i++)
            {
                g.DrawLine(pen, _x, _y, _x + GridSize * SizeFactor, _y);
                _y += SizeFactor;
            }

            _y = y;
            for (int i = 0; i <= GridSize; i++)
            {
                g.DrawLine(pen, _x, _y, _x, _y + GridSize * SizeFactor);
                _x += SizeFactor;
            }

            // MapArrayToGameBoard(g);
            string CharacterToMap;
            for (int i = 0; i < GridSize; i++)
                for (int j = 0; j < GridSize; j++)
                {
                  //  System.Windows.Forms.MessageBox.Show("" + WORDS_IN_BOARD[i, j]);
                    if (WORDS_IN_BOARD[i, j] != '\0')
                    {
                        CharacterToMap = " " + WORDS_IN_BOARD[i, j]; // "" is needed as a means for conversion of character to string.
                       // System.Windows.Forms.MessageBox.Show(CharacterToMap);
                        g.DrawString(CharacterToMap, drawFont, drawBrush, (i + 1) * SizeFactor + CalibrationFactor, (j + 1) * SizeFactor + CalibrationFactor+5);
                    }
                }

        }

        private static void ColourCells(Graphics g,List<Point> Rect, Color RectColor)
        {
            try
            {
                SolidBrush myBrush = new SolidBrush(RectColor);
                for (int i = 0; i < Rect.Count; i++)
                    g.FillRectangle(myBrush, new Rectangle(Rect[i], new Size(SizeFactor, SizeFactor)));
         
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'ColourCells' method of 'GameBoard' form. Error msg: " + Ex.Message);
            }
        }
       
    }
}
