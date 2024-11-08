using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggers : MonoBehaviour
{
    private Player player => GetComponentInParent<Player>();

    public void AnimationTrigger()
    {
        player.slidePS.Play();
    }
    public void AnimationFinishTrigger()
    {
        player.AnimationFinishTrigger();
    }
}
