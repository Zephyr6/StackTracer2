using System;
using System.Collections.Generic;
using BeefBall.Entities;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;

using FlatRedBall.Graphics.Model;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;
using FlatRedBall.Localization;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
using System.IO;
using FlatRedBall.Graphics;
#endif

namespace BeefBall.Screens
{
    public partial class QuizScreenCopy
    {
        private int tries = 37;
        private int correctAnswers = 0;
        private List<Question> questions = new List<Question>();
        Text questionText = TextManager.AddText("");
        Text answerXText = TextManager.AddText("");
        Text answerYText = TextManager.AddText("");
        Text answerBText = TextManager.AddText("");
        Text answerAText = TextManager.AddText("");
        Text keyText = TextManager.AddText("");
        Xbox360GamePad GamePad;
        static Random rnd;

        //TextArial ta = new TextArial();
        void CustomInitialize()
        {
            InitializeCustomEvents();
            FlatRedBallServices.IsWindowsCursorVisible = true;
            StartButtonInst.Visible = false;
            NextQuestion.Visible = false;
            ReadInCSV();
            RandomizeQuestions();
            DisplayQuestions();
            GamePad = InputManager.Xbox360GamePads[0];
        }

        void CustomActivity(bool firstTimeCalled)
        {
            XButtonPress();
            YButtonPress();
            AButtonPress();
            BButtonPress();
            LeftBumperPress();

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
            TextManager.RemoveText(keyText);

        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        public void InitializeCustomEvents()
        {
            XButtoninst.Click += OnXBoxXButtonClick;
            XButtoninst.RollOn += OnXboxXButtonRollOn;
            XButtoninst.RollOff += OnXBoxXButtonRollOff;

            YButtonInst.Click += onXBoxYButtonClick;
            YButtonInst.RollOn += OnXboxYButtonRollOn;
            YButtonInst.RollOff += OnXBoxYButtonRollOff;

            AButtonInst.RollOn += OnXboxAButtonRollOn;
            AButtonInst.Click += OnXBoxAButtonClick;
            AButtonInst.RollOff += OnXBoxAButtonRollOff;

            BButtonInst.Click += OnXBoxBButtonClick;
            BButtonInst.RollOn += OnXboxBButtonRollOn;
            BButtonInst.RollOff += OnXBoxBButtonRollOff;

            StartButtonInst.Click += OnStartButtonClick;

            LeftBumperInstance.Click += OnLbButtonClick;
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

        public void RandomizeQuestions()
        {
            int count = questions.Count;
            rnd = new Random();
            while (count > 1)
            {
                count--;
                int index = rnd.Next(count + 1);
                Question value = questions[index];
                questions[index] = questions[count];
                questions[count] = value;
            } 
        }


        public void DisplayQuestions()
        {
            questionText.DisplayText = questions[questionIndex].QuestionText;
            questionText.Scale = 8f;
            questionText.Spacing = 8;
            questionText.X = -200;
            questionText.Y = 100;

            answerXText.DisplayText = string.Format("X)   {0}", questions[questionIndex].answerList[0]);
            answerXText.Scale = 6f;
            answerXText.Spacing = 6;
            answerXText.X = -130;
            answerXText.Y = 60;

            answerYText.DisplayText = string.Format("Y)   {0}", questions[questionIndex].answerList[1]);
            answerYText.Scale = 6f;
            answerYText.Spacing = 6;
            answerYText.X = -130;
            answerYText.Y = 20;

            answerBText.DisplayText = string.Format("B)   {0}", questions[questionIndex].answerList[2]);
            answerBText.Scale = 6f;
            answerBText.Spacing = 6;
            answerBText.X = -130;
            answerBText.Y = -20;

            answerAText.DisplayText = string.Format("A)   {0}", questions[questionIndex].answerList[3]);
            answerAText.Scale = 6f;
            answerAText.Spacing = 6;
            answerAText.X = -130;
            answerAText.Y = -60;
        }
    }
}