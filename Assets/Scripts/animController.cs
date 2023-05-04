using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{

    public Animator animator, animator2, gunAnimator, gunAnimator2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("turningTrigger", true);
            animator2.SetBool("turningTrigger", true);
            gunAnimator.SetBool("gunWalking", true);
            gunAnimator2.SetBool("gunWalking", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("turningTrigger", false);
            animator2.SetBool("turningTrigger", false);
            gunAnimator.SetBool("gunWalking", false);
            gunAnimator2.SetBool("gunWalking", false);
        }
    }
}
