using System;
using System.Collections.Generic;
using FlatRedBall;
using FlatRedBall.Input;
using Microsoft.Xna.Framework;
#if FRB_XNA || SILVERLIGHT
#endif

namespace BeefBall.Entities.GameScreen
{
    public partial class Player
    {
        public List<Enemy> enemies { get; set; }

        public Xbox360GamePad mGamePad;
        double timePunched;
        double timeHurt;
        //Text debugText;

        int facing;

        int punchPower = 10;

        int mHealth;
        public int Health { get { return mHealth; } set { mHealth = value; } }

        public int PlayerIndex
        {
            set
            {
                mGamePad = InputManager.Xbox360GamePads[value];
            }
        }

        private void CustomInitialize()
        {
            facing = Game1.RIGHT;
            CurrentState = VariableState.R_Idle;

            this.PlayerIndex = 0;
            Acceleration.Y = -400F;

            //debugText = TextManager.AddText("");
            //debugText.Position.Y += 40;
            //debugText.AttachTo(this, true);
            //UpdateDebugText();

            Health = MaxBatteries * 4;
        }

        private void CustomActivity()
        {
            MoveActivity();

            UpdateDebugText();
        }

        private void CustomDestroy()
        {
            //TextManager.RemoveText(debugText);

        }

        private void MoveActivity()
        {
            Velocity.X = 0;


            // Move left/right
            if (!IsAttacking() || CurrentState == VariableState.Jumping)
            {
                Velocity.X = mGamePad.LeftStick.Position.X * MovementSpeed;

                // Animate
                if (CurrentState != VariableState.Jumping)
                {
                    if (mGamePad.LeftStick.Position.X < 0)
                        CurrentState = VariableState.L_Walking;
                    else if (mGamePad.LeftStick.Position.X > 0)
                        CurrentState = VariableState.R_Walking;
                }
            }

            // Jump
            if (mGamePad.ButtonPushed(Xbox360GamePad.Button.A) && CurrentState != VariableState.Jumping)
            {
                jump.Play();
                Velocity.Y = 200;
                CurrentState = VariableState.Jumping;
            }

            // Idle
            if (mGamePad.LeftStick.Position.X == 0 && !IsAttacking())
            {
                if (CurrentState == VariableState.L_Walking)
                    CurrentState = VariableState.L_Idle;
                else if (CurrentState == VariableState.R_Walking)
                    CurrentState = VariableState.R_Idle;
            }

            AttackActivity();
            if (mGamePad.ButtonPushed(Xbox360GamePad.Button.Y))
                Console.WriteLine(InnerExScene.CurrentChain.TotalLength);
        }

        private bool IsAttacking()
        {
            return timePunched > 0 || CurrentState == VariableState.R_Attack || CurrentState == VariableState.R_Attack2 || CurrentState == VariableState.L_Attack || CurrentState == VariableState.L_Attack2;
        }

        private int GetFacing()
        {
            int dir = facing;

            if (mGamePad.LeftStick.Position.X > 0)
                dir = Game1.RIGHT;
            else if (mGamePad.LeftStick.Position.X < 0)
                dir = Game1.LEFT;

            facing = dir;

            return dir;
        }

        public void Land()
        {
            if (GetFacing() == Game1.RIGHT)
                CurrentState = VariableState.R_Idle;
            else if (GetFacing() == Game1.LEFT)
                CurrentState = VariableState.L_Idle;
        }

        void AttackActivity()
        {
            Random rand = new Random();

            if (mGamePad.ButtonPushed(Xbox360GamePad.Button.B))
            {
                if (CurrentState != VariableState.Jumping)
                    Velocity.X = 0;

                swing2.Play();

                if (!SpriteManager.Camera.IsPointInView(X, Y, 0F))
                    Y = 0;

                if (timePunched != 0)
                {
                    timePunched = TimeManager.CurrentTime;

                    if (CurrentState == VariableState.L_Attack2 || CurrentState == VariableState.R_Attack2)
                    {
                        if (GetFacing() == Game1.RIGHT)
                            CurrentState = VariableState.R_Attack;
                        else if (GetFacing() == Game1.LEFT)
                            CurrentState = VariableState.L_Attack;
                    }
                    else
                    {
                        if (GetFacing() == Game1.RIGHT)
                            CurrentState = VariableState.R_Attack2;
                        else if (GetFacing() == Game1.LEFT)
                            CurrentState = VariableState.L_Attack2;
                    }

                }
                else
                {
                    timePunched = TimeManager.CurrentTime;

                    if (GetFacing() == Game1.RIGHT)
                        CurrentState = VariableState.R_Attack;
                    else
                        CurrentState = VariableState.L_Attack;
                }

                foreach (Entities.GameScreen.Enemy el in enemies)
                {
                    int dmg = rand.Next(punchPower - (punchPower / 3), punchPower + (punchPower / 4));
                    Console.WriteLine("DAMAGE: {0} Min/Max: ({1}, {2})", dmg, punchPower - (punchPower / 3), punchPower + (punchPower / 4));

                    if (GetFacing() == Game1.RIGHT)
                    {
                        if ((RightAttack.CollideAgainst(el.Body) || RightAttack.CollideAgainst(el.Head)) && el.canBeHit)
                        {
                            hit.Play();
                            el.BodyColor = new Color(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                            el.Hurt(dmg);
                            el.Velocity.X = 20;
                        }
                    }
                    else if (GetFacing() == Game1.LEFT)
                    {
                        if ((LeftAttack.CollideAgainst(el.Body) || LeftAttack.CollideAgainst(el.Head)) && el.canBeHit)
                        {
                            hit.Play();
                            el.BodyColor = new Color(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                            el.Hurt(dmg);
                            el.Velocity.X = -20;
                        }
                    }
                }
            }

            if (timePunched > 0 && (TimeManager.SecondsSince(timePunched) >= InnerExScene.CurrentChain.TotalLength))
            {
                if (GetFacing() == Game1.RIGHT)
                    CurrentState = VariableState.R_Idle;
                else if (GetFacing() == Game1.LEFT)
                    CurrentState = VariableState.L_Idle;

                timePunched = 0;
            }

            if (TimeManager.SecondsSince(timeHurt) >= 1.5)
            {
                timeHurt = 0;
            }
        }

        void UpdateDebugText()
        {
            //debugText.DisplayText = string.Format("State: {0}\nFacing: {1}\nHealth: {2}", CurrentState, GetFacing(), Health);
        }

        public void Hurt(double damage, int dir)
        {
            if (timeHurt == 0)
            {
                timeHurt = TimeManager.CurrentTime;
                Health--;
                hurt.Play();
                Velocity.X = (dir == Game1.RIGHT) ? -1000 : 1000;

                if (dir == Game1.LEFT)
                    CurrentState = VariableState.L_Hurt;
                else
                    CurrentState = VariableState.R_Hurt;
            }
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
    }
}
