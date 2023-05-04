using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke_controller : MonoBehaviour
{

    public ParticleSystem smoke;
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
            smoke.Play();
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            smoke.Stop();
        }
    }
}
