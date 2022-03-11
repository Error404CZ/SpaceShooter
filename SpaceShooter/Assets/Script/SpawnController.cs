using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnController : MonoBehaviour
{
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject asteroid3;
    private int asteroidModel;
    private Vector3 aPosition;
    private Vector3 ePosition;
    public GameObject enemy;

    public float aSpawnRate = 1f;
    private float randomSpawnRate;
    [SerializeField] private float randomSpawnRate1;
    [SerializeField] private float randomSpawnRate2;
    
    
    [HideInInspector] public bool aSpawnOn = true;
    [HideInInspector] public bool eSpawnOn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        aPosition.y = 31f;
        aPosition.z = 7f;
        ePosition.y = 31f;
        ePosition.z = 7f;
        StartCoroutine(SpawnAsteroids());
        StartCoroutine(SpawnEnemy());
    }

    
    IEnumerator SpawnAsteroids()
    {
        while (aSpawnOn)
        {
            yield return new WaitForSeconds(aSpawnRate);
            asteroidModel = Random.Range(0, 3);
            aPosition.x = Random.Range(-6.4f, 6.5f);
            if (asteroidModel==1)
            {
                GameObject newInstance = Instantiate(asteroid1);
                newInstance.transform.position = aPosition;
                
            }else if (asteroidModel == 2)
            {
                GameObject newInstance = Instantiate(asteroid2);
                newInstance.transform.position = aPosition;
                
            }
            else
            {
                GameObject newInstance = Instantiate(asteroid3);
                newInstance.transform.position = aPosition;
                
            }
                
        }
    }

    IEnumerator SpawnEnemy()
    {
        while (eSpawnOn)
        {
            randomSpawnRate = Random.Range(randomSpawnRate1-1, randomSpawnRate2);
            yield return new WaitForSeconds(randomSpawnRate);
            GameObject newInstance = Instantiate(enemy);
            ePosition.x = Random.Range(-6.4f, 6.5f);
            newInstance.transform.position = ePosition;
        }
    }
}
