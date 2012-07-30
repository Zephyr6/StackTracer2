using System;
using FlatRedBall;
#if FRB_XNA || SILVERLIGHT
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