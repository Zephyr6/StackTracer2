using System;
using System.Collections.Generic;
using System.Linq;
using BeefBall.Screens;
using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Input;
using FlatRedBall.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace BeefBall
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        public static SoundEffect StartGameSFX;
        public static SoundEffect BeepSFX;

        public static int RIGHT = 0;
        public static int LEFT = 1;

        public static Entities.GameScreen.Player Player;
        public static Xbox360GamePad GamePad;

        private static List<string> Levels;
        private static int currentLevel = -1;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";

            BackStack<string> bs = new BackStack<string>();
            bs.Current = string.Empty;
            #if WINDOWS_PHONE
			// Frame rate is 30 fps by default for Windows Phone.
            TargetElapsedTime = TimeSpan.FromTicks(333333);
            graphics.IsFullScreen = true;
            #endif
        }

        protected override void Initialize()
        {
            Renderer.UseRenderTargets = false;
            FlatRedBallServices.InitializeFlatRedBall(this, graphics);
            CameraSetup.SetupCamera(SpriteManager.Camera);
            GlobalContent.Initialize();

            // Are there any gamepads connected?
            if (FlatRedBall.Input.InputManager.Xbox360GamePads[0].IsConnected == false)
            {
                FlatRedBall.Input.InputManager.Xbox360GamePads[0].CreateDefaultButtonMap();
            }
            GamePad = InputManager.Xbox360GamePads[0];

            Screens.ScreenManager.Start(typeof(BeefBall.Screens.MainMenu).FullName);

            base.Initialize();

            FlatRedBallServices.GraphicsOptions.UseMultiSampling = false;
            FlatRedBallServices.GraphicsOptions.TextureFilter = TextureFilter.Point;

            StartGameSFX = Content.Load<SoundEffect>("StartSound");
            BeepSFX = Content.Load<SoundEffect>("beep");

            Levels = new List<string>();
            Levels.Add(typeof(BeefBall.Screens.GameScreen).FullName);
            Levels.Add(typeof(BeefBall.Screens.GameScreenCopy).FullName);
        }

        public static string GetNextLevel()
        {
            currentLevel++;
            if (currentLevel >= Levels.Count)
            {
                currentLevel = -1;
                return typeof(BeefBall.Screens.MainMenu).FullName;
            }
            else
                return Levels[currentLevel];
        }

        public static void ResetLevel()
        {
            currentLevel = 0;
        }

        protected override void Update(GameTime gameTime)
        {
            FlatRedBallServices.Update(gameTime);

            ScreenManager.Activity();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            FlatRedBallServices.Draw();

            base.Draw(gameTime);
        }
    }
}