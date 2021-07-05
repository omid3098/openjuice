// Copyright (c) 2020 Omid Saadat (@omid3098)
using UnityEngine;

namespace OD.OpenJuice
{
    public class ButtonStopMusic : BaseButton
    {
        [SerializeField] AudioClip clip = null;
        protected override void OnPressed() => Juicer.Instance.StopMusic(clip);
    }
}