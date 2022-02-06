using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsLive : MonoBehaviour
{
    private AudioSource audioSource;
    /*[SerializeField] private AudioClip audioClip;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bolt")
        {
            //audioSource.Play();
            Destroy(gameObject);
        }
        
    }

}
