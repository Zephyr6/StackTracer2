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
	public partial class GameScreenCopyCopyCopy
	{
        static string songManager = "ContentManager";
        static Song song = FlatRedBallServices.Load<Song>(@"Content/Dragonfly", songManager);
        
		void CustomInitialize()
		{
            Microsoft.Xna.Framework.Media.MediaPlayer.Play(song);
		}

		void CustomActivity(bool firstTimeCalled)
		{


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
