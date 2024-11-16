using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator currentAnimator;
    public bool instance;
    public int index = 0;

    public void setIndex(int index)
    {
        if (instance && currentAnimator != null)
        {
            currentAnimator.SetInteger("index", index);
            this.index = index;
        }
    }
    public void setCurrentAnimator([SerializeField] Animator i)
    {
        if (instance == false && currentAnimator == null)
        {
            currentAnimator = i;
            instance = true;
            currentAnimator.SetInteger("index", 0);
        }
    }

    public void resetAnimatorManager()
    {
        instance = false;
        currentAnimator = null;
        index = 0;
    }
}
