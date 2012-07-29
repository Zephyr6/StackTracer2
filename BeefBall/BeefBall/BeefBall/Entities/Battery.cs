using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;

using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;


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
