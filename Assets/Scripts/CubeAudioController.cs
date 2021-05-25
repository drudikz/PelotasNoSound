using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudioController : MonoBehaviour
{
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        Renderer rend = GetComponent<Renderer>();
        Bounds bounds = rend.bounds;
        source.pitch = 1f / bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {        
        source.Play();

}

}