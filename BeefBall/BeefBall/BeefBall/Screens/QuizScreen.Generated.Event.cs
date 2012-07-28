using System;
using FlatRedBall;
using FlatRedBall.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using BeefBall.Entities;
using BeefBall.Entities.GameScreen;
using BeefBall.Screens;
namespace BeefBall.Screens
{
	public partial class QuizScreen
	{
		void OnNextQuestionClickTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.NextQuestionClick != null)
			{
				NextQuestionClick(callingWindow);
			}
		}
	}
}
