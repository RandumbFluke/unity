using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioChatter : MonoBehaviour
{

    AudioSource radioSound;

    // Start is called before the first frame update
    void Start()
    {
        radioSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            radioSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            radioSound.Stop();
        }
    }
}
