using System;

namespace BeefBall.Screens
{
    public partial class QuizScreen
    {
        void OnNextQuestionClickTunnel(FlatRedBall.Gui.IWindow callingWindow)
        {
            if (this.NextQuestionClick != null)
            {
                NextQuestionClick(callingWindow);
            }
        }
    }
}