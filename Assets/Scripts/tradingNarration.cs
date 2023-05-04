using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tradingNarration : MonoBehaviour
{
    AudioSource tradeNarration;

    // Start is called before the first frame update
    void Start()
    {
        tradeNarration = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused)
        {
            tradeNarration.Stop();
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            tradeNarration.Play();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            tradeNarration.Stop();
        }
    }
}
