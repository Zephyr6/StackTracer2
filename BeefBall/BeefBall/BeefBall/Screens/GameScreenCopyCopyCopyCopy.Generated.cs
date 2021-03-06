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
    public partial class GameScreenCopyCopyCopyCopy : Screen
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

        public GameScreenCopyCopyCopyCopy() : base("GameScreenCopyCopyCopyCopy")
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
                EnemyInstance.Y = -30f;
            }
            else
            {
                EnemyInstance.RelativeY = -30f;
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
                EnemyInstance2.Y = -70f;
            }
            else
            {
                EnemyInstance2.RelativeY = -70f;
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
                CapacitorPlatformInstance2.Y = -300f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeY = -300f;
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
                ResistorStampInstance.X = 0f;
            }
            else
            {
                ResistorStampInstance.RelativeX = 0f;
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
                ResistorStampInstance2.X = 300f;
            }
            else
            {
                ResistorStampInstance2.RelativeX = 300f;
            }
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.Y = -20f;
            }
            else
            {
                ResistorStampInstance2.RelativeY = -20f;
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
                CapacitorPlatformInstance3.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance3.RelativeY = -340f;
            }
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.X = 685f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeX = 685f;
            }
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeY = -340f;
            }
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.X = 900f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeX = 900f;
            }
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeY = -340f;
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
                CapacitorPlatformInstance6.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance6.RelativeY = -340f;
            }
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.X = 1273f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeX = 1273f;
            }
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.Y = -320f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeY = -320f;
            }
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.X = 1480f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeX = 1480f;
            }
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.Y = -300f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeY = -300f;
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
                ToQuizInstance.Y = -35f;
            }
            else
            {
                ToQuizInstance.RelativeY = -35f;
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
                mEnemyInstance.Y = -30f;
            }
            else
            {
                mEnemyInstance.RelativeY = -30f;
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
                mEnemyInstance2.Y = -70f;
            }
            else
            {
                mEnemyInstance2.RelativeY = -70f;
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
                CapacitorPlatformInstance2.Y = -300f;
            }
            else
            {
                CapacitorPlatformInstance2.RelativeY = -300f;
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
                ResistorStampInstance.X = 0f;
            }
            else
            {
                ResistorStampInstance.RelativeX = 0f;
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
                ResistorStampInstance2.X = 300f;
            }
            else
            {
                ResistorStampInstance2.RelativeX = 300f;
            }
            if (ResistorStampInstance2.Parent == null)
            {
                ResistorStampInstance2.Y = -20f;
            }
            else
            {
                ResistorStampInstance2.RelativeY = -20f;
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
                CapacitorPlatformInstance3.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance3.RelativeY = -340f;
            }
            CapacitorPlatformInstance4.AddToManagers(mLayer);
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.X = 685f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeX = 685f;
            }
            if (CapacitorPlatformInstance4.Parent == null)
            {
                CapacitorPlatformInstance4.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance4.RelativeY = -340f;
            }
            CapacitorPlatformInstance5.AddToManagers(mLayer);
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.X = 900f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeX = 900f;
            }
            if (CapacitorPlatformInstance5.Parent == null)
            {
                CapacitorPlatformInstance5.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance5.RelativeY = -340f;
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
                CapacitorPlatformInstance6.Y = -340f;
            }
            else
            {
                CapacitorPlatformInstance6.RelativeY = -340f;
            }
            CapacitorPlatformInstance7.AddToManagers(mLayer);
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.X = 1273f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeX = 1273f;
            }
            if (CapacitorPlatformInstance7.Parent == null)
            {
                CapacitorPlatformInstance7.Y = -320f;
            }
            else
            {
                CapacitorPlatformInstance7.RelativeY = -320f;
            }
            CapacitorPlatformInstance8.AddToManagers(mLayer);
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.X = 1480f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeX = 1480f;
            }
            if (CapacitorPlatformInstance8.Parent == null)
            {
                CapacitorPlatformInstance8.Y = -300f;
            }
            else
            {
                CapacitorPlatformInstance8.RelativeY = -300f;
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
                ToQuizInstance.Y = -35f;
            }
            else
            {
                ToQuizInstance.RelativeY = -35f;
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