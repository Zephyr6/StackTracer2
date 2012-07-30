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
using FlatRedBall.Graphics;

namespace BeefBall.Screens
{
	public partial class GameOver : Screen
	{
		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		
		private FlatRedBall.Graphics.Text InfoText;

		public GameOver()
			: base("GameOver")
		{
		}

        public override void Initialize(bool addToManagers)
        {
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			InfoText = new FlatRedBall.Graphics.Text();
			
			
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
			
			if (InfoText != null)
			{
				InfoText.Detach(); TextManager.RemoveText(InfoText);
			}

			base.Destroy();

			CustomDestroy();

		}

		// Generated Methods
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			InfoText.DisplayText = "Game Over";
			if (InfoText.Parent == null)
			{
				InfoText.X = -150f;
			}
			else
			{
				InfoText.RelativeX = -150f;
			}
			if (InfoText.Parent == null)
			{
				InfoText.Y = 0f;
			}
			else
			{
				InfoText.RelativeY = 0f;
			}
			InfoText.Scale = 40f;
			InfoText.Spacing = 37f;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}
		public virtual void AddToManagersBottomUp ()
		{
			TextManager.AddText(InfoText); InfoText.SetPixelPerfectScale(SpriteManager.Camera);
			InfoText.SetPixelPerfectScale(mLayer);
			InfoText.DisplayText = "Game Over";
			if (InfoText.Parent == null)
			{
				InfoText.X = -150f;
			}
			else
			{
				InfoText.RelativeX = -150f;
			}
			if (InfoText.Parent == null)
			{
				InfoText.Y = 0f;
			}
			else
			{
				InfoText.RelativeY = 0f;
			}
			InfoText.Scale = 40f;
			InfoText.Spacing = 37f;
		}
		public virtual void ConvertToManuallyUpdated ()
		{
			TextManager.ConvertToManuallyUpdated(InfoText);
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
			CustomLoadStaticContent(contentManagerName);
		}
		object GetMember (string memberName)
		{
			return null;
		}


	}
}
