using System;
using System.Text;
using BeefBall.Entities;

namespace BeefBall.Screens
{
    public partial class About
    {
        bool toMainMenu = true;
        bool buttonsHidden = false;
        StringBuilder sb = new StringBuilder();
        void OnBackButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            BackButtonActivity();
        }

        void BackButtonActivity() 
        {
            if (toMainMenu)
                this.MoveToScreen(typeof(MainMenu).FullName);
            else
            {
                ShowButtons();
                clearText();
                sb = sb.Clear();
            }
            Game1.BeepSFX.Play();
        }

        void OnBackButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            BackButton.CurrentState = Button.VariableState.Regular;
        }

        void OnBackButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            BackButton.CurrentState = Button.VariableState.Disabled;
        }

        void OnProjectButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            ProjectButtonActivity();
        }

        void ProjectButtonActivity() 
        {
            HideButtons();
            ProjectbuttonText();
        }

        void OnProjectButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            ProjectButton.CurrentState = Button.VariableState.Regular;
        }

        void OnProjectButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            ProjectButton.CurrentState = Button.VariableState.Disabled;
        }

        void OnQuizButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            QuizButtonActivity();
        }

        void QuizButtonActivity() 
        {
            Game1.BeepSFX.Play();
            this.MoveToScreen(typeof(QuizScreenCopy).FullName);
        }

        void OnQuizButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            QuizButton.CurrentState = Button.VariableState.Regular;
        }

        void OnQuizButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            QuizButton.CurrentState = Button.VariableState.Disabled;
        }

        void OnStoryButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            StoryButtonActivity();
        }

        void StoryButtonActivity() 
        {
            HideButtons();
            StoryButtonText();
        }

        void OnStoryButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            StoryButton.CurrentState = Button.VariableState.Regular;
        }

        void OnStoryButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            StoryButton.CurrentState = Button.VariableState.Disabled;
        }

        void OnTeamButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            TeamButtonActivity();
        }

        void TeamButtonActivity() 
        {
            HideButtons();
            TeamButtonText();
        }

        void OnTeamButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            TeamButton.CurrentState = Button.VariableState.Regular;
        }

        void OnTeamButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            TeamButton.CurrentState = Button.VariableState.Disabled;
        }

        void HideButtons() 
        {
            Game1.BeepSFX.Play();
            buttonsHidden = true;
            TeamButton.Visible = false;
            ProjectButton.Visible = false;
            StoryButton.Visible = false;
            QuizButton.Visible = false;
            toMainMenu = false;
        }

        void ShowButtons() 
        {
            buttonsHidden = false;
            TeamButton.Visible = true;
            ProjectButton.Visible = true;
            StoryButton.Visible = true;
            QuizButton.Visible = true;
            toMainMenu = true;
        }

        void StoryButtonText() 
        {
            clearText();
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
            clearText();
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
            clearText();
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
            sb = sb.Append("Art and animation by:  Nathan Christie & Carlos Cruz");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Music by:  Brandon Ellis");
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append(Environment.NewLine);
            sb = sb.Append("Extreme patience by:  Wives and girlfriends");
            WriteText(sb.ToString());
        }

        void clearText() 
        {
            sb.Clear();
            aboutText.DisplayText = "";
        }

        void WriteText(string text) 
        {
            aboutText.Scale = 8f;
            aboutText.Spacing = 8;
            aboutText.X = -90;
            aboutText.Y = 80;
            aboutText.DisplayText = text;
        }

        void OnBackClick(FlatRedBall.Gui.IWindow callingWindow)
        {
        }
    
        void OnBackRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
        }

        void OnBackRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
        }
    }
}