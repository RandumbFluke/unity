using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huntingNarration : MonoBehaviour
{
    AudioSource huntNarration;

    // Start is called before the first frame update
    void Start()
    {
        huntNarration = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused)
        {
            huntNarration.Stop();
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            huntNarration.Play();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            huntNarration.Stop();
        }
    }
}
