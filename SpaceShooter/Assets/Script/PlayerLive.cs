using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLive : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject ScoreScreen;
    [SerializeField] private GameObject playerAll;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject asteroidController;
    [SerializeField] private GameObject DeathZone;
    [SerializeField] private float time = 2f;

    public Score Score;
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
            StartCoroutine(death());
        }else if (other.tag == "Enemy")
        {
            StartCoroutine(death());
        }else if (other.tag == "EnemyBolt")
        {
            StartCoroutine(death());
        }
        
    }

    IEnumerator death()
    {
        asteroidController.SetActive(false);
        player.SetActive(false);
        explosion.SetActive(true);
        Score.FinalScore();
        yield return new WaitForSeconds(time);
        ScoreScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        playerAll.SetActive(false);
        DeathZone.SetActive(true);
    }
}
