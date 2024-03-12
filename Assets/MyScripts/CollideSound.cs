using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSound : MonoBehaviour
{
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = sound;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("Music");
    }
}
