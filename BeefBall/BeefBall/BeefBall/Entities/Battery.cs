using System;
using FlatRedBall;

#if FRB_XNA || SILVERLIGHT
#endif

namespace BeefBall.Entities
{
    public partial class Battery
    {
        public float posX, posY;
        public int max;

        private void CustomInitialize()
        {
            posX = X;
            posY = Y;
        }

        private void CustomActivity()
        {
            X = posX + SpriteManager.Camera.X;
            Y = posY + SpriteManager.Camera.Y;

            Bar.X = X;
            Bar.Y = Y;

            if (Game1.Player.Health >= max)
                CurrentState = VariableState.Full;
            else if (Game1.Player.Health == max - 1)
                CurrentState = VariableState.ThreeQuarters;
            else if (Game1.Player.Health == max - 2)
                CurrentState = VariableState.Half;
            else if (Game1.Player.Health == max - 3)
                CurrentState = VariableState.Quarter;
            else
                CurrentState = VariableState.Empty;
        }

        private void CustomDestroy()
        {
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
        }
    }
}