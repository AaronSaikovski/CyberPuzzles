﻿////////////////////////////////////////////////////////////////////////////
//                                                                        //
//      Module:     MouseHandler.cs                                      //
//      Authors:    Aaron Saikovski                                       //
//      Date:       31/10/2023                                            //
//      Version:    1.0                                                   //
//      Purpose:    Generic crosswordMain mouse handler.                      //
//      Ref:        https://github.com/DavidFidge/InputHandlers           //
//                                                                        //
////////////////////////////////////////////////////////////////////////////

using InputHandlers.Mouse;
using Microsoft.Xna.Framework.Input;

namespace Crossword.EventHandlers;

public class MouseInputHandler(App.CrosswordMain crosswordMain) : IMouseHandler
{
    #region Mouse_Input_Handler

    //CrosswordMain.Application instance

    public void HandleLeftMouseClick(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();

    }

    public void HandleLeftMouseDoubleClick(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleLeftMouseDown(MouseState mouseState)
    {

    }

    public void HandleLeftMouseDragDone(MouseState mouseState, MouseState originalMouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleLeftMouseDragging(MouseState mouseState, MouseState originalMouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleLeftMouseUp(MouseState mouseState, MouseState origin)
    {
        //Check if the mouse action is inside the main rect
        if (crosswordMain.rectCrossWord.Contains(origin.Position))
        {
            //Console.WriteLine("Inside rect!");
            crosswordMain.MouseUp(origin.X, origin.Y);
        }
    }


    public void HandleMiddleMouseClick(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleMiddleMouseDoubleClick(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleMiddleMouseDown(MouseState mouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleMiddleMouseDragDone(MouseState mouseState, MouseState originalMouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleMiddleMouseDragging(MouseState mouseState, MouseState originalMouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleMiddleMouseUp(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleMouseMoving(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleMouseScrollWheelMove(MouseState mouseState, int difference)
    {
        //throw new NotImplementedException();
    }

    public void HandleRightMouseClick(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleRightMouseDoubleClick(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    public void HandleRightMouseDown(MouseState mouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleRightMouseDragDone(MouseState mouseState, MouseState originalMouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleRightMouseDragging(MouseState mouseState, MouseState originalMouseState)
    {
        //throw new NotImplementedException();
    }

    public void HandleRightMouseUp(MouseState mouseState, MouseState origin)
    {
        //throw new NotImplementedException();
    }

    #endregion
}