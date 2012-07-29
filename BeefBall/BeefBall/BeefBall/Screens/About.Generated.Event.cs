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
	public partial class About
	{
		void OnBackClickTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.BackClick != null)
			{
				BackClick(callingWindow);
			}
		}
		void OnBackRollOffTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.BackRollOff != null)
			{
				BackRollOff(callingWindow);
			}
		}
		void OnBackRollOnTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.BackRollOn != null)
			{
				BackRollOn(callingWindow);
			}
		}
		void OnProjectButtonClickTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.ProjectButtonClick != null)
			{
				ProjectButtonClick(callingWindow);
			}
		}
		void OnProjectButtonRollOffTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.ProjectButtonRollOff != null)
			{
				ProjectButtonRollOff(callingWindow);
			}
		}
		void OnProjectButtonRollOnTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.ProjectButtonRollOn != null)
			{
				ProjectButtonRollOn(callingWindow);
			}
		}
		void OnQuizButtonClickTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.QuizButtonClick != null)
			{
				QuizButtonClick(callingWindow);
			}
		}
		void OnQuizButtonRollOffTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.QuizButtonRollOff != null)
			{
				QuizButtonRollOff(callingWindow);
			}
		}
		void OnQuizButtonRollOnTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.QuizButtonRollOn != null)
			{
				QuizButtonRollOn(callingWindow);
			}
		}
		void OnStoryButtonClickTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.StoryButtonClick != null)
			{
				StoryButtonClick(callingWindow);
			}
		}
		void OnStoryButtonRollOffTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.StoryButtonRollOff != null)
			{
				StoryButtonRollOff(callingWindow);
			}
		}
		void OnStoryButtonRollOnTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.StoryButtonRollOn != null)
			{
				StoryButtonRollOn(callingWindow);
			}
		}
		void OnTeamButtonClickTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.TeamButtonClick != null)
			{
				TeamButtonClick(callingWindow);
			}
		}
		void OnTeamButtonRollOffTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.TeamButtonRollOff != null)
			{
				TeamButtonRollOff(callingWindow);
			}
		}
		void OnTeamButtonRollOnTunnel (FlatRedBall.Gui.IWindow callingWindow)
		{
			if (this.TeamButtonRollOn != null)
			{
				TeamButtonRollOn(callingWindow);
			}
		}
	}
}
