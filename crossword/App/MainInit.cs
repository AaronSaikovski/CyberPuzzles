namespace CyberPuzzles.Crossword.App;

public sealed partial class Crossword
{
    #region MainInit

    private void MainInit()
    {
        //load fonts
        LoadFonts();

        //Load images
        LoadImages();

        //Init the data
        InitData();

        //Init the controls
        InitControls();


        //build the crossword data
        BuildCrossword();

        BNewBackFlush = true;


        //Show the lists
        LstClueAcross.Visible = true;
        LstClueDown.Visible = true;

        //Set the initial active square
        SqCurrentSquare = CaPuzzleClueAnswers[0].GetSquare();

        //Return the orientation
        IsAcross = CaPuzzleClueAnswers[0].BIsAcross;

        //Highlight the default square...if allowed
        CaPuzzleClueAnswers[0].HighlightSquares(SqCurrentSquare, true);

        //Set the default across list item to be the first item in the list
        LstClueAcross.SelectedIndex = 0;


        //Forces dirty squares
        for (var i = 0; i < NNumRows; i++)
        {
            //down
            for (var j = 0; j < NNumCols; j++)
            {
                _sqPuzzleSquares[i, j].BIsDirty = true;
            }
        }


        //Set index to bubble out
        //nBubbleOut = 1;
        BBufferDirty = true;
        BNewBackFlush = true;

        //Get next puzzle ID
        _bMorePuzzles = true; // getNextPuzzleData();
    }

    #endregion
}