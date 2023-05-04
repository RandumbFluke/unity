using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunNoise : MonoBehaviour
{


    AudioSource pewSound;
    // Start is called before the first frame update
    void Start()
    {
        pewSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pewSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            pewSound.Stop();
        }
    }
}
