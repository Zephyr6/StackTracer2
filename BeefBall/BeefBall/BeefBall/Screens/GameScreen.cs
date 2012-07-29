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

using Microsoft.Xna.Framework;
using Microsoft.Xna;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
using FlatRedBall.Math;
#endif

namespace BeefBall.Screens
{
    public partial class GameScreen
    {
        List<Entities.GameScreen.Enemy> enemies;
        List<Entities.CapacitorPlatform> capacitorPlatforms;
        List<Entities.Battery> playerBatteries;

        void CustomInitialize()
        {
            SpriteManager.Camera.MinimumX = 100;
            SpriteManager.Camera.MinimumY = -93;

            SpriteManager.Camera.AttachTo(PlayerInstance.Body, true);
            //SpriteManager.Camera.BackgroundColor = Color.DeepSkyBlue;

            enemies = new List<Entities.GameScreen.Enemy>();
            enemies.Add(EnemyInstance);
            enemies.Add(EnemyInstance2);

            capacitorPlatforms = new List<Entities.CapacitorPlatform>();
            capacitorPlatforms.Add(CapacitorPlatformInstance);
            capacitorPlatforms.Add(CapacitorPlatformInstance2);
            capacitorPlatforms.Add(CapacitorPlatformInstance3);
            capacitorPlatforms.Add(CapacitorPlatformInstance4);
            capacitorPlatforms.Add(CapacitorPlatformInstance5);
            capacitorPlatforms.Add(CapacitorPlatformInstance6);
            capacitorPlatforms.Add(CapacitorPlatformInstance7);
            capacitorPlatforms.Add(CapacitorPlatformInstance8);

            PlayerInstance.enemies = enemies;

            Game1.Player = PlayerInstance;

            playerBatteries = new List<Entities.Battery>();
            for (int i = 0; i < PlayerInstance.MaxBatteries; i++)
            {
                AddBattery();
            }
        }

        void AddBattery()
        {
            Entities.Battery bat = new Entities.Battery(ContentManagerName, true);
            bat.posX = -175.1F + (playerBatteries.Count * 40);
            bat.posY = 135.1F;
            playerBatteries.Add(bat);
        }

        void BatteryActivity()
        {
            for (int i = 0; i < Game1.Player.MaxBatteries; i++)
            {
                if (Game1.Player.Health >= (i + 1) * 4)
                {
                    playerBatteries[i].CurrentState = Entities.Battery.VariableState.Full;
                }
                else
                {
                    float mod = Game1.Player.Health - (i * 4);

                    if (mod == 3)
                        playerBatteries[i].CurrentState = Entities.Battery.VariableState.ThreeQuarters;
                    else if (mod == 2)
                        playerBatteries[i].CurrentState = Entities.Battery.VariableState.Half;
                    else if (mod == 1)
                        playerBatteries[i].CurrentState = Entities.Battery.VariableState.Quarter;
                    else
                        playerBatteries[i].CurrentState = Entities.Battery.VariableState.Empty;
                }
            }
        }

        void CustomActivity(bool firstTimeCalled)
        {
            CollisionActivity();
            CleanUpActivity();

            playerBatteries[0].posX += Game1.GamePad.RightStick.Position.X;
            playerBatteries[0].posY += Game1.GamePad.RightStick.Position.Y;

            if (Game1.GamePad.ButtonPushed(Xbox360GamePad.Button.RightStick))
                PlayerInstance.Health--;

            BatteryActivity();

            foreach (Entities.Battery bat in playerBatteries)
                bat.Activity();
        }

        private void CleanUpActivity()
        {
            List<Entities.GameScreen.Enemy> enemiesToRemove = new List<Entities.GameScreen.Enemy>();

            foreach (Entities.GameScreen.Enemy en in enemies)
                if (en.isDead)
                    enemiesToRemove.Add(en);

            foreach (Entities.GameScreen.Enemy en in enemiesToRemove)
            {
                enemies.Remove(en);
                PlayerInstance.enemies.Remove(en);
                en.Destroy();
            }
        }

        private void CollisionActivity()
        {
            foreach (Entities.CapacitorPlatform c in capacitorPlatforms)
            {
                Vector3 positionBefore = PlayerInstance.Position;
                if (PlayerInstance.Body.CollideAgainstBounce(c.Collision, 0, 1, 0))
                {
                    if (PlayerInstance.CurrentState == Entities.GameScreen.Player.VariableState.Jumping)
                        PlayerInstance.Land();

                    Vector3 distanceTraveled = PlayerInstance.Position - positionBefore;

                    Vector3 distanceTraveledNormalized = distanceTraveled;
                    distanceTraveledNormalized.Normalize();
                    const float minimumY = .1f;

                    if (Math.Abs(distanceTraveledNormalized.Y) > minimumY)
                    {
                        // flip this 90 degrees
                        float tempVariable = distanceTraveled.X;
                        distanceTraveled.X = distanceTraveled.Y;
                        distanceTraveled.Y = -tempVariable;

                        // this makes X = 1
                        distanceTraveled /= distanceTraveled.X;
                        float xShift = positionBefore.X - PlayerInstance.X;
                        PlayerInstance.X = positionBefore.X;
                        PlayerInstance.Y += (xShift * distanceTraveled.Y);
                    }
                }

                if (PlayerInstance.CurrentState == Entities.GameScreen.Player.VariableState.Jumping && PlayerInstance.Body.LastCollisionTangent.Y > 0)
                    PlayerInstance.Land();

                foreach (Entities.GameScreen.Enemy en in enemies)
                {
                    en.Body.CollideAgainstBounce(c.Collision, 0, 1, 0);
                }
            }

            if (PlayerInstance.Body.CollideAgainst(ToQuizInstance.Body))
            {
                ToQuizInstance.InstructionTextVisible = true;

                if (PlayerInstance.mGamePad.ButtonPushed(Xbox360GamePad.Button.X))
                {
                    SpriteManager.Camera.Detach();
                    SpriteManager.Camera.X = 0;
                    SpriteManager.Camera.Y = 0;
                    SpriteManager.Camera.Z = 40;
                    SpriteManager.Camera.MinimumX = -1000;
                    SpriteManager.Camera.MinimumY = -1000;

                    this.MoveToScreen(typeof(QuizScreen).FullName);
                }
            }
            else ToQuizInstance.InstructionTextVisible = false;
        }

        void CustomDestroy()
        {
            foreach (Entities.GameScreen.Enemy en in enemies)
                en.Destroy();

            foreach (Entities.CapacitorPlatform cap in capacitorPlatforms)
                cap.Destroy();

            foreach (Entities.Battery bat in playerBatteries)
                bat.Destroy();

            enemies.Clear();
            capacitorPlatforms.Clear();

        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

    }
}
