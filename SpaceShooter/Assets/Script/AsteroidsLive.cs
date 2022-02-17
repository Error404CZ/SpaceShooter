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
    private Score Score;
    [SerializeField] private GameObject ScoreManager;

    private void Start()
    {
        Score = ScoreManager.GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bolt")
        {
            StartCoroutine(asteroidDestroy());
            Score.UpScore();
        }
        
    }

    IEnumerator asteroidDestroy()
    {
        asteridMesh.SetActive(false);
        //Score.UpScore();
        explosion.SetActive(true);
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}
