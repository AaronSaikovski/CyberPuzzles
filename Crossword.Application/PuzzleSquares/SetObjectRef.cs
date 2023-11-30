using System;
using CyberPuzzles.Crossword.App.ClueAnswer;
using Crossword.Shared.Constants;

namespace CyberPuzzles.Crossword.App.PuzzleSquares;

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
        BackColour = CWSettings.SquareHighlightNone;
    }

    #endregion
}