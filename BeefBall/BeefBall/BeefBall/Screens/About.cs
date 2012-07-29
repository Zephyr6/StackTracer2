using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;

using FlatRedBall.Graphics.Model;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;
using FlatRedBall.Localization;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
using FlatRedBall.Graphics;
#endif

namespace BeefBall.Screens
{
	public partial class About
	{
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
                        TeamButtonActivity();
                        Game1.StartGameSFX.Play();
                    }
                    else if (currentButton == AboutButtons.Story)
                    {
                        StoryButtonActivity();
                        Game1.AboutGameSFX.Play();
                    }
                    else if (currentButton == AboutButtons.Project)
                    {
                        ProjectButtonActivity();
                        Game1.AboutGameSFX.Play();
                    }
                    else if (currentButton == AboutButtons.Quiz)
                    {
                        QuizButtonActivity();
                        Game1.AboutGameSFX.Play();
                    }
                    else if (currentButton == AboutButtons.Back)
                    {
                        BackButtonActivity();
                        Game1.AboutGameSFX.Play();
                    }
                }
                else
                    isMousedOver = false;

            }

		}

        void SelectActivity()
        {
            if(mGamePad.ButtonPushed(Xbox360GamePad.Button.B))
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
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
