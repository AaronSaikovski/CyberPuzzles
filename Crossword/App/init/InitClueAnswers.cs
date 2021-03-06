using System;
using Crossword.ClueAnswer;
using Crossword.PuzzleSquares;
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Crossword.App;

public sealed partial class CrosswordMain
{
    #region InitClueAnswers

    /// <summary>
    /// Inits the ClueAnswer objects
    /// </summary>
    private void InitClueAnswers()
    {
        try
        {
            _logger.LogInformation("Start InitClueAnswers()");
            
            //loop over the questions
            for (var i = 0; i < NumQuestions; i++)
            {
                //Need to build a temp object of sqAnswerSquares[]
                var sqAnswerSquares = new Square?[_puzzleDataset[i].Answer.Length];
                for (var j = 0; j < _puzzleDataset[i].Answer.Length; j++)
                {
                    //Need to work out number
                    //Build the Clue/Answer sets
                    if (_puzzleDataset[i].IsAcross)
                    {
                        sqAnswerSquares[j] =
                            sqPuzzleSquares[_puzzleDataset[i].CoordDown + j, _puzzleDataset[i].CoordAcross];
                        if (j == 0)
                            LstClueAcross.Items.Add(new ListItem(
                                $"{_puzzleDataset[i].QuestionNum}. {_puzzleDataset[i].Clue}",
                                Color.White));
                    }
                    else
                    {
                        sqAnswerSquares[j] =
                            sqPuzzleSquares[_puzzleDataset[i].CoordDown, _puzzleDataset[i].CoordAcross + j];
                        if (j == 0)
                            LstClueDown.Items.Add(new ListItem(
                                $"{_puzzleDataset[i].QuestionNum}. {_puzzleDataset[i].Clue}",
                                Color.White));
                    }
                }

                //Build the Clue/Answer references
                caPuzzleClueAnswers[i] = new ClueAnswerMap();
                caPuzzleClueAnswers[i].SetObjectRef(_puzzleDataset[i].Answer,
                    _puzzleDataset[i].Clue, _puzzleDataset[i].QuestionNum,
                    _puzzleDataset[i].IsAcross, sqAnswerSquares);
            }
        
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,ex.Message);
            throw;
        }
    }

    #endregion
}