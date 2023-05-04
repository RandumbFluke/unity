using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSFX : MonoBehaviour
{

    AudioSource fireSound;

    // Start is called before the first frame update
    void Start()
    {
        fireSound = GetComponent<AudioSource>();
    }

    void update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            fireSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            fireSound.Stop();
        }
    }
}
