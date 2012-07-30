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
using Microsoft.Xna.Framework.Media;
#endif

namespace BeefBall.Screens
{
	public partial class GameOver
	{
        static string songManager = "ContentManager";
        static Song song = FlatRedBallServices.Load<Song>(@"Content/Find a smile, bring it home", songManager);
		void CustomInitialize()
		{
            Microsoft.Xna.Framework.Media.MediaPlayer.Play(song);
            Game1.ResetLevel();

		}

		void CustomActivity(bool firstTimeCalled)
		{
            if (Game1.GamePad.AnyButtonPushed())
                this.MoveToScreen(typeof(MainMenu).FullName);

		}

		void CustomDestroy()
		{
            Microsoft.Xna.Framework.Media.MediaPlayer.Stop();

		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
