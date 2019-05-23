using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{

    public AudioClip Sonido;


    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = Sonido;
        GetComponent<AudioSource>().enabled = true;

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player") GetComponent<AudioSource>().Play();

    }
}

