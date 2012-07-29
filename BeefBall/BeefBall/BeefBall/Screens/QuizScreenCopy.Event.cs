using System;
using FlatRedBall;
using FlatRedBall.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using BeefBall.Entities;
using BeefBall.Entities.GameScreen;
using BeefBall.Screens;
using System.Collections.Generic;
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

        void onXBoxYButtonClick(FlatRedBall.Gui.IWindow callingWindow)
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

        void StartButtonActivity()
        {
            NextQuestionAdvance();
        }

        void LBumperActivity() 
        {
            questionText.DisplayText = "Quit to main menu?";
            answerXText.DisplayText = "X) Yes";
            answerYText.DisplayText = "Y) No";
            answerAText.DisplayText = "";
            answerBText.DisplayText = "";
            AButtonInst.RotationX = 5;
            AButtonInst.RotationY = 5;
            BButtonInst.RotationX = 5;
            BButtonInst.RotationY = 5;
            menuOptionsScreen = true;
        }

        void AActivity()
        {
            if (questionIndex < 37 && canClick && !endQuizOptions && !reviewQuestions)
            {
                if (IsRightAnswer(3))
                {
                    numCorrect++;
                    answerAText.SetColor(0, 255, 0);
                }
                else
                {
                    answerAText.SetColor(255, 0, 0);
                }

                ButtonPressCommonActivity(3);
            }

            if (endQuizOptions && !reviewQuestions) 
            {
                //Do nothing
            }

            if (reviewQuestions) 
            {
                this.MoveToScreen(typeof(QuizScreenCopy).FullName);
            }
        }

        void BActivity()
        {
            if (questionIndex < 37 && canClick && !endQuizOptions && !reviewQuestions)
            {
                if (IsRightAnswer(2))
                {
                    numCorrect++;
                    answerBText.SetColor(0, 255, 0);
                }
                else
                {
                    answerBText.SetColor(255, 0, 0);
                }
                ButtonPressCommonActivity(2);
            }

            if (endQuizOptions && !reviewQuestions)
            {
                ReviewQuiz();
            }

            if (reviewQuestions) 
            {
                if (reviewIndex < answeredQuestions.Count - 1) 
                {
                    reviewIndex++;
                    ResetDisplayColors();
                    DisplayReview();
                }
            }
        }

        void XActivity()
        {
            if (questionIndex < 37 && canClick && !menuOptionsScreen && !endQuizOptions && !reviewQuestions)
            {
                if (IsRightAnswer(0))
                {
                    numCorrect++;
                    answerXText.SetColor(0, 255, 0);
                }
                else
                {
                    answerXText.SetColor(255, 0, 0);
                }
                ButtonPressCommonActivity(0);
            }

            if (menuOptionsScreen && !reviewQuestions) 
            {
                this.MoveToScreen(typeof(MainMenu).FullName);
            }

            if (endQuizOptions && !reviewQuestions)
            {
                this.MoveToScreen(typeof(MainMenu).FullName);
            }

            if (reviewQuestions) 
            {
                if (reviewIndex > 0)
                {
                    reviewIndex--;
                    ResetDisplayColors();
                    DisplayReview();
                }
            }
        }

        void YActivity()
        {
            if (questionIndex < 37 && canClick && !menuOptionsScreen && !endQuizOptions && !reviewQuestions)
            {
                if (IsRightAnswer(1))
                {
                    numCorrect++;
                    answerYText.SetColor(0, 255, 0);
                }
                else
                {
                    answerYText.SetColor(255, 0, 0);
                }
                ButtonPressCommonActivity(1);
            }
            if (menuOptionsScreen)
            {
                menuOptionsScreen = false;
                InflateAllAnswers();
                DisplayQuestions();
                NextQuestionVisible();
            }

            if (endQuizOptions && !reviewQuestions)
            {
                this.MoveToScreen(typeof(QuizScreenCopy).FullName);
            }

            if (reviewQuestions) 
            {
                this.MoveToScreen(typeof(MainMenu).FullName);
            }
        }

        void ButtonPressCommonActivity(int choice)
        {
            AddAnswerToList(choice);
            CollapseWrongAnswers();
            questionIndex++;
            UpdateNumCorrect();
            NextQuestionVisible();
        }

        void OnNextQuestionClick(FlatRedBall.Gui.IWindow callingWindow)
        {
            NextQuestionAdvance();
        }

        void NextQuestionAdvance()
        {
            ResetTextColors();
            if (questionIndex < 37)
            {
                DisplayQuestions();
                InflateAllAnswers();
            }
            NextQuestionNotVisible();

            if (questionIndex > 36)
            {
                endQuizOptions = true;
                EndQuizOptionsLoad();
            }
        }

        void EndQuizOptionsLoad() 
        {
            StartButtonInst.Visible = false;
            LeftBumperInstance.Visible = false;
            canClick = true;
            canRollOver = false;
            InflateAllAnswers();
            StartButtonInst.Visible = false;
            XButtoninst.Visible = true;
            YButtonInst.Visible = true;
            BButtonInst.Visible = true;
            AButtonInst.Visible = true;
            questionText.DisplayText = string.Format("End of quiz you scored {0:#.#}%.  {1}", PercentCorrect(), DisplayStatus());
            answerXText.DisplayText = "X) Main Menu";
            answerYText.DisplayText = "Y) Restart Quiz";
            answerBText.DisplayText = "B) Review";
            answerAText.DisplayText = "";
            AButtonInst.RotationX = 5;
            AButtonInst.RotationY = 5;
        }

        string DisplayStatus() 
        {
            if (percent > 93)
            {
                return "Great job!";
            }
            else if (percent < 93 && percent > 89)
            { 
                return "Good not great.";
            }
            else if (percent < 89 && percent > 77)
            {
                return "You should try again.";
            }
            else 
            {
                return "It's not looking good for you.";
            }
        }
        
        double PercentCorrect() 
        {
            
            percent = ((double)numCorrect / 37) * 100;
            Console.WriteLine(percent);
            return percent;
        }

        void AnyKeyDone()
        {
            this.MoveToScreen(Game1.GetNextLevel());
        }

        void CollapseWrongAnswers()
        {
            canClick = false;
            if (!IsRightAnswer(0))
            {
                canRollOver = false;
                XButtoninst.RotationX = 5;
                XButtoninst.RotationY = 5;
                answerXText.DisplayText = "X)";
            }
            if (!IsRightAnswer(1))
            {
                canRollOver = false;
                YButtonInst.RotationX = 5;
                YButtonInst.RotationY = 5;
                answerYText.DisplayText = "Y)";
            }
            if (!IsRightAnswer(2))
            {
                canRollOver = false;
                BButtonInst.RotationX = 5;
                BButtonInst.RotationY = 5;
                answerBText.DisplayText = "B)";
            }
            if (!IsRightAnswer(3))
            {
                canRollOver = false;
                AButtonInst.RotationX = 5;
                AButtonInst.RotationY = 5;
                answerAText.DisplayText = "A)";
            }
        }

        void AddAnswerToList(int choice) 
        {
            questions[questionIndex].Choice = choice;
            answeredQuestions.Add(questions[questionIndex]);
        }

        void ResetTextColors()
        {
            answerAText.SetColor(255, 255, 255);
            answerBText.SetColor(255, 255, 255);
            answerXText.SetColor(255, 255, 255);
            answerYText.SetColor(255, 255, 255);

        }

        void InflateAllAnswers()
        {
            canClick = true;
            canRollOver = true;
            XButtoninst.RotationX = 0;
            XButtoninst.RotationY = 0;
            XButtoninst.RotationZ = 0;
            YButtonInst.RotationX = 0;
            YButtonInst.RotationY = 0;
            YButtonInst.RotationZ = 0;
            BButtonInst.RotationX = 0;
            BButtonInst.RotationY = 0;
            BButtonInst.RotationZ = 0;
            AButtonInst.RotationX = 0;
            AButtonInst.RotationY = 0;
            AButtonInst.RotationZ = 0;

        }

        public bool IsRightAnswer(int index)
        {
            if (questions[questionIndex].answerIndex == index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRightAnswerReview(int index) 
        {
            if (answeredQuestions[reviewIndex].answerIndex == index)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }


        void NextQuestionVisible()
        {
            this.StartButtonInst.Visible = true;
            if (questionIndex > 36)
            {
                this.NextQuestion.DisplayText = "Done";
            }
        }

        void NextQuestionNotVisible()
        {
            if (questionIndex < 37)
            {
                this.StartButtonInst.Visible = false;
            }
            else
                EndQuiz();
        }

        void EndQuiz()
        {
            this.XButtoninst.Visible = false;
            this.YButtonInst.Visible = false;
            this.BButtonInst.Visible = false;
            this.AButtonInst.Visible = false;
        }

        void ReviewQuiz() 
        {
            reviewQuestions = true;
            InflateAllAnswers();
            LeftBumperInstance.Visible = false;
            SetUpKey();
            DisplayReview();
            //Highlight Right answer and wrong answer if chosen
        }

        void SetUpKey() 
        {
            keyText.DisplayText = string.Format("X) Previous Question\nY) Main Menu\nB) Next Question\nA) Restart Quiz");
            keyText.X = 90;
            keyText.Y = -60;
        }
        
        void DisplayReview()
        {
            int choice = answeredQuestions[reviewIndex].Choice;
            questionText.DisplayText = answeredQuestions[reviewIndex].QuestionText;
            questionText.Scale = 8f;
            questionText.Spacing = 8;
            questionText.X = -200;
            questionText.Y = 100;

            answerXText.DisplayText = string.Format("X)   {0}", answeredQuestions[reviewIndex].answerList[0]);
            answerXText.Scale = 6f;
            answerXText.Spacing = 6;
            answerXText.X = -130;
            answerXText.Y = 60;

            answerYText.DisplayText = string.Format("Y)   {0}", answeredQuestions[reviewIndex].answerList[1]);
            answerYText.Scale = 6f;
            answerYText.Spacing = 6;
            answerYText.X = -130;
            answerYText.Y = 20;

            answerBText.DisplayText = string.Format("B)   {0}", answeredQuestions[reviewIndex].answerList[2]);
            answerBText.Scale = 6f;
            answerBText.Spacing = 6;
            answerBText.X = -130;
            answerBText.Y = -20;

            answerAText.DisplayText = string.Format("A)   {0}", answeredQuestions[reviewIndex].answerList[3]);
            answerAText.Scale = 6f;
            answerAText.Spacing = 6;
            answerAText.X = -130;
            answerAText.Y = -60;

            if (IsRightAnswerReview(0)) 
            {
                answerXText.SetColor(0, 255, 0);
            }

            else if (IsRightAnswerReview(1))
            {
                answerYText.SetColor(0, 255, 0);
            }

            else if (IsRightAnswerReview(2))
            {
                answerBText.SetColor(0, 255, 0);
            }

            else if (IsRightAnswerReview(3))
            {
                answerAText.SetColor(0, 255, 0);
            }

            if (!IsRightAnswerReview(choice))
            {
                if(choice == 0)
                {
                    answerXText.SetColor(255,0,0);
                }
                if(choice == 1)
                {
                    answerYText.SetColor(255,0,0);
                }   
                if(choice == 2)
                {
                    answerBText.SetColor(255,0,0);
                }   
                if(choice == 3)
                {
                    answerAText.SetColor(255, 0, 0);
                }   
            }
        }

        void UpdateNumCorrect()
        {
            this.NumberCorrect.CurrentState = Button.VariableState.Hover;
            string score = string.Format("{0} out of {1}", numCorrect, questionIndex);
            NumberCorrect.DisplayText = (score);
        }

        public void ResetDisplayColors()
        {
            answerXText.SetColor(250, 250, 250);
            answerYText.SetColor(250, 250, 250);
            answerBText.SetColor(250, 250, 250);
            answerAText.SetColor(250, 250, 250);
        }

    }
}
