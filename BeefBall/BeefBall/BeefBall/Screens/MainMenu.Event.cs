using System;
using BeefBall.Entities;
using FlatRedBall;

namespace BeefBall.Screens
{
    public partial class MainMenu
    {
        void OnStartButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            this.MoveToScreen(typeof(GameScreen).FullName);
            Game1.StartGameSFX.Play();
        }
        
        void OnAboutButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            this.MoveToScreen(typeof(About).FullName);
        }
        
        void OnExitButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            FlatRedBallServices.Game.Exit();
        }

        void OnStartButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            AboutButton.CurrentState = Button.VariableState.Disabled;
            ExitButton.CurrentState = Button.VariableState.Disabled;
            StartGameButton.CurrentState = Button.VariableState.Regular;
            isMousedOver = true;
            beep.Play();
        }
        
        void OnStartButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            AboutButton.CurrentState = Button.VariableState.Disabled;
            ExitButton.CurrentState = Button.VariableState.Disabled;
            StartGameButton.CurrentState = Button.VariableState.Disabled;
        }
        
        void OnAboutButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            AboutButton.CurrentState = Button.VariableState.Regular;
            ExitButton.CurrentState = Button.VariableState.Disabled;
            StartGameButton.CurrentState = Button.VariableState.Disabled;
            isMousedOver = true;
            beep.Play();
        }
        
        void OnAboutButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            AboutButton.CurrentState = Button.VariableState.Disabled;
            ExitButton.CurrentState = Button.VariableState.Disabled;
            StartGameButton.CurrentState = Button.VariableState.Disabled;
        }
        
        void OnExitButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            AboutButton.CurrentState = Button.VariableState.Disabled;
            ExitButton.CurrentState = Button.VariableState.Regular;
            StartGameButton.CurrentState = Button.VariableState.Disabled;
            isMousedOver = true;
            beep.Play();
        }
        
        void OnExitButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            AboutButton.CurrentState = Button.VariableState.Disabled;
            ExitButton.CurrentState = Button.VariableState.Disabled;
            StartGameButton.CurrentState = Button.VariableState.Disabled;
        }
    }
}