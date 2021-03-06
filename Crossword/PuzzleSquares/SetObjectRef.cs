using System;
using Crossword.ClueAnswer;
using Crossword.Constants;

namespace Crossword.PuzzleSquares;

public sealed partial class Square
{
    #region SetObjectRef

    /// <summary>
    /// Set the object reference to clueanswer object
    /// </summary>
    /// <param name="isAcross"></param>
    /// <param name="clueAnswer"></param>
    public void SetObjectRef(bool isAcross, ClueAnswerMap clueAnswer)
    {
        ArgumentNullException.ThrowIfNull(clueAnswer);
        
        if (isAcross)
            ClueAnswerAcross = clueAnswer;
        else
            ClueAnswerDown = clueAnswer;

        IsCharAllowed = true;
        IsDirty = true;
        BackColour = UIConstants.SquareHighlightNone;
    }

    #endregion
}