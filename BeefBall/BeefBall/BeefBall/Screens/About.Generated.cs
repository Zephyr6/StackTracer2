using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math.Geometry;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Input;
using FlatRedBall.IO;
using FlatRedBall.Instructions;
using FlatRedBall.Math.Splines;
using FlatRedBall.Utilities;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;

#if XNA4
using Color = Microsoft.Xna.Framework.Color;
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
using Microsoft.Xna.Framework.Media;
#endif

// Generated Usings
using FlatRedBall.Broadcasting;
using BeefBall.Entities;
using BeefBall.Entities.GameScreen;
using FlatRedBall;

namespace BeefBall.Screens
{
	public partial class About : Screen
	{
		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		
		private BeefBall.Entities.Button StoryButton;
		private BeefBall.Entities.Button ProjectButton;
		private BeefBall.Entities.Button QuizButton;
		private BeefBall.Entities.Button BackButton;
		private BeefBall.Entities.Button TeamButton;
		public event FlatRedBall.Gui.WindowEvent BackClick;
		public event FlatRedBall.Gui.WindowEvent BackRollOff;
		public event FlatRedBall.Gui.WindowEvent BackRollOn;
		public event FlatRedBall.Gui.WindowEvent ProjectButtonClick;
		public event FlatRedBall.Gui.WindowEvent ProjectButtonRollOff;
		public event FlatRedBall.Gui.WindowEvent ProjectButtonRollOn;
		public event FlatRedBall.Gui.WindowEvent QuizButtonClick;
		public event FlatRedBall.Gui.WindowEvent QuizButtonRollOff;
		public event FlatRedBall.Gui.WindowEvent QuizButtonRollOn;
		public event FlatRedBall.Gui.WindowEvent StoryButtonClick;
		public event FlatRedBall.Gui.WindowEvent StoryButtonRollOff;
		public event FlatRedBall.Gui.WindowEvent StoryButtonRollOn;
		public event FlatRedBall.Gui.WindowEvent TeamButtonClick;
		public event FlatRedBall.Gui.WindowEvent TeamButtonRollOff;
		public event FlatRedBall.Gui.WindowEvent TeamButtonRollOn;

		public About()
			: base("About")
		{
		}

        public override void Initialize(bool addToManagers)
        {
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			StoryButton = new BeefBall.Entities.Button(ContentManagerName, false);
			StoryButton.Name = "StoryButton";
			ProjectButton = new BeefBall.Entities.Button(ContentManagerName, false);
			ProjectButton.Name = "ProjectButton";
			QuizButton = new BeefBall.Entities.Button(ContentManagerName, false);
			QuizButton.Name = "QuizButton";
			BackButton = new BeefBall.Entities.Button(ContentManagerName, false);
			BackButton.Name = "BackButton";
			TeamButton = new BeefBall.Entities.Button(ContentManagerName, false);
			TeamButton.Name = "TeamButton";
			BackButton.Click += OnBackClickTunnel;
			BackButton.RollOff += OnBackRollOffTunnel;
			BackButton.RollOn += OnBackRollOnTunnel;
			ProjectButton.Click += OnProjectButtonClick;
			ProjectButton.Click += OnProjectButtonClickTunnel;
			ProjectButton.RollOff += OnProjectButtonRollOff;
			ProjectButton.RollOff += OnProjectButtonRollOffTunnel;
			ProjectButton.RollOn += OnProjectButtonRollOn;
			ProjectButton.RollOn += OnProjectButtonRollOnTunnel;
			QuizButton.Click += OnQuizButtonClick;
			QuizButton.Click += OnQuizButtonClickTunnel;
			QuizButton.RollOff += OnQuizButtonRollOff;
			QuizButton.RollOff += OnQuizButtonRollOffTunnel;
			QuizButton.RollOn += OnQuizButtonRollOn;
			QuizButton.RollOn += OnQuizButtonRollOnTunnel;
			StoryButton.Click += OnStoryButtonClick;
			StoryButton.Click += OnStoryButtonClickTunnel;
			StoryButton.RollOff += OnStoryButtonRollOff;
			StoryButton.RollOff += OnStoryButtonRollOffTunnel;
			StoryButton.RollOn += OnStoryButtonRollOn;
			StoryButton.RollOn += OnStoryButtonRollOnTunnel;
			TeamButton.Click += OnTeamButtonClick;
			TeamButton.Click += OnTeamButtonClickTunnel;
			TeamButton.RollOff += OnTeamButtonRollOff;
			TeamButton.RollOff += OnTeamButtonRollOffTunnel;
			TeamButton.RollOn += OnTeamButtonRollOn;
			TeamButton.RollOn += OnTeamButtonRollOnTunnel;
			
			
			PostInitialize();
			base.Initialize(addToManagers);
			if (addToManagers)
			{
				AddToManagers();
			}

        }
        
// Generated AddToManagers
		public override void AddToManagers ()
		{
			base.AddToManagers();
			AddToManagersBottomUp();
			CustomInitialize();
		}


		public override void Activity(bool firstTimeCalled)
		{
			// Generated Activity
			if (!IsPaused)
			{
				
				StoryButton.Activity();
				ProjectButton.Activity();
				QuizButton.Activity();
				BackButton.Activity();
				TeamButton.Activity();
			}
			else
			{
			}
			base.Activity(firstTimeCalled);
			if (!IsActivityFinished)
			{
				CustomActivity(firstTimeCalled);
			}


				// After Custom Activity
				
            
		}

		public override void Destroy()
		{
			// Generated Destroy
			
			if (StoryButton != null)
			{
				StoryButton.Destroy();
				StoryButton.Detach();
			}
			if (ProjectButton != null)
			{
				ProjectButton.Destroy();
				ProjectButton.Detach();
			}
			if (QuizButton != null)
			{
				QuizButton.Destroy();
				QuizButton.Detach();
			}
			if (BackButton != null)
			{
				BackButton.Destroy();
				BackButton.Detach();
			}
			if (TeamButton != null)
			{
				TeamButton.Destroy();
				TeamButton.Detach();
			}

			base.Destroy();

			CustomDestroy();

		}

		// Generated Methods
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			StoryButton.DisplayText = "Story";
			if (StoryButton.Parent == null)
			{
				StoryButton.X = 50f;
			}
			else
			{
				StoryButton.RelativeX = 50f;
			}
			if (StoryButton.Parent == null)
			{
				StoryButton.Y = 80f;
			}
			else
			{
				StoryButton.RelativeY = 80f;
			}
			ProjectButton.DisplayText = "Project";
			if (ProjectButton.Parent == null)
			{
				ProjectButton.X = 50f;
			}
			else
			{
				ProjectButton.RelativeX = 50f;
			}
			if (ProjectButton.Parent == null)
			{
				ProjectButton.Y = 40f;
			}
			else
			{
				ProjectButton.RelativeY = 40f;
			}
			QuizButton.DisplayText = "Quiz";
			if (QuizButton.Parent == null)
			{
				QuizButton.X = 50f;
			}
			else
			{
				QuizButton.RelativeX = 50f;
			}
			if (QuizButton.Parent == null)
			{
				QuizButton.Y = 0f;
			}
			else
			{
				QuizButton.RelativeY = 0f;
			}
			BackButton.DisplayText = "Back";
			if (BackButton.Parent == null)
			{
				BackButton.X = 50f;
			}
			else
			{
				BackButton.RelativeX = 50f;
			}
			if (BackButton.Parent == null)
			{
				BackButton.Y = -40f;
			}
			else
			{
				BackButton.RelativeY = -40f;
			}
			TeamButton.DisplayText = "Team";
			if (TeamButton.Parent == null)
			{
				TeamButton.X = 50f;
			}
			else
			{
				TeamButton.RelativeX = 50f;
			}
			if (TeamButton.Parent == null)
			{
				TeamButton.Y = 120f;
			}
			else
			{
				TeamButton.RelativeY = 120f;
			}
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}
		public virtual void AddToManagersBottomUp ()
		{
			StoryButton.AddToManagers(mLayer);
			StoryButton.CurrentState = BeefBall.Entities.Button.VariableState.Disabled;
			StoryButton.DisplayText = "Story";
			if (StoryButton.Parent == null)
			{
				StoryButton.X = 50f;
			}
			else
			{
				StoryButton.RelativeX = 50f;
			}
			if (StoryButton.Parent == null)
			{
				StoryButton.Y = 80f;
			}
			else
			{
				StoryButton.RelativeY = 80f;
			}
			ProjectButton.AddToManagers(mLayer);
			ProjectButton.CurrentState = BeefBall.Entities.Button.VariableState.Disabled;
			ProjectButton.DisplayText = "Project";
			if (ProjectButton.Parent == null)
			{
				ProjectButton.X = 50f;
			}
			else
			{
				ProjectButton.RelativeX = 50f;
			}
			if (ProjectButton.Parent == null)
			{
				ProjectButton.Y = 40f;
			}
			else
			{
				ProjectButton.RelativeY = 40f;
			}
			QuizButton.AddToManagers(mLayer);
			QuizButton.CurrentState = BeefBall.Entities.Button.VariableState.Disabled;
			QuizButton.DisplayText = "Quiz";
			if (QuizButton.Parent == null)
			{
				QuizButton.X = 50f;
			}
			else
			{
				QuizButton.RelativeX = 50f;
			}
			if (QuizButton.Parent == null)
			{
				QuizButton.Y = 0f;
			}
			else
			{
				QuizButton.RelativeY = 0f;
			}
			BackButton.AddToManagers(mLayer);
			BackButton.CurrentState = BeefBall.Entities.Button.VariableState.Disabled;
			BackButton.DisplayText = "Back";
			if (BackButton.Parent == null)
			{
				BackButton.X = 50f;
			}
			else
			{
				BackButton.RelativeX = 50f;
			}
			if (BackButton.Parent == null)
			{
				BackButton.Y = -40f;
			}
			else
			{
				BackButton.RelativeY = -40f;
			}
			TeamButton.AddToManagers(mLayer);
			TeamButton.CurrentState = BeefBall.Entities.Button.VariableState.Disabled;
			TeamButton.DisplayText = "Team";
			if (TeamButton.Parent == null)
			{
				TeamButton.X = 50f;
			}
			else
			{
				TeamButton.RelativeX = 50f;
			}
			if (TeamButton.Parent == null)
			{
				TeamButton.Y = 120f;
			}
			else
			{
				TeamButton.RelativeY = 120f;
			}
		}
		public virtual void ConvertToManuallyUpdated ()
		{
			StoryButton.ConvertToManuallyUpdated();
			ProjectButton.ConvertToManuallyUpdated();
			QuizButton.ConvertToManuallyUpdated();
			BackButton.ConvertToManuallyUpdated();
			TeamButton.ConvertToManuallyUpdated();
		}
		public static void LoadStaticContent (string contentManagerName)
		{
			#if DEBUG
			if (contentManagerName == FlatRedBallServices.GlobalContentManager)
			{
				HasBeenLoadedWithGlobalContentManager = true;
			}
			else if (HasBeenLoadedWithGlobalContentManager)
			{
				throw new Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
			}
			#endif
			BeefBall.Entities.Button.LoadStaticContent(contentManagerName);
			CustomLoadStaticContent(contentManagerName);
		}
		object GetMember (string memberName)
		{
			return null;
		}


	}
}
