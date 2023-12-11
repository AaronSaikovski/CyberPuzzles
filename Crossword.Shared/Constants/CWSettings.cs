
////////////////////////////////////////////////////////////////////////////
//                                                                        //
//      Module:     CWSettings.cs                                         //
//      Authors:    Aaron Saikovski                                       //
//      Date:       31/10/202                                             //
//      Version:    1.0                                                   //
//      Purpose:    Global constants.                                     //
//                                                                        //
////////////////////////////////////////////////////////////////////////////

using Color = Microsoft.Xna.Framework.Color;

namespace Crossword.Shared.Constants;

public sealed class CWSettings
{

    //API key name
    public const string ApiKeyName = "XApiKey";
    
    //Square width and height constants
    public const int SquareWidth = 40;
    public const int SquareHeight = 40;
    public const float SquareSpacer = 1.9f;

    //Highlight Constants
    public const int CurrentLetter = 1;
    public const int CurrentWord = 2;
    public const int CurrentNone = 3;


    //Font sizes
    public const int FntSml = 9;
    public const int FntMed = 15;
    public const int FntLge = 20;

    //Crossword.Application dimension constants
    // public const int NMaxCrossWidth = 291;
    // public const int NMaxCrossHeight = 291;

    //main game offsets
    public const int MainOffsetX = 30;
    public const int MainOffsetY = 30;


    //Small number offset
    public const float SmlNumOffsetX = 1.8f;
    public const float SmlNumOffsetY = 1.7f;


    //Square char offset
    public const float SqCharOffsetX = 12.5f;
    public const float SqCharOffsetY = 12f;

    //ClueList offsets/sizes
    public const int ClLabelHeight = 20;
    public const int ClListboxHeight = 180;
    public const int ClListSpacer = 5;

    //Colors for square letters
    public static Color SqCorrect = Color.Green;
    public static Color SqError = Color.Black;
    
    //default puzzledata for testing
    public const string DefaultPuzzleData = "505*JX000000*0707*0 0 1 1#0 2 1 4#0 3 1 7#4 3 1 8#1 4 1 10#0 6 1 11#0 0 2 1#2 0 2 2#5 0 2 3#1 2 2 5#4 2 2 6#6 3 2 9*Try#Writing surface#Night bird#Truck#Opposite of male#Nearest#Car#Piece of furniture#Part of a flower#Terrible#Avoid#Unscramble XNET*ATTEMPT#TABLET#OWL#VAN#FEMALE#CLOSEST#AUTO#TABLE#PETAL#AWFUL#EVADE#NEXT*ABCDEFLMNOPSTUVWX*30 1 1 0 1 5*Use the clues to solve this crossword and earn CyberSilver. If you have not played our crosswords before and want help, then click the HELP button. Have fun!";
    
    //Puzzle tile images
    public const string BlackSquare = "images/tile_black";
    public const string HighliteSquare = "images/tile_yellow";
    public const string SquareWord = "images/tile_orange";
    public const string NormalSquare = "images/tile_grey";
    
    //Link Buttons
    public const string HintButtonImage = "images/btn_get_hint";
    public const string NextPuzzleButtonImage = "images/btn_next_puzzle";
    
    
    //Fonts
    public const string HelveticaBold = "fonts/Helvetica-Bold.ttf";
    public const string HelveticaPlain = "fonts/Helvetica.ttf";
    
    
    //Score color
    public static Color ScoreColor = Color.Red;
    
    
    //Button colours
    public static Color ButtonTextColor = Color.White;
    public static Color ButtonHoverTextColor = Color.Yellow;
    
 
    //Listbox text colors
    public static Color ListBoxTextColor = Color.Black;
    
    //Square highlight colors
    public static Color SquareHighlightCurrent = Color.Cyan;
    public static Color SquareHighlightWord = Color.Yellow;
    public static Color SquareHighlightNone = Color.White;
    public static Color SquareHighlightErr = Color.Red;
    public static Color SquareHighlightDefault = Color.Black;
    
    //Font colors
    public static Color SmallFontColor = Color.Black;
} 


    
