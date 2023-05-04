using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loggingNarration : MonoBehaviour
{
    AudioSource deforestationNarration;

    // Start is called before the first frame update
    void Start()
    {
        deforestationNarration = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused)
        {
            deforestationNarration.Stop();
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            deforestationNarration.Play();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            deforestationNarration.Stop();
        }
    }
}