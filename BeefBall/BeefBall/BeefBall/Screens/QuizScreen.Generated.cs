using System;
#if XNA4
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif
#if FRB_XNA || SILVERLIGHT
#endif
// Generated Usings
using FlatRedBall;

namespace BeefBall.Screens
{
    public partial class QuizScreen : Screen
    {
        // Generated Fields
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
		
        private BeefBall.Entities.Button NextQuestion;
        private BeefBall.Entities.Button NumberCorrect;
        private BeefBall.Entities.YButton YButtonInst;
        private BeefBall.Entities.XButton XButtoninst;
        private BeefBall.Entities.BButton BButtonInst;
        private BeefBall.Entities.AButton AButtonInst;
        private BeefBall.Entities.StartButton StartButtonInst;
        public event FlatRedBall.Gui.WindowEvent NextQuestionClick;

        public QuizScreen() : base("QuizScreen")
        {
        }

        public override void Initialize(bool addToManagers)
        {
            // Generated Initialize
            LoadStaticContent(ContentManagerName);
            NextQuestion = new BeefBall.Entities.Button(ContentManagerName, false);
            NextQuestion.Name = "NextQuestion";
            NumberCorrect = new BeefBall.Entities.Button(ContentManagerName, false);
            NumberCorrect.Name = "NumberCorrect";
            YButtonInst = new BeefBall.Entities.YButton(ContentManagerName, false);
            YButtonInst.Name = "YButtonInst";
            XButtoninst = new BeefBall.Entities.XButton(ContentManagerName, false);
            XButtoninst.Name = "XButtoninst";
            BButtonInst = new BeefBall.Entities.BButton(ContentManagerName, false);
            BButtonInst.Name = "BButtonInst";
            AButtonInst = new BeefBall.Entities.AButton(ContentManagerName, false);
            AButtonInst.Name = "AButtonInst";
            StartButtonInst = new BeefBall.Entities.StartButton(ContentManagerName, false);
            StartButtonInst.Name = "StartButtonInst";
            NextQuestion.Click += OnNextQuestionClick;
            NextQuestion.Click += OnNextQuestionClickTunnel;
			
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
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }

        public override void Activity(bool firstTimeCalled)
        {
            // Generated Activity
            if (!IsPaused)
            {
                NextQuestion.Activity();
                NumberCorrect.Activity();
                YButtonInst.Activity();
                XButtoninst.Activity();
                BButtonInst.Activity();
                AButtonInst.Activity();
                StartButtonInst.Activity();
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
            if (NextQuestion != null)
            {
                NextQuestion.Destroy();
                NextQuestion.Detach();
            }
            if (NumberCorrect != null)
            {
                NumberCorrect.Destroy();
                NumberCorrect.Detach();
            }
            if (YButtonInst != null)
            {
                YButtonInst.Destroy();
                YButtonInst.Detach();
            }
            if (XButtoninst != null)
            {
                XButtoninst.Destroy();
                XButtoninst.Detach();
            }
            if (BButtonInst != null)
            {
                BButtonInst.Destroy();
                BButtonInst.Detach();
            }
            if (AButtonInst != null)
            {
                AButtonInst.Destroy();
                AButtonInst.Detach();
            }
            if (StartButtonInst != null)
            {
                StartButtonInst.Destroy();
                StartButtonInst.Detach();
            }

            base.Destroy();

            CustomDestroy();
        }

        // Generated Methods
        public virtual void PostInitialize()
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            NextQuestion.DisplayText = "Next Question";
            if (NextQuestion.Parent == null)
            {
                NextQuestion.Y = -90f;
            }
            else
            {
                NextQuestion.RelativeY = -90f;
            }
            NumberCorrect.DisplayText = "0 out of 0";
            if (NumberCorrect.Parent == null)
            {
                NumberCorrect.X = 130f;
            }
            else
            {
                NumberCorrect.RelativeX = 130f;
            }
            if (NumberCorrect.Parent == null)
            {
                NumberCorrect.Y = 130f;
            }
            else
            {
                NumberCorrect.RelativeY = 130f;
            }
            if (YButtonInst.Parent == null)
            {
                YButtonInst.X = 120f;
            }
            else
            {
                YButtonInst.RelativeX = 120f;
            }
            if (YButtonInst.Parent == null)
            {
                YButtonInst.Y = 40f;
            }
            else
            {
                YButtonInst.RelativeY = 40f;
            }
            if (XButtoninst.Parent == null)
            {
                XButtoninst.X = 90f;
            }
            else
            {
                XButtoninst.RelativeX = 90f;
            }
            if (XButtoninst.Parent == null)
            {
                XButtoninst.Y = 10f;
            }
            else
            {
                XButtoninst.RelativeY = 10f;
            }
            if (BButtonInst.Parent == null)
            {
                BButtonInst.X = 150f;
            }
            else
            {
                BButtonInst.RelativeX = 150f;
            }
            if (BButtonInst.Parent == null)
            {
                BButtonInst.Y = 10f;
            }
            else
            {
                BButtonInst.RelativeY = 10f;
            }
            if (AButtonInst.Parent == null)
            {
                AButtonInst.X = 120f;
            }
            else
            {
                AButtonInst.RelativeX = 120f;
            }
            if (AButtonInst.Parent == null)
            {
                AButtonInst.Y = -20f;
            }
            else
            {
                AButtonInst.RelativeY = -20f;
            }
            if (StartButtonInst.Parent == null)
            {
                StartButtonInst.X = 120f;
            }
            else
            {
                StartButtonInst.RelativeX = 120f;
            }
            if (StartButtonInst.Parent == null)
            {
                StartButtonInst.Y = -30f;
            }
            else
            {
                StartButtonInst.RelativeY = -30f;
            }
            StartButtonInst.Visible = false;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }

        public virtual void AddToManagersBottomUp()
        {
            NextQuestion.AddToManagers(mLayer);
            NextQuestion.DisplayText = "Next Question";
            if (NextQuestion.Parent == null)
            {
                NextQuestion.Y = -90f;
            }
            else
            {
                NextQuestion.RelativeY = -90f;
            }
            NumberCorrect.AddToManagers(mLayer);
            NumberCorrect.CurrentState = BeefBall.Entities.Button.VariableState.Disabled;
            NumberCorrect.DisplayText = "0 out of 0";
            if (NumberCorrect.Parent == null)
            {
                NumberCorrect.X = 130f;
            }
            else
            {
                NumberCorrect.RelativeX = 130f;
            }
            if (NumberCorrect.Parent == null)
            {
                NumberCorrect.Y = 130f;
            }
            else
            {
                NumberCorrect.RelativeY = 130f;
            }
            YButtonInst.AddToManagers(mLayer);
            if (YButtonInst.Parent == null)
            {
                YButtonInst.X = 120f;
            }
            else
            {
                YButtonInst.RelativeX = 120f;
            }
            if (YButtonInst.Parent == null)
            {
                YButtonInst.Y = 40f;
            }
            else
            {
                YButtonInst.RelativeY = 40f;
            }
            XButtoninst.AddToManagers(mLayer);
            if (XButtoninst.Parent == null)
            {
                XButtoninst.X = 90f;
            }
            else
            {
                XButtoninst.RelativeX = 90f;
            }
            if (XButtoninst.Parent == null)
            {
                XButtoninst.Y = 10f;
            }
            else
            {
                XButtoninst.RelativeY = 10f;
            }
            BButtonInst.AddToManagers(mLayer);
            if (BButtonInst.Parent == null)
            {
                BButtonInst.X = 150f;
            }
            else
            {
                BButtonInst.RelativeX = 150f;
            }
            if (BButtonInst.Parent == null)
            {
                BButtonInst.Y = 10f;
            }
            else
            {
                BButtonInst.RelativeY = 10f;
            }
            AButtonInst.AddToManagers(mLayer);
            if (AButtonInst.Parent == null)
            {
                AButtonInst.X = 120f;
            }
            else
            {
                AButtonInst.RelativeX = 120f;
            }
            if (AButtonInst.Parent == null)
            {
                AButtonInst.Y = -20f;
            }
            else
            {
                AButtonInst.RelativeY = -20f;
            }
            StartButtonInst.AddToManagers(mLayer);
            if (StartButtonInst.Parent == null)
            {
                StartButtonInst.X = 120f;
            }
            else
            {
                StartButtonInst.RelativeX = 120f;
            }
            if (StartButtonInst.Parent == null)
            {
                StartButtonInst.Y = -30f;
            }
            else
            {
                StartButtonInst.RelativeY = -30f;
            }
            StartButtonInst.Visible = false;
        }

        public virtual void ConvertToManuallyUpdated()
        {
            NextQuestion.ConvertToManuallyUpdated();
            NumberCorrect.ConvertToManuallyUpdated();
            YButtonInst.ConvertToManuallyUpdated();
            XButtoninst.ConvertToManuallyUpdated();
            BButtonInst.ConvertToManuallyUpdated();
            AButtonInst.ConvertToManuallyUpdated();
            StartButtonInst.ConvertToManuallyUpdated();
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
            BeefBall.Entities.Button.LoadStaticContent(contentManagerName);
            BeefBall.Entities.YButton.LoadStaticContent(contentManagerName);
            BeefBall.Entities.XButton.LoadStaticContent(contentManagerName);
            BeefBall.Entities.BButton.LoadStaticContent(contentManagerName);
            BeefBall.Entities.AButton.LoadStaticContent(contentManagerName);
            BeefBall.Entities.StartButton.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }

        object GetMember(string memberName)
        {
            return null;
        }
    }
}