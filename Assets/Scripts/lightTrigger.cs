using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTrigger : MonoBehaviour
{
    public GameObject light;
    AudioSource lightSwitch;

    // Start is called before the first frame update
    void Start()
    {
        light.GetComponent<Light>().enabled = false;
        lightSwitch = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            light.GetComponent<Light>().enabled = true;
            lightSwitch.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            light.GetComponent<Light>().enabled = false;
            lightSwitch.Stop();
        }
    }
}
