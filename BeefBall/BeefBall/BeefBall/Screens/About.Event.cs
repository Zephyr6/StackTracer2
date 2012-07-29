using System;
using FlatRedBall;
using FlatRedBall.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using BeefBall.Entities;
using BeefBall.Entities.GameScreen;
using BeefBall.Screens;
using System.Text;
namespace BeefBall.Screens
{
	public partial class About
	{
        bool toMainMenu = true;
        StringBuilder sb = new StringBuilder();
        void OnBackButtonClick (FlatRedBall.Gui.IWindow callingWindow)
        {
            if (toMainMenu)
                this.MoveToScreen(typeof(MainMenu).FullName);
            else
            {
                ShowButtons();
                aboutText.DisplayText = "";
                sb = sb.Clear();
            }
        }
        void OnBackButtonRollOn (FlatRedBall.Gui.IWindow callingWindow)
        {
            BackButton.CurrentState = Button.VariableState.Regular;
        }
        void OnBackButtonRollOff (FlatRedBall.Gui.IWindow callingWindow)
        {
            BackButton.CurrentState = Button.VariableState.Disabled;
        }
        void OnProjectButtonClick (FlatRedBall.Gui.IWindow callingWindow)
        {
            HideButtons();
            ProjectbuttonText();
        }
        void OnProjectButtonRollOn (FlatRedBall.Gui.IWindow callingWindow)
        {
            ProjectButton.CurrentState = Button.VariableState.Regular;
        }
        void OnProjectButtonRollOff (FlatRedBall.Gui.IWindow callingWindow)
        {
            ProjectButton.CurrentState = Button.VariableState.Disabled;
        }
        void OnQuizButtonClick (FlatRedBall.Gui.IWindow callingWindow)
        {
            this.MoveToScreen(typeof(QuizScreenCopy).FullName);
        }
        void OnQuizButtonRollOn (FlatRedBall.Gui.IWindow callingWindow)
        {
            QuizButton.CurrentState = Button.VariableState.Regular;
        }
        void OnQuizButtonRollOff (FlatRedBall.Gui.IWindow callingWindow)
        {
            QuizButton.CurrentState = Button.VariableState.Disabled;
        }
        void OnStoryButtonClick (FlatRedBall.Gui.IWindow callingWindow)
        {
            HideButtons();
            StoryButtonText();
        }
        void OnStoryButtonRollOn (FlatRedBall.Gui.IWindow callingWindow)
        {
            StoryButton.CurrentState = Button.VariableState.Regular;
        }
        void OnStoryButtonRollOff (FlatRedBall.Gui.IWindow callingWindow)
        {
            StoryButton.CurrentState = Button.VariableState.Disabled;
        }
        void OnTeamButtonClick (FlatRedBall.Gui.IWindow callingWindow)
        {
            HideButtons();
            TeamButtonText();
        }
        void OnTeamButtonRollOn (FlatRedBall.Gui.IWindow callingWindow)
        {
            TeamButton.CurrentState = Button.VariableState.Regular;
        }
        void OnTeamButtonRollOff (FlatRedBall.Gui.IWindow callingWindow)
        {
            TeamButton.CurrentState = Button.VariableState.Disabled;
        }

        void HideButtons() 
        {
            TeamButton.Visible = false;
            ProjectButton.Visible = false;
            StoryButton.Visible = false;
            QuizButton.Visible = false;
            toMainMenu = false;
           
        }

        void ShowButtons() 
        {
            TeamButton.Visible = true;
            ProjectButton.Visible = true;
            StoryButton.Visible = true;
            QuizButton.Visible = true;
            toMainMenu = true;
        }

        void StoryButtonText() 
        {
            sb = sb.Append("Our hero, InnerEx must fight his way through");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);

            sb = sb.Append("those who prefer sloppy code & infinate loops.");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);

            sb = sb.Append("Only through defeating his enemies & proving his");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("C# knowledge can he ever turely free his compiler");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("from runtime errors.  Good Luck Inner Ex!");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            WriteText(sb.ToString());   
        }

        void ProjectbuttonText()
        {
            sb = sb.Append("Code:");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);

            sb = sb.Append("C# with XNA and Flat Red Ball Libraries");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Project Helper:  Glue");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Repository:  GitHub Open source project");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            WriteText(sb.ToString());
        }

        void TeamButtonText() 
        {
            sb = sb.Append("Team:");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            
            sb = sb.Append("Code by: David Jungst & Carlos Cruz");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Story by: David Jungst & Carlos Cruz");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Art and animation by :  Nathan Christie");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Extreme patience by:  Wives and girlfriends");
            WriteText(sb.ToString());
        }

        void WriteText(string text) 
        {
            aboutText.Scale = 8f;
            aboutText.Spacing = 8;
            aboutText.X = -90;
            aboutText.Y = 80;
            aboutText.DisplayText = text;
        }        void OnBackClick (FlatRedBall.Gui.IWindow callingWindow)
        {
            
        }
    

	}
}
