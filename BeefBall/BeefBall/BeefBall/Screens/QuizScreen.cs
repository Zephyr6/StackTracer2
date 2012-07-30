using System;
using System.Collections.Generic;
using BeefBall.Entities;
using FlatRedBall;
using FlatRedBall.Input;
#if FRB_XNA || SILVERLIGHT
using System.IO;
using FlatRedBall.Graphics;
using Microsoft.Xna.Framework.Media;

#endif

namespace BeefBall.Screens
{
    public partial class QuizScreen
    {
        private int tries = 3;
        private int correctAnswers = 0;
        private List<Question> questions = new List<Question>();
        private Question[] threeQuestions = new Question[3];
        Text questionText = TextManager.AddText("");
        Text answerXText = TextManager.AddText("");
        Text answerYText = TextManager.AddText("");
        Text answerBText = TextManager.AddText("");
        Text answerAText = TextManager.AddText("");
        Text headerText = TextManager.AddText("");
        Xbox360GamePad GamePad;
        static string songManager = "ContentManager";
        static Song song = FlatRedBallServices.Load<Song>(@"Content/Acrostics", songManager);

        void CustomInitialize()
        {
            Microsoft.Xna.Framework.Media.MediaPlayer.Play(song);
            InitializeCustomEvents();
            InitializeHeaderText();
            FlatRedBallServices.IsWindowsCursorVisible = true;
            StartButtonInst.Visible = false;
            NextQuestion.Visible = false;
            ReadInCSV();
            Select3RandomQuestions();
            DisplayQuestions();
            GamePad = InputManager.Xbox360GamePads[0];
        }

        void CustomActivity(bool firstTimeCalled)
        {
            XButtonPress();
            YButtonPress();
            AButtonPress();
            BButtonPress();

            if (canClick == false)
            {
                if (GamePad.ButtonPushed(Xbox360GamePad.Button.Start))
                    NextQuestionAdvance();
            }
        }

        void CustomDestroy()
        {
            TextManager.RemoveText(questionText);
            TextManager.RemoveText(answerAText);
            TextManager.RemoveText(answerBText);
            TextManager.RemoveText(answerXText);
            TextManager.RemoveText(answerYText);
            TextManager.RemoveText(headerText);
            Microsoft.Xna.Framework.Media.MediaPlayer.Stop();
        }

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }

        public void InitializeCustomEvents() 
        {
            XButtoninst.Click += OnXBoxXButtonClick;
            XButtoninst.RollOn += OnXboxXButtonRollOn;
            XButtoninst.RollOff += OnXBoxXButtonRollOff;
            
            YButtonInst.Click += OnXBoxYButtonClick;
            YButtonInst.RollOn += OnXboxYButtonRollOn;
            YButtonInst.RollOff += OnXBoxYButtonRollOff;
            
            AButtonInst.RollOn += OnXboxAButtonRollOn;
            AButtonInst.Click += OnXBoxAButtonClick;
            AButtonInst.RollOff += OnXBoxAButtonRollOff;
            
            BButtonInst.Click += OnXBoxBButtonClick;
            BButtonInst.RollOn += OnXboxBButtonRollOn;
            BButtonInst.RollOff += OnXBoxBButtonRollOff;

            StartButtonInst.Click += OnStartButtonClick;
        }

        public void ReadInCSV()
        {
            using (StreamReader input = new StreamReader("qa.csv"))
            {
                string line;
                string[] lineList;
                while ((line = input.ReadLine()) != null)
                {
                    lineList = line.Split(',');
                    Question q = new Question();
                    q.QuestionText = lineList[0];
                    q.CorrectAnswer = lineList[1];
                    q.WrongAnswer1 = lineList[2];
                    q.WrongAnswer2 = lineList[3];
                    q.WrongAnswer3 = lineList[4];
                    q.SetAnswers();
                    questions.Add(q);
                }
            }
        }

        public void Select3RandomQuestions()
        {
            int indexQuestion1;
            int indexQuestion2;
            int indexQuestion3;
            int listSize = 0;

            Random rnd = new Random();

            foreach (Question q in questions)
            {
                listSize++;
            }

            indexQuestion1 = rnd.Next(listSize);

            do
            {
                indexQuestion2 = rnd.Next(listSize);
            }
            while (indexQuestion2 == indexQuestion1);

            do
            {
                indexQuestion3 = rnd.Next(listSize);
            }
            while (indexQuestion3 == indexQuestion1 || indexQuestion3 == indexQuestion2);

            threeQuestions[0] = questions[indexQuestion1];
            threeQuestions[1] = questions[indexQuestion2];
            threeQuestions[2] = questions[indexQuestion3];
        }

        public void InitializeHeaderText() 
        {
            headerText.Scale = 8f;
            headerText.Spacing = 8;
            headerText.X = -200;
            headerText.Y = 140;
            headerText.SetColor(0, 255, 255);
            headerText.DisplayText = "Must get 3 questions correct to advance";
        }
        
        public void DisplayQuestions()
        {
            questionText.DisplayText = threeQuestions[questionIndex].QuestionText;
            questionText.Scale = 8f;
            questionText.Spacing = 8;
            questionText.X = -200;
            questionText.Y = 100;

            answerXText.DisplayText = string.Format("X)   {0}", threeQuestions[questionIndex].answerList[0]);
            answerXText.Scale = 6f;
            answerXText.Spacing = 6;
            answerXText.X = -130;
            answerXText.Y = 60;

            answerYText.DisplayText = string.Format("Y)   {0}", threeQuestions[questionIndex].answerList[1]);
            answerYText.Scale = 6f;
            answerYText.Spacing = 6;
            answerYText.X = -130;
            answerYText.Y = 20;

            answerBText.DisplayText = string.Format("B)   {0}", threeQuestions[questionIndex].answerList[2]);
            answerBText.Scale = 6f;
            answerBText.Spacing = 6;
            answerBText.X = -130;
            answerBText.Y = -20;

            answerAText.DisplayText = string.Format("A)   {0}", threeQuestions[questionIndex].answerList[3]);
            answerAText.Scale = 6f;
            answerAText.Spacing = 6;
            answerAText.X = -130;
            answerAText.Y = -60;
        }

        void StartButtonActivity()
        {
            NextQuestionAdvance();
        }

        void AActivity()
        {
            if (questionIndex < 3 && canClick)
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

                ButtonPressCommonActivity();
            }
        }

        void BActivity()
        {
            if (questionIndex < 3 && canClick)
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
                ButtonPressCommonActivity();
            }
        }

        void XActivity()
        {
            if (questionIndex < 3 && canClick)
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
                ButtonPressCommonActivity();
            }
        }

        void YActivity()
        {
            if (questionIndex < 3 && canClick)
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
                ButtonPressCommonActivity();
            }
        }

        void ButtonPressCommonActivity()
        {
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
            if (questionIndex < 3)
            {
                DisplayQuestions();
                InflateAllAnswers();
            }
            NextQuestionNotVisible();

            if (questionIndex > 2)
            {
                if (numCorrect == 3)
                {
                    this.MoveToScreen(Game1.GetNextLevel());
                }
                else
                {
                    this.MoveToScreen(typeof(QuizScreen).FullName);
                }
            }
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
            if (threeQuestions[questionIndex].answerIndex == index)
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
            if (questionIndex > 2)
            {
                this.NextQuestion.DisplayText = "Done";
            }
        }

        void NextQuestionNotVisible()
        {
            if (questionIndex < 3)
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

        void UpdateNumCorrect()
        {
            this.NumberCorrect.CurrentState = Button.VariableState.Hover;
            string score = string.Format("{0} out of {1}", numCorrect, questionIndex);
            NumberCorrect.DisplayText = (score);
        }
    }
}