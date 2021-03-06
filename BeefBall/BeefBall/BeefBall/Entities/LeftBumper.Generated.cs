using System;
using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Gui;
using FlatRedBall.Instructions;
using FlatRedBall.Math;
using GuiManager = FlatRedBall.Gui.GuiManager;
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
    public partial class LeftBumper : PositionedObject, IDestroyable, IVisible, IWindow
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
        private static Scene Lb;
		
        private FlatRedBall.Sprite LeftBumperButton;
        public bool LeftBumperButtonVisible
        {
            get
            {
                return LeftBumperButton.Visible;
            }
            set
            {
                LeftBumperButton.Visible = value;
            }
        }
        public float LeftBumperButtonScaleX
        {
            get
            {
                return LeftBumperButton.ScaleX;
            }
            set
            {
                LeftBumperButton.ScaleX = value;
            }
        }
        public float LeftBumperButtonScaleY
        {
            get
            {
                return LeftBumperButton.ScaleY;
            }
            set
            {
                LeftBumperButton.ScaleY = value;
            }
        }
        public int Index { get; set; }
        public bool Used { get; set; }
        public event EventHandler BeforeVisibleSet;
        public event EventHandler AfterVisibleSet;
        protected bool mVisible = true;
        public virtual bool Visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                if (BeforeVisibleSet != null)
                {
                    BeforeVisibleSet(this, null);
                }
                mVisible = value;
                if (AfterVisibleSet != null)
                {
                    AfterVisibleSet(this, null);
                }
            }
        }
        public bool IgnoresParentVisibility { get; set; }
        public bool AbsoluteVisible
        {
            get
            {
                return Visible && (Parent == null || IgnoresParentVisibility || Parent is IVisible == false || (Parent as IVisible).AbsoluteVisible);
            }
        }
        IVisible IVisible.Parent
        {
            get
            {
                if (this.Parent != null && this.Parent is IVisible)
                {
                    return this.Parent as IVisible;
                }
                else
                {
                    return null;
                }
            }
        }
        protected Layer LayerProvidedByContainer = null;

        public LeftBumper(string contentManagerName) : this(contentManagerName, true)
        {
        }

        public LeftBumper(string contentManagerName, bool addToManagers) : base()
        {
            // Don't delete this:
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }

        protected virtual void InitializeEntity(bool addToManagers)
        {
            // Generated Initialize
            LoadStaticContent(ContentManagerName);
            LeftBumperButton = Lb.Sprites.FindByName("xboxcontrollerleftshoulder1").Clone();
            this.Click += OnClick;
            this.RollOn += OnRollOn;
            this.RollOff += OnRollOff;
			
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
            GuiManager.AddWindow(this);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }

        public virtual void Activity()
        {
            // Generated Activity
            mIsPaused = false;
			
            CustomActivity();
            // After Custom Activity
        }

        public virtual void Destroy()
        {
            // Generated Destroy
            SpriteManager.RemovePositionedObject(this);
            GuiManager.RemoveWindow(this);
			
            if (LeftBumperButton != null)
            {
                LeftBumperButton.Detach();
                SpriteManager.RemoveSprite(LeftBumperButton);
            }

            CustomDestroy();
        }

        // Generated Methods
        public virtual void PostInitialize()
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (LeftBumperButton != null && LeftBumperButton.Parent == null)
            {
                LeftBumperButton.CopyAbsoluteToRelative();
                LeftBumperButton.AttachTo(this, false);
            }
            X = 0f;
            Y = 0f;
            LeftBumperButtonVisible = true;
            LeftBumperButtonScaleX = 109f;
            LeftBumperButtonScaleY = 46f;
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
            SpriteManager.AddToLayer(LeftBumperButton, layerToAddTo);
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
            SpriteManager.ConvertToManuallyUpdated(LeftBumperButton);
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
                        FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("LeftBumperStaticUnload", UnloadStaticContent);
                        mHasRegisteredUnload = true;
                    }
                }
                bool registerUnload = false;
                if (!FlatRedBallServices.IsLoaded<Scene>(@"content/entities/leftbumper/lb.scnx", ContentManagerName))
                {
                    registerUnload = true;
                }
                Lb = FlatRedBallServices.Load<Scene>(@"content/entities/leftbumper/lb.scnx", ContentManagerName);
                if (registerUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                {
                    lock (mLockObject)
                    {
                        if (!mHasRegisteredUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
                        {
                            FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("LeftBumperStaticUnload", UnloadStaticContent);
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
            if (Lb != null)
            {
                Lb.RemoveFromManagers(ContentManagerName != "Global");
                Lb = null;
            }
        }

        public static object GetStaticMember(string memberName)
        {
            switch(memberName)
            {
                case "Lb":
                    return Lb;
            }
            return null;
        }

        object GetMember(string memberName)
        {
            switch(memberName)
            {
                case "Lb":
                    return Lb;
            }
            return null;
        }
		
        // DELEGATE START HERE
    
        #region IWindow methods and properties

        public event WindowEvent Click;
        public event WindowEvent ClickNoSlide;
        public event WindowEvent SlideOnClick;
        public event WindowEvent Push;
        public event WindowEvent DragOver;
        public event WindowEvent RollOn;
        public event WindowEvent RollOff;

        System.Collections.ObjectModel.ReadOnlyCollection<IWindow> IWindow.Children
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool mEnabled = true;

        bool IWindow.Visible
        {
            get
            {
                return this.AbsoluteVisible;
            }
            set
            {
                this.Visible = value;
            }
        }

        bool IWindow.Enabled
        {
            get
            {
                return mEnabled;
            }
            set
            {
                mEnabled = value;
            }
        }

        public bool MovesWhenGrabbed { get; set; }

        bool IWindow.GuiManagerDrawn
        {
            get
            {
                return false;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IgnoredByCursor
        {
            get
            {
                return false;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IWindow> FloatingChildren
        {
            get
            {
                return null;
            }
        }

        public FlatRedBall.ManagedSpriteGroups.SpriteFrame SpriteFrame
        {
            get
            {
                return null;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IWindow.WorldUnitX
        {
            get
            {
                return Position.X;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IWindow.WorldUnitY
        {
            get
            {
                return Position.Y;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IWindow.WorldUnitRelativeX
        {
            get
            {
                return RelativePosition.X;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IWindow.WorldUnitRelativeY
        {
            get
            {
                return RelativePosition.Y;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IWindow.ScaleX { get; set; }

        float IWindow.ScaleY { get; set; }

        IWindow IWindow.Parent
        {
            get
            {
                return null;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void IWindow.Activity(Camera camera)
        {
        }

        void IWindow.CallRollOff()
        {
            if (RollOff != null)
            {
                RollOff(this);
            }
        }

        void IWindow.CallRollOn()
        {
            if (RollOn != null)
            {
                RollOn(this);
            }
        }

        void IWindow.CloseWindow()
        {
            throw new NotImplementedException();
        }

        void IWindow.CallClick()
        {
            if (Click != null)
            {
                Click(this);
            }
        }

        public bool GetParentVisibility()
        {
            throw new NotImplementedException();
        }

        bool IWindow.IsPointOnWindow(float x, float y)
        {
            throw new NotImplementedException();
        }

        public void OnDragging()
        {
            if (DragOver != null)
            {
                DragOver(this);
            }
        }

        public void OnResize()
        {
            throw new NotImplementedException();
        }

        public void OnResizeEnd()
        {
            throw new NotImplementedException();
        }

        public void OnLosingFocus()
        {
            // Do nothing
        }

        public bool OverlapsWindow(IWindow otherWindow)
        {
            return false; // we don't care about this.
        }

        public void SetScaleTL(float newScaleX, float newScaleY)
        {
            throw new NotImplementedException();
        }

        public void SetScaleTL(float newScaleX, float newScaleY, bool keepTopLeftStatic)
        {
            throw new NotImplementedException();
        }

        public virtual void TestCollision(FlatRedBall.Gui.Cursor cursor)
        {
            if (HasCursorOver(cursor))
            {
                cursor.WindowOver = this;

                if (cursor.PrimaryPush)
                {
                    cursor.WindowPushed = this;

                    if (Push != null)
                        Push(this);

                    cursor.GrabWindow(this);
                }

                if (cursor.PrimaryClick) // both pushing and clicking can occur in one frame because of buffered input
                {
                    if (cursor.WindowPushed == this)
                    {
                        if (Click != null)
                        {
                            Click(this);
                        }
                        if (cursor.PrimaryClickNoSlide && ClickNoSlide != null)
                        {
                            ClickNoSlide(this);
                        }
                        // if (cursor.PrimaryDoubleClick && DoubleClick != null)
                        //   DoubleClick(this);
                    }
                    else
                    {
                        if (SlideOnClick != null)
                        {
                            SlideOnClick(this);
                        }
                    }
                }
            }
        }

        void IWindow.UpdateDependencies()
        {
            // do nothing
        }

        Layer ILayered.Layer
        {
            get
            {
                return LayerProvidedByContainer;
            }
        }

        #endregion

        public virtual bool HasCursorOver(FlatRedBall.Gui.Cursor cursor)
        {
            if (mIsPaused)
            {
                return false;
            }
            if (!AbsoluteVisible)
            {
                return false;
            }
            if (LayerProvidedByContainer != null && LayerProvidedByContainer.Visible == false)
            {
                return false;
            }
            if (!cursor.IsOn(LayerProvidedByContainer))
            {
                return false;
            }
            if (cursor.IsOn3D(LeftBumperButton, LayerProvidedByContainer))
            {
                return true;
            }
            return false;
        }

        public virtual bool WasClickedThisFrame(FlatRedBall.Gui.Cursor cursor)
        {
            return cursor.PrimaryClick && HasCursorOver(cursor);
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
            InstructionManager.IgnorePausingFor(LeftBumperButton);
        }
    }
	
    // Extra classes
    public static class LeftBumperExtensionMethods
    {
        public static void SetVisible(this PositionedObjectList<LeftBumper> list, bool value)
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}