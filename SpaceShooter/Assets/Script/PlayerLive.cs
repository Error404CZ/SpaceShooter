using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLive : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField] 
    private GameObject player;
    [SerializeField] 
    private GameObject asteroidController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Asteroid")
        {
            gameOverScreen.SetActive(true);
            asteroidController.SetActive(false);
            player.SetActive(false);
        }
        
    }
}
