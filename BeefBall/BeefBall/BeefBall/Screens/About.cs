using System;
using FlatRedBall;
using FlatRedBall.Input;
#if FRB_XNA || SILVERLIGHT
using FlatRedBall.Graphics;
using Microsoft.Xna.Framework.Media;

#endif

namespace BeefBall.Screens
{
    public partial class About
    {
        static string songManager = "ContentManager";
        static Song song = FlatRedBallServices.Load<Song>(@"Content/Blue Ruin", songManager);
		
        enum AboutButtons 
        {
            Team,
            Story,
            Project,
            Quiz,
            Back
        }

        AboutButtons currentButton = AboutButtons.Team;
        Xbox360GamePad mGamePad;
        bool canMove;
        bool isMousedOver;
        
        Text aboutText = TextManager.AddText("");
		
        void CustomInitialize()
        {
            Microsoft.Xna.Framework.Media.MediaPlayer.Play(song);
            TeamButton.CurrentState = Entities.Button.VariableState.Regular;
            mGamePad = InputManager.Xbox360GamePads[0];

            canMove = true;
            FlatRedBallServices.Game.IsMouseVisible = true;

            BackButton.Click += OnBackButtonClick;
            BackButton.RollOff += OnBackButtonRollOff;
            BackButton.RollOn += OnBackButtonRollOn;
        }

        void CustomActivity(bool firstTimeCalled)
        {
            if (!isMousedOver)
            {
                if (canMove)
                    SelectActivity();

                if (mGamePad.LeftStick.Position.Y == 0)
                    canMove = true;

                if (currentButton == AboutButtons.Team)
                {
                    TeamButton.CurrentState = Entities.Button.VariableState.Regular;
                    ProjectButton.CurrentState = Entities.Button.VariableState.Disabled;
                    StoryButton.CurrentState = Entities.Button.VariableState.Disabled;
                    QuizButton.CurrentState = Entities.Button.VariableState.Disabled;
                    BackButton.CurrentState = Entities.Button.VariableState.Disabled;
                }
                else if (currentButton == AboutButtons.Story)
                {
                    TeamButton.CurrentState = Entities.Button.VariableState.Disabled;
                    ProjectButton.CurrentState = Entities.Button.VariableState.Disabled;
                    StoryButton.CurrentState = Entities.Button.VariableState.Regular;
                    QuizButton.CurrentState = Entities.Button.VariableState.Disabled;
                    BackButton.CurrentState = Entities.Button.VariableState.Disabled;
                }
                else if (currentButton == AboutButtons.Project)
                {
                    TeamButton.CurrentState = Entities.Button.VariableState.Disabled;
                    ProjectButton.CurrentState = Entities.Button.VariableState.Regular;
                    StoryButton.CurrentState = Entities.Button.VariableState.Disabled;
                    QuizButton.CurrentState = Entities.Button.VariableState.Disabled;
                    BackButton.CurrentState = Entities.Button.VariableState.Disabled;
                }
                else if (currentButton == AboutButtons.Quiz)
                {
                    TeamButton.CurrentState = Entities.Button.VariableState.Disabled;
                    ProjectButton.CurrentState = Entities.Button.VariableState.Disabled;
                    StoryButton.CurrentState = Entities.Button.VariableState.Disabled;
                    QuizButton.CurrentState = Entities.Button.VariableState.Regular;
                    BackButton.CurrentState = Entities.Button.VariableState.Disabled;
                }
                else if (currentButton == AboutButtons.Back)
                {
                    TeamButton.CurrentState = Entities.Button.VariableState.Disabled;
                    ProjectButton.CurrentState = Entities.Button.VariableState.Disabled;
                    StoryButton.CurrentState = Entities.Button.VariableState.Disabled;
                    QuizButton.CurrentState = Entities.Button.VariableState.Disabled;
                    BackButton.CurrentState = Entities.Button.VariableState.Regular;
                }
            }
            else
            {
                if (mGamePad.LeftStick.Position.Y != 0)
                    isMousedOver = false;
            }

            if (mGamePad.ButtonPushed(Xbox360GamePad.Button.A) || mGamePad.ButtonPushed(Xbox360GamePad.Button.Start))
            {
                if (!isMousedOver)
                {
                    if (currentButton == AboutButtons.Team)
                    {
                        if (!buttonsHidden)
                        {
                            TeamButtonActivity();
                            Game1.BeepSFX.Play();
                        }
                    }
                    else if (currentButton == AboutButtons.Story)
                    {
                        if (!buttonsHidden)
                        {
                            StoryButtonActivity();
                        }
                    }
                    else if (currentButton == AboutButtons.Project)
                    {
                        if (!buttonsHidden)
                        { 
                            ProjectButtonActivity();
                            Game1.BeepSFX.Play();
                        }
                    }
                    else if (currentButton == AboutButtons.Quiz)
                    {
                        if (!buttonsHidden)
                        {
                            QuizButtonActivity();
                            Game1.BeepSFX.Play();
                        }
                    }
                    else if (currentButton == AboutButtons.Back)
                    {
                        BackButtonActivity();
                        if (!buttonsHidden)
                        {
                            Game1.BeepSFX.Play();
                        }
                    }
                }
                else
                    isMousedOver = false;
            }
        }

        void SelectActivity()
        {
            if (mGamePad.ButtonPushed(Xbox360GamePad.Button.B))
                BackButtonActivity();

            if (mGamePad.LeftStick.Position.Y > 0) // up
            {
                if (currentButton == AboutButtons.Team)
                    currentButton = AboutButtons.Team;
                else if (currentButton == AboutButtons.Project)
                    currentButton = AboutButtons.Story;
                else if (currentButton == AboutButtons.Story)
                    currentButton = AboutButtons.Team;
                else if (currentButton == AboutButtons.Quiz)
                    currentButton = AboutButtons.Project;
                else if (currentButton == AboutButtons.Back)
                    currentButton = AboutButtons.Quiz;
            }
            else if (mGamePad.LeftStick.Position.Y < 0) // down
            {
                if (currentButton == AboutButtons.Team)
                    currentButton = AboutButtons.Story;
                else if (currentButton == AboutButtons.Project)
                    currentButton = AboutButtons.Quiz;
                else if (currentButton == AboutButtons.Story)
                    currentButton = AboutButtons.Project;
                else if (currentButton == AboutButtons.Quiz)
                    currentButton = AboutButtons.Back;
                else if (currentButton == AboutButtons.Back)
                    currentButton = AboutButtons.Back;
            }

            canMove = false;
        }

        void CustomDestroy()
        {
            TextManager.RemoveText(aboutText);
            Microsoft.Xna.Framework.Media.MediaPlayer.Stop();
        }

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }
    }
}