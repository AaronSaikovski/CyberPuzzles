
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

using CyberPuzzles.Crossword.App.Datasets;

namespace CyberPuzzles.Crossword.App;

public sealed partial class Crossword
{
    #region InitControls

    private void InitControls()
    {
        //Init the main rectangle
        rectCrossWord = new Rectangle(nCrossOffsetX, nCrossOffsetY, _nCrosswordWidth, _nCrosswordHeight);

        //List box elements
        InitListBoxes();
      
        //Init Hint Button
        InitHintButton();
        
        //Init next puzzle button
        InitGetNextPuzzleButton();
        
        //Crossword Parsed Dataset
        //
        //Dimension array for crossword data
        _puzzleDataset = new PuzzleDataset[NumQuestions];
         for (var i = 0; i < NumQuestions; i++)
             _puzzleDataset[i] = new PuzzleDataset(_rowRef[i], _colRef[i], _szAnswers[i], _szClues[i], _bDataIsAcross[i],
                 _quesNum[i]);

        // init labels
        _currentScoreLabel = new Label();
        _maxScoreLabel = new Label();
    }

    #endregion
}