using CyberPuzzles.Crossword.Constants;
using FontStashSharp;
using Microsoft.Xna.Framework;

namespace CyberPuzzles.Crossword.App;

public sealed partial class Crossword
{
    #region DrawCrossword

    /// <summary>
    /// Draws the crossword graphics
    /// </summary>
    private void DrawCrossword()
    {
        // Begin drawing
        _spriteBatch.Begin();

        //Draw the main rectangle
        _spriteBatch.Draw(_blackTexture, rectCrossWord, _rectangleColor);

        //Build the squares
        for (var i = 0; i < _NumRows; i++)
        {
            for (var j = 0; j < _NumCols; j++)
            {
                if (sqPuzzleSquares == null) continue;
                _puzzleSquares[i, j] = new Rectangle(sqPuzzleSquares[i, j].xCoord, sqPuzzleSquares[i, j].yCoord,
                    CwSettings.nSquareWidth, CwSettings.nSquareHeight);

                //Check to see if a char is allowed
                if (sqPuzzleSquares[i, j].IsCharAllowed)
                {
                    //Draws the squares
                    if (DrawSquares(i, j)) continue;

                    //small number font
                    DrawSmallFontAcross(i, j);
                    DrawSmallFontDown(i, j);

                    //Char entered by user.
                    DrawUserChar(i, j);
                }
                else
                {
                    // Black square
                    _spriteBatch.Draw(_blackTexture, _puzzleSquares[i, j], _rectangleColor);
                }
            }
        }

        _spriteBatch.End();
        NewBackFlush = false;
    }

    #endregion

    #region DrawUserChar
    /// <summary>
    /// Draws char entered by user
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    private void DrawUserChar(int i, int j)
    {
        //Char entered by user.
        _spriteBatch.DrawString(_fntFont, char.ToUpper(sqPuzzleSquares[i, j].Letter).ToString(),
            new Vector2(_puzzleSquares[i, j].X + CwSettings.SqCharOffsetX,
                _puzzleSquares[i, j].Y + CwSettings.SqCharOffsetY),
            sqPuzzleSquares[i, j].ForeColour);

    }
    #endregion

    #region DrawSmallFont
    /// <summary>
    /// Draws small font Across
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    private void DrawSmallFontAcross(int i, int j)
    {
        if (sqPuzzleSquares[i, j].ClueAnswerAcross == null) return;
        if (sqPuzzleSquares[i, j].ClueAnswerAcross?.SqAnswerSquares?[0] != sqPuzzleSquares[i, j]) return;
        _spriteBatch.DrawString(_fntnumFont,
            sqPuzzleSquares[i, j].ClueAnswerAcross?.QuestionNumber.ToString(),
            new Vector2(_puzzleSquares[i, j].X + CwSettings.SmlNumOffsetX,
                _puzzleSquares[i, j].Y + CwSettings.SmlNumOffsetY), Color.Black);
    }

    /// <summary>
    /// Draws small font Down
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    private void DrawSmallFontDown(int i, int j)
    {
        if (sqPuzzleSquares?[i, j].ClueAnswerDown == null) return;
        if (sqPuzzleSquares[i, j].ClueAnswerDown?.SqAnswerSquares?[0] != sqPuzzleSquares[i, j]) return;
        _spriteBatch.DrawString(_fntnumFont,
            sqPuzzleSquares[i, j].ClueAnswerDown?.QuestionNumber.ToString(),
            new Vector2(_puzzleSquares[i, j].X + CwSettings.SmlNumOffsetX,
                _puzzleSquares[i, j].Y + CwSettings.SmlNumOffsetY), Color.Black);
    }
    #endregion

    #region DrawSquares
    /// <summary>
    /// Draws the crossword squares
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <returns></returns>
    private bool DrawSquares(int i, int j)
    {
        //Check to see if a repaint is required
        if (!sqPuzzleSquares[i, j]!.IsDirty) return true;
        if (sqPuzzleSquares[i, j].BackColour.Equals(Color.White))
        {
            _spriteBatch.Draw(_imgNormalSquare, _puzzleSquares[i, j], _rectangleColor);
        }

        if (sqPuzzleSquares[i, j].BackColour.Equals(Color.Yellow))
        {
            _spriteBatch.Draw(_imgSquareWord, _puzzleSquares[i, j], _rectangleColor);
        }

        if (sqPuzzleSquares[i, j].BackColour.Equals(Color.Cyan))
        {
            _spriteBatch.Draw(_imgHighliteSquare, _puzzleSquares[i, j], _rectangleColor);
        }

        return false;
    }

    #endregion
}