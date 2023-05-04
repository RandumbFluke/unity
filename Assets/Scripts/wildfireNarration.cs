using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wildfireNarration : MonoBehaviour
{
    AudioSource fireNarration;

    // Start is called before the first frame update
    void Start()
    {
        fireNarration = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused)
        {
            fireNarration.Stop();
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            fireNarration.Play();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            fireNarration.Stop();
        }
    }
}
