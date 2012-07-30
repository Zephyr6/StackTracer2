using System;
using FlatRedBall;
#if FRB_XNA || SILVERLIGHT
#endif

namespace BeefBall.Entities
{
    public partial class CapacitorPlatformCopyCopy
    {
        float posX;

        private void CustomInitialize()
        {
            posX = X;
        }

        private void CustomActivity()
        {
            X = posX + SpriteManager.Camera.X * followAmount;
        }

        private void CustomDestroy()
        {
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
        }
    }
}