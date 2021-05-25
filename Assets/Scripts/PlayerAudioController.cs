using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{

//ARRAY

    AudioSource[] sources;
    Rigidbody rb;
    float speed = 0.0f;
    bool isPlaying = false;

    

    void Start()

    {
        sources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody>();
        sources[1].pitch = 1.0f / rb.mass;

    }


    void Update()

    {
        speed = rb.velocity.magnitude;
        if (speed > 0.1f && ! isPlaying) {
            isPlaying = true;
            sources[0].Play();

        }   else if (speed < 0.1f && isPlaying){
            isPlaying = false;
            sources[0].Stop();
        }

            sources[0].pitch = speed / rb.mass;

    }
        
    
 void OnCollisionEnter(Collision collision)
 
 {

 print("collision");
 sources[1].Play();
        
        }

}

