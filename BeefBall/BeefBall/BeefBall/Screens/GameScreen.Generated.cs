using System;
#if XNA4
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif
#if FRB_XNA || SILVERLIGHT
#endif
// Generated Usings
using BeefBall.Entities;
using FlatRedBall;
using FlatRedBall.Math;

namespace BeefBall.Screens
{
    public partial class GameScreen : Screen
    {
        // Generated Fields
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
		
        private BeefBall.Entities.GameScreen.Player PlayerInstance;
        private BeefBall.Entities.GameScreen.Enemy mEnemyInstance;
        public BeefBall.Entities.GameScreen.Enemy EnemyInstance
        {
            get
            {
                return mEnemyInstance;
            }
        }
        private BeefBall.Entities.GameScreen.Enemy mEnemyInstance2;
        public BeefBall.Entities.GameScreen.Enemy EnemyInstance2
        {
            get
            {
                return mEnemyInstance2;
            }
        }
        private FlatRedBall.Graphics.Layer SpriteLayer;
        private FlatRedBall.Graphics.Layer PlayerLayer;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance2;
        private BeefBall.Entities.ResistorStamp ResistorStampInstance;
        private BeefBall.Entities.ResistorStamp ResistorStampInstance2;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance3;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance4;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance5;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance6;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance7;
        private BeefBall.Entities.CapacitorPlatform CapacitorPlatformInstance8;
        private PositionedObjectList<HealthBar> HealthBarList;
        private BeefBall.Entities.ToQuiz ToQuizInstance;
        private PositionedObjectList<CapacitorPlatformCopy> capList;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy1;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy2;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy3;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy4;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy5;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy6;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy7;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy8;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy9;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy10;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy11;
        private BeefBall.Entities.CapacitorPlatformCopy CapacitorPlatformCopy12;
        private PositionedObjectList<CapacitorPlatformCopyCopy> foregroundCaps;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy1;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy2;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy3;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy4;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy5;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy6;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy7;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy8;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy9;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy10;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy11;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy12;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy13;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy14;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy15;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy16;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy17;
        private BeefBall.Entities.CapacitorPlatformCopyCopy CapacitorPlatformCopyCopy18;
        private BeefBall.Entities.GameScreen.Enemy EnemyInstance3;
        private BeefBall.Entities.GameScreen.Enemy EnemyInstance4;
        private BeefBall.Entities.ResistorStamp ResistorStampInstance3;
        private BeefBall.Entities.ResistorStamp ResistorStampInstance4;
        private BeefBall.Entities.ResistorStamp ResistorStampInstance5;

        public GameScreen() : base("GameScreen")
        {
        }

        public override void Initialize(bool addToManagers)
        {
            // Generated Initialize
            LoadStaticContent(ContentManagerName);
            PlayerInstance = new BeefBall.Entities.GameScreen.Player(ContentManagerName, false);
            PlayerInstance.Name = "PlayerInstance";
            mEnemyInstance = new BeefBall.Entities.GameScreen.Enemy(ContentManagerName, false);
            mEnemyInstance.Name = "mEnemyInstance";
            mEnemyInstance2 = new BeefBall.Entities.GameScreen.Enemy(ContentManagerName, false);
            mEnemyInstance2.Name = "mEnemyInstance2";
            SpriteLayer = new FlatRedBall.Graphics.Layer();
            SpriteLayer.Name = "SpriteLayer";
            PlayerLayer = new FlatRedBall.Graphics.Layer();
            PlayerLayer.Name = "PlayerLayer";
            CapacitorPlatformInstance = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance.Name = "CapacitorPlatformInstance";
            CapacitorPlatformInstance2 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance2.Name = "CapacitorPlatformInstance2";
            ResistorStampInstance = new BeefBall.Entities.ResistorStamp(ContentManagerName, false);
            ResistorStampInstance.Name = "ResistorStampInstance";
            ResistorStampInstance2 = new BeefBall.Entities.ResistorStamp(ContentManagerName, false);
            ResistorStampInstance2.Name = "ResistorStampInstance2";
            CapacitorPlatformInstance3 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance3.Name = "CapacitorPlatformInstance3";
            CapacitorPlatformInstance4 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance4.Name = "CapacitorPlatformInstance4";
            CapacitorPlatformInstance5 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance5.Name = "CapacitorPlatformInstance5";
            CapacitorPlatformInstance6 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance6.Name = "CapacitorPlatformInstance6";
            CapacitorPlatformInstance7 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance7.Name = "CapacitorPlatformInstance7";
            CapacitorPlatformInstance8 = new BeefBall.Entities.CapacitorPlatform(ContentManagerName, false);
            CapacitorPlatformInstance8.Name = "CapacitorPlatformInstance8";
            HealthBarList = new PositionedObjectList<HealthBar>();
            ToQuizInstance = new BeefBall.Entities.ToQuiz(ContentManagerName, false);
            ToQuizInstance.Name = "ToQuizInstance";
            capList = new PositionedObjectList<CapacitorPlatformCopy>();
            CapacitorPlatformCopy1 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy1.Name = "CapacitorPlatformCopy1";
            CapacitorPlatformCopy2 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy2.Name = "CapacitorPlatformCopy2";
            CapacitorPlatformCopy3 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy3.Name = "CapacitorPlatformCopy3";
            CapacitorPlatformCopy4 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy4.Name = "CapacitorPlatformCopy4";
            CapacitorPlatformCopy5 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy5.Name = "CapacitorPlatformCopy5";
            CapacitorPlatformCopy6 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy6.Name = "CapacitorPlatformCopy6";
            CapacitorPlatformCopy7 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy7.Name = "CapacitorPlatformCopy7";
            CapacitorPlatformCopy8 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy8.Name = "CapacitorPlatformCopy8";
            CapacitorPlatformCopy9 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy9.Name = "CapacitorPlatformCopy9";
            CapacitorPlatformCopy10 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy10.Name = "CapacitorPlatformCopy10";
            CapacitorPlatformCopy11 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy11.Name = "CapacitorPlatformCopy11";
            CapacitorPlatformCopy12 = new BeefBall.Entities.CapacitorPlatformCopy(ContentManagerName, false);
            CapacitorPlatformCopy12.Name = "CapacitorPlatformCopy12";
            foregroundCaps = new PositionedObjectList<CapacitorPlatformCopyCopy>();
            CapacitorPlatformCopyCopy1 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy1.Name = "CapacitorPlatformCopyCopy1";
            CapacitorPlatformCopyCopy2 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy2.Name = "CapacitorPlatformCopyCopy2";
            CapacitorPlatformCopyCopy3 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy3.Name = "CapacitorPlatformCopyCopy3";
            CapacitorPlatformCopyCopy4 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy4.Name = "CapacitorPlatformCopyCopy4";
            CapacitorPlatformCopyCopy5 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy5.Name = "CapacitorPlatformCopyCopy5";
            CapacitorPlatformCopyCopy6 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy6.Name = "CapacitorPlatformCopyCopy6";
            CapacitorPlatformCopyCopy7 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy7.Name = "CapacitorPlatformCopyCopy7";
            CapacitorPlatformCopyCopy8 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy8.Name = "CapacitorPlatformCopyCopy8";
            CapacitorPlatformCopyCopy9 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy9.Name = "CapacitorPlatformCopyCopy9";
            CapacitorPlatformCopyCopy10 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy10.Name = "CapacitorPlatformCopyCopy10";
            CapacitorPlatformCopyCopy11 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy11.Name = "CapacitorPlatformCopyCopy11";
            CapacitorPlatformCopyCopy12 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy12.Name = "CapacitorPlatformCopyCopy12";
            CapacitorPlatformCopyCopy13 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy13.Name = "CapacitorPlatformCopyCopy13";
            CapacitorPlatformCopyCopy14 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy14.Name = "CapacitorPlatformCopyCopy14";
            CapacitorPlatformCopyCopy15 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy15.Name = "CapacitorPlatformCopyCopy15";
            CapacitorPlatformCopyCopy16 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy16.Name = "CapacitorPlatformCopyCopy16";
            CapacitorPlatformCopyCopy17 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy17.Name = "CapacitorPlatformCopyCopy17";
            CapacitorPlatformCopyCopy18 = new BeefBall.Entities.CapacitorPlatformCopyCopy(ContentManagerName, false);
            CapacitorPlatformCopyCopy18.Name = "CapacitorPlatformCopyCopy18";
            EnemyInstance3 = new BeefBall.Entities.GameScreen.Enemy(ContentManagerName, false);
            EnemyInstance3.Name = "EnemyInstance3";
            EnemyInstance4 = new BeefBall.Entities.GameScreen.Enemy(ContentManagerName, false);
            EnemyInstance4.Name = "EnemyInstance4";
            ResistorStampInstance3 = new BeefBall.Entities.ResistorStamp(ContentManagerName, false);
            ResistorStampInstance3.Name = "ResistorStampInstance3";
            ResistorStampInstance4 = new BeefBall.Entities.ResistorStamp(ContentManagerName, false);
            ResistorStampInstance4.Name = "ResistorStampInstance4";
            ResistorStampInstance5 = new BeefBall.Entities.ResistorStamp(ContentManagerName, false);
            ResistorStampInstance5.Name = "ResistorStampInstance5";
            capList.Add(CapacitorPlatformCopy1);
            capList.Add(CapacitorPlatformCopy2);
            capList.Add(CapacitorPlatformCopy3);
            capList.Add(CapacitorPlatformCopy4);
            capList.Add(CapacitorPlatformCopy5);
            capList.Add(CapacitorPlatformCopy6);
            capList.Add(CapacitorPlatformCopy7);
            capList.Add(CapacitorPlatformCopy8);
            capList.Add(CapacitorPlatformCopy9);
            capList.Add(CapacitorPlatformCopy10);
            capList.Add(CapacitorPlatformCopy11);
            capList.Add(CapacitorPlatformCopy12);
            foregroundCaps.Add(CapacitorPlatformCopyCopy1);
            foregroundCaps.Add(CapacitorPlatformCopyCopy2);
            foregroundCaps.Add(CapacitorPlatformCopyCopy3);
            foregroundCaps.Add(CapacitorPlatformCopyCopy4);
            foregroundCaps.Add(CapacitorPlatformCopyCopy5);
            foregroundCaps.Add(CapacitorPlatformCopyCopy6);
            foregroundCaps.Add(CapacitorPlatformCopyCopy7);
            foregroundCaps.Add(CapacitorPlatformCopyCopy8);
            foregroundCaps.Add(CapacitorPlatformCopyCopy9);
            foregroundCaps.Add(CapacitorPlatformCopyCopy10);
            foregroundCaps.Add(CapacitorPlatformCopyCopy11);
            foregroundCaps.Add(CapacitorPlatformCopyCopy12);
            foregroundCaps.Add(CapacitorPlatformCopyCopy13);
            foregroundCaps.Add(CapacitorPlatformCopyCopy14);
            foregroundCaps.Add(CapacitorPlatformCopyCopy15);
            foregroundCaps.Add(CapacitorPlatformCopyCopy16);
            foregroundCaps.Add(CapacitorPlatformCopyCopy17);
            foregroundCaps.Add(CapacitorPlatformCopyCopy18);
			
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        
        // Generated AddToManagers
        public override void AddToManagers()
        {
            SpriteManager.AddLayer(SpriteLayer);
            SpriteManager.AddLayer(PlayerLayer);
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }

        public override void Activity(bool firstTimeCalled)
        {
            // Generated Activity
            if (!IsPaused)
            {
                PlayerInstance.Activity();
                EnemyInstance.Activity();
                EnemyInstance2.Activity();
                CapacitorPlatformInstance.Activity();
                CapacitorPlatformInstance2.Activity();
                ResistorStampInstance.Activity();
                ResistorStampInstance2.Activity();
                CapacitorPlatformInstance3.Activity();
                CapacitorPlatformInstance4.Activity();
                CapacitorPlatformInstance5.Activity();
                CapacitorPlatformInstance6.Activity();
                CapacitorPlatformInstance7.Activity();
                CapacitorPlatformInstance8.Activity();
                for (int i = HealthBarList.Count - 1; i > -1; i--)
                {
                    if (i < HealthBarList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        HealthBarList[i].Activity();
                    }
                }
                ToQuizInstance.Activity();
                for (int i = capList.Count - 1; i > -1; i--)
                {
                    if (i < capList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        capList[i].Activity();
                    }
                }
                for (int i = foregroundCaps.Count - 1; i > -1; i--)
                {
                    if (i < foregroundCaps.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        foregroundCaps[i].Activity();
                    }
                }
                EnemyInstance3.Activity();
                EnemyInstance4.Activity();
                ResistorStampInstance3.Activity();
                ResistorStampInstance4.Activity();
                ResistorStampInstance5.Activity();
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
            // After Custom Activity
        }

        public override void Destroy()
        {
            // Generated Destroy
            if (PlayerInstance != null)
            {
                PlayerInstance.Destroy();
                PlayerInstance.Detach();
            }
            if (EnemyInstance != null)
            {
                EnemyInstance.Destroy();
                EnemyInstance.Detach();
            }
            if (EnemyInstance2 != null)
            {
                EnemyInstance2.Destroy();
                EnemyInstance2.Detach();
            }
            if (SpriteLayer != null)
            {
                SpriteManager.RemoveLayer(SpriteLayer);
            }
            if (PlayerLayer != null)
            {
                SpriteManager.RemoveLayer(PlayerLayer);
            }
            if (CapacitorPlatformInstance != null)
            {
                CapacitorPlatformInstance.Destroy();
                CapacitorPlatformInstance.Detach();
            }
            if (CapacitorPlatformInstance2 != null)
            {
                CapacitorPlatformInstance2.Destroy();
                CapacitorPlatformInstance2.Detach();
            }
            if (ResistorStampInstance != null)
            {
                ResistorStampInstance.Destroy();
                ResistorStampInstance.Detach();
            }
            if (ResistorStampInstance2 != null)
            {
                ResistorStampInstance2.Destroy();
                ResistorStampInstance2.Detach();
            }
            if (CapacitorPlatformInstance3 != null)
            {
                CapacitorPlatformInstance3.Destroy();
                CapacitorPlatformInstance3.Detach();
            }
            if (CapacitorPlatformInstance4 != null)
            {
                CapacitorPlatformInstance4.Destroy();
                CapacitorPlatformInstance4.Detach();
            }
            if (CapacitorPlatformInstance5 != null)
            {
                CapacitorPlatformInstance5.Destroy();
                CapacitorPlatformInstance5.Detach();
            }
            if (CapacitorPlatformInstance6 != null)
            {
                CapacitorPlatformInstance6.Destroy();
                CapacitorPlatformInstance6.Detach();
            }
            if (CapacitorPlatformInstance7 != null)
            {
                CapacitorPlatformInstance7.Destroy();
                CapacitorPlatformInstance7.Detach();
            }
            if (CapacitorPlatformInstance8 != null)
            {
                CapacitorPlatformInstance8.Destroy();
                CapacitorPlatformInstance8.Detach();
            }
            for (int i = HealthBarList.Count - 1; i > -1; i--)
            {
                HealthBarList[i].Destroy();
            }
            if (ToQuizInstance != null)
            {
                ToQuizInstance.Destroy();
                ToQuizInstance.Detach();
            }
            for (int i = capList.Count - 1; i > -1; i--)
            {
                capList[i].Destroy();
            }
            for (int i = foregroundCaps.Count - 1; i > -1; i--)
            {
                foregroundCaps[i].Destroy();
            }
            if (EnemyInstance3 != null)
            {
                EnemyInstance3.Destroy();
                EnemyInstance3.Detach();
            }
            if (EnemyInstance4 != null)
            {
                EnemyInstance4.Destroy();
                EnemyInstance4.Detach();
            }
            if (ResistorStampInstance3 != null)
            {
                ResistorStampInstance3.Destroy();
                ResistorStampInstance3.Detach();
            }
            if (ResistorStampInstance4 != null)
            {
                ResistorStampInstance4.Destroy();
                ResistorStampInstance4.Detach();
            }
            if (ResistorStampInstance5 != null)
            {
                ResistorStampInstance5.Destroy();
                ResistorStampInstance5.Detach();
            }

            base.Destroy();

            CustomDestroy();
        }

        // Generated Methods
        public virtual void PostInitialize()
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.X = 80f;
            }
            else
            {
                PlayerInstance.RelativeX = 80f;
            }
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.Y = 0f;
            }
            else
            {
                PlayerInstance.RelativeY = 0f;
            }
            if (EnemyInstance.Parent == null)
            {
                EnemyInstance.X = 280f;
            }
            else
            {
                EnemyInstance.RelativeX = 280f;
            }
            if (EnemyInstance.Parent == null)
            {
                EnemyInstance.Y = 0f;
            }
            else
            {
                EnemyInstance.RelativeY = 0f;
            }
            EnemyInstance.PathAreaScaleX = 35f;
            if (EnemyInstance2.Parent == null)
            {
                EnemyInstance2.X = 470f;
            }
            else
            {
                EnemyInstance2.RelativeX = 470f;
            }
            if (EnemyInstance2.Parent == null)
            {
                EnemyInstance2.Y = 30f;
            }
            else
            {
                EnemyInstance2.RelativeY = 30f;
            }
            EnemyInstance2.PathAreaScaleX = 35f;
            if (CapacitorPlatformInstance.Parent == null)
            {
                CapacitorPlatformInstance.X = 92f;
            }
            else
            {
                CapacitorPlatformInstance.RelativeX = 92f;
            }
            if (CapacitorPlatformInstance.Parent == null)
            {
                CapacitorPlatformInstance.Y = -271f;
            }
            else
            {
                CapacitorPlatformInstance.RelativeY = -271f;
            }
            if (CapacitorPlatformInstance2.Parent == null)
            {
                CapacitorPlatformInstance2.X = 280f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeX = 280f;
            }
            if (CapacitorPlatformInstance2.Parent == null)
            {
                CapacitorPlatformInstance2.Y = -270f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeY = -270f;
            }
            if (CapacitorPlatformInstance2.Parent == null)
            {
                CapacitorPlatformInstance2.Z = 0f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeZ = 0f;
            }
            if (ResistorStampInstance.Parent == null)
            {
                ResistorStampInstance.X = 80f;
            }
            else
            {
                ResistorStampInstance.RelativeX = 80f;
            }
            if (ResistorStampInstance.Parent == null)
            {
                ResistorStampInstance.Y = -30f;
            }
            else
            {
                ResistorStampInstance.RelativeY = -30f;
            }
            if (ResistorStampInstance.Parent == null)
            {
                ResistorStampInstance.Z = -1f;
            }
            else
            {
                ResistorStampInstance.RelativeZ = -1f;
            }
            ResistorStampInstance.followAmount = 0.4f;
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.X = 280f;
            }
            else
            {
                ResistorStampInstance2.RelativeX = 280f;
            }
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.Y = -10f;
            }
            else
            {
                ResistorStampInstance2.RelativeY = -10f;
            }
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.Z = -1f;
            }
            else
            {
                ResistorStampInstance2.RelativeZ = -1f;
            }
            ResistorStampInstance2.followAmount = 0.4f;
            if (CapacitorPlatformInstance3.Parent == null)
            {
                CapacitorPlatformInstance3.X = 465f;
            }
            else
            {
                CapacitorPlatformInstance3.RelativeX = 465f;
            }
            if (CapacitorPlatformInstance3.Parent == null)
            {
                CapacitorPlatformInstance3.Y = -240f;
            }
            else
            {
                CapacitorPlatformInstance3.RelativeY = -240f;
            }
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.X = 652f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeX = 652f;
            }
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.Y = -210f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeY = -210f;
            }
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.X = 870f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeX = 870f;
            }
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.Y = -210f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeY = -210f;
            }
            if (CapacitorPlatformInstance6.Parent == null)
            {
                CapacitorPlatformInstance6.X = 1088f;
            }
            else
            {
                CapacitorPlatformInstance6.RelativeX = 1088f;
            }
            if (CapacitorPlatformInstance6.Parent == null)
            {
                CapacitorPlatformInstance6.Y = -210f;
            }
            else
            {
                CapacitorPlatformInstance6.RelativeY = -210f;
            }
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.X = 1310f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeX = 1310f;
            }
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.Y = -270f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeY = -270f;
            }
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.X = 1518f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeX = 1518f;
            }
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.Y = -270f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeY = -270f;
            }
            if (ToQuizInstance.Parent == null)
            {
                ToQuizInstance.X = 1530f;
            }
            else
            {
                ToQuizInstance.RelativeX = 1530f;
            }
            if (ToQuizInstance.Parent == null)
            {
                ToQuizInstance.Y = -5f;
            }
            else
            {
                ToQuizInstance.RelativeY = -5f;
            }
            if (CapacitorPlatformCopy1.Parent == null)
            {
                CapacitorPlatformCopy1.X = 454f;
            }
            else
            {
                CapacitorPlatformCopy1.RelativeX = 454f;
            }
            if (CapacitorPlatformCopy1.Parent == null)
            {
                CapacitorPlatformCopy1.Y = 50f;
            }
            else
            {
                CapacitorPlatformCopy1.RelativeY = 50f;
            }
            if (CapacitorPlatformCopy2.Parent == null)
            {
                CapacitorPlatformCopy2.X = 348f;
            }
            else
            {
                CapacitorPlatformCopy2.RelativeX = 348f;
            }
            if (CapacitorPlatformCopy3.Parent == null)
            {
                CapacitorPlatformCopy3.X = 835f;
            }
            else
            {
                CapacitorPlatformCopy3.RelativeX = 835f;
            }
            if (CapacitorPlatformCopy4.Parent == null)
            {
                CapacitorPlatformCopy4.X = 1534f;
            }
            else
            {
                CapacitorPlatformCopy4.RelativeX = 1534f;
            }
            if (CapacitorPlatformCopy4.Parent == null)
            {
                CapacitorPlatformCopy4.Y = -130f;
            }
            else
            {
                CapacitorPlatformCopy4.RelativeY = -130f;
            }
            if (CapacitorPlatformCopy5.Parent == null)
            {
                CapacitorPlatformCopy5.X = 212f;
            }
            else
            {
                CapacitorPlatformCopy5.RelativeX = 212f;
            }
            if (CapacitorPlatformCopy5.Parent == null)
            {
                CapacitorPlatformCopy5.Y = -187f;
            }
            else
            {
                CapacitorPlatformCopy5.RelativeY = -187f;
            }
            if (CapacitorPlatformCopy6.Parent == null)
            {
                CapacitorPlatformCopy6.X = 48f;
            }
            else
            {
                CapacitorPlatformCopy6.RelativeX = 48f;
            }
            if (CapacitorPlatformCopy7.Parent == null)
            {
                CapacitorPlatformCopy7.X = 1265f;
            }
            else
            {
                CapacitorPlatformCopy7.RelativeX = 1265f;
            }
            if (CapacitorPlatformCopy8.Parent == null)
            {
                CapacitorPlatformCopy8.X = 1000f;
            }
            else
            {
                CapacitorPlatformCopy8.RelativeX = 1000f;
            }
            if (CapacitorPlatformCopy9.Parent == null)
            {
                CapacitorPlatformCopy9.X = 1152f;
            }
            else
            {
                CapacitorPlatformCopy9.RelativeX = 1152f;
            }
            if (CapacitorPlatformCopy9.Parent == null)
            {
                CapacitorPlatformCopy9.Y = -149f;
            }
            else
            {
                CapacitorPlatformCopy9.RelativeY = -149f;
            }
            if (CapacitorPlatformCopy10.Parent == null)
            {
                CapacitorPlatformCopy10.X = 612f;
            }
            else
            {
                CapacitorPlatformCopy10.RelativeX = 612f;
            }
            if (CapacitorPlatformCopy10.Parent == null)
            {
                CapacitorPlatformCopy10.Y = -72f;
            }
            else
            {
                CapacitorPlatformCopy10.RelativeY = -72f;
            }
            if (CapacitorPlatformCopy11.Parent == null)
            {
                CapacitorPlatformCopy11.X = 1375f;
            }
            else
            {
                CapacitorPlatformCopy11.RelativeX = 1375f;
            }
            if (CapacitorPlatformCopy11.Parent == null)
            {
                CapacitorPlatformCopy11.Y = -200f;
            }
            else
            {
                CapacitorPlatformCopy11.RelativeY = -200f;
            }
            if (CapacitorPlatformCopy12.Parent == null)
            {
                CapacitorPlatformCopy12.X = 700f;
            }
            else
            {
                CapacitorPlatformCopy12.RelativeX = 700f;
            }
            if (CapacitorPlatformCopy12.Parent == null)
            {
                CapacitorPlatformCopy12.Y = 120f;
            }
            else
            {
                CapacitorPlatformCopy12.RelativeY = 120f;
            }
            if (CapacitorPlatformCopyCopy1.Parent == null)
            {
                CapacitorPlatformCopyCopy1.X = 149f;
            }
            else
            {
                CapacitorPlatformCopyCopy1.RelativeX = 149f;
            }
            if (CapacitorPlatformCopyCopy1.Parent == null)
            {
                CapacitorPlatformCopyCopy1.Y = -320f;
            }
            else
            {
                CapacitorPlatformCopyCopy1.RelativeY = -320f;
            }
            if (CapacitorPlatformCopyCopy2.Parent == null)
            {
                CapacitorPlatformCopyCopy2.X = 1300f;
            }
            else
            {
                CapacitorPlatformCopyCopy2.RelativeX = 1300f;
            }
            if (CapacitorPlatformCopyCopy2.Parent == null)
            {
                CapacitorPlatformCopyCopy2.Y = -420f;
            }
            else
            {
                CapacitorPlatformCopyCopy2.RelativeY = -420f;
            }
            if (CapacitorPlatformCopyCopy3.Parent == null)
            {
                CapacitorPlatformCopyCopy3.X = 715f;
            }
            else
            {
                CapacitorPlatformCopyCopy3.RelativeX = 715f;
            }
            if (CapacitorPlatformCopyCopy3.Parent == null)
            {
                CapacitorPlatformCopyCopy3.Y = -270f;
            }
            else
            {
                CapacitorPlatformCopyCopy3.RelativeY = -270f;
            }
            if (CapacitorPlatformCopyCopy4.Parent == null)
            {
                CapacitorPlatformCopyCopy4.X = 390f;
            }
            else
            {
                CapacitorPlatformCopyCopy4.RelativeX = 390f;
            }
            if (CapacitorPlatformCopyCopy4.Parent == null)
            {
                CapacitorPlatformCopyCopy4.Y = -320f;
            }
            else
            {
                CapacitorPlatformCopyCopy4.RelativeY = -320f;
            }
            if (CapacitorPlatformCopyCopy5.Parent == null)
            {
                CapacitorPlatformCopyCopy5.X = 904f;
            }
            else
            {
                CapacitorPlatformCopyCopy5.RelativeX = 904f;
            }
            if (CapacitorPlatformCopyCopy5.Parent == null)
            {
                CapacitorPlatformCopyCopy5.Y = -260f;
            }
            else
            {
                CapacitorPlatformCopyCopy5.RelativeY = -260f;
            }
            if (CapacitorPlatformCopyCopy6.Parent == null)
            {
                CapacitorPlatformCopyCopy6.X = 1470f;
            }
            else
            {
                CapacitorPlatformCopyCopy6.RelativeX = 1470f;
            }
            if (CapacitorPlatformCopyCopy6.Parent == null)
            {
                CapacitorPlatformCopyCopy6.Y = -360f;
            }
            else
            {
                CapacitorPlatformCopyCopy6.RelativeY = -360f;
            }
            if (CapacitorPlatformCopyCopy7.Parent == null)
            {
                CapacitorPlatformCopyCopy7.X = 1124f;
            }
            else
            {
                CapacitorPlatformCopyCopy7.RelativeX = 1124f;
            }
            if (CapacitorPlatformCopyCopy7.Parent == null)
            {
                CapacitorPlatformCopyCopy7.Y = -330f;
            }
            else
            {
                CapacitorPlatformCopyCopy7.RelativeY = -330f;
            }
            if (CapacitorPlatformCopyCopy8.Parent == null)
            {
                CapacitorPlatformCopyCopy8.X = 209f;
            }
            else
            {
                CapacitorPlatformCopyCopy8.RelativeX = 209f;
            }
            if (CapacitorPlatformCopyCopy8.Parent == null)
            {
                CapacitorPlatformCopyCopy8.Y = -360f;
            }
            else
            {
                CapacitorPlatformCopyCopy8.RelativeY = -360f;
            }
            if (CapacitorPlatformCopyCopy9.Parent == null)
            {
                CapacitorPlatformCopyCopy9.X = 1720f;
            }
            else
            {
                CapacitorPlatformCopyCopy9.RelativeX = 1720f;
            }
            if (CapacitorPlatformCopyCopy9.Parent == null)
            {
                CapacitorPlatformCopyCopy9.Y = -350f;
            }
            else
            {
                CapacitorPlatformCopyCopy9.RelativeY = -350f;
            }
            if (CapacitorPlatformCopyCopy10.Parent == null)
            {
                CapacitorPlatformCopyCopy10.X = 550f;
            }
            else
            {
                CapacitorPlatformCopyCopy10.RelativeX = 550f;
            }
            if (CapacitorPlatformCopyCopy10.Parent == null)
            {
                CapacitorPlatformCopyCopy10.Y = -300f;
            }
            else
            {
                CapacitorPlatformCopyCopy10.RelativeY = -300f;
            }
            if (CapacitorPlatformCopyCopy11.Parent == null)
            {
                CapacitorPlatformCopyCopy11.X = 0f;
            }
            else
            {
                CapacitorPlatformCopyCopy11.RelativeX = 0f;
            }
            if (CapacitorPlatformCopyCopy11.Parent == null)
            {
                CapacitorPlatformCopyCopy11.Y = -360f;
            }
            else
            {
                CapacitorPlatformCopyCopy11.RelativeY = -360f;
            }
            if (CapacitorPlatformCopyCopy12.Parent == null)
            {
                CapacitorPlatformCopyCopy12.X = 1890f;
            }
            else
            {
                CapacitorPlatformCopyCopy12.RelativeX = 1890f;
            }
            if (CapacitorPlatformCopyCopy12.Parent == null)
            {
                CapacitorPlatformCopyCopy12.Y = -310f;
            }
            else
            {
                CapacitorPlatformCopyCopy12.RelativeY = -310f;
            }
            if (CapacitorPlatformCopyCopy13.Parent == null)
            {
                CapacitorPlatformCopyCopy13.X = 1600f;
            }
            else
            {
                CapacitorPlatformCopyCopy13.RelativeX = 1600f;
            }
            if (CapacitorPlatformCopyCopy13.Parent == null)
            {
                CapacitorPlatformCopyCopy13.Y = -300f;
            }
            else
            {
                CapacitorPlatformCopyCopy13.RelativeY = -300f;
            }
            if (CapacitorPlatformCopyCopy14.Parent == null)
            {
                CapacitorPlatformCopyCopy14.X = 1000f;
            }
            else
            {
                CapacitorPlatformCopyCopy14.RelativeX = 1000f;
            }
            if (CapacitorPlatformCopyCopy14.Parent == null)
            {
                CapacitorPlatformCopyCopy14.Y = -300f;
            }
            else
            {
                CapacitorPlatformCopyCopy14.RelativeY = -300f;
            }
            if (CapacitorPlatformCopyCopy15.Parent == null)
            {
                CapacitorPlatformCopyCopy15.X = 2340f;
            }
            else
            {
                CapacitorPlatformCopyCopy15.RelativeX = 2340f;
            }
            if (CapacitorPlatformCopyCopy15.Parent == null)
            {
                CapacitorPlatformCopyCopy15.Y = -310f;
            }
            else
            {
                CapacitorPlatformCopyCopy15.RelativeY = -310f;
            }
            if (CapacitorPlatformCopyCopy16.Parent == null)
            {
                CapacitorPlatformCopyCopy16.X = 2500f;
            }
            else
            {
                CapacitorPlatformCopyCopy16.RelativeX = 2500f;
            }
            if (CapacitorPlatformCopyCopy16.Parent == null)
            {
                CapacitorPlatformCopyCopy16.Y = -330f;
            }
            else
            {
                CapacitorPlatformCopyCopy16.RelativeY = -330f;
            }
            if (CapacitorPlatformCopyCopy17.Parent == null)
            {
                CapacitorPlatformCopyCopy17.X = 2200f;
            }
            else
            {
                CapacitorPlatformCopyCopy17.RelativeX = 2200f;
            }
            if (CapacitorPlatformCopyCopy17.Parent == null)
            {
                CapacitorPlatformCopyCopy17.Y = -340f;
            }
            else
            {
                CapacitorPlatformCopyCopy17.RelativeY = -340f;
            }
            if (CapacitorPlatformCopyCopy18.Parent == null)
            {
                CapacitorPlatformCopyCopy18.X = 2060f;
            }
            else
            {
                CapacitorPlatformCopyCopy18.RelativeX = 2060f;
            }
            if (CapacitorPlatformCopyCopy18.Parent == null)
            {
                CapacitorPlatformCopyCopy18.Y = -369f;
            }
            else
            {
                CapacitorPlatformCopyCopy18.RelativeY = -369f;
            }
            if (EnemyInstance3.Parent == null)
            {
                EnemyInstance3.X = 1090f;
            }
            else
            {
                EnemyInstance3.RelativeX = 1090f;
            }
            if (EnemyInstance3.Parent == null)
            {
                EnemyInstance3.Y = 50f;
            }
            else
            {
                EnemyInstance3.RelativeY = 50f;
            }
            if (EnemyInstance4.Parent == null)
            {
                EnemyInstance4.X = 1310f;
            }
            else
            {
                EnemyInstance4.RelativeX = 1310f;
            }
            if (EnemyInstance4.Parent == null)
            {
                EnemyInstance4.Y = 0f;
            }
            else
            {
                EnemyInstance4.RelativeY = 0f;
            }
            if (ResistorStampInstance3.Parent == null)
            {
                ResistorStampInstance3.X = 1000f;
            }
            else
            {
                ResistorStampInstance3.RelativeX = 1000f;
            }
            if (ResistorStampInstance3.Parent == null)
            {
                ResistorStampInstance3.Y = 0f;
            }
            else
            {
                ResistorStampInstance3.RelativeY = 0f;
            }
            if (ResistorStampInstance4.Parent == null)
            {
                ResistorStampInstance4.X = 600f;
            }
            else
            {
                ResistorStampInstance4.RelativeX = 600f;
            }
            if (ResistorStampInstance4.Parent == null)
            {
                ResistorStampInstance4.Y = 25f;
            }
            else
            {
                ResistorStampInstance4.RelativeY = 25f;
            }
            if (ResistorStampInstance5.Parent == null)
            {
                ResistorStampInstance5.X = 1300f;
            }
            else
            {
                ResistorStampInstance5.RelativeX = 1300f;
            }
            if (ResistorStampInstance5.Parent == null)
            {
                ResistorStampInstance5.Y = -100f;
            }
            else
            {
                ResistorStampInstance5.RelativeY = -100f;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }

        public virtual void AddToManagersBottomUp()
        {
            PlayerInstance.AddToManagers(PlayerLayer);
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.X = 80f;
            }
            else
            {
                PlayerInstance.RelativeX = 80f;
            }
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.Y = 0f;
            }
            else
            {
                PlayerInstance.RelativeY = 0f;
            }
            mEnemyInstance.AddToManagers(SpriteLayer);
            if (mEnemyInstance.Parent == null)
            {
                mEnemyInstance.X = 280f;
            }
            else
            {
                mEnemyInstance.RelativeX = 280f;
            }
            if (mEnemyInstance.Parent == null)
            {
                mEnemyInstance.Y = 0f;
            }
            else
            {
                mEnemyInstance.RelativeY = 0f;
            }
            mEnemyInstance.PathAreaScaleX = 35f;
            mEnemyInstance2.AddToManagers(SpriteLayer);
            if (mEnemyInstance2.Parent == null)
            {
                mEnemyInstance2.X = 470f;
            }
            else
            {
                mEnemyInstance2.RelativeX = 470f;
            }
            if (mEnemyInstance2.Parent == null)
            {
                mEnemyInstance2.Y = 30f;
            }
            else
            {
                mEnemyInstance2.RelativeY = 30f;
            }
            mEnemyInstance2.PathAreaScaleX = 35f;
            CapacitorPlatformInstance.AddToManagers(mLayer);
            if (CapacitorPlatformInstance.Parent == null)
            {
                CapacitorPlatformInstance.X = 92f;
            }
            else
            {
                CapacitorPlatformInstance.RelativeX = 92f;
            }
            if (CapacitorPlatformInstance.Parent == null)
            {
                CapacitorPlatformInstance.Y = -271f;
            }
            else
            {
                CapacitorPlatformInstance.RelativeY = -271f;
            }
            CapacitorPlatformInstance2.AddToManagers(mLayer);
            if (CapacitorPlatformInstance2.Parent == null)
            {
                CapacitorPlatformInstance2.X = 280f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeX = 280f;
            }
            if (CapacitorPlatformInstance2.Parent == null)
            {
                CapacitorPlatformInstance2.Y = -270f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeY = -270f;
            }
            if (CapacitorPlatformInstance2.Parent == null)
            {
                CapacitorPlatformInstance2.Z = 0f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeZ = 0f;
            }
            ResistorStampInstance.AddToManagers(mLayer);
            if (ResistorStampInstance.Parent == null)
            {
                ResistorStampInstance.X = 80f;
            }
            else
            {
                ResistorStampInstance.RelativeX = 80f;
            }
            if (ResistorStampInstance.Parent == null)
            {
                ResistorStampInstance.Y = -30f;
            }
            else
            {
                ResistorStampInstance.RelativeY = -30f;
            }
            if (ResistorStampInstance.Parent == null)
            {
                ResistorStampInstance.Z = -1f;
            }
            else
            {
                ResistorStampInstance.RelativeZ = -1f;
            }
            ResistorStampInstance.followAmount = 0.4f;
            ResistorStampInstance2.AddToManagers(mLayer);
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.X = 280f;
            }
            else
            {
                ResistorStampInstance2.RelativeX = 280f;
            }
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.Y = -10f;
            }
            else
            {
                ResistorStampInstance2.RelativeY = -10f;
            }
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.Z = -1f;
            }
            else
            {
                ResistorStampInstance2.RelativeZ = -1f;
            }
            ResistorStampInstance2.followAmount = 0.4f;
            CapacitorPlatformInstance3.AddToManagers(mLayer);
            if (CapacitorPlatformInstance3.Parent == null)
            {
                CapacitorPlatformInstance3.X = 465f;
            }
            else
            {
                CapacitorPlatformInstance3.RelativeX = 465f;
            }
            if (CapacitorPlatformInstance3.Parent == null)
            {
                CapacitorPlatformInstance3.Y = -240f;
            }
            else
            {
                CapacitorPlatformInstance3.RelativeY = -240f;
            }
            CapacitorPlatformInstance4.AddToManagers(mLayer);
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.X = 652f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeX = 652f;
            }
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.Y = -210f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeY = -210f;
            }
            CapacitorPlatformInstance5.AddToManagers(mLayer);
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.X = 870f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeX = 870f;
            }
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.Y = -210f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeY = -210f;
            }
            CapacitorPlatformInstance6.AddToManagers(mLayer);
            if (CapacitorPlatformInstance6.Parent == null)
            {
                CapacitorPlatformInstance6.X = 1088f;
            }
            else
            {
                CapacitorPlatformInstance6.RelativeX = 1088f;
            }
            if (CapacitorPlatformInstance6.Parent == null)
            {
                CapacitorPlatformInstance6.Y = -210f;
            }
            else
            {
                CapacitorPlatformInstance6.RelativeY = -210f;
            }
            CapacitorPlatformInstance7.AddToManagers(mLayer);
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.X = 1310f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeX = 1310f;
            }
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.Y = -270f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeY = -270f;
            }
            CapacitorPlatformInstance8.AddToManagers(mLayer);
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.X = 1518f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeX = 1518f;
            }
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.Y = -270f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeY = -270f;
            }
            ToQuizInstance.AddToManagers(mLayer);
            if (ToQuizInstance.Parent == null)
            {
                ToQuizInstance.X = 1530f;
            }
            else
            {
                ToQuizInstance.RelativeX = 1530f;
            }
            if (ToQuizInstance.Parent == null)
            {
                ToQuizInstance.Y = -5f;
            }
            else
            {
                ToQuizInstance.RelativeY = -5f;
            }
            CapacitorPlatformCopy1.AddToManagers(mLayer);
            if (CapacitorPlatformCopy1.Parent == null)
            {
                CapacitorPlatformCopy1.X = 454f;
            }
            else
            {
                CapacitorPlatformCopy1.RelativeX = 454f;
            }
            if (CapacitorPlatformCopy1.Parent == null)
            {
                CapacitorPlatformCopy1.Y = 50f;
            }
            else
            {
                CapacitorPlatformCopy1.RelativeY = 50f;
            }
            CapacitorPlatformCopy2.AddToManagers(mLayer);
            if (CapacitorPlatformCopy2.Parent == null)
            {
                CapacitorPlatformCopy2.X = 348f;
            }
            else
            {
                CapacitorPlatformCopy2.RelativeX = 348f;
            }
            CapacitorPlatformCopy3.AddToManagers(mLayer);
            if (CapacitorPlatformCopy3.Parent == null)
            {
                CapacitorPlatformCopy3.X = 835f;
            }
            else
            {
                CapacitorPlatformCopy3.RelativeX = 835f;
            }
            CapacitorPlatformCopy4.AddToManagers(mLayer);
            if (CapacitorPlatformCopy4.Parent == null)
            {
                CapacitorPlatformCopy4.X = 1534f;
            }
            else
            {
                CapacitorPlatformCopy4.RelativeX = 1534f;
            }
            if (CapacitorPlatformCopy4.Parent == null)
            {
                CapacitorPlatformCopy4.Y = -130f;
            }
            else
            {
                CapacitorPlatformCopy4.RelativeY = -130f;
            }
            CapacitorPlatformCopy5.AddToManagers(mLayer);
            if (CapacitorPlatformCopy5.Parent == null)
            {
                CapacitorPlatformCopy5.X = 212f;
            }
            else
            {
                CapacitorPlatformCopy5.RelativeX = 212f;
            }
            if (CapacitorPlatformCopy5.Parent == null)
            {
                CapacitorPlatformCopy5.Y = -187f;
            }
            else
            {
                CapacitorPlatformCopy5.RelativeY = -187f;
            }
            CapacitorPlatformCopy6.AddToManagers(mLayer);
            if (CapacitorPlatformCopy6.Parent == null)
            {
                CapacitorPlatformCopy6.X = 48f;
            }
            else
            {
                CapacitorPlatformCopy6.RelativeX = 48f;
            }
            CapacitorPlatformCopy7.AddToManagers(mLayer);
            if (CapacitorPlatformCopy7.Parent == null)
            {
                CapacitorPlatformCopy7.X = 1265f;
            }
            else
            {
                CapacitorPlatformCopy7.RelativeX = 1265f;
            }
            CapacitorPlatformCopy8.AddToManagers(mLayer);
            if (CapacitorPlatformCopy8.Parent == null)
            {
                CapacitorPlatformCopy8.X = 1000f;
            }
            else
            {
                CapacitorPlatformCopy8.RelativeX = 1000f;
            }
            CapacitorPlatformCopy9.AddToManagers(mLayer);
            if (CapacitorPlatformCopy9.Parent == null)
            {
                CapacitorPlatformCopy9.X = 1152f;
            }
            else
            {
                CapacitorPlatformCopy9.RelativeX = 1152f;
            }
            if (CapacitorPlatformCopy9.Parent == null)
            {
                CapacitorPlatformCopy9.Y = -149f;
            }
            else
            {
                CapacitorPlatformCopy9.RelativeY = -149f;
            }
            CapacitorPlatformCopy10.AddToManagers(mLayer);
            if (CapacitorPlatformCopy10.Parent == null)
            {
                CapacitorPlatformCopy10.X = 612f;
            }
            else
            {
                CapacitorPlatformCopy10.RelativeX = 612f;
            }
            if (CapacitorPlatformCopy10.Parent == null)
            {
                CapacitorPlatformCopy10.Y = -72f;
            }
            else
            {
                CapacitorPlatformCopy10.RelativeY = -72f;
            }
            CapacitorPlatformCopy11.AddToManagers(mLayer);
            if (CapacitorPlatformCopy11.Parent == null)
            {
                CapacitorPlatformCopy11.X = 1375f;
            }
            else
            {
                CapacitorPlatformCopy11.RelativeX = 1375f;
            }
            if (CapacitorPlatformCopy11.Parent == null)
            {
                CapacitorPlatformCopy11.Y = -200f;
            }
            else
            {
                CapacitorPlatformCopy11.RelativeY = -200f;
            }
            CapacitorPlatformCopy12.AddToManagers(mLayer);
            if (CapacitorPlatformCopy12.Parent == null)
            {
                CapacitorPlatformCopy12.X = 700f;
            }
            else
            {
                CapacitorPlatformCopy12.RelativeX = 700f;
            }
            if (CapacitorPlatformCopy12.Parent == null)
            {
                CapacitorPlatformCopy12.Y = 120f;
            }
            else
            {
                CapacitorPlatformCopy12.RelativeY = 120f;
            }
            CapacitorPlatformCopyCopy1.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy1.Parent == null)
            {
                CapacitorPlatformCopyCopy1.X = 149f;
            }
            else
            {
                CapacitorPlatformCopyCopy1.RelativeX = 149f;
            }
            if (CapacitorPlatformCopyCopy1.Parent == null)
            {
                CapacitorPlatformCopyCopy1.Y = -320f;
            }
            else
            {
                CapacitorPlatformCopyCopy1.RelativeY = -320f;
            }
            CapacitorPlatformCopyCopy2.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy2.Parent == null)
            {
                CapacitorPlatformCopyCopy2.X = 1300f;
            }
            else
            {
                CapacitorPlatformCopyCopy2.RelativeX = 1300f;
            }
            if (CapacitorPlatformCopyCopy2.Parent == null)
            {
                CapacitorPlatformCopyCopy2.Y = -420f;
            }
            else
            {
                CapacitorPlatformCopyCopy2.RelativeY = -420f;
            }
            CapacitorPlatformCopyCopy3.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy3.Parent == null)
            {
                CapacitorPlatformCopyCopy3.X = 715f;
            }
            else
            {
                CapacitorPlatformCopyCopy3.RelativeX = 715f;
            }
            if (CapacitorPlatformCopyCopy3.Parent == null)
            {
                CapacitorPlatformCopyCopy3.Y = -270f;
            }
            else
            {
                CapacitorPlatformCopyCopy3.RelativeY = -270f;
            }
            CapacitorPlatformCopyCopy4.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy4.Parent == null)
            {
                CapacitorPlatformCopyCopy4.X = 390f;
            }
            else
            {
                CapacitorPlatformCopyCopy4.RelativeX = 390f;
            }
            if (CapacitorPlatformCopyCopy4.Parent == null)
            {
                CapacitorPlatformCopyCopy4.Y = -320f;
            }
            else
            {
                CapacitorPlatformCopyCopy4.RelativeY = -320f;
            }
            CapacitorPlatformCopyCopy5.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy5.Parent == null)
            {
                CapacitorPlatformCopyCopy5.X = 904f;
            }
            else
            {
                CapacitorPlatformCopyCopy5.RelativeX = 904f;
            }
            if (CapacitorPlatformCopyCopy5.Parent == null)
            {
                CapacitorPlatformCopyCopy5.Y = -260f;
            }
            else
            {
                CapacitorPlatformCopyCopy5.RelativeY = -260f;
            }
            CapacitorPlatformCopyCopy6.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy6.Parent == null)
            {
                CapacitorPlatformCopyCopy6.X = 1470f;
            }
            else
            {
                CapacitorPlatformCopyCopy6.RelativeX = 1470f;
            }
            if (CapacitorPlatformCopyCopy6.Parent == null)
            {
                CapacitorPlatformCopyCopy6.Y = -360f;
            }
            else
            {
                CapacitorPlatformCopyCopy6.RelativeY = -360f;
            }
            CapacitorPlatformCopyCopy7.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy7.Parent == null)
            {
                CapacitorPlatformCopyCopy7.X = 1124f;
            }
            else
            {
                CapacitorPlatformCopyCopy7.RelativeX = 1124f;
            }
            if (CapacitorPlatformCopyCopy7.Parent == null)
            {
                CapacitorPlatformCopyCopy7.Y = -330f;
            }
            else
            {
                CapacitorPlatformCopyCopy7.RelativeY = -330f;
            }
            CapacitorPlatformCopyCopy8.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy8.Parent == null)
            {
                CapacitorPlatformCopyCopy8.X = 209f;
            }
            else
            {
                CapacitorPlatformCopyCopy8.RelativeX = 209f;
            }
            if (CapacitorPlatformCopyCopy8.Parent == null)
            {
                CapacitorPlatformCopyCopy8.Y = -360f;
            }
            else
            {
                CapacitorPlatformCopyCopy8.RelativeY = -360f;
            }
            CapacitorPlatformCopyCopy9.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy9.Parent == null)
            {
                CapacitorPlatformCopyCopy9.X = 1720f;
            }
            else
            {
                CapacitorPlatformCopyCopy9.RelativeX = 1720f;
            }
            if (CapacitorPlatformCopyCopy9.Parent == null)
            {
                CapacitorPlatformCopyCopy9.Y = -350f;
            }
            else
            {
                CapacitorPlatformCopyCopy9.RelativeY = -350f;
            }
            CapacitorPlatformCopyCopy10.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy10.Parent == null)
            {
                CapacitorPlatformCopyCopy10.X = 550f;
            }
            else
            {
                CapacitorPlatformCopyCopy10.RelativeX = 550f;
            }
            if (CapacitorPlatformCopyCopy10.Parent == null)
            {
                CapacitorPlatformCopyCopy10.Y = -300f;
            }
            else
            {
                CapacitorPlatformCopyCopy10.RelativeY = -300f;
            }
            CapacitorPlatformCopyCopy11.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy11.Parent == null)
            {
                CapacitorPlatformCopyCopy11.X = 0f;
            }
            else
            {
                CapacitorPlatformCopyCopy11.RelativeX = 0f;
            }
            if (CapacitorPlatformCopyCopy11.Parent == null)
            {
                CapacitorPlatformCopyCopy11.Y = -360f;
            }
            else
            {
                CapacitorPlatformCopyCopy11.RelativeY = -360f;
            }
            CapacitorPlatformCopyCopy12.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy12.Parent == null)
            {
                CapacitorPlatformCopyCopy12.X = 1890f;
            }
            else
            {
                CapacitorPlatformCopyCopy12.RelativeX = 1890f;
            }
            if (CapacitorPlatformCopyCopy12.Parent == null)
            {
                CapacitorPlatformCopyCopy12.Y = -310f;
            }
            else
            {
                CapacitorPlatformCopyCopy12.RelativeY = -310f;
            }
            CapacitorPlatformCopyCopy13.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy13.Parent == null)
            {
                CapacitorPlatformCopyCopy13.X = 1600f;
            }
            else
            {
                CapacitorPlatformCopyCopy13.RelativeX = 1600f;
            }
            if (CapacitorPlatformCopyCopy13.Parent == null)
            {
                CapacitorPlatformCopyCopy13.Y = -300f;
            }
            else
            {
                CapacitorPlatformCopyCopy13.RelativeY = -300f;
            }
            CapacitorPlatformCopyCopy14.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy14.Parent == null)
            {
                CapacitorPlatformCopyCopy14.X = 1000f;
            }
            else
            {
                CapacitorPlatformCopyCopy14.RelativeX = 1000f;
            }
            if (CapacitorPlatformCopyCopy14.Parent == null)
            {
                CapacitorPlatformCopyCopy14.Y = -300f;
            }
            else
            {
                CapacitorPlatformCopyCopy14.RelativeY = -300f;
            }
            CapacitorPlatformCopyCopy15.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy15.Parent == null)
            {
                CapacitorPlatformCopyCopy15.X = 2340f;
            }
            else
            {
                CapacitorPlatformCopyCopy15.RelativeX = 2340f;
            }
            if (CapacitorPlatformCopyCopy15.Parent == null)
            {
                CapacitorPlatformCopyCopy15.Y = -310f;
            }
            else
            {
                CapacitorPlatformCopyCopy15.RelativeY = -310f;
            }
            CapacitorPlatformCopyCopy16.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy16.Parent == null)
            {
                CapacitorPlatformCopyCopy16.X = 2500f;
            }
            else
            {
                CapacitorPlatformCopyCopy16.RelativeX = 2500f;
            }
            if (CapacitorPlatformCopyCopy16.Parent == null)
            {
                CapacitorPlatformCopyCopy16.Y = -330f;
            }
            else
            {
                CapacitorPlatformCopyCopy16.RelativeY = -330f;
            }
            CapacitorPlatformCopyCopy17.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy17.Parent == null)
            {
                CapacitorPlatformCopyCopy17.X = 2200f;
            }
            else
            {
                CapacitorPlatformCopyCopy17.RelativeX = 2200f;
            }
            if (CapacitorPlatformCopyCopy17.Parent == null)
            {
                CapacitorPlatformCopyCopy17.Y = -340f;
            }
            else
            {
                CapacitorPlatformCopyCopy17.RelativeY = -340f;
            }
            CapacitorPlatformCopyCopy18.AddToManagers(mLayer);
            if (CapacitorPlatformCopyCopy18.Parent == null)
            {
                CapacitorPlatformCopyCopy18.X = 2060f;
            }
            else
            {
                CapacitorPlatformCopyCopy18.RelativeX = 2060f;
            }
            if (CapacitorPlatformCopyCopy18.Parent == null)
            {
                CapacitorPlatformCopyCopy18.Y = -369f;
            }
            else
            {
                CapacitorPlatformCopyCopy18.RelativeY = -369f;
            }
            EnemyInstance3.AddToManagers(SpriteLayer);
            if (EnemyInstance3.Parent == null)
            {
                EnemyInstance3.X = 1090f;
            }
            else
            {
                EnemyInstance3.RelativeX = 1090f;
            }
            if (EnemyInstance3.Parent == null)
            {
                EnemyInstance3.Y = 50f;
            }
            else
            {
                EnemyInstance3.RelativeY = 50f;
            }
            EnemyInstance4.AddToManagers(SpriteLayer);
            if (EnemyInstance4.Parent == null)
            {
                EnemyInstance4.X = 1310f;
            }
            else
            {
                EnemyInstance4.RelativeX = 1310f;
            }
            if (EnemyInstance4.Parent == null)
            {
                EnemyInstance4.Y = 0f;
            }
            else
            {
                EnemyInstance4.RelativeY = 0f;
            }
            ResistorStampInstance3.AddToManagers(mLayer);
            if (ResistorStampInstance3.Parent == null)
            {
                ResistorStampInstance3.X = 1000f;
            }
            else
            {
                ResistorStampInstance3.RelativeX = 1000f;
            }
            if (ResistorStampInstance3.Parent == null)
            {
                ResistorStampInstance3.Y = 0f;
            }
            else
            {
                ResistorStampInstance3.RelativeY = 0f;
            }
            ResistorStampInstance4.AddToManagers(mLayer);
            if (ResistorStampInstance4.Parent == null)
            {
                ResistorStampInstance4.X = 600f;
            }
            else
            {
                ResistorStampInstance4.RelativeX = 600f;
            }
            if (ResistorStampInstance4.Parent == null)
            {
                ResistorStampInstance4.Y = 25f;
            }
            else
            {
                ResistorStampInstance4.RelativeY = 25f;
            }
            ResistorStampInstance5.AddToManagers(mLayer);
            if (ResistorStampInstance5.Parent == null)
            {
                ResistorStampInstance5.X = 1300f;
            }
            else
            {
                ResistorStampInstance5.RelativeX = 1300f;
            }
            if (ResistorStampInstance5.Parent == null)
            {
                ResistorStampInstance5.Y = -100f;
            }
            else
            {
                ResistorStampInstance5.RelativeY = -100f;
            }
        }

        public virtual void ConvertToManuallyUpdated()
        {
            PlayerInstance.ConvertToManuallyUpdated();
            EnemyInstance.ConvertToManuallyUpdated();
            EnemyInstance2.ConvertToManuallyUpdated();
            CapacitorPlatformInstance.ConvertToManuallyUpdated();
            CapacitorPlatformInstance2.ConvertToManuallyUpdated();
            ResistorStampInstance.ConvertToManuallyUpdated();
            ResistorStampInstance2.ConvertToManuallyUpdated();
            CapacitorPlatformInstance3.ConvertToManuallyUpdated();
            CapacitorPlatformInstance4.ConvertToManuallyUpdated();
            CapacitorPlatformInstance5.ConvertToManuallyUpdated();
            CapacitorPlatformInstance6.ConvertToManuallyUpdated();
            CapacitorPlatformInstance7.ConvertToManuallyUpdated();
            CapacitorPlatformInstance8.ConvertToManuallyUpdated();
            for (int i = 0; i < HealthBarList.Count; i++)
            {
                HealthBarList[i].ConvertToManuallyUpdated();
            }
            ToQuizInstance.ConvertToManuallyUpdated();
            for (int i = 0; i < capList.Count; i++)
            {
                capList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < foregroundCaps.Count; i++)
            {
                foregroundCaps[i].ConvertToManuallyUpdated();
            }
            EnemyInstance3.ConvertToManuallyUpdated();
            EnemyInstance4.ConvertToManuallyUpdated();
            ResistorStampInstance3.ConvertToManuallyUpdated();
            ResistorStampInstance4.ConvertToManuallyUpdated();
            ResistorStampInstance5.ConvertToManuallyUpdated();
        }

        public static void LoadStaticContent(string contentManagerName)
        {
            #if DEBUG
            if (contentManagerName == FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            BeefBall.Entities.GameScreen.Player.LoadStaticContent(contentManagerName);
            BeefBall.Entities.GameScreen.Enemy.LoadStaticContent(contentManagerName);
            BeefBall.Entities.CapacitorPlatform.LoadStaticContent(contentManagerName);
            BeefBall.Entities.ResistorStamp.LoadStaticContent(contentManagerName);
            BeefBall.Entities.ToQuiz.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }

        object GetMember(string memberName)
        {
            return null;
        }
    }
}