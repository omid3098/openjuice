#if UI_EFFECT

using Coffee.UIEffects;
using UnityEngine;
// Copyright (c) 2020 Omid Saadat (@omid3098)

namespace OD.OpenJuice
{
    public class TransitionEffect : Effect
    {
        [SerializeField] UITransitionEffect transitionEffect;

        public void Show()
        {
            gameObject.SetActive(true);
            transitionEffect.Show();
        }
        public void Hide()
        {
            transitionEffect.Hide();
        }
        internal double Duration => transitionEffect.effectPlayer.duration;
    }
}
#endif
