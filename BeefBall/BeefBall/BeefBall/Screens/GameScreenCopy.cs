using System;
using System.Collections.Generic;
using FlatRedBall;
using FlatRedBall.Input;
using Microsoft.Xna.Framework.Media;
#if FRB_XNA || SILVERLIGHT
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Microsoft.Xna.Framework.Audio;

#endif

namespace BeefBall.Screens
{
    public partial class GameScreenCopy
    {
        public static SoundEffect BGMusic;
        List<Entities.GameScreen.Enemy> enemies;
        List<Entities.CapacitorPlatform> capacitorPlatforms;
        List<Entities.Battery> playerBatteries;
        static string songManager = "ContentManager";
        static Song song = FlatRedBallServices.Load<Song>(@"Content/15th Night - Night Tower", songManager);

        void CustomInitialize()
        {
            SpriteManager.Camera.MinimumX = 100;
            SpriteManager.Camera.MinimumY = -93;
            Microsoft.Xna.Framework.Media.MediaPlayer.Play(song);

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
                AddBattery(4 * (i + 1));
            }
        }

        void AddBattery(int max)
        {
            Console.WriteLine("MAX: " + max);
            Entities.Battery bat = new Entities.Battery(ContentManagerName, true);
            bat.posX = -175.1F + (playerBatteries.Count * 40);
            bat.posY = 135.1F;
            bat.max = max;
            playerBatteries.Add(bat);
        }

        void CustomActivity(bool firstTimeCalled)
        {
            CollisionActivity();
            CleanUpActivity();

            if (Game1.GamePad.ButtonPushed(Xbox360GamePad.Button.Y))
                PlayerInstance.Health--;

            foreach (Entities.Battery bat in playerBatteries)
                bat.Activity();

            if (Game1.Player.Health <= 0)
            {
                SpriteManager.Camera.Detach();
                SpriteManager.Camera.X = 0;
                SpriteManager.Camera.Y = 0;
                SpriteManager.Camera.Z = 40;
                SpriteManager.Camera.MinimumX = -1000;
                SpriteManager.Camera.MinimumY = -1000;
                this.MoveToScreen(typeof(GameOver).FullName);
            }
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
            else
                ToQuizInstance.InstructionTextVisible = false;
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
            Microsoft.Xna.Framework.Media.MediaPlayer.Stop();
        }

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }
    }
}