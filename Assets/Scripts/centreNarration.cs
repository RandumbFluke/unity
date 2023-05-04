using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centreNarration : MonoBehaviour
{
    AudioSource startNarration;

    // Start is called before the first frame update
    void Start()
    {
        startNarration = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused)
        {
            startNarration.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            startNarration.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            startNarration.Stop();
        }
    }
}
