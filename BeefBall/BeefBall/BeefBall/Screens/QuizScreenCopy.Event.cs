using System;
using System.Collections.Generic;
using BeefBall.Entities;
using FlatRedBall.Input;

namespace BeefBall.Screens
{
    public partial class QuizScreenCopy
    {
        int questionIndex = 0;
        int reviewIndex = 0;
        int numCorrect = 0;
        double percent = 0;
        bool canRollOver = true;
        bool canClick = true;
        bool lastScreen = false;
        bool menuOptionsScreen = false;
        bool endQuizOptions = false;
        bool reviewQuestions = false;
        List<Question> answeredQuestions = new List<Question>();

        void StartButtonPress()
        {
            if (GamePad.ButtonPushed(Xbox360GamePad.Button.Start))
                StartButtonActivity();
        }

        void LeftBumperPress()
        {
            if (!reviewQuestions)
            {
                if (GamePad.ButtonPushed(Xbox360GamePad.Button.LeftShoulder))
                    LBumperActivity();
            }
        }

        void XButtonPress()
        {
            if (GamePad.ButtonPushed(Xbox360GamePad.Button.X))
                XActivity();
        }

        void YButtonPress()
        {
            if (GamePad.ButtonPushed(Xbox360GamePad.Button.Y))
                YActivity();
        }

        void AButtonPress()
        {
            if (GamePad.ButtonPushed(Xbox360GamePad.Button.A))
                AActivity();
        }

        void BButtonPress()
        {
            if (GamePad.ButtonPushed(Xbox360GamePad.Button.B))
                BActivity();
        }

        void OnXBoxXButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            XActivity();
        }

        void OnXboxXButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                XButtoninst.RotationZ = 1;
            }
        }

        void OnXBoxXButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                XButtoninst.RotationZ = 0;
                XButtoninst.RotationX = 0;
                XButtoninst.RotationY = 0;
            }
        }

        void OnXBoxYButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            YActivity();
        }

        void OnXboxYButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                YButtonInst.RotationZ = 1;
            }
        }

        void OnXBoxYButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                YButtonInst.RotationZ = 0;
                YButtonInst.RotationX = 0;
                YButtonInst.RotationY = 0;
            }
        }

        void OnXBoxBButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            BActivity();
        }

        void OnXboxBButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                BButtonInst.RotationZ = 1;
            }
        }

        void OnXBoxBButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                BButtonInst.RotationZ = 0;
                BButtonInst.RotationX = 0;
                BButtonInst.RotationY = 0;
            }
        }

        void OnXBoxAButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            AActivity();
        }

        void OnXboxAButtonRollOn(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                AButtonInst.RotationZ = 1;
            }
        }

        void OnXBoxAButtonRollOff(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (canRollOver)
            {
                AButtonInst.RotationZ = 0;
                AButtonInst.RotationX = 0;
                AButtonInst.RotationY = 0;
            }
        }

        void OnLbButtonClick(FlatRedBall.Gui.IWindow callingWindow) 
        {
            LBumperActivity();
        }

        void OnStartButtonClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            StartButtonActivity();
        }
    }
}