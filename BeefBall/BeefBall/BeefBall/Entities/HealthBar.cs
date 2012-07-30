using System;
#if FRB_XNA || SILVERLIGHT
#endif

namespace BeefBall.Entities
{
    public partial class HealthBar
    {
        public float RatioFull
        {
            get
            {
                return mRatioFull;
            }
            set
            {
                if (value > 0)
                    mRatioFull = value;
                else
                    Destroy();

                InterpolateBetween(VariableState.Empty, VariableState.Full, mRatioFull);
            }
        }

        bool mVisible;
        public bool Visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                mVisible = value;
                BarSpriteVisible = value;
                BorderSpriteVisible = value;
                FrameSpriteVisible = value;
            }
        }

        private void CustomInitialize()
        {
        }

        private void CustomActivity()
        {
        }

        private void CustomDestroy()
        {
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
        }
    }
}