using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AsteroidsLive : MonoBehaviour
{
    [SerializeField] private float time = 2f;
    [SerializeField] private GameObject asteridMesh;
    [SerializeField] private GameObject explosion;

    public Score Score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bolt")
        {
            Score.UpScore();
            StartCoroutine(asteroidDestroy());
        }else if (other.tag == "EnemyBolt")
        {
            Score.DownScore();
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
