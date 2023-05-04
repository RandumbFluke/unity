using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController2 : MonoBehaviour
{

    public Animator animator, gunAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("turningTrigger", true);
            gunAnimator.SetBool("gunWalking", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("turningTrigger", false);
            gunAnimator.SetBool("gunWalking", false);
        }
    }
}
