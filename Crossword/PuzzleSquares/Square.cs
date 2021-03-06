////////////////////////////////////////////////////////////////////////////
//                                                                        //
//      Module:             Square.cs                                     //
//      Authors:            Aaron Saikovski & Bryan Richards              //
//      Original Date:      23/01/97                                      //
//      Version:            1.0                                           //
//      Purpose:           Defines a Square and it's attributes            //
//                                                                        //
////////////////////////////////////////////////////////////////////////////

using Crossword.ClueAnswer;
using Microsoft.Xna.Framework;

namespace Crossword.PuzzleSquares;

//Square class
public sealed partial class Square
{
    #region getters_setters

    public int XCoord { get; set; }
    public int YCoord { get; set; }


    public char Letter { get; set; }


    public Color ForeColour { get; set; } = Color.Black;
    public Color BackColour { get; set; } = Color.Black;

    public bool IsDirty { get; set; } = true;

    public bool IsCharAllowed { get; set; }

    public ClueAnswerMap? ClueAnswerAcross { get; set; }
    public ClueAnswerMap? ClueAnswerDown { get; set; }

    #endregion
}