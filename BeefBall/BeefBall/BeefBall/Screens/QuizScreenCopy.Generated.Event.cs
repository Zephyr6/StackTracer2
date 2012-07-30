using System;

namespace BeefBall.Screens
{
    public partial class QuizScreenCopy
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