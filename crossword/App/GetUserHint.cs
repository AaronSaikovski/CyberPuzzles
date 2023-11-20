using System;

namespace CyberPuzzles.Crossword.App;

public sealed partial class Crossword
{
    //Hint implementation
    private void GetHintLetters(int nCount) {
        try {

            //local vars
            bool bHintSupplied=false, bAllHintLettersChecked=false;

            while(!bHintSupplied&&(!bAllHintLettersChecked)){
             
                if(_szTmpGetLetters.Length > 0){
                    var chHintLetter = _szTmpGetLetters[0];
                    _szTmpGetLetters = _szTmpGetLetters[1..];
                    for(var i = 0; i<NumQuestions; i++)
                    {
                        var bTmpResult = caPuzzleClueAnswers[i].CheckHint(chHintLetter);
                        if(bTmpResult) {
                            bHintSupplied = true;
                        }
                    }
                    nCount++;
                    if(nCount == _szGetLetters.Length)
                        bAllHintLettersChecked = true;
                }
                else
                {
                    _szTmpGetLetters = _szGetLetters;
                    GetHintLetters(nCount);
                    bHintSupplied = true;

                }
            }
        }
        catch (Exception e) { //Catch the exception
            Console.WriteLine("Exception " + e + " occurred in method GetHintLetters()");
        }
        
        // try {
        //
        //     //local vars
        //     bool bHintSupplied=false, bAllHintLettersChecked=false, bTmpResult;
        //
        //     while((!bHintSupplied)&&(!bAllHintLettersChecked)){
        //      
        //         if(_szTmpGetLetters.Length > 0){
        //             char chHintLetter = _szTmpGetLetters[0];
        //             _szTmpGetLetters = _szTmpGetLetters.Substring(1);
        //             for(int i = 0; i<nNumQuestions; i++) {
        //                 bTmpResult = caPuzzleClueAnswers[i].checkHint(chHintLetter);
        //                 if(bTmpResult) {
        //                     bHintSupplied = true;
        //                 }
        //             }
        //             nCount++;
        //             if(nCount == _szGetLetters.Length)
        //                 bAllHintLettersChecked = true;
        //         }
        //         else
        //         {
        //             _szTmpGetLetters = _szGetLetters;
        //             GetHintLetters(nCount);
        //             bHintSupplied = true;
        //
        //         }
        //     }
        // }
        // catch (Exception e) { //Catch the exception
        //     Console.WriteLine("Exception " + e + " occurred in method GetHintLetters()");
        // }
    }
    
}