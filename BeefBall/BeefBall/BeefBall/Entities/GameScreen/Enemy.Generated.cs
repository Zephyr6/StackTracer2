using System;
using FlatRedBall.Instructions;
// Generated Usings
using FlatRedBall.Graphics;
using FlatRedBall;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Graphics.Animation;
#if XNA4
using Color = Microsoft.Xna.Framework.Color;

#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif

#if FRB_XNA || SILVERLIGHT
#endif

#if FRB_XNA && !MONODROID
#endif

namespace BeefBall.Entities.GameScreen
{
    public partial class Enemy : PositionedObject, IDestroyable
    {
        // This is made global so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }

        // Generated Fields
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;

        #endif
        public enum VariableState
        {
            Uninitialized, //This exists so that the first set call actually does something
            R_Idle, 
            L_Idle, 
            R_Hurt, 
            L_Hurt, 
            R_Die, 
            L_Die, 
            R_Attack, 
            L_Attack, 
            R_Walking, 
            L_Walking
        }
        VariableState mCurrentState = VariableState.Uninitialized;
        public VariableState CurrentState
        {
            get
            {
                return mCurrentState;
            }
            set
            {
                mCurrentState = value;
                switch(mCurrentState)
                {
                    case VariableState.R_Idle:
                        EntireSceneCurrentChainName = "R_Hustle";
                        break;
                    case VariableState.L_Idle:
                        EntireSceneCurrentChainName = "L_Hustle";
                        break;
                    case VariableState.R_Hurt:
                        EntireSceneCurrentChainName = "R_Hurt";
                        break;
                    case VariableState.L_Hurt:
                        EntireSceneCurrentChainName = "L_Hurt";
                        break;
                    case VariableState.R_Die:
                        EntireSceneCurrentChainName = "R_Die";
                        break;
                    case VariableState.L_Die:
                        EntireSceneCurrentChainName = "L_Die";
                        break;
                    case VariableState.R_Attack:
                        EntireSceneCurrentChainName = "R_Punch";
                        break;
                    case VariableState.L_Attack:
                        EntireSceneCurrentChainName = "L_Punch";
                        break;
                    case VariableState.R_Walking:
                        EntireSceneCurrentChainName = "R_Running";
                        break;
                    case VariableState.L_Walking:
                        EntireSceneCurrentChainName = "L_Running";
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static bool mHasRegisteredUnload = false;
        static bool IsStaticContentLoaded = false;
        private static Scene EnemySpriteScene;
        private static AnimationChainList AnimationChainListFile;
		
        private FlatRedBall.Math.Geometry.Circle mBody;
        public FlatRedBall.Math.Geometry.Circle Body
        {
            get
            {
                return mBody;
            }
        }
        private FlatRedBall.Graphics.Animation.AnimationChainList AnimSprite;
        private FlatRedBall.Sprite EntireScene;
        private FlatRedBall.Math.Geometry.Circle mHead;
        public FlatRedBall.Math.Geometry.Circle Head
        {
            get
            {
                return mHead;
            }
        }
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle PathArea;
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle RightAttack;
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle LeftAttack;
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle ViewArea;
        public Microsoft.Xna.Framework.Color BodyColor
        {
            get
            {
                return Body.Color;
            }
            set
            {
                Body.Color = value;
            }
        }
        public string EntireSceneCurrentChainName
        {
            get
            {
                return EntireScene.CurrentChainName;
            }
            set
            {
                EntireScene.CurrentChainName = value;
            }
        }
        public int StartingHealth = 50;
        public float PathAreaScaleX
        {
            get
            {
                return PathArea.ScaleX;
            }
            set
            {
                PathArea.ScaleX = value;
            }
        }
        public int Index { get; set; }
        public bool Used { get; set; }
        protected Layer LayerProvidedByContainer = null;

        public Enemy(string contentManagerName) : this(contentManagerName, true)
        {
        }

        public Enemy(string contentManagerName, bool addToManagers) : base()
        {
            // Don't delete this:
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }

        protected virtual void InitializeEntity(bool addToManagers)
        {
            // Generated Initialize
            LoadStaticContent(ContentManagerName);
            AnimSprite = AnimationChainListFile;
            mBody = new FlatRedBall.Math.Geometry.Circle();
            EntireScene = EnemySpriteScene.Sprites.FindByName("testsprite32x321").Clone();
            mHead = new FlatRedBall.Math.Geometry.Circle();
            PathArea = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            RightAttack = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            LeftAttack = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            ViewArea = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
			
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
			
            if (Body != null)
            {
                Body.Detach();
                ShapeManager.Remove(Body);
            }
            if (EntireScene != null)
            {
                EntireScene.Detach();
                SpriteManager.RemoveSprite(EntireScene);
            }
            if (Head != null)
            {
                Head.Detach();
                ShapeManager.Remove(Head);
            }
            if (PathArea != null)
            {
                PathArea.Detach();
                ShapeManager.Remove(PathArea);
            }
            if (RightAttack != null)
            {
                RightAttack.Detach();
                ShapeManager.Remove(RightAttack);
            }
            if (LeftAttack != null)
            {
                LeftAttack.Detach();
                ShapeManager.Remove(LeftAttack);
            }
            if (ViewArea != null)
            {
                ViewArea.Detach();
                ShapeManager.Remove(ViewArea);
            }

            CustomDestroy();
        }

        // Generated Methods
        public virtual void PostInitialize()
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (mBody != null && mBody.Parent == null)
            {
                mBody.CopyAbsoluteToRelative();
                mBody.AttachTo(this, false);
            }
            Body.Visible = false;
            if (Body.Parent == null)
            {
                Body.X = 0f;
            }
            else
            {
                Body.RelativeX = 0f;
            }
            if (Body.Parent == null)
            {
                Body.Y = -8f;
            }
            else
            {
                Body.RelativeY = -8f;
            }
            Body.Radius = 8f;
            Body.Color = Color.Aqua;
            if (EntireScene != null && EntireScene.Parent == null)
            {
                EntireScene.CopyAbsoluteToRelative();
                EntireScene.AttachTo(this, false);
            }
            if (mHead != null && mHead.Parent == null)
            {
                mHead.CopyAbsoluteToRelative();
                mHead.AttachTo(this, false);
            }
            Head.Visible = false;
            if (Head.Parent == null)
            {
                Head.X = 0f;
            }
            else
            {
                Head.RelativeX = 0f;
            }
            if (Head.Parent == null)
            {
                Head.Y = 5f;
            }
            else
            {
                Head.RelativeY = 5f;
            }
            Head.Radius = 9f;
            PathArea.Visible = false;
            PathArea.ScaleX = 10f;
            PathArea.ScaleY = 10f;
            PathArea.Color = Color.Cyan;
            if (RightAttack != null && RightAttack.Parent == null)
            {
                RightAttack.CopyAbsoluteToRelative();
                RightAttack.AttachTo(this, false);
            }
            RightAttack.Visible = false;
            if (RightAttack.Parent == null)
            {
                RightAttack.X = 7f;
            }
            else
            {
                RightAttack.RelativeX = 7f;
            }
            if (RightAttack.Parent == null)
            {
                RightAttack.Y = -2f;
            }
            else
            {
                RightAttack.RelativeY = -2f;
            }
            RightAttack.ScaleX = 4f;
            RightAttack.ScaleY = 3f;
            if (LeftAttack != null && LeftAttack.Parent == null)
            {
                LeftAttack.CopyAbsoluteToRelative();
                LeftAttack.AttachTo(this, false);
            }
            LeftAttack.Visible = false;
            if (LeftAttack.Parent == null)
            {
                LeftAttack.X = -7f;
            }
            else
            {
                LeftAttack.RelativeX = -7f;
            }
            if (LeftAttack.Parent == null)
            {
                LeftAttack.Y = -2f;
            }
            else
            {
                LeftAttack.RelativeY = -2f;
            }
            LeftAttack.ScaleX = 4f;
            LeftAttack.ScaleY = 3f;
            if (ViewArea != null && ViewArea.Parent == null)
            {
                ViewArea.CopyAbsoluteToRelative();
                ViewArea.AttachTo(this, false);
            }
            ViewArea.Visible = false;
            ViewArea.ScaleX = 80f;
            ViewArea.ScaleY = 15f;
            X = 0f;
            Y = 0f;
            BodyColor = Color.Aqua;
            EntireSceneCurrentChainName = "L_Hustle";
            StartingHealth = 50;
            PathAreaScaleX = 10f;
            Z = 5f;
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
            ShapeManager.AddToLayer(mBody, layerToAddTo);
            mBody.Visible = false;
            if (mBody.Parent == null)
            {
                mBody.X = 0f;
            }
            else
            {
                mBody.RelativeX = 0f;
            }
            if (mBody.Parent == null)
            {
                mBody.Y = -8f;
            }
            else
            {
                mBody.RelativeY = -8f;
            }
            mBody.Radius = 8f;
            mBody.Color = Color.Aqua;
            SpriteManager.AddToLayer(EntireScene, layerToAddTo);
            ShapeManager.AddToLayer(mHead, layerToAddTo);
            mHead.Visible = false;
            if (mHead.Parent == null)
            {
                mHead.X = 0f;
            }
            else
            {
                mHead.RelativeX = 0f;
            }
            if (mHead.Parent == null)
            {
                mHead.Y = 5f;
            }
            else
            {
                mHead.RelativeY = 5f;
            }
            mHead.Radius = 9f;
            ShapeManager.AddToLayer(PathArea, layerToAddTo);
            PathArea.Visible = false;
            PathArea.ScaleX = 10f;
            PathArea.ScaleY = 10f;
            PathArea.Color = Color.Cyan;
            ShapeManager.AddToLayer(RightAttack, layerToAddTo);
            RightAttack.Visible = false;
            if (RightAttack.Parent == null)
            {
                RightAttack.X = 7f;
            }
            else
            {
                RightAttack.RelativeX = 7f;
            }
            if (RightAttack.Parent == null)
            {
                RightAttack.Y = -2f;
            }
            else
            {
                RightAttack.RelativeY = -2f;
            }
            RightAttack.ScaleX = 4f;
            RightAttack.ScaleY = 3f;
            ShapeManager.AddToLayer(LeftAttack, layerToAddTo);
            LeftAttack.Visible = false;
            if (LeftAttack.Parent == null)
            {
                LeftAttack.X = -7f;
            }
            else
            {
                LeftAttack.RelativeX = -7f;
            }
            if (LeftAttack.Parent == null)
            {
                LeftAttack.Y = -2f;
            }
            else
            {
                LeftAttack.RelativeY = -2f;
            }
            LeftAttack.ScaleX = 4f;
            LeftAttack.ScaleY = 3f;
            ShapeManager.AddToLayer(ViewArea, layerToAddTo);
            ViewArea.Visible = false;
            ViewArea.ScaleX = 80f;
            ViewArea.ScaleY = 15f;
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
            SpriteManager.ConvertToManuallyUpdated(EntireScene);
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
                        FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("EnemyStaticUnload", UnloadStaticContent);
                        mHasRegisteredUnload = true;
                    }
                }
                bool registerUnload = false;
                if (!FlatRedBallServices.IsLoaded<Scene>(@"content/entities/gamescreen/enemy/enemyspritescene.scnx", ContentManagerName))
                {
                    registerUnload = true;
                }
                EnemySpriteScene = FlatRedBallServices.Load<Scene>(@"content/entities/gamescreen/enemy/enemyspritescene.scnx", ContentManagerName);
                if (!FlatRedBallServices.IsLoaded<AnimationChainList>(@"content/entities/gamescreen/enemy/animationchainlistfile.achx", ContentManagerName))
                {
                    registerUnload = true;
                }
                AnimationChainListFile = FlatRedBallServices.Load<AnimationChainList>(@"content/entities/gamescreen/enemy/animationchainlistfile.achx", ContentManagerName);
                if (registerUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                {
                    lock (mLockObject)
                    {
                        if (!mHasRegisteredUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                        {
                            FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("EnemyStaticUnload", UnloadStaticContent);
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
            if (EnemySpriteScene != null)
            {
                EnemySpriteScene.RemoveFromManagers(ContentManagerName != "Global");
                EnemySpriteScene = null;
            }
            if (AnimationChainListFile != null)
            {
                AnimationChainListFile = null;
            }
        }

        public static object GetStaticMember(string memberName)
        {
            switch(memberName)
            {
                case "EnemySpriteScene":
                    return EnemySpriteScene;
                case "AnimationChainListFile":
                    return AnimationChainListFile;
            }
            return null;
        }

        static VariableState mLoadingState = VariableState.Uninitialized;
        public static VariableState LoadingState
        {
            get
            {
                return mLoadingState;
            }
            set
            {
                mLoadingState = value;
            }
        }
        public Instruction InterpolateToState(VariableState stateToInterpolateTo, double secondsToTake)
        {
            switch(stateToInterpolateTo)
            {
                case VariableState.R_Idle:
                    break;
                case VariableState.L_Idle:
                    break;
                case VariableState.R_Hurt:
                    break;
                case VariableState.L_Hurt:
                    break;
                case VariableState.R_Die:
                    break;
                case VariableState.L_Die:
                    break;
                case VariableState.R_Attack:
                    break;
                case VariableState.L_Attack:
                    break;
                case VariableState.R_Walking:
                    break;
                case VariableState.L_Walking:
                    break;
            }
            var instruction = new DelegateInstruction<VariableState>(StopStateInterpolation, stateToInterpolateTo);
            instruction.TimeToExecute = TimeManager.CurrentTime + secondsToTake;
            this.Instructions.Add(instruction);
            return instruction;
        }

        public void StopStateInterpolation(VariableState stateToStop)
        {
            switch(stateToStop)
            {
                case VariableState.R_Idle:
                    break;
                case VariableState.L_Idle:
                    break;
                case VariableState.R_Hurt:
                    break;
                case VariableState.L_Hurt:
                    break;
                case VariableState.R_Die:
                    break;
                case VariableState.L_Die:
                    break;
                case VariableState.R_Attack:
                    break;
                case VariableState.L_Attack:
                    break;
                case VariableState.R_Walking:
                    break;
                case VariableState.L_Walking:
                    break;
            }
            CurrentState = stateToStop;
        }

        public void InterpolateBetween(VariableState firstState, VariableState secondState, float interpolationValue)
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new Exception("interpolationValue cannot be NaN");
            }
            #endif
            switch(firstState)
            {
                case VariableState.R_Idle:
                    break;
                case VariableState.L_Idle:
                    break;
                case VariableState.R_Hurt:
                    break;
                case VariableState.L_Hurt:
                    break;
                case VariableState.R_Die:
                    break;
                case VariableState.L_Die:
                    break;
                case VariableState.R_Attack:
                    break;
                case VariableState.L_Attack:
                    break;
                case VariableState.R_Walking:
                    break;
                case VariableState.L_Walking:
                    break;
            }
            switch(secondState)
            {
                case VariableState.R_Idle:
                    break;
                case VariableState.L_Idle:
                    break;
                case VariableState.R_Hurt:
                    break;
                case VariableState.L_Hurt:
                    break;
                case VariableState.R_Die:
                    break;
                case VariableState.L_Die:
                    break;
                case VariableState.R_Attack:
                    break;
                case VariableState.L_Attack:
                    break;
                case VariableState.R_Walking:
                    break;
                case VariableState.L_Walking:
                    break;
            }
        }

        object GetMember(string memberName)
        {
            switch(memberName)
            {
                case "EnemySpriteScene":
                    return EnemySpriteScene;
                case "AnimationChainListFile":
                    return AnimationChainListFile;
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
            InstructionManager.IgnorePausingFor(Body);
            InstructionManager.IgnorePausingFor(EntireScene);
            InstructionManager.IgnorePausingFor(Head);
            InstructionManager.IgnorePausingFor(PathArea);
            InstructionManager.IgnorePausingFor(RightAttack);
            InstructionManager.IgnorePausingFor(LeftAttack);
            InstructionManager.IgnorePausingFor(ViewArea);
        }
    }
	
    // Extra classes
    public static class EnemyExtensionMethods
    {
    }
}