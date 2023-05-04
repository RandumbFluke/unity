using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundflame_cotroller : MonoBehaviour
{

    public ParticleSystem groundFlame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            groundFlame.Play();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            groundFlame.Stop();
        }
    }
}
