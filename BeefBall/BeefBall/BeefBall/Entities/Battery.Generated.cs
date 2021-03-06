using System;
using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Instructions;

// Generated Usings
#if XNA4
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif

#if FRB_XNA || SILVERLIGHT
#endif

#if FRB_XNA && !MONODROID
#endif

namespace BeefBall.Entities
{
    public partial class Battery : PositionedObject, IDestroyable
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
            Full, 
            Half, 
            Empty, 
            Quarter, 
            ThreeQuarters
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
                    case VariableState.Full:
                        BarCurrentChainName = "Full";
                        break;
                    case VariableState.Half:
                        BarCurrentChainName = "Half";
                        break;
                    case VariableState.Empty:
                        BarCurrentChainName = "Empty";
                        break;
                    case VariableState.Quarter:
                        BarCurrentChainName = "Quarter";
                        break;
                    case VariableState.ThreeQuarters:
                        BarCurrentChainName = "ThreeQuarters";
                        break;
                }
            }
        }
        static object mLockObject = new object();
        static bool mHasRegisteredUnload = false;
        static bool IsStaticContentLoaded = false;
        private static AnimationChainList AnimationChainListFile;
        private static Scene SceneFile;
		
        private FlatRedBall.Sprite mBar;
        public FlatRedBall.Sprite Bar
        {
            get
            {
                return mBar;
            }
        }
        public string BarCurrentChainName
        {
            get
            {
                return Bar.CurrentChainName;
            }
            set
            {
                Bar.CurrentChainName = value;
            }
        }
        public int Index { get; set; }
        public bool Used { get; set; }
        protected Layer LayerProvidedByContainer = null;

        public Battery(string contentManagerName) : this(contentManagerName, true)
        {
        }

        public Battery(string contentManagerName, bool addToManagers) : base()
        {
            // Don't delete this:
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }

        protected virtual void InitializeEntity(bool addToManagers)
        {
            // Generated Initialize
            LoadStaticContent(ContentManagerName);
            mBar = SceneFile.Sprites.FindByName("battery1").Clone();
			
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
			
            if (Bar != null)
            {
                Bar.Detach();
                SpriteManager.RemoveSprite(Bar);
            }

            CustomDestroy();
        }

        // Generated Methods
        public virtual void PostInitialize()
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (mBar != null && mBar.Parent == null)
            {
                mBar.CopyAbsoluteToRelative();
                mBar.AttachTo(this, false);
            }
            Bar.ScaleX = 1f;
            Bar.PixelSize = 1f;
            BarCurrentChainName = "Full";
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
            SpriteManager.AddToLayer(mBar, layerToAddTo);
            mBar.ScaleX = 1f;
            mBar.PixelSize = 1f;
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
            SpriteManager.ConvertToManuallyUpdated(Bar);
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
                        FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BatteryStaticUnload", UnloadStaticContent);
                        mHasRegisteredUnload = true;
                    }
                }
                bool registerUnload = false;
                if (!FlatRedBallServices.IsLoaded<AnimationChainList>(@"content/entities/battery/animationchainlistfile.achx", ContentManagerName))
                {
                    registerUnload = true;
                }
                AnimationChainListFile = FlatRedBallServices.Load<AnimationChainList>(@"content/entities/battery/animationchainlistfile.achx", ContentManagerName);
                if (!FlatRedBallServices.IsLoaded<Scene>(@"content/entities/battery/scenefile.scnx", ContentManagerName))
                {
                    registerUnload = true;
                }
                SceneFile = FlatRedBallServices.Load<Scene>(@"content/entities/battery/scenefile.scnx", ContentManagerName);
                if (registerUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                {
                    lock (mLockObject)
                    {
                        if (!mHasRegisteredUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                        {
                            FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BatteryStaticUnload", UnloadStaticContent);
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
            if (AnimationChainListFile != null)
            {
                AnimationChainListFile = null;
            }
            if (SceneFile != null)
            {
                SceneFile.RemoveFromManagers(ContentManagerName != "Global");
                SceneFile = null;
            }
        }

        public static object GetStaticMember(string memberName)
        {
            switch(memberName)
            {
                case "AnimationChainListFile":
                    return AnimationChainListFile;
                case "SceneFile":
                    return SceneFile;
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
                case VariableState.Full:
                    break;
                case VariableState.Half:
                    break;
                case VariableState.Empty:
                    break;
                case VariableState.Quarter:
                    break;
                case VariableState.ThreeQuarters:
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
                case VariableState.Full:
                    break;
                case VariableState.Half:
                    break;
                case VariableState.Empty:
                    break;
                case VariableState.Quarter:
                    break;
                case VariableState.ThreeQuarters:
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
                case VariableState.Full:
                    break;
                case VariableState.Half:
                    break;
                case VariableState.Empty:
                    break;
                case VariableState.Quarter:
                    break;
                case VariableState.ThreeQuarters:
                    break;
            }
            switch(secondState)
            {
                case VariableState.Full:
                    break;
                case VariableState.Half:
                    break;
                case VariableState.Empty:
                    break;
                case VariableState.Quarter:
                    break;
                case VariableState.ThreeQuarters:
                    break;
            }
        }

        object GetMember(string memberName)
        {
            switch(memberName)
            {
                case "AnimationChainListFile":
                    return AnimationChainListFile;
                case "SceneFile":
                    return SceneFile;
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
            InstructionManager.IgnorePausingFor(Bar);
        }
    }
	
    // Extra classes
    public static class BatteryExtensionMethods
    {
    }
}