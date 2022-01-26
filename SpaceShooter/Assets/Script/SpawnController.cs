using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject asteroid3;
    private int asteroidModel;
    private Vector3 position;

    public float spawnRate = 1f;
    
    [HideInInspector] 
    public bool spawnOn = true;
    // Start is called before the first frame update
    void Start()
    {
        position.y = 31f;
        position.z = 7f;
        StartCoroutine(SpawnAsteroids());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator SpawnAsteroids()
    {
        while (spawnOn)
        {
            yield return new WaitForSeconds(spawnRate);
            asteroidModel = Random.Range(0, 3);
            position.x = Random.Range(-6.4f, 6.5f);
            if (asteroidModel==1)
            {
                GameObject newInstance = Instantiate(asteroid1);
                newInstance.transform.position = position;
            }else if (asteroidModel == 2)
            {
                GameObject newInstance = Instantiate(asteroid2);
                newInstance.transform.position = position;
            }
            else
            {
                GameObject newInstance = Instantiate(asteroid3);
                newInstance.transform.position = position;
            }
                
        }
    }
}
