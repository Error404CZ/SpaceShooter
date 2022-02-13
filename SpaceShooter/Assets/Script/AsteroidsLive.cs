using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsLive : MonoBehaviour
{
    [SerializeField] private float time = 2f;
    [SerializeField] private GameObject asteridMesh;
    [SerializeField] private GameObject explosion;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bolt")
        {
            StartCoroutine(asteroidDestroy());
        }
        
    }

    IEnumerator asteroidDestroy()
    {
        asteridMesh.SetActive(false);
        explosion.SetActive(true);
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}
