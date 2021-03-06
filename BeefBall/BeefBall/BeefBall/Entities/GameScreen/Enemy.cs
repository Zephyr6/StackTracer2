using System;
using System.Collections.Generic;
using FlatRedBall;
using FlatRedBall.Graphics;
#if FRB_XNA || SILVERLIGHT
using Vector3 = Microsoft.Xna.Framework.Vector3;

#endif

namespace BeefBall.Entities.GameScreen
{
    public partial class Enemy
    {
        public bool canBeHit = true;
        public bool isDead;
        public bool engaged;

        int facing;
        int speed = 30;

        bool isWalking = false;
        double idleDelay = 1;
        double timeIdle;

        double delay = 0.5;
        double timeHit = 0;
        double timeWalking;

        int mHealth;
        public int Health
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;
            }
        }
        HealthBar mHealthBar;
        private List<Text> damageTexts;

        private void CustomInitialize()
        {
            damageTexts = new List<Text>();
            Health = StartingHealth;
            mHealthBar = new HealthBar(ContentManagerName, false);
            mHealthBar.AddToManagers(LayerProvidedByContainer);
            mHealthBar.X = X;
            mHealthBar.Y = Y + 20;
            mHealthBar.AttachTo(this, true);
            mHealthBar.Visible = false;
            Acceleration.Y = -40F;

            Velocity.X = -speed;
            CurrentState = VariableState.L_Walking;
            facing = Game1.LEFT;

            PathArea.X = X - (PathArea.ScaleX / 2) + (Body.Radius);
            PathArea.Y = Y;
            PathArea.Acceleration = Vector3.Zero;
        }

        private void CustomActivity()
        {
            if (!isDead)
            {
                if (CurrentState != VariableState.L_Hurt && CurrentState != VariableState.R_Hurt && CurrentState != VariableState.L_Die && CurrentState != VariableState.R_Die)
                    PathActivity();

                HitActivity();
                DamageTextActivity();
            }
        }

        void PathActivity()
        {
            if (isWalking)
            {
                if (!Body.CollideAgainst(PathArea))
                {
                    if (TimeManager.SecondsSince(timeWalking) >= delay)
                    {
                        timeIdle = TimeManager.CurrentTime;
                        isWalking = false;

                        if (facing == Game1.LEFT)
                            CurrentState = VariableState.L_Idle;
                        else
                            CurrentState = VariableState.R_Idle;

                        Velocity.X = 0;
                        isWalking = false;
                    }
                }
            }
            else
            {
                if (TimeManager.SecondsSince(timeIdle) >= idleDelay)
                {
                    if (facing == Game1.LEFT)
                    {
                        Velocity.X = speed;
                        CurrentState = VariableState.R_Walking;
                        facing = Game1.RIGHT;
                    }
                    else
                    {
                        Velocity.X = -speed;
                        CurrentState = VariableState.L_Walking;
                        facing = Game1.LEFT;
                    }
                    timeWalking = TimeManager.CurrentTime;
                    isWalking = true;
                }
            }

            if (ViewArea.CollideAgainst(Game1.Player.Body))
            {
                if (LeftAttack.CollideAgainst(Game1.Player.Body))
                {
                    CurrentState = VariableState.L_Attack;
                    Game1.Player.Hurt(10, Game1.RIGHT);
                    Velocity.X = 0;
                }
                else if (RightAttack.CollideAgainst(Game1.Player.Body))
                {
                    CurrentState = VariableState.R_Attack;
                    Game1.Player.Hurt(10, Game1.LEFT);
                    Velocity.X = 0;
                }
                else
                {
                    if (Game1.Player.X > X)
                    {
                        Velocity.X = speed;
                        CurrentState = VariableState.R_Walking;
                    }
                    else if (Game1.Player.X < X)
                    {
                        Velocity.X = -speed;
                        CurrentState = VariableState.L_Walking;
                    }
                }
            }
        }

        void HitActivity()
        {
            mHealthBar.RatioFull = Health / (float)StartingHealth;

            if (timeHit != 0)
            {
                if (TimeManager.SecondsSince(timeHit) >= delay)
                {
                    if (Health > 0)
                    {
                        canBeHit = true;
                        timeHit = 0;

                        if (facing == Game1.LEFT)
                        {
                            Velocity.X = -speed;
                            CurrentState = VariableState.L_Walking;
                        }
                        else
                        {
                            Velocity.X = speed;
                            CurrentState = VariableState.R_Walking;
                        }
                    }
                    else
                        this.Destroy();
                }
            }
        }

        private void DamageTextActivity()
        {
            List<Text> textToRemove = new List<Text>();

            foreach (Text t in damageTexts)
            {
                if (t.Alpha <= 0)
                {
                    textToRemove.Add(t);
                }
            }

            foreach (Text t in textToRemove)
            {
                damageTexts.Remove(t);
            }
        }

        public void Hurt(int damage)
        {
            mHealthBar.Visible = true;
            AddDamageText(damage);

            Health -= damage;
            canBeHit = false;
            Velocity.X = 0;

            timeHit = TimeManager.CurrentTime;
            CurrentState = VariableState.L_Hurt;

            if (Health <= 0)
                Kill();
        }

        void AddDamageText(int amount)
        {
            Random rnd = new Random();

            Text dmgText = TextManager.AddText("-" + amount, this.LayerProvidedByContainer);

            dmgText.Velocity.Y = 40;
            dmgText.Velocity.X = rnd.Next(-15, 15);
            dmgText.SetColor(255, 0, 0);
            dmgText.AlphaRate = -0.4F;
            dmgText.Position = new Vector3(Body.X + Body.Radius, Body.Y + Body.Radius, Body.Z);
            dmgText.Scale += 3;

            damageTexts.Add(dmgText);
        }

        public void Kill()
        {
            delay = 1.5;
            CurrentState = VariableState.L_Die;
            Velocity.X += 30;
            Velocity.Y += 30;
        }

        private void CustomDestroy()
        {
            foreach (Text t in damageTexts)
                TextManager.RemoveText(t);

            mHealthBar.Destroy();
            isDead = true;
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
        }
    }
}