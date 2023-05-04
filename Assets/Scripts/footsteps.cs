using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound, jumpSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            jumpSound.enabled = true;
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
        else if(Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.D))))){
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
                jumpSound.enabled = false;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
                jumpSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
            jumpSound.enabled = false;
        }
    }
}

