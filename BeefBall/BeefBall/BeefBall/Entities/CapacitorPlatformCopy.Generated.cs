using System;
using FlatRedBall.Instructions;
// Generated Usings
using FlatRedBall.Graphics;
using FlatRedBall;
using FlatRedBall.Math.Geometry;
#if XNA4
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif
#if FRB_XNA || SILVERLIGHT
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
#endif
#if FRB_XNA && !MONODROID
#endif

namespace BeefBall.Entities
{
    public partial class CapacitorPlatformCopy : PositionedObject, IDestroyable
    {
        // This is made global so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }

        // Generated Fields
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        static object mLockObject = new object();
        static bool mHasRegisteredUnload = false;
        static bool IsStaticContentLoaded = false;
        private static Texture2D Capacitor;
        private static Scene SceneFile1;
        private static ShapeCollection CapacitorCollisionFile;
		
        private FlatRedBall.Sprite CapacitorScn;
        private FlatRedBall.Math.Geometry.Polygon mCollision;
        public FlatRedBall.Math.Geometry.Polygon Collision
        {
            get
            {
                return mCollision;
            }
        }
        public float followAmount = 0.3f;
        public int Index { get; set; }
        public bool Used { get; set; }
        protected Layer LayerProvidedByContainer = null;

        public CapacitorPlatformCopy(string contentManagerName) : this(contentManagerName, true)
        {
        }

        public CapacitorPlatformCopy(string contentManagerName, bool addToManagers) : base()
        {
            // Don't delete this:
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }

        protected virtual void InitializeEntity(bool addToManagers)
        {
            // Generated Initialize
            LoadStaticContent(ContentManagerName);
            CapacitorScn = SceneFile1.Sprites.FindByName("capacitor1").Clone();
            mCollision = CapacitorCollisionFile.Polygons.FindByName("Polygon1").Clone();
			
            PostInitialize();
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }

        // Generated AddToManagers
        public virtual void AddToManagers(Layer layerToAddTo)
        {
            LayerProvidedByContainer = layerToAddTo;
            SpriteManager.AddPositionedObject(this);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }

        public virtual void Activity()
        {
            // Generated Activity
            CustomActivity();
            // After Custom Activity
        }

        public virtual void Destroy()
        {
            // Generated Destroy
            SpriteManager.RemovePositionedObject(this);
			
            if (CapacitorScn != null)
            {
                CapacitorScn.Detach();
                SpriteManager.RemoveSprite(CapacitorScn);
            }
            if (Collision != null)
            {
                Collision.Detach();
                ShapeManager.Remove(Collision);
            }

            CustomDestroy();
        }

        // Generated Methods
        public virtual void PostInitialize()
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (CapacitorScn != null && CapacitorScn.Parent == null)
            {
                CapacitorScn.CopyAbsoluteToRelative();
                CapacitorScn.AttachTo(this, false);
            }
            if (CapacitorScn.Parent == null)
            {
                CapacitorScn.Z = -10f;
            }
            else
            {
                CapacitorScn.RelativeZ = -10f;
            }
            if (mCollision != null && mCollision.Parent == null)
            {
                mCollision.CopyAbsoluteToRelative();
                mCollision.AttachTo(this, false);
            }
            Collision.Visible = false;
            X = 0f;
            Y = 0f;
            Z = 0f;
            followAmount = 0.3f;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }

        public virtual void AddToManagersBottomUp(Layer layerToAddTo)
        {
            // We move this back to the origin and unrotate it so that anything attached to it can just use its absolute position
            float oldRotationX = RotationX;
            float oldRotationY = RotationY;
            float oldRotationZ = RotationZ;
			
            float oldX = X;
            float oldY = Y;
            float oldZ = Z;
			
            X = 0;
            Y = 0;
            Z = 0;
            RotationX = 0;
            RotationY = 0;
            RotationZ = 0;
            SpriteManager.AddToLayer(CapacitorScn, layerToAddTo);
            if (CapacitorScn.Parent == null)
            {
                CapacitorScn.Z = -10f;
            }
            else
            {
                CapacitorScn.RelativeZ = -10f;
            }
            ShapeManager.AddToLayer(mCollision, layerToAddTo);
            mCollision.Visible = false;
            X = oldX;
            Y = oldY;
            Z = oldZ;
            RotationX = oldRotationX;
            RotationY = oldRotationY;
            RotationZ = oldRotationZ;
        }

        public virtual void ConvertToManuallyUpdated()
        {
            this.ForceUpdateDependenciesDeep();
            SpriteManager.ConvertToManuallyUpdated(this);
            SpriteManager.ConvertToManuallyUpdated(CapacitorScn);
        }

        public static void LoadStaticContent(string contentManagerName)
        {
            ContentManagerName = contentManagerName;
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
            if (IsStaticContentLoaded == false)
            {
                IsStaticContentLoaded = true;
                lock (mLockObject)
                {
                    if (!mHasRegisteredUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("CapacitorPlatformCopyStaticUnload", UnloadStaticContent);
                        mHasRegisteredUnload = true;
                    }
                }
                bool registerUnload = false;
                if (!FlatRedBallServices.IsLoaded<Texture2D>(@"content/entities/capacitorplatform/capacitor.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                Capacitor = FlatRedBallServices.Load<Texture2D>(@"content/entities/capacitorplatform/capacitor.png", ContentManagerName);
                if (!FlatRedBallServices.IsLoaded<Scene>(@"content/entities/capacitorplatform/scenefile1.scnx", ContentManagerName))
                {
                    registerUnload = true;
                }
                SceneFile1 = FlatRedBallServices.Load<Scene>(@"content/entities/capacitorplatform/scenefile1.scnx", ContentManagerName);
                if (!FlatRedBallServices.IsLoaded<ShapeCollection>(@"content/entities/capacitorplatform/capacitorcollisionfile.shcx", ContentManagerName))
                {
                    registerUnload = true;
                }
                CapacitorCollisionFile = FlatRedBallServices.Load<ShapeCollection>(@"content/entities/capacitorplatform/capacitorcollisionfile.shcx", ContentManagerName);
                if (registerUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                {
                    lock (mLockObject)
                    {
                        if (!mHasRegisteredUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                        {
                            FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("CapacitorPlatformCopyStaticUnload", UnloadStaticContent);
                            mHasRegisteredUnload = true;
                        }
                    }
                }
                CustomLoadStaticContent(contentManagerName);
            }
        }

        public static void UnloadStaticContent()
        {
            IsStaticContentLoaded = false;
            mHasRegisteredUnload = false;
            if (Capacitor != null)
            {
                Capacitor = null;
            }
            if (SceneFile1 != null)
            {
                SceneFile1.RemoveFromManagers(ContentManagerName != "Global");
                SceneFile1 = null;
            }
            if (CapacitorCollisionFile != null)
            {
                CapacitorCollisionFile.RemoveFromManagers(ContentManagerName != "Global");
                CapacitorCollisionFile = null;
            }
        }

        public static object GetStaticMember(string memberName)
        {
            switch(memberName)
            {
                case "Capacitor":
                    return Capacitor;
                case "SceneFile1":
                    return SceneFile1;
                case "CapacitorCollisionFile":
                    return CapacitorCollisionFile;
            }
            return null;
        }

        object GetMember(string memberName)
        {
            switch(memberName)
            {
                case "Capacitor":
                    return Capacitor;
                case "SceneFile1":
                    return SceneFile1;
                case "CapacitorCollisionFile":
                    return CapacitorCollisionFile;
            }
            return null;
        }

        protected bool mIsPaused;
        public override void Pause(InstructionList instructions)
        {
            base.Pause(instructions);
            mIsPaused = true;
        }

        public virtual void SetToIgnorePausing()
        {
            InstructionManager.IgnorePausingFor(this);
            InstructionManager.IgnorePausingFor(CapacitorScn);
            InstructionManager.IgnorePausingFor(Collision);
        }
    }
	
    // Extra classes
    public static class CapacitorPlatformCopyExtensionMethods
    {
    }
}