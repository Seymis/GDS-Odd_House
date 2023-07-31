using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCard : MonoBehaviour
{
    public Animator titleCardAnimator;

    public string titleCardBoolean;
    private void OnTriggerEnter(Collider other)
    {
        //plays the animation attached to the title - uses on trigger
        titleCardAnimator.SetBool(titleCardBoolean, true);
    }

}
