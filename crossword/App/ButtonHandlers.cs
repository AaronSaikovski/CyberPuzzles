using System;

namespace CyberPuzzles.Crossword.App;

public sealed partial class Crossword
{

    private void HintButtonClick(object sender, EventArgs args)
    {
        GetHintLetters(0);
    }

    private void NextPuzzleButtonClick(object sender, EventArgs args)
    {
        Console.WriteLine("next puzz pressed");
    }


}