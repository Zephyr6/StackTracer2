using System;
using FlatRedBall;
#if FRB_XNA || SILVERLIGHT
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