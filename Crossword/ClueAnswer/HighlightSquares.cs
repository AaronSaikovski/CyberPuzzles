using System;
using System.Threading.Tasks;
using Crossword.PuzzleSquares;
using Crossword.Constants;

namespace Crossword.ClueAnswer;

public sealed partial class ClueAnswerMap
{
    #region HighlightSquares

    /// <summary>
    /// /Highlights the current word and sets active square
    /// </summary>
    /// <param name="sq"></param>
    /// <param name="setHighLighted"></param>
    public void HighlightSquares(Square? sq, bool setHighLighted)
    {
        ArgumentNullException.ThrowIfNull(sq);
        
        if (Answer is null) return;
        for (var i = 0; i < Answer.Length; i++)
        {
            if (!setHighLighted)
                SqAnswerSquares?[i]?.SetHighlighted(UIConstants.CurrentNone);
            else
            {
                SqAnswerSquares?[i]
                    ?.SetHighlighted(SqAnswerSquares?[i] == sq
                        ? UIConstants.CurrentLetter
                        : UIConstants.CurrentWord);
            }
        }
        
        
        
        // Parallel.For(0, Answer.Length, i =>
        // {
        //     if (!setHighLighted)
        //         SqAnswerSquares?[i]?.SetHighlighted(UIConstants.CurrentNone);
        //     else
        //     {
        //         SqAnswerSquares?[i]
        //         ?.SetHighlighted(SqAnswerSquares?[i] == sq
        //         ? UIConstants.CurrentLetter
        //         : UIConstants.CurrentWord);
        //     }
        // });
    }

    #endregion
}